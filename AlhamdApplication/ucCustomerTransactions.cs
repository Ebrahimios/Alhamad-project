using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlhamdApplication
{
    public partial class ucCustomerTransactions : UserControl
    {
        public ucCustomerTransactions()
        {
            InitializeComponent();
        }

        private void ucCustomerTransactions_Load(object sender, EventArgs e)
        {
            cbTransactionSelector.SelectedIndex = 0;
            this.customerTransactionTableAdapter.Fill(this.alhamdDBDataSet.CustomerTransaction);

            CalculateTotalProfit();
            CalculateTotalRemainingMoney();
        }

        private void cbTransactionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransactionSelector.SelectedIndex == 0)
            {
                this.customerTransactionTableAdapter.Fill(this.alhamdDBDataSet.CustomerTransaction);

                lblCustomerStartDate.Visible = false;
                lblCustomerEndDate.Visible = false;
                dtpCustomerStartDate.Visible = false;
                dtpCustomerEndDate.Visible = false;
            }
            else if (cbTransactionSelector.SelectedIndex == 1)
            {
                this.customerTransactionTableAdapter.FillAllByRemainingMoney(this.alhamdDBDataSet.CustomerTransaction);

                lblCustomerStartDate.Visible = false;
                lblCustomerEndDate.Visible = false;
                dtpCustomerStartDate.Visible = false;
                dtpCustomerEndDate.Visible = false;
            }
            else
            {
                DateTime startDate = dtpCustomerStartDate.Value.Date;
                DateTime endDate = dtpCustomerEndDate.Value.Date;

                string startDateFormatted = startDate.ToString("yyyy-MM-dd");
                string endDateFormatted = endDate.ToString("yyyy-MM-dd");

                lblCustomerStartDate.Visible = true;
                lblCustomerEndDate.Visible = true;
                dtpCustomerStartDate.Visible = true;
                dtpCustomerEndDate.Visible = true;
                this.customerTransactionTableAdapter.FillAllBySpecificDate(this.alhamdDBDataSet.CustomerTransaction, startDateFormatted, endDateFormatted);
            }
            CalculateTotalProfit();
            CalculateTotalRemainingMoney();
        }

        private void dtpCustomerStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpCustomerStartDate.Value.Date;
            DateTime endDate = dtpCustomerEndDate.Value.Date;

            string startDateFormatted = startDate.ToString("yyyy-MM-dd");
            string endDateFormatted = endDate.ToString("yyyy-MM-dd");

            this.customerTransactionTableAdapter.FillAllBySpecificDate(this.alhamdDBDataSet.CustomerTransaction, startDateFormatted, endDateFormatted);
            CalculateTotalProfit();
            CalculateTotalRemainingMoney();
        }

        private void dtpCustomerEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpCustomerStartDate.Value.Date;
            DateTime endDate = dtpCustomerEndDate.Value.Date;

            string startDateFormatted = startDate.ToString("yyyy-MM-dd");
            string endDateFormatted = endDate.ToString("yyyy-MM-dd");

            this.customerTransactionTableAdapter.FillAllBySpecificDate(this.alhamdDBDataSet.CustomerTransaction, startDateFormatted, endDateFormatted);
            CalculateTotalProfit();
            CalculateTotalRemainingMoney();
        }

        private void CalculateTotalProfit()
        {
            decimal totalSum = 0;

            // Iterate over the rows of the DataGridView
            foreach (DataGridViewRow row in dgvCustomerTransactions.Rows)
            {
                if (row.Cells["dgvTotalPrice"] != null && row.Cells["dgvTotalPrice"].Value != null)
                {
                    // Try to parse the cell value as a decimal
                    if (decimal.TryParse(row.Cells["dgvTotalPrice"].Value.ToString(), out decimal price))
                    {
                        totalSum += price;
                    }
                }
            }

            // Display the total sum in the TextBox
            txtTotalProfit.Text = totalSum.ToString(); // Format as currency
        }

        private void CalculateTotalRemainingMoney()
        {
            decimal totalSum = 0;

            // Iterate over the rows of the DataGridView
            foreach (DataGridViewRow row in dgvCustomerTransactions.Rows)
            {
                if (row.Cells["dgvRemainingMoney"] != null && row.Cells["dgvRemainingMoney"].Value != null)
                {
                    // Try to parse the cell value as a decimal
                    if (decimal.TryParse(row.Cells["dgvRemainingMoney"].Value.ToString(), out decimal price))
                    {
                        totalSum += price;
                    }
                }
            }

            // Display the total sum in the TextBox
            txtRemainingMoney.Text = totalSum.ToString(); // Format as currency
        }

        private void dgvCustomerTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCustomerTransactions.Columns[e.ColumnIndex].Name == "dgvCustomerName")
            {
                int transactionId = Convert.ToInt32(dgvCustomerTransactions.Rows[e.RowIndex].Cells["dgvTransactionId"].Value);

                frmCustomerTransactionItems customerTransactionItemsForm = new frmCustomerTransactionItems(transactionId.ToString());
                customerTransactionItemsForm.ShowDialog();

                cbTransactionSelector.SelectedIndex = 0;
                this.customerTransactionTableAdapter.Fill(this.alhamdDBDataSet.CustomerTransaction);
            }
        }
    }
}
