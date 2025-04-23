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
using DevExpressProject.DTOs;
using DevExpressProject.Entities;
using DevExpressProject.FormProduct;

namespace DevExpressProject.FormOrder
{
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            LoadOrder();
        }

        private void LoadOrder()
        {
            using (var context = new AppDbContext())
            {
                var result = context.Database.SqlQuery<OrderListDto>(

                    @"SELECT o.Id, o.FisNo, 
                             c.FullName AS Cari, 
                             STUFF((
                                 SELECT DISTINCT ', ' + p2.ProductName
                                 FROM OrderDetails od2
                                 JOIN Products p2 ON od2.ProductId = p2.Id
                                 WHERE od2.OrderId = o.Id
                                 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS Products,
                             COUNT(DISTINCT p.Id) AS UrunSayisi, 
                             SUM(od.Quantity) AS TotalQuantity,
                             o.ShipmentDate AS SevkiyatTarihi, 
                             o.CreatedDate, 
                             o.UpdatedDate, 
                             SUM(od.Quantity * od.UnitPrice) AS ToplamTutar 
                      FROM Orders o 
                      JOIN Customers c ON o.CustomerId = c.Id 
                      JOIN OrderDetails od ON od.OrderId = o.Id 
                      JOIN Products p ON od.ProductId = p.Id 
                      GROUP BY o.Id, c.FullName, o.FisNo, o.ShipmentDate, o.CreatedDate, o.UpdatedDate").ToList();

                dgvOrderList.DataSource = result;
                //gridView1.Columns["Orders"].Visible = false;
                gridView1.Columns["Id"].Visible = true;
                gridView1.Columns["Id"].VisibleIndex = 0;

            }
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = txtSearch.Text;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();
            addOrderForm.ShowDialog();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                int Id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Id"));
                string fisNo = gridView1.GetRowCellValue(rowHandle, "FisNo").ToString();
                var form = new AddOrderForm(Id, fisNo);
                form.Show();
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dialog = MessageBox.Show("Seçili siparişi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));

                    using (var context = new AppDbContext())
                    {
                        var order = context.Orders
                               .Include("OrderDetails")
                               .FirstOrDefault(o => o.Id == selectedId);

                        if (order != null)
                        {
                            context.OrderDetails.RemoveRange(order.OrderDetails);
                            context.Orders.Remove(order);
                            context.SaveChanges();

                            MessageBox.Show("Sipariş başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadOrder();
                        }
                    }
                }
            }
        }
    }
}
