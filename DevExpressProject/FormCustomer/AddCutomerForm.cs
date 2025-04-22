using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpressProject.Context;
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
                        VergiDairesi = txtVergiDairesi.Text
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
        }

       
    }
}
