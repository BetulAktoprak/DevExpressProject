namespace DevExpressProject.FormOrder
{
    partial class AddOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblFisNo = new DevExpress.XtraEditors.LabelControl();
            this.spinQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.lookUpCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpProduct = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPrice = new DevExpress.XtraEditors.LabelControl();
            this.btnPlus = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddOrder = new DevExpress.XtraEditors.SimpleButton();
            this.lblKdv = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpSevkTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dgvPRoductList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSevkTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSevkTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRoductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblFisNo);
            this.panelControl1.Controls.Add(this.spinQuantity);
            this.panelControl1.Controls.Add(this.lookUpCustomer);
            this.panelControl1.Controls.Add(this.lookUpProduct);
            this.panelControl1.Controls.Add(this.lblPrice);
            this.panelControl1.Controls.Add(this.btnPlus);
            this.panelControl1.Controls.Add(this.btnAddOrder);
            this.panelControl1.Controls.Add(this.lblKdv);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dtpSevkTarihi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(732, 298);
            this.panelControl1.TabIndex = 0;
            // 
            // lblFisNo
            // 
            this.lblFisNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFisNo.Location = new System.Drawing.Point(594, 25);
            this.lblFisNo.Name = "lblFisNo";
            this.lblFisNo.Size = new System.Drawing.Size(63, 13);
            this.lblFisNo.TabIndex = 14;
            this.lblFisNo.Text = "labelControl6";
            // 
            // spinQuantity
            // 
            this.spinQuantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinQuantity.Location = new System.Drawing.Point(127, 159);
            this.spinQuantity.Name = "spinQuantity";
            this.spinQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinQuantity.Size = new System.Drawing.Size(100, 20);
            this.spinQuantity.TabIndex = 3;
            // 
            // lookUpCustomer
            // 
            this.lookUpCustomer.Location = new System.Drawing.Point(127, 83);
            this.lookUpCustomer.Name = "lookUpCustomer";
            this.lookUpCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCustomer.Properties.NullText = "cari seçiniz";
            this.lookUpCustomer.Size = new System.Drawing.Size(265, 20);
            this.lookUpCustomer.TabIndex = 1;
            // 
            // lookUpProduct
            // 
            this.lookUpProduct.Location = new System.Drawing.Point(127, 46);
            this.lookUpProduct.Name = "lookUpProduct";
            this.lookUpProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpProduct.Properties.NullText = "ürün seçiniz";
            this.lookUpProduct.Size = new System.Drawing.Size(265, 20);
            this.lookUpProduct.TabIndex = 0;
            this.lookUpProduct.EditValueChanged += new System.EventHandler(this.lookUpProduct_EditValueChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(41, 245);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 13;
            // 
            // btnPlus
            // 
            this.btnPlus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPlus.ImageOptions.Image")));
            this.btnPlus.Location = new System.Drawing.Point(398, 41);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPlus.Size = new System.Drawing.Size(34, 29);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Appearance.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAddOrder.Appearance.Options.UseBackColor = true;
            this.btnAddOrder.Appearance.Options.UseFont = true;
            this.btnAddOrder.Location = new System.Drawing.Point(277, 245);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(115, 36);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "Kaydet";
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lblKdv
            // 
            this.lblKdv.Location = new System.Drawing.Point(127, 202);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(0, 13);
            this.lblKdv.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(41, 162);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Miktar:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(41, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Sevk Tarihi:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(41, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Cariler:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(41, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Ürünler:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 202);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "KDV:";
            // 
            // dtpSevkTarihi
            // 
            this.dtpSevkTarihi.EditValue = null;
            this.dtpSevkTarihi.Location = new System.Drawing.Point(127, 120);
            this.dtpSevkTarihi.Name = "dtpSevkTarihi";
            this.dtpSevkTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSevkTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSevkTarihi.Size = new System.Drawing.Size(140, 20);
            this.dtpSevkTarihi.TabIndex = 2;
            // 
            // dgvPRoductList
            // 
            this.dgvPRoductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPRoductList.Location = new System.Drawing.Point(0, 298);
            this.dgvPRoductList.MainView = this.gridView1;
            this.dgvPRoductList.Name = "dgvPRoductList";
            this.dgvPRoductList.Size = new System.Drawing.Size(732, 292);
            this.dgvPRoductList.TabIndex = 1;
            this.dgvPRoductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvPRoductList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPRoductList_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvPRoductList;
            this.gridView1.Name = "gridView1";
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 590);
            this.Controls.Add(this.dgvPRoductList);
            this.Controls.Add(this.panelControl1);
            this.Name = "AddOrderForm";
            this.Text = "AddOrderForm";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSevkTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSevkTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRoductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddOrder;
        private DevExpress.XtraEditors.LabelControl lblKdv;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtpSevkTarihi;
        private DevExpress.XtraGrid.GridControl dgvPRoductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnPlus;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private DevExpress.XtraEditors.LookUpEdit lookUpCustomer;
        private DevExpress.XtraEditors.LookUpEdit lookUpProduct;
        private DevExpress.XtraEditors.SpinEdit spinQuantity;
        private DevExpress.XtraEditors.LabelControl lblFisNo;
    }
}