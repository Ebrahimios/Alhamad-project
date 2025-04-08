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
    public partial class frmCustomerTransactionItems : Form
    {
        private string _transactionID;

        public frmCustomerTransactionItems(string transactionId)
        {
            _transactionID = transactionId;
            InitializeComponent();
        }

        private void frmCustomerTransactionItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alhamdDBDataSet.CustomerTransactionItems' table. You can move, or remove it, as needed.
            this.customerTransactionItemsTableAdapter.FillByTransactionID(this.alhamdDBDataSet.CustomerTransactionItems, Convert.ToInt32(_transactionID));

        }

        private void dgvPayedProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPayedProducts.Columns[e.ColumnIndex].Name == "dgvQuantity")
            {
                int itemId = Convert.ToInt32(dgvPayedProducts.Rows[e.RowIndex].Cells["dgvId"].Value);
                int newQuantity = Convert.ToInt32(dgvPayedProducts.Rows[e.RowIndex].Cells["dgvQuantity"].Value);
                decimal unitPrice = Convert.ToDecimal(dgvPayedProducts.Rows[e.RowIndex].Cells["dgvUnitPrice"].Value);

                decimal newTotalPrice = newQuantity * unitPrice;

                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();

                        string updateItemQuery = @"
                    UPDATE CustomerTransactionItems
                    SET Quantity = @Quantity, TotalPrice = @TotalPrice
                    WHERE TransactionItemID = @TransactionItemID";
                        SqlCommand command = new SqlCommand(updateItemQuery, connection);
                        command.Parameters.AddWithValue("@Quantity", newQuantity);
                        command.Parameters.AddWithValue("@TotalPrice", newTotalPrice);
                        command.Parameters.AddWithValue("@TransactionItemID", itemId);
                        command.ExecuteNonQuery();

                        // Update TotalPrice and RemainingMoney in CustomerTransaction
                        UpdateTransactionTotals();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("المبلغ المدفوع أكبر من السعر الكلي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.customerTransactionItemsTableAdapter.FillByTransactionID(this.alhamdDBDataSet.CustomerTransactionItems, Convert.ToInt32(_transactionID));
                    }
                }
            }
        }

        //private void dgvPayedProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && dgvPayedProducts.Columns[e.ColumnIndex].Name == "dgvDelete")
        //    {
        //        int itemId = Convert.ToInt32(dgvPayedProducts.Rows[e.RowIndex].Cells["dgvId"].Value);

        //        var confirmResult = MessageBox.Show("هل أنت متأكد من حذف هذا المنتج",
        //                                            "تأكيد الحذف",
        //                                            MessageBoxButtons.YesNo,
        //                                            MessageBoxIcon.Warning);
        //        if (confirmResult == DialogResult.Yes)
        //        {
        //            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
        //            {
        //                try
        //                {
        //                    connection.Open();

        //                    // Delete the product from CustomerTransactionItems
        //                    string deleteQuery = "DELETE FROM CustomerTransactionItems WHERE TransactionItemID = @TransactionItemID";
        //                    SqlCommand command = new SqlCommand(deleteQuery, connection);
        //                    command.Parameters.AddWithValue("@TransactionItemID", itemId);
        //                    command.ExecuteNonQuery();

        //                    // Update TotalPrice and RemainingMoney in CustomerTransaction
        //                    UpdateTransactionTotals();

        //                    // Refresh DataGridView
        //                    dgvPayedProducts.Rows.RemoveAt(e.RowIndex);

        //                    MessageBox.Show("تم حذف المنتج بنجاح", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show("المبلغ المدفوع أكبر من السعر الكلي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    this.customerTransactionItemsTableAdapter.FillByTransactionID(this.alhamdDBDataSet.CustomerTransactionItems, Convert.ToInt32(_transactionID));
        //                }
        //            }
        //        }
        //    }
        //}

        private void UpdateTransactionTotals()
        {
            string transactionId = _transactionID;

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    // Recalculate TotalPrice
                    string calculateTotalQuery = @"
                SELECT SUM(TotalPrice)
                FROM CustomerTransactionItems
                WHERE TransactionID = @TransactionID";
                    SqlCommand calculateCommand = new SqlCommand(calculateTotalQuery, connection);
                    calculateCommand.Parameters.AddWithValue("@TransactionID", transactionId);

                    decimal totalWithoutDiscount = (decimal)(calculateCommand.ExecuteScalar() ?? 0);

                    // Retrieve the percentage discount for the transaction
                    string discountQuery = @"
                SELECT PercentageDiscount
                FROM CustomerTransaction
                WHERE TransactionID = @TransactionID";
                    SqlCommand discountCommand = new SqlCommand(discountQuery, connection);
                    discountCommand.Parameters.AddWithValue("@TransactionID", transactionId);

                    decimal percentageDiscount = (decimal)(discountCommand.ExecuteScalar() ?? 0);

                    // Apply percentage discount
                    decimal totalWithDiscount = totalWithoutDiscount * (1 - (percentageDiscount / 100));

                    // Update CustomerTransaction with new totals
                    string updateTransactionQuery = @"
                UPDATE CustomerTransaction
                SET TotalPrice = @TotalPrice, 
                    RemainingMoney = @TotalPrice - PayedMoney
                WHERE TransactionID = @TransactionID";
                    SqlCommand updateCommand = new SqlCommand(updateTransactionQuery, connection);
                    updateCommand.Parameters.AddWithValue("@TotalPrice", totalWithDiscount);
                    updateCommand.Parameters.AddWithValue("@TransactionID", transactionId);
                    updateCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating transaction totals: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
