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
    public partial class ucProductTransactions : UserControl
    {
        public ucProductTransactions()
        {
            InitializeComponent();
        }

        private void ucProductTransactions_Load(object sender, EventArgs e)
        {
            cbTransactionSelector.SelectedIndex = 0;
            LoadData();
        }

        private void LoadData()
        {
            string query = @"
        SELECT 
            p.ProductID, 
            p.Name, 
            ISNULL(SUM(c.Quantity), 0) AS Quantity
        FROM 
            Product p
        LEFT JOIN 
            CustomerTransactionItems c ON p.ProductID = c.ProductID
        GROUP BY 
            p.ProductID, p.Name
        ORDER BY 
            p.Name";

            try
            {
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        connection.Open();
                        adapter.Fill(dataTable);
                        connection.Close();

                        dgvProducts.DataSource = dataTable;

                        dgvProducts.Columns["ProductID"].Visible = false;

                        dgvProducts.Columns["Name"].HeaderText = "اسم المنتج";
                        dgvProducts.Columns["Quantity"].HeaderText = "الكمية المباعة";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataBetweenDates(DateTime startDate, DateTime endDate)
        {
            string query = @"
        SELECT 
            p.ProductID, 
            p.Name, 
            ISNULL(SUM(c.Quantity), 0) AS Quantity
        FROM 
            Product p
        LEFT JOIN 
            CustomerTransactionItems c ON p.ProductID = c.ProductID
        LEFT JOIN 
            CustomerTransaction t ON c.TransactionID = t.TransactionID
        WHERE 
            t.TransactionDate BETWEEN @StartDate AND @EndDate
        GROUP BY 
            p.ProductID, p.Name
        ORDER BY 
            p.Name";

            try
            {
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters for the date range
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        connection.Open();
                        adapter.Fill(dataTable);
                        connection.Close();

                        dgvProducts.DataSource = dataTable;

                        dgvProducts.Columns["ProductID"].Visible = false;

                        dgvProducts.Columns["Name"].HeaderText = "Product Name";
                        dgvProducts.Columns["Quantity"].HeaderText = "Total Paid Quantity";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cbTransactionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransactionSelector.SelectedIndex == 0)
            {
                LoadData();
                lblStartDate.Visible = false;
                lblEndDate.Visible = false;
                dtpStartDate.Visible = false;
                dtpEndDate.Visible = false;
            }
            else
            {
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;

                string startDateFormatted = startDate.ToString("yyyy-MM-dd");
                string endDateFormatted = endDate.ToString("yyyy-MM-dd");

                lblStartDate.Visible = true;
                lblEndDate.Visible = true;
                dtpStartDate.Visible = true;
                dtpEndDate.Visible = true;

                LoadDataBetweenDates(startDate, endDate);
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            string startDateFormatted = startDate.ToString("yyyy-MM-dd");
            string endDateFormatted = endDate.ToString("yyyy-MM-dd");

            LoadDataBetweenDates(startDate, endDate);
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            string startDateFormatted = startDate.ToString("yyyy-MM-dd");
            string endDateFormatted = endDate.ToString("yyyy-MM-dd");

            LoadDataBetweenDates(startDate, endDate);
        }
    }
}
