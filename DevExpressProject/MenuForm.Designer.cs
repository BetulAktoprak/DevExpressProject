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
            this.sbtnCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnProduct = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnOrders = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // sbtnCustomer
            // 
            this.sbtnCustomer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sbtnCustomer.Appearance.BorderColor = System.Drawing.Color.Black;
            this.sbtnCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnCustomer.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbtnCustomer.Appearance.Options.UseBackColor = true;
            this.sbtnCustomer.Appearance.Options.UseBorderColor = true;
            this.sbtnCustomer.Appearance.Options.UseFont = true;
            this.sbtnCustomer.Appearance.Options.UseForeColor = true;
            this.sbtnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sbtnCustomer.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.sbtnCustomer.Location = new System.Drawing.Point(41, 74);
            this.sbtnCustomer.Name = "sbtnCustomer";
            this.sbtnCustomer.Size = new System.Drawing.Size(221, 165);
            this.sbtnCustomer.TabIndex = 0;
            this.sbtnCustomer.Text = "Müşteriler";
            this.sbtnCustomer.Click += new System.EventHandler(this.sbtnCustomer_Click);
            // 
            // sbtnProduct
            // 
            this.sbtnProduct.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sbtnProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnProduct.Appearance.Options.UseBackColor = true;
            this.sbtnProduct.Appearance.Options.UseFont = true;
            this.sbtnProduct.Location = new System.Drawing.Point(301, 74);
            this.sbtnProduct.Name = "sbtnProduct";
            this.sbtnProduct.Size = new System.Drawing.Size(210, 165);
            this.sbtnProduct.TabIndex = 1;
            this.sbtnProduct.Text = "Stok Kartları";
            // 
            // sbtnOrders
            // 
            this.sbtnOrders.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sbtnOrders.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnOrders.Appearance.Options.UseBackColor = true;
            this.sbtnOrders.Appearance.Options.UseFont = true;
            this.sbtnOrders.Location = new System.Drawing.Point(554, 74);
            this.sbtnOrders.Name = "sbtnOrders";
            this.sbtnOrders.Size = new System.Drawing.Size(218, 165);
            this.sbtnOrders.TabIndex = 2;
            this.sbtnOrders.Text = "Siparişler";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 326);
            this.Controls.Add(this.sbtnOrders);
            this.Controls.Add(this.sbtnProduct);
            this.Controls.Add(this.sbtnCustomer);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbtnCustomer;
        private DevExpress.XtraEditors.SimpleButton sbtnProduct;
        private DevExpress.XtraEditors.SimpleButton sbtnOrders;
    }
}

