namespace DevExpressProject.FormProduct
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.nmrKilo = new System.Windows.Forms.NumericUpDown();
            this.nmrMetre = new System.Windows.Forms.NumericUpDown();
            this.nmrUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.nmrStock = new System.Windows.Forms.NumericUpDown();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnBarcode = new DevExpress.XtraEditors.SimpleButton();
            this.lblBarcode = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMetre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.nmrKilo);
            this.groupControl1.Controls.Add(this.nmrMetre);
            this.groupControl1.Controls.Add(this.nmrUnitPrice);
            this.groupControl1.Controls.Add(this.nmrStock);
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.btnBarcode);
            this.groupControl1.Controls.Add(this.lblBarcode);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Location = new System.Drawing.Point(31, 24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(362, 414);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Cari Ekle";
            // 
            // nmrKilo
            // 
            this.nmrKilo.Location = new System.Drawing.Point(114, 255);
            this.nmrKilo.Name = "nmrKilo";
            this.nmrKilo.Size = new System.Drawing.Size(188, 21);
            this.nmrKilo.TabIndex = 5;
            // 
            // nmrMetre
            // 
            this.nmrMetre.Location = new System.Drawing.Point(114, 226);
            this.nmrMetre.Name = "nmrMetre";
            this.nmrMetre.Size = new System.Drawing.Size(188, 21);
            this.nmrMetre.TabIndex = 4;
            // 
            // nmrUnitPrice
            // 
            this.nmrUnitPrice.Location = new System.Drawing.Point(114, 190);
            this.nmrUnitPrice.Name = "nmrUnitPrice";
            this.nmrUnitPrice.Size = new System.Drawing.Size(188, 21);
            this.nmrUnitPrice.TabIndex = 3;
            // 
            // nmrStock
            // 
            this.nmrStock.Location = new System.Drawing.Point(114, 160);
            this.nmrStock.Name = "nmrStock";
            this.nmrStock.Size = new System.Drawing.Size(188, 21);
            this.nmrStock.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(114, 101);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(188, 48);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = "";
            // 
            // btnBarcode
            // 
            this.btnBarcode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarcode.ImageOptions.Image")));
            this.btnBarcode.Location = new System.Drawing.Point(18, 293);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(93, 23);
            this.btnBarcode.TabIndex = 16;
            this.btnBarcode.Text = "6";
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // lblBarcode
            // 
            this.lblBarcode.Location = new System.Drawing.Point(142, 298);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(0, 13);
            this.lblBarcode.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnSave.Appearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseBorderColor = true;
            this.btnSave.Location = new System.Drawing.Point(114, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(71, 263);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(16, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Kilo";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(59, 234);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Metre";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(63, 198);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Fiyat";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(66, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(21, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Stok";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(46, 136);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Açıklama";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ürün Adı";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(114, 63);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(188, 20);
            this.txtAd.TabIndex = 0;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.groupControl1);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMetre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.SimpleButton btnBarcode;
        private DevExpress.XtraEditors.LabelControl lblBarcode;
        private System.Windows.Forms.NumericUpDown nmrUnitPrice;
        private System.Windows.Forms.NumericUpDown nmrStock;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.NumericUpDown nmrKilo;
        private System.Windows.Forms.NumericUpDown nmrMetre;
    }
}