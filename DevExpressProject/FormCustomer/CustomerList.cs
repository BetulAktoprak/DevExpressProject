using DevExpressProject.Context;
using DevExpressProject.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

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
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            using (var context = new AppDbContext())
            {
                var result = context.Database.SqlQuery<Customer>(
                    "SELECT Id, FullName, TCNo, Phone, Email, Address, Country, Province, District, VergiNo, VergiDairesi, CreatedDate, UpdatedDate FROM Customers").ToList();

                dgvCariList.DataSource = result;
                gridView1.Columns["Orders"].Visible = false;
                gridView1.Columns["Id"].Visible = true;
                gridView1.Columns["Id"].VisibleIndex = 0;

            }
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = txtSearch.Text;
        }

        private void btnCariEkle_Click(object sender, EventArgs e)
        {
            AddCutomerForm addCutomerForm = new AddCutomerForm();
            addCutomerForm.ShowDialog();
            LoadCustomer();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                int Id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Id"));
                var form = new AddCutomerForm(Id);
                form.Show();
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
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
