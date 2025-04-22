namespace DevExpressProject
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCustomerList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSaveCari = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnProductList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSaveProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnOrderList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSaveOrder = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement4,
            this.accordionControlElement2});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(260, 785);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnCustomerList,
            this.btnSaveCari});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Cariler";
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.btnCustomerList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerList.ImageOptions.Image")));
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCustomerList.Text = "Cari Listesi";
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // btnSaveCari
            // 
            this.btnSaveCari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCari.ImageOptions.Image")));
            this.btnSaveCari.Name = "btnSaveCari";
            this.btnSaveCari.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSaveCari.Text = "Cari Ekle";
            this.btnSaveCari.Click += new System.EventHandler(this.btnSaveCari_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnProductList,
            this.btnSaveProduct});
            this.accordionControlElement4.Expanded = true;
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Ürünler";
            // 
            // btnProductList
            // 
            this.btnProductList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductList.ImageOptions.Image")));
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnProductList.Text = "Ürün Listesi";
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveProduct.ImageOptions.Image")));
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSaveProduct.Text = "Ürün Ekle";
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnOrderList,
            this.btnSaveOrder});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Siparişler";
            // 
            // btnOrderList
            // 
            this.btnOrderList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnOrderList.Text = "Sipariş Listesi";
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement5.ImageOptions.Image")));
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSaveOrder.Text = "Sipariş Ekle";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 785);
            this.Controls.Add(this.accordionControl1);
            this.IsMdiContainer = true;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCustomerList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSaveCari;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnProductList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSaveProduct;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnOrderList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSaveOrder;
    }
}