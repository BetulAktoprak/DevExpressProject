using System;
using System.Linq;
using System.Windows.Forms;
using DevExpressProject.Context;
using DevExpressProject.Entities;

namespace DevExpressProject.FormCustomer
{
    public partial class CustomerList : Form
    {
        private int _customerId;
        public CustomerList()
        {
            InitializeComponent();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            using (var context = new AppDbContext())
            {
                var result = context.Database.SqlQuery<Customer>(
                    "SELECT Id, FullName, TCNo, Phone, Email, VergiNo, VergiDairesi, CreatedDate, UpdatedDate FROM Customers").ToList();

                dgvCariList.DataSource = result;
                gridView1.Columns["Orders"].Visible = false;
                gridView1.Columns["Id"].Visible = true;
                gridView1.Columns["Id"].VisibleIndex = 0;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {

                var newCustomer = new Customer
                {
                    FullName = txtFullName.Text,
                    TCNo = txtTc.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    VergiNo = txtVergiNo.Text,
                    VergiDairesi = txtVergiDairesi.Text
                };

                //var validator = new CustomerValidator();
                //var result = validator.Validate(newCustomer);

                //if (!result.IsValid)
                //{
                //    var errorMessage = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                //    MessageBox.Show(errorMessage, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                context.Customers.Add(newCustomer);
                context.SaveChanges();

                MessageBox.Show("Kullanıcı başarıyla kaydedildi!");
                //CustomerAdded?.Invoke(this, EventArgs.Empty);
                CustomerClear();
                LoadCustomer();
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
        }
        
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("Id") != null)
            {
                _customerId = (int)gridView1.GetFocusedRowCellValue("Id");
                txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
                txtTc.Text = gridView1.GetFocusedRowCellValue("TCNo").ToString();
                txtFullName.Text = gridView1.GetFocusedRowCellValue("FullName").ToString();
                txtEmail.Text = gridView1.GetFocusedRowCellValue("Email").ToString();
                txtPhone.Text = gridView1.GetFocusedRowCellValue("Phone").ToString();
                txtVergiNo.Text = gridView1.GetFocusedRowCellValue("VergiNo").ToString();
                txtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VergiDairesi").ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var customer = context.Customers.FirstOrDefault(c => c.Id == _customerId);
                if (customer != null)
                {
                    customer.FullName = txtFullName.Text;
                    customer.Email = txtEmail.Text;
                    customer.Phone = txtPhone.Text;
                    customer.TCNo = txtTc.Text;
                    customer.VergiDairesi = txtVergiDairesi.Text;
                    customer.VergiNo = txtVergiNo.Text;

                    customer.UpdatedDate = DateTime.UtcNow;

                    //var validator = new CustomerValidator();
                    //var result = validator.Validate(customer);
                    //if (!result.IsValid)
                    //{
                    //    var errorMessage = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                    //    MessageBox.Show(errorMessage, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}

                    context.SaveChanges();
                    //CustomerUpdated?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("Müşteri bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomer();
                }
                else
                {
                    MessageBox.Show("Müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CustomerClear();
        }

        private void dgvCariList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dialog = MessageBox.Show("Seçili müşteriyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));

                    using (var context = new AppDbContext())
                    {
                        var customer = context.Customers.FirstOrDefault(c => c.Id == selectedId);
                        if (customer != null)
                        {
                            context.Customers.Remove(customer);
                            context.SaveChanges();
                            MessageBox.Show("Müşteri silindi.");

                            LoadCustomer();
                        }
                    }
                }
            }
        }
    }
}
