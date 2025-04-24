using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpressProject.Context;
using DevExpressProject.Entities;
using DevExpressProject.Validations;

namespace DevExpressProject.FormProduct
{
    public partial class AddProductForm : Form
    {
        private readonly int? _productId;
        public AddProductForm(int? productId = null)
        {
            InitializeComponent();
            _productId = productId;
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            if (_productId.HasValue)
            {
                using (var context = new AppDbContext())
                {
                    var product = context.Products.FirstOrDefault(p => p.Id == _productId.Value);

                    if (product != null)
                    {
                        txtAd.Text = product.ProductName;
                        lblBarcode.Text = product.Barcode;
                        txtDescription.Text = product.Description;
                        nmrStock.Text = product.Stock.ToString();
                        nmrUnitPrice.Text = product.UnitPrice.ToString("F2");
                        nmrMetre.Text = product.Metre.ToString();
                        nmrKilo.Text = product.Kilo.ToString();
                    }
                }
            }
        }

        private string CreateBarcode()
        {
            return "Logo" + Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
        }
        private void btnBarcode_Click(object sender, EventArgs e)
        {
            string barcode = CreateBarcode();
            lblBarcode.Text = barcode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {

                    Product product;

                    if (_productId.HasValue)
                    {
                        product = context.Products.FirstOrDefault(p => p.Id == _productId.Value) ?? new Product();
                    }
                    else
                    {
                        product = new Product();
                        context.Products.Add(product);
                    }

                    product.ProductName = txtAd.Text;
                    product.Barcode = lblBarcode.Text;
                    product.Description = txtDescription.Text;
                    product.Stock = int.TryParse(nmrStock.Text, out var stock) ? stock : 0;
                    product.UnitPrice = decimal.TryParse(nmrUnitPrice.Text, out var price) ? price : 0;
                    product.Metre = double.TryParse(nmrMetre.Text, out var metre) ? metre : 0;
                    product.Kilo = double.TryParse(nmrKilo.Text, out var kilo) ? kilo : 0;

                    var validator = new ProductValidator();
                    var result = validator.Validate(product);

                    if (!result.IsValid)
                    {
                        var errorMessage = string.Join("\n", result.Errors.Select(err => err.ErrorMessage));
                        MessageBox.Show(errorMessage, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    context.SaveChanges();


                    string message = _productId.HasValue ? "Ürün güncellendi!" : "Ürün eklendi!";
                    MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu. " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtAd.Clear();
            nmrUnitPrice.Value = 0;
            nmrStock.Value = 0;
            nmrMetre.Value = 0;
            nmrKilo.Value = 0;
            txtDescription.Clear();
            lblBarcode.Text = string.Empty;
        }

    }
}
