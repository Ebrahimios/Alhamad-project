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
    public partial class ucSuppliers : UserControl
    {
        public ucSuppliers()
        {
            InitializeComponent();
        }

        private void ucSuppliers_Load(object sender, EventArgs e)
        {
            this.supplierTableAdapter.Fill(this.alhamdDBDataSet.Supplier);

            int newWidth = (int)(this.Width * 0.8);
            newWidth = Math.Max(newWidth, 100);
            dgvSupplier.Width = newWidth;

            txtSearchBar.Width = newWidth - btnAddSupplier.Width - 20;
            btnAddSupplier.Width = newWidth - txtSearchBar.Width;
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];
                string supplierId = row.Cells["dgvId"].Value.ToString();

                if (dgvSupplier.Columns[e.ColumnIndex].Name == "dgvSell")
                {
                    frmSupplierBuy supplierBuyForm = new frmSupplierBuy(supplierId);
                    supplierBuyForm.ShowDialog();
                }
                else if (dgvSupplier.Columns[e.ColumnIndex].Name == "dgvShow")
                {
                    frmViewSupplier viewSupplierForm = new frmViewSupplier(supplierId);
                    viewSupplierForm.ShowDialog();
                }
                else if (dgvSupplier.Columns[e.ColumnIndex].Name == "dgvDelete")
                {
                    DialogResult dialogResult = MessageBox.Show("هل انت متأكد من ازالة هذا المورد?", "ازالة مورد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DeactivateSupplier(supplierId);
                        this.supplierTableAdapter.Fill(this.alhamdDBDataSet.Supplier);
                    }
                }
            }
        }

        private void DeactivateSupplier(string supplierId)
        {
            if (int.TryParse(supplierId, out int supplierIdInt))
            {
                string updateQuery = "UPDATE Supplier SET IsActive = 0 WHERE SupplierID = @SupplierID";
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@SupplierID", supplierIdInt);
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
            this.supplierTableAdapter.FillBySearchWord(this.alhamdDBDataSet.Supplier, $"%{txtSearchBar.Text}%");
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAddSupplier addSupplierForm = new frmAddSupplier();
            addSupplierForm.ShowDialog();
            this.supplierTableAdapter.Fill(this.alhamdDBDataSet.Supplier);
        }
    }
}
