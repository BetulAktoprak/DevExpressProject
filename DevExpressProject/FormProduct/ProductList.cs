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
    }
}
