using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlhamdApplication
{
    public partial class ucProducts : UserControl
    {
        public ucProducts()
        {
            InitializeComponent();
        }

        private void ucProducts_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.alhamdDBDataSet.Product);

            int newWidth = (int)(this.Width * 0.8);
            newWidth = Math.Max(newWidth, 100);
            dgvProduct.Width = newWidth;

            txtSearchBar.Width = newWidth - btnAddProduct.Width - 20;
            btnAddProduct.Width = newWidth - txtSearchBar.Width;
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];
                string productId = row.Cells["dgvId"].Value.ToString();

                if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvShow")
                {
                    frmViewProduct viewProductForm = new frmViewProduct(productId);
                    viewProductForm.ShowDialog();
                    this.productTableAdapter.Fill(this.alhamdDBDataSet.Product);
                }
                else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvDelete")
                {
                    DialogResult dialogResult = MessageBox.Show("هل انت متأكد من ازالة هذا المنتج?", "ازالة منتج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DeactivateProduct(productId);
                        this.productTableAdapter.Fill(this.alhamdDBDataSet.Product);
                    }
                }
            }
        }

        private void DeactivateProduct(string productId)
        {
            if (int.TryParse(productId, out int productIdInt))
            {
                string updateQuery = "UPDATE Product SET IsActive = 0 WHERE ProductID = @ProductID";
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@ProductID", productIdInt);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            this.productTableAdapter.FillBySearchWord(this.alhamdDBDataSet.Product, $"%{txtSearchBar.Text}%");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct addProductForm = new frmAddProduct();
            addProductForm.ShowDialog();
            this.productTableAdapter.Fill(this.alhamdDBDataSet.Product);
        }
    }
}
