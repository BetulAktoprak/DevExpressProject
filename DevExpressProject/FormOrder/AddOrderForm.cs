using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpressProject.Context;
using DevExpressProject.Entities;

namespace DevExpressProject.FormOrder
{
    public partial class AddOrderForm : Form
    {
        private int? _id;
        public AddOrderForm(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }
        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            using (var context = new AppDbContext())
            {
                var customers = context.Customers
                    .Select(c => new { c.Id, c.FullName })
                    .ToList();
                lookUpCustomer.Properties.DataSource = customers;
                lookUpCustomer.Properties.DisplayMember = "FullName";
                lookUpCustomer.Properties.ValueMember = "Id";

                lookUpCustomer.Properties.Columns.Clear();
                lookUpCustomer.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Cari"));


                var products = context.Products
                    .Select(p => new { p.Id, Display = p.ProductName })
                    .ToList();
                lookUpProduct.Properties.DataSource = products;
                lookUpProduct.Properties.DisplayMember = "Display";
                lookUpProduct.Properties.ValueMember = "Id";

                lookUpProduct.Properties.Columns.Clear();
                lookUpProduct.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Display", "Ürün Adı"));


                if (products.Count > 0)
                    lookUpProduct.EditValue = products.First().Id;

                if (_id.HasValue)
                {
                    var order = context.Orders
                        .Include("OrderDetails")
                        .FirstOrDefault(o => o.Id == _id.Value);

                    if (order != null)
                    {
                        lookUpCustomer.EditValue = order.CustomerId;
                        dtpSevkTarihi.EditValue = (DateTime)order.ShipmentDate;

                        orderDetails = order.OrderDetails
                            .Select(d => new OrderDetail
                            {
                                ProductId = d.ProductId,
                                Quantity = d.Quantity,
                                UnitPrice = d.UnitPrice,
                                KDV = d.KDV,
                                TotalAmount = d.TotalAmount
                            })
                            .ToList();

                        RefreshGrid();
                    }
                }

                lblKdv.Text = "%18";
                dtpSevkTarihi.Properties.MinValue = DateTime.Today;
                lookUpProduct_EditValueChanged(lookUpProduct, EventArgs.Empty);

            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (lookUpCustomer.EditValue == null || orderDetails.Count == 0)
            {
                XtraMessageBox.Show("Müşteri seçiniz ve en az bir ürün ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new AppDbContext())
            {
                if (_id.HasValue)
                {
                    var existingOrder = context.Orders
                        .Include("OrderDetails")
                        .FirstOrDefault(o => o.Id == _id.Value);

                    if (existingOrder != null)
                    {
                        existingOrder.CustomerId = (int)lookUpCustomer.EditValue;
                        existingOrder.ShipmentDate = dtpSevkTarihi.DateTime;
                        existingOrder.UpdatedDate = DateTime.UtcNow;

                        context.OrderDetails.RemoveRange(existingOrder.OrderDetails);
                        existingOrder.OrderDetails = orderDetails;
                    }
                }
                else
                {
                    var order = new Order
                    {
                        CustomerId = (int)lookUpCustomer.EditValue,
                        ShipmentDate = dtpSevkTarihi.DateTime,
                        FisNo = new Random().Next(1000, 9999),
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow,
                        OrderDetails = orderDetails
                    };

                    context.Orders.Add(order);
                }
                context.SaveChanges();

                XtraMessageBox.Show("Sipariş başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //OrderChanged?.Invoke(this, EventArgs.Empty);
                orderDetails.Clear();
                RefreshGrid();
            }
        }

        

        private List<OrderDetail> orderDetails = new List<OrderDetail>();

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (lookUpProduct.EditValue == null || !int.TryParse(lookUpProduct.EditValue.ToString(), out int productId))
            {
                XtraMessageBox.Show("Lütfen bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(lblPrice.Text) ||
                !decimal.TryParse(lblPrice.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal unitPrice))
            {
                XtraMessageBox.Show("Fiyat geçersiz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(lblKdv.Text.Replace("%", ""), out int kdv))
            {
                XtraMessageBox.Show("KDV formatı geçersiz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantity = (int)spinQuantity.Value;
            var detail = new OrderDetail
            {
                ProductId = productId,
                Quantity = quantity,
                UnitPrice = unitPrice,
                KDV = kdv,
                TotalAmount = quantity * unitPrice
            };

            //var validator = new OrderDetailValidator();
            //var result = validator.Validate(detail);

            //if (!result.IsValid)
            //{
            //    var errorMessage = string.Join("\n", result.Errors.Select(err => err.ErrorMessage));
            //    MessageBox.Show(errorMessage, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            orderDetails.Add(detail);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            
            dgvPRoductList.DataSource = orderDetails.Select(od => new
            {
                Ürün = GetProductNameById(od.ProductId),
                Miktar = od.Quantity,
                Fiyat = od.UnitPrice,
                KDV = od.KDV,
                Tutar = od.TotalAmount
            }).ToList();

            gridView1.PopulateColumns();

        }
        private string GetProductNameById(int productId)
        {
            using (var context = new AppDbContext())
            {
                return context.Products.FirstOrDefault(p => p.Id == productId)?.ProductName ?? "Bilinmiyor";
            }
        }

        private void dgvPRoductList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var selectedRow = gridView1.FocusedRowHandle;
                if (selectedRow >= 0)
                {
                    orderDetails.RemoveAt(selectedRow);
                    RefreshGrid();
                }
            }
        }

        private void lookUpProduct_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpProduct.EditValue is int productId)
            {
                using (var context = new AppDbContext())
                {
                    var product = context.Products.FirstOrDefault(p => p.Id == productId);
                    if (product != null)
                    {
                        lblPrice.Text = product.UnitPrice.ToString("N2");
                    }
                }
            }
        }
    }
}
