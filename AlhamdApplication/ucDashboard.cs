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
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadDefaultScreen();
        }

        private void LoadDefaultScreen()
        {
            btnCustomerTransactions.FillColor = Color.FromArgb(122, 71, 224);
            btnCustomerTransactions.ForeColor = Color.White;

            btnSupplierTransactions.ForeColor = Color.FromArgb(122, 71, 224);
            btnSupplierTransactions.FillColor = Color.Transparent;
            btnProductTransactions.ForeColor = Color.FromArgb(122, 71, 224);
            btnProductTransactions.FillColor = Color.Transparent;

            LoadScreen(new ucCustomerTransactions());
        }

        private void LoadScreen(UserControl screen)
        {
            pnlContainer.Controls.Clear();

            screen.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(screen);
        }

        private void LoadDashboardData()
        {
            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                connection.Open();
                // Load TotalProfit
                lblTotalSalesValue.Text = ExecuteScalarQuery(connection, @" SELECT SUM(CustomerTransaction.TotalPrice) AS TotalProfit FROM CustomerTransaction").ToString();
                lblCurrentYearSalesValue.Text = ExecuteScalarQuery(connection, @" SELECT SUM(CustomerTransaction.TotalPrice) AS CurrentYearProfit FROM CustomerTransaction WHERE YEAR(CustomerTransaction.TransactionDate) = YEAR(GETDATE())").ToString();
                lblCurrentMonthSalesValue.Text = ExecuteScalarQuery(connection, @" SELECT SUM(CustomerTransaction.TotalPrice) AS CurrentMonthProfit FROM CustomerTransaction WHERE YEAR(CustomerTransaction.TransactionDate) = YEAR(GETDATE()) AND MONTH(CustomerTransaction.TransactionDate) = MONTH(GETDATE())").ToString();
                lblRemainingMoneyValue.Text = ExecuteScalarQuery(connection, @"SELECT SUM(RemainingMoney) FROM CustomerTransaction").ToString();
            }
        }

        private object ExecuteScalarQuery(SqlConnection connection, string query)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                return command.ExecuteScalar();
            }
        }

        private void btnCustomerTransactions_Click(object sender, EventArgs e)
        {
            btnCustomerTransactions.FillColor = Color.FromArgb(122, 71, 224);
            btnCustomerTransactions.ForeColor = Color.White;

            btnSupplierTransactions.ForeColor = Color.FromArgb(122, 71, 224);
            btnSupplierTransactions.FillColor = Color.Transparent;
            btnProductTransactions.ForeColor = Color.FromArgb(122, 71, 224);
            btnProductTransactions.FillColor = Color.Transparent;

            LoadScreen(new ucCustomerTransactions());
        }

        private void btnSupplierTransactions_Click(object sender, EventArgs e)
        {
            btnSupplierTransactions.FillColor = Color.FromArgb(122, 71, 224);
            btnSupplierTransactions.ForeColor = Color.White;

            btnCustomerTransactions.ForeColor = Color.FromArgb(122, 71, 224);
            btnCustomerTransactions.FillColor = Color.Transparent;
            btnProductTransactions.ForeColor = Color.FromArgb(122, 71, 224);
            btnProductTransactions.FillColor = Color.Transparent;

            LoadScreen(new ucSupplierTransactions());
        }

        private void btnProductTransactions_Click(object sender, EventArgs e)
        {
            btnProductTransactions.FillColor = Color.FromArgb(122, 71, 224);
            btnProductTransactions.ForeColor = Color.White;

            btnCustomerTransactions.ForeColor = Color.FromArgb(122, 71, 224);
            btnCustomerTransactions.FillColor = Color.Transparent;
            btnSupplierTransactions.ForeColor = Color.FromArgb(122, 71, 224);
            btnSupplierTransactions.FillColor = Color.Transparent;

            LoadScreen(new ucProductTransactions());
        }
    }
}
