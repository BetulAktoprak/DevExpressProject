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
using DevExpressProject.FormCustomer;

namespace DevExpressProject.FormProduct
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowGroupPanel = false;

            LoadProductList();
        }
        private void LoadProductList()
        {
            using (var context = new AppDbContext())
            {
                var result = context.Database.SqlQuery<Product>(
                    "SELECT Id, ProductName, UnitPrice, Barcode, Stock, Description, Kilo, Metre, CreatedDate, UpdatedDate FROM Products").ToList();

                dgvProductList.DataSource = result;
                gridView1.Columns["OrderDetails"].Visible = false;
                gridView1.Columns["Id"].Visible = true;
                gridView1.Columns["Id"].VisibleIndex = 0;

            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();
            form.ShowDialog();
            LoadProductList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                int Id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Id"));
                var form = new AddProductForm(Id);
                form.Show();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void dgvProductList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dialog = MessageBox.Show("Seçili müşteriyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));

                    using (var context = new AppDbContext())
                    {
                        var product = context.Products.FirstOrDefault(c => c.Id == selectedId);
                        if (product != null)
                        {
                            context.Products.Remove(product);
                            context.SaveChanges();
                            MessageBox.Show("Müşteri silindi.");

                            LoadProductList();
                        }
                    }
                }
            }
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = txtSearch.Text;
        }
    }
}
