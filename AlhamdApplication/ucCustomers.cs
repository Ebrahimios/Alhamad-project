using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlhamdApplication
{
    public partial class ucCustomers : UserControl
    {
        public ucCustomers()
        {
            InitializeComponent();
        }

        private async void ucCustomers_Load(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var apiClient = new Client("http://inventq.runasp.net", httpClient);

            try
            {
                //AlhamdDBDataSet.CustomerDataTable summary = await apiClient.GetCustomersAsync(System.Threading.CancellationToken.None) as AlhamdDBDataSet.CustomerDataTable;
                //MessageBox.Show($"Total users: {summary.Count}"); // على حسب الداتا اللي في DashboardSummaryDto
                

            }
            catch (ApiException ex)
            {
                MessageBox.Show($"API Error: {ex.Message}");
            }

            this.customerTableAdapter.Fill(this.alhamdDBDataSet.Customer);
            int newWidth = (int)(this.Width * 0.8);
            newWidth = Math.Max(newWidth, 100);
            dgvCustomer.Width = newWidth;

            txtSearchBar.Width = newWidth - btnAddCustomer.Width - 20;
            btnAddCustomer.Width = newWidth - txtSearchBar.Width;
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                string customerId = row.Cells["dgvId"].Value.ToString();

                if (dgvCustomer.Columns[e.ColumnIndex].Name == "dgvSell")
                {
                    frmCustomerSell CustomerSellForm = new frmCustomerSell(customerId);
                    CustomerSellForm.ShowDialog();
                }
                else if (dgvCustomer.Columns[e.ColumnIndex].Name == "dgvShow")
                {
                    frmViewCustomer viewCustomerForm = new frmViewCustomer(customerId);
                    viewCustomerForm.ShowDialog();
                    this.customerTableAdapter.Fill(this.alhamdDBDataSet.Customer);
                }
                else if (dgvCustomer.Columns[e.ColumnIndex].Name == "dgvDelete")
                {
                    if (customerId == "1")
                    {
                        MessageBox.Show("هذا العميل لا يمكن حذفه", "عميل لا يمكن حذفه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    DialogResult dialogResult = MessageBox.Show("هل انت متأكد من ازالة هذا العميل?", "ازالة عميل", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DeactivateCustomer(customerId);
                        this.customerTableAdapter.Fill(this.alhamdDBDataSet.Customer);
                    }
                }
            }
        }

        private void DeactivateCustomer(string customerId)
        {
            if (int.TryParse(customerId, out int customerIdInt))
            {
                string updateQuery = "UPDATE Customer SET IsActive = 0 WHERE CustomerID = @CustomerID AND CustomerID <> 1";
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@CustomerID", customerIdInt);
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
            this.customerTableAdapter.FillBySearchWord(this.alhamdDBDataSet.Customer, $"%{txtSearchBar.Text}%");
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomerForm = new frmAddCustomer();
            addCustomerForm.ShowDialog();
            this.customerTableAdapter.Fill(this.alhamdDBDataSet.Customer);
        }
    }
}
