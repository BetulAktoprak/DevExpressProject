using DevExpressProject.FormCustomer;
using DevExpressProject.FormOrder;
using DevExpressProject.FormProduct;
using System;
using System.Windows.Forms;

namespace DevExpressProject
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            CustomerList customerList = new CustomerList();
            customerList.MdiParent = this;
            customerList.Show();
        }

        private void btnSaveCari_Click(object sender, EventArgs e)
        {
            AddCutomerForm addCutomerForm = new AddCutomerForm();
            addCutomerForm.MdiParent = this;
            addCutomerForm.Show();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            productList.MdiParent = this;
            productList.Show();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.MdiParent = this;
            addProductForm.Show();
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            OrderListForm orderListForm = new OrderListForm();
            orderListForm.MdiParent = this;
            orderListForm.Show();
        }
    }
}
