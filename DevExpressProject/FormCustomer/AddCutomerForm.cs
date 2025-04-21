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
        public AddCutomerForm()
        {
            InitializeComponent();
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
