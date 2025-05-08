using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Forms;

namespace AlhamdApplication
{
    public partial class frmSupplierTransactionItems : Form, ITranslatable
    {
        public string Scope => "frmCustomerTransactionItems";
        public Control RootControl => this;
        public void ApplyTranslation()
        {
            // Apply translation logic here
            // Example: this.Text = translator.Translate(Scope, "formTitle");
        }
    
        private string _transactionID;


        public frmSupplierTransactionItems(string id)
        {
            _transactionID = id;
            InitializeComponent();
            this.Tag = "title";
            dgvPayedProducts.Tag = "dgvPayedProducts";
            dgvProductName.Tag = "dgvProductName";
            dgvQuantity.Tag = "dgvQuantity";
            dgvUnitPrice.Tag = "dgvUnitPrice";
            dgvTotalPrice.Tag = "dgvTotalPrice";
            btnSave.Tag = "btnSave";
        }

        private void frmSupplierTransactionItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alhamdDBDataSet.SupplierTransactionItems' table. You can move, or remove it, as needed.
            this.supplierTransactionItemsTableAdapter.Fill(this.alhamdDBDataSet.SupplierTransactionItems);
        }

        private void dgvPayedProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPayedProducts.Columns[e.ColumnIndex].Name == "dgvQuantity")
            {
                int itemId = Convert.ToInt32(dgvPayedProducts.Rows[e.RowIndex].Cells["dgvId"].Value);
                int newQuantity = Convert.ToInt32(dgvPayedProducts.Rows[e.RowIndex].Cells["dgvQuantity"].Value);
                decimal unitPrice = Convert.ToDecimal(dgvPayedProducts.Rows[e.RowIndex].Cells["dgvUnitPrice"].Value);

                // Calculate new TotalPrice for the product
                decimal newTotalPrice = newQuantity * unitPrice;

                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Update Quantity and TotalPrice in CustomerTransactionItems
                        string updateItemQuery = @"
                    UPDATE SupplierTransactionItems
                    SET Quantity = @Quantity, TotalPrice = @TotalPrice
                    WHERE TransactionItemID = @TransactionItemID";
                        SqlCommand command = new SqlCommand(updateItemQuery, connection);
                        command.Parameters.AddWithValue("@Quantity", newQuantity);
                        command.Parameters.AddWithValue("@TotalPrice", newTotalPrice);
                        command.Parameters.AddWithValue("@TransactionItemID", itemId);
                        command.ExecuteNonQuery();

                        UpdateTransactionTotals();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("المبلغ المدفوع أكبر من السعر الكلي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.supplierTransactionItemsTableAdapter.FillByTransactionID(this.alhamdDBDataSet.SupplierTransactionItems, Convert.ToInt32(_transactionID));
                    }
                }
            }
        }

        //private void dgvPayedProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && dgvPayedProducts.Columns[e.ColumnIndex].Name == "dgvDelete")
        //    {
        //        int itemId = Convert.ToInt32(dgvPayedProducts.Rows[e.RowIndex].Cells["dgvId"].Value);

        //        var confirmResult = MessageBox.Show("Are you sure you want to delete this product?",
        //                                            "Confirm Deletion",
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
        //                    string deleteQuery = "DELETE FROM SupplierTransactionItems WHERE TransactionItemID = @TransactionItemID";
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
        //                    this.supplierTransactionItemsTableAdapter.FillByTransactionID(this.alhamdDBDataSet.SupplierTransactionItems, Convert.ToInt32(_transactionID));
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
                FROM SupplierTransactionItems
                WHERE TransactionID = @TransactionID";
                    SqlCommand calculateCommand = new SqlCommand(calculateTotalQuery, connection);
                    calculateCommand.Parameters.AddWithValue("@TransactionID", transactionId);

                    decimal totalWithoutDiscount = (decimal)(calculateCommand.ExecuteScalar() ?? 0);

                    // Retrieve the percentage discount for the transaction
                    string discountQuery = @"
                SELECT PercentageDiscount
                FROM SupplierTransaction
                WHERE TransactionID = @TransactionID";
                    SqlCommand discountCommand = new SqlCommand(discountQuery, connection);
                    discountCommand.Parameters.AddWithValue("@TransactionID", transactionId);

                    decimal percentageDiscount = (decimal)(discountCommand.ExecuteScalar() ?? 0);

                    // Apply percentage discount
                    decimal totalWithDiscount = totalWithoutDiscount * (1 - (percentageDiscount / 100));

                    // Update CustomerTransaction with new totals
                    string updateTransactionQuery = @"
                UPDATE SupplierTransaction
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
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ScopedTranslator.Instance.ApplyOnce(this);
        }
    }
}
