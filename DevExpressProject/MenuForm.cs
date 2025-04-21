using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpressProject.Context;
using DevExpressProject.Entities;
using DevExpressProject.FormCustomer;
using DevExpressProject.FormProduct;

namespace DevExpressProject
{
    public partial class MenuForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MenuForm()
        {
            InitializeComponent();
        }


        private void btnCustomerList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CustomerList customerList = new CustomerList();
            customerList.MdiParent = this;
            customerList.WindowState = FormWindowState.Maximized;
            customerList.Show();
            //LoadCustomer();
        }

        private void btnAddedCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddCutomerForm addCutomerForm = new AddCutomerForm();
            addCutomerForm.Show();
        }

        private void btnCustomerInformation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CustomerInformationForm customerInformationForm = new CustomerInformationForm();
            customerInformationForm.MdiParent = this;
            customerInformationForm.Show();
        }

        private void btnUrunList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductList productList = new ProductList();
            productList.MdiParent = this;
            productList.Show();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }
    }
}
