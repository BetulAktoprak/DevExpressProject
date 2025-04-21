using DevExpressProject.FormCustomer;
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
    }
}
