using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpressProject.Context;
using DevExpressProject.DTOs;

namespace DevExpressProject.FormOrder
{
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            LoadOrder();
        }

        private void LoadOrder()
        {
            using (var context = new AppDbContext())
            {

                var orders = context.Orders.Select(o => new
                {
                    o.Id,
                    o.FisNo,
                    Cari = o.Customer.FullName,
                    o.ShipmentDate,
                    o.CreatedDate,
                    ProductNames = o.OrderDetails.Select(od => od.Product.ProductName),
                    UrunSayisi = o.OrderDetails.Select(od => od.ProductId).Distinct().Count(),
                    TotalQuantity = o.OrderDetails.Sum(od => od.Quantity),
                    ToplamTutar = o.OrderDetails.Sum(od => od.Quantity * od.UnitPrice)
                }).ToList();

                var result = orders.Select(o => new OrderListDto
                {
                    Id = o.Id,
                    FisNo = o.FisNo,
                    Cari = o.Cari,
                    SevkiyatTarihi = o.ShipmentDate ?? DateTime.MinValue,
                    CreatedDate = o.CreatedDate,
                    Ürünler = string.Join(", ", o.ProductNames.Distinct()),
                    UrunSayisi = o.UrunSayisi,
                    TotalQuantity = o.TotalQuantity,
                    ToplamTutar = o.ToplamTutar
                }).ToList();


                dgvOrderList.DataSource = result;
                gridView1.Columns["Id"].Visible = true;
                gridView1.Columns["Id"].VisibleIndex = 0;

            }
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = txtSearch.Text;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();
            if(addOrderForm.ShowDialog() == DialogResult.OK)
            {
                LoadOrder();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                int Id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Id"));
                string fisNo = gridView1.GetRowCellValue(rowHandle, "FisNo").ToString();
                var form = new AddOrderForm(Id, fisNo);
                if(form.ShowDialog() == DialogResult.OK)
                {
                    LoadOrder();
                }
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dialog = MessageBox.Show("Seçili siparişi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));

                    using (var context = new AppDbContext())
                    {
                        var order = context.Orders
                               .Include("OrderDetails")
                               .FirstOrDefault(o => o.Id == selectedId);

                        if (order != null)
                        {
                            context.OrderDetails.RemoveRange(order.OrderDetails);
                            context.Orders.Remove(order);
                            context.SaveChanges();

                            MessageBox.Show("Sipariş başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadOrder();
                        }
                    }
                }
            }
        }
    }
}
