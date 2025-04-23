using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpressProject.Context;
using DevExpressProject.DTOs;
using DevExpressProject.Entities;

namespace DevExpressProject.FormCustomer
{
    public partial class AddCutomerForm : Form
    {
        private readonly int? _cariId;
        public AddCutomerForm(int? cariId = null)
        {
            InitializeComponent();
            _cariId = cariId;
        }
        private void AddCutomerForm_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowGroupPanel = false;

            if (_cariId.HasValue)
            {
                using (var context = new AppDbContext())
                {
                    var cari = context.Customers.FirstOrDefault(c => c.Id == _cariId.Value);
                    if (cari != null)
                    {
                        txtTc.Text = cari.TCNo;
                        txtFullName.Text = cari.FullName;
                        txtEmail.Text = cari.Email;
                        txtPhone.Text = cari.Phone;
                        txtVergiNo.Text = cari.VergiNo;
                        txtVergiDairesi.Text = cari.VergiDairesi;
                        txtAddress.Text = cari.Address;
                        txtÜlke.Text = cari.Country;
                        txtil.Text = cari.Province;
                        txtilçe.Text = cari.District;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                if (_cariId.HasValue)
                {
                    var existingCustomer = context.Customers.FirstOrDefault(c => c.Id == _cariId.Value);
                    if(existingCustomer != null)
                    {
                        existingCustomer.FullName = txtFullName.Text;
                        existingCustomer.TCNo = txtTc.Text;
                        existingCustomer.Phone = txtPhone.Text;
                        existingCustomer.Email = txtEmail.Text;
                        existingCustomer.VergiNo = txtVergiNo.Text;
                        existingCustomer.VergiDairesi = txtVergiDairesi.Text;
                        existingCustomer.Address = txtAddress.Text;
                        existingCustomer.Country = txtÜlke.Text;
                        existingCustomer.Province = txtil.Text;
                        existingCustomer.District = txtilçe.Text;

                        context.SaveChanges();
                        MessageBox.Show("Müşteri Bilgileri Güncellendi.");
                        CustomerClear();
                        this.Close();
                    }
                }
                else
                {
                    var newCustomer = new Customer
                    {
                        FullName = txtFullName.Text,
                        TCNo = txtTc.Text,
                        Phone = txtPhone.Text,
                        Email = txtEmail.Text,
                        VergiNo = txtVergiNo.Text,
                        VergiDairesi = txtVergiDairesi.Text,
                        Address = txtAddress.Text,
                        Country = txtÜlke.Text,
                        Province = txtil.Text,
                        District = txtilçe.Text
                    };

                    context.Customers.Add(newCustomer);
                    context.SaveChanges();

                    MessageBox.Show("Kullanıcı başarıyla kaydedildi!");
                    CustomerClear();
                }
                    

                //var validator = new CustomerValidator();
                //var result = validator.Validate(newCustomer);

                //if (!result.IsValid)
                //{
                //    var errorMessage = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                //    MessageBox.Show(errorMessage, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

               
                //CustomerAdded?.Invoke(this, EventArgs.Empty);
                
            }
        }
        private void CustomerClear()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtTc.Clear();
            txtVergiNo.Clear();
            txtVergiDairesi.Clear();
            txtAddress.Clear();
            txtÜlke.Clear();
            txtil.Clear();
            txtilçe.Clear();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage1)
            {
                LoadCustomerOrders();
            }
        }

        private void LoadCustomerOrders()
        {
            using (var context = new AppDbContext())
            {
                var orders = context.Orders
            .Where(o => o.CustomerId == _cariId)
            .Select(o => new
            {
                o.Id,
                o.FisNo,
                o.ShipmentDate,
                o.CreatedDate,
                ProductNames = o.OrderDetails.Select(od => od.Product.ProductName),
                ToplamTutar = o.OrderDetails.Sum(x => x.Quantity * x.UnitPrice)
            })
            .ToList();

                var result = orders.Select(o => new OrderListDto
                {
                    Id = o.Id,
                    FisNo = o.FisNo,
                    SevkiyatTarihi = (DateTime)o.ShipmentDate,
                    CreatedDate = o.CreatedDate,
                    ToplamTutar = o.ToplamTutar,
                    Ürünler = string.Join(", ", o.ProductNames.Distinct())
                }).ToList();

                gridControlOrders.DataSource = result;
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            LoadCustomerOrders();
        }

        private void gridControlOrders_KeyDown(object sender, KeyEventArgs e)
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
                        }
                    }
                }
            }
        }
    }
}
