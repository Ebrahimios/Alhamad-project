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
    public partial class ucSupplierTransactions : UserControl
    {
        public ucSupplierTransactions()
        {
            InitializeComponent();
        }

        private void ucSupplierTransactions_Load(object sender, EventArgs e)
        {
            cbTransactionSelector.SelectedIndex = 0;
            this.supplierTransactionTableAdapter.Fill(this.alhamdDBDataSet.SupplierTransaction);

            CalculateTotalProfit();
            CalculateTotalRemainingMoney();
        }

        private void cbTransactionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransactionSelector.SelectedIndex == 0)
            {
                this.supplierTransactionTableAdapter.Fill(this.alhamdDBDataSet.SupplierTransaction);

                lblStartDate.Visible = false;
                lblEndDate.Visible = false;
                dtpSupplierStartDate.Visible = false;
                dtpSupplierEndDate.Visible = false;
            }
            else if (cbTransactionSelector.SelectedIndex == 1)
            {
                this.supplierTransactionTableAdapter.FillAllByRemainingMoney(this.alhamdDBDataSet.SupplierTransaction);

                lblStartDate.Visible = false;
                lblEndDate.Visible = false;
                dtpSupplierStartDate.Visible = false;
                dtpSupplierEndDate.Visible = false;
            }
            else
            {
                DateTime startDate = dtpSupplierStartDate.Value.Date;
                DateTime endDate = dtpSupplierEndDate.Value.Date;

                string startDateFormatted = startDate.ToString("yyyy-MM-dd");
                string endDateFormatted = endDate.ToString("yyyy-MM-dd");

                lblStartDate.Visible = true;
                lblEndDate.Visible = true;
                dtpSupplierStartDate.Visible = true;
                dtpSupplierEndDate.Visible = true;
                this.supplierTransactionTableAdapter.FillAllBySpecificDate(this.alhamdDBDataSet.SupplierTransaction, startDateFormatted, endDateFormatted);
            }
            CalculateTotalProfit();
            CalculateTotalRemainingMoney();
        }

        private void dtpSupplierStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpSupplierStartDate.Value.Date;
            DateTime endDate = dtpSupplierEndDate.Value.Date;

            string startDateFormatted = startDate.ToString("yyyy-MM-dd");
            string endDateFormatted = endDate.ToString("yyyy-MM-dd");

            this.supplierTransactionTableAdapter.FillAllBySpecificDate(this.alhamdDBDataSet.SupplierTransaction, startDateFormatted, endDateFormatted);
            CalculateTotalProfit();
            CalculateTotalRemainingMoney();
        }

        private void dtpSupplierEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpSupplierStartDate.Value.Date;
            DateTime endDate = dtpSupplierEndDate.Value.Date;

            string startDateFormatted = startDate.ToString("yyyy-MM-dd");
            string endDateFormatted = endDate.ToString("yyyy-MM-dd");

            this.supplierTransactionTableAdapter.FillAllBySpecificDate(this.alhamdDBDataSet.SupplierTransaction, startDateFormatted, endDateFormatted);
            CalculateTotalProfit();
            CalculateTotalRemainingMoney();
        }

        private void CalculateTotalProfit()
        {
            decimal totalSum = 0;

            // Iterate over the rows of the DataGridView
            foreach (DataGridViewRow row in dgvSupplierTransactions.Rows)
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
            foreach (DataGridViewRow row in dgvSupplierTransactions.Rows)
            {
                if (row.Cells["dgvRemainingMoney"] != null && row.Cells["dgvRemainingMoney"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["dgvRemainingMoney"].Value.ToString(), out decimal price))
                    {
                        totalSum += price;
                    }
                }
            }

            txtRemainingMoney.Text = totalSum.ToString();
        }
    }
}
