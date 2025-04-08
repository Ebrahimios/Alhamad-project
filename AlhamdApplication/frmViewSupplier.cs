using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlhamdApplication
{
    public partial class frmViewSupplier : Form
    {
        private string _supplierID;
        private string _supplierName;

        public frmViewSupplier(string id)
        {
            _supplierID = id;

            InitializeComponent();
        }

        private void frmViewSupplier_Load(object sender, EventArgs e)
        {
            DataTable supplierDetails = GetSupplierDetails(_supplierID);

            if (supplierDetails != null && supplierDetails.Rows.Count > 0)
            {
                DataRow row = supplierDetails.Rows[0];

                txtName.Text = row["SupplierName"].ToString();
                _supplierName = row["SupplierName"].ToString();
                txtPhone.Text = row["SupplierPhone"].ToString();
                txtNotes.Text = row["Notes"].ToString();
                lblTotalSalesValue.Text = CalculateSupplierTotalBought(_supplierID).ToString();
                lblRecievedMoney.Text = CalculateSupplierPaidMoney(_supplierID).ToString();
                lblRemainingMoneyValue.Text = CalculateSupplierRemainingMoney(_supplierID).ToString();
            }
            else
            {
                MessageBox.Show("No Supplier data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            this.supplierTransactionTableAdapter.FillBySpecificSupplierID(this.alhamdDBDataSet.SupplierTransaction, Convert.ToInt32(_supplierID));
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.MultiSelect = true;
        }

        private void cbTransactionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransactionSelector.SelectedIndex == 0)
            {
                this.supplierTransactionTableAdapter.FillBySpecificSupplierID(this.alhamdDBDataSet.SupplierTransaction, Convert.ToInt32(_supplierID));

                lblStartDate.Visible = false;
                lblEndDate.Visible = false;
                dtpStartDate.Visible = false;
                dtpEndDate.Visible = false;
            }
            else if (cbTransactionSelector.SelectedIndex == 1)
            {
                this.supplierTransactionTableAdapter.FillBySpecificSupplierID(this.alhamdDBDataSet.SupplierTransaction, Convert.ToInt32(_supplierID));


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
                this.supplierTransactionTableAdapter.FillBySpecificSupplierDate(this.alhamdDBDataSet.SupplierTransaction, Convert.ToInt32(_supplierID), startDateFormatted, endDateFormatted);
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            string startDateFormatted = startDate.ToString("yyyy-MM-dd");
            string endDateFormatted = endDate.ToString("yyyy-MM-dd");

            this.supplierTransactionTableAdapter.FillBySpecificSupplierDate(this.alhamdDBDataSet.SupplierTransaction, Convert.ToInt32(_supplierID), startDateFormatted, endDateFormatted);
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            string startDateFormatted = startDate.ToString("yyyy-MM-dd");
            string endDateFormatted = endDate.ToString("yyyy-MM-dd");

            this.supplierTransactionTableAdapter.FillBySpecificSupplierDate(this.alhamdDBDataSet.SupplierTransaction, Convert.ToInt32(_supplierID), startDateFormatted, endDateFormatted);
        }

        private DataTable GetSupplierDetails(string supplierId)
        {
            string query = @"SELECT Name AS SupplierName, Phone AS SupplierPhone, TotalBoughtMoney, PaidMoney, Notes FROM Supplier WHERE SupplierID = @SupplierID";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SupplierID", supplierId);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable supplierDetails = new DataTable();
                        dataAdapter.Fill(supplierDetails);

                        return supplierDetails;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private bool IsNameExists(string name)
        {
            string query = "SELECT COUNT(*) FROM Supplier WHERE Name = @Name AND SupplierID <> @SupplierID AND IsActive = 1";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@SupplierID", _supplierID);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in connection" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtNotes.ReadOnly = false;
            txtName.FillColor = Color.White;
            txtPhone.FillColor = Color.White;
            txtNotes.FillColor = Color.White;

            btnEdit.FillColor = Color.DarkGray;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation.IsValidName(txtName.Text))
            {
                MessageBox.Show("هذا الاسم غير صالح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsNameExists(txtName.Text))
            {
                MessageBox.Show("هذا الاسم موجود بالفعل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(txtPhone.Text))
            {
                if (!Validation.IsValidPhone(txtPhone.Text))
                {
                    MessageBox.Show("رقم الهاتف غير صالح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من حفظ هذه البيانات", "تعديل بيانات العميل", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "UPDATE Supplier SET Name = @Name, Phone = @Phone, Notes = @Notes WHERE SupplierID = @SupplierID";

                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SupplierID", _supplierID);
                            command.Parameters.AddWithValue("@Name", txtName.Text.ToString());
                            command.Parameters.AddWithValue("@Phone", txtPhone.Text.ToString());
                            command.Parameters.AddWithValue("@Notes", txtPhone.Text.ToString());

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                txtName.ReadOnly = true;
                txtPhone.ReadOnly = true;
                txtNotes.ReadOnly = true;
                txtName.FillColor = Color.FromArgb(248, 249, 250);
                txtPhone.FillColor = Color.FromArgb(248, 249, 250);
                txtNotes.FillColor = Color.FromArgb(248, 249, 250);

                btnEdit.FillColor = Color.FromArgb(94, 148, 255);
            }
        }

        private void dgvTransactions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransactions.Rows[e.RowIndex];
                string transactionId = row.Cells["dgvId"].Value.ToString();

                decimal newValue = Convert.ToDecimal(row.Cells[e.ColumnIndex].Value);

                if (string.IsNullOrEmpty(newValue.ToString()) || newValue < 0)
                {
                    this.supplierTransactionTableAdapter.FillBySpecificSupplierID(this.alhamdDBDataSet.SupplierTransaction, Convert.ToInt32(_supplierID));
                    return;
                }

                // Get the total price from the "TotalPrice" column (assuming the column name is "dgvTotalPrice")
                decimal totalPrice = Convert.ToDecimal(row.Cells["dgvTotalPrice"].Value);

                // Check if the received money is greater than the total price
                if (dgvTransactions.Columns[e.ColumnIndex].Name == "dgvPaidMoney")
                {
                    if (newValue > totalPrice)
                    {
                        MessageBox.Show("المبلغ المدفوع اكبر من المبلغ الكلي");
                        this.supplierTransactionTableAdapter.FillBySpecificSupplierID(this.alhamdDBDataSet.SupplierTransaction, Convert.ToInt32(_supplierID));
                        return;
                    }
                    UpdatePayedMoney(transactionId, newValue);
                }
            }

            lblRemainingMoneyValue.Text = CalculateSupplierRemainingMoney(_supplierID).ToString();
            lblRecievedMoney.Text = CalculateSupplierPaidMoney(_supplierID).ToString();
            lblTotalSalesValue.Text = CalculateSupplierTotalBought(_supplierID).ToString();

            cbTransactionSelector.SelectedIndex = 0;
            this.supplierTransactionTableAdapter.FillBySpecificSupplierID(this.alhamdDBDataSet.SupplierTransaction, Convert.ToInt32(_supplierID));
        }

        private void UpdatePayedMoney(string transactionId, decimal newValue)
        {
            if (int.TryParse(transactionId, out int transactionIdInt))
            {
                string updateQuery = $"UPDATE SupplierTransaction SET PayedMoney = @NewValue WHERE TransactionID = @TransactionID";
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@NewValue", newValue);
                        command.Parameters.AddWithValue("@TransactionID", transactionIdInt);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            UpdateRemainingMoney(transactionId, newValue);
        }

        private void UpdateRemainingMoney(string transactionId, decimal receivedMoney)
        {
            if (int.TryParse(transactionId, out int transactionIdInt))
            {
                string updateQuery = @"
            UPDATE SupplierTransaction SET RemainingMoney = TotalPrice - PayedMoney WHERE TransactionID = @TransactionID";

                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@ReceivedMoney", receivedMoney);
                        command.Parameters.AddWithValue("@TransactionID", transactionIdInt);

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private decimal CalculateSupplierRemainingMoney(string supplierId)
        {
            decimal totalRemainingMoney = 0;

            string query = @"
        SELECT SUM(RemainingMoney) 
        FROM SupplierTransaction 
        WHERE SupplierID = @SupplierID";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SupplierID", supplierId);

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalRemainingMoney = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while calculating remaining money: " + ex.Message);
                }
            }

            return totalRemainingMoney;
        }

        private decimal CalculateSupplierTotalBought(string supplierId)
        {
            decimal totalRemainingMoney = 0;

            string query = @"
        SELECT SUM(TotalPrice) 
        FROM SupplierTransaction 
        WHERE SupplierID = @SupplierID";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SupplierID", supplierId);

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalRemainingMoney = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while calculating remaining money: " + ex.Message);
                }
            }

            return totalRemainingMoney;
        }

        private decimal CalculateSupplierPaidMoney(string supplierId)
        {
            decimal totalRemainingMoney = 0;

            string query = @"
        SELECT SUM(PayedMoney) 
        FROM SupplierTransaction 
        WHERE SupplierID = @SupplierID";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SupplierID", supplierId);

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalRemainingMoney = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while calculating remaining money: " + ex.Message);
                }
            }

            return totalRemainingMoney;
        }

        private void btnGeneratePdf_Click(object sender, EventArgs e)
        {
            List<int> selectedTransactionIds = new List<int>();

            foreach (DataGridViewRow row in dgvTransactions.SelectedRows)
            {
                int transactionId = Convert.ToInt32(row.Cells["dgvId"].Value);
                selectedTransactionIds.Add(transactionId);
            }

            if (selectedTransactionIds.Count > 0)
            {
                ExportMultipleTransactionsPdf(selectedTransactionIds, _supplierName, frmMain.EmployeeName);
            }
            else
            {
                MessageBox.Show("يجب اختيار تعامل واحد علي الأقل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ExportMultipleTransactionsPdf(List<int> transactionIds, string supplierName, string employeeName)
        {
            var fontPath = Environment.GetEnvironmentVariable("SystemRoot") + @"\fonts\Arial.ttf";
            BaseFont bfArialUniCode = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font textFont = new iTextSharp.text.Font(bfArialUniCode, 12, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bfArialUniCode, 12, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bfArialUniCode, 16, iTextSharp.text.Font.BOLD);

            decimal totalPrice = 0; // To calculate the total price across all transactions
            var transactionDates = new Dictionary<int, string>(); // To store transaction dates for each transaction ID

            foreach (var transactionId in transactionIds)
            {
                // Fetch transaction date and items
                transactionDates[transactionId] = GetTransactionDateFromDatabase(transactionId);
                DataTable transactionItems = GetTransactionItemsFromDatabase(transactionId);

                // Calculate total price for this transaction
                foreach (DataRow row in transactionItems.Rows)
                {
                    if (decimal.TryParse(row["Total Price"].ToString(), out decimal itemPrice))
                    {
                        totalPrice += itemPrice;
                    }
                }
            }

            var saveFileDialog = new SaveFileDialog { FileName = "Multiple_Transactions", DefaultExt = ".pdf" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 50f, 20f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    try
                    {
                        var logoImage = iTextSharp.text.Image.GetInstance(Properties.Resources.brand_logo_black, System.Drawing.Imaging.ImageFormat.Png);
                        logoImage.ScaleToFit(150f, 150f);
                        logoImage.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(logoImage);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل تحميل الشعار: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    pdfDoc.Add(new Paragraph("\n\n")); // Space between transactions

                    PdfPTable metaTable = new PdfPTable(2) { WidthPercentage = 80, RunDirection = PdfWriter.RUN_DIRECTION_RTL };
                    metaTable.SetWidths(new float[] { 80f, 20f });
                    AddMetaRow(metaTable, "اسم المورد", supplierName, textFont);
                    AddMetaRow(metaTable, "اسم الموظف", employeeName, textFont);
                    AddMetaRow(metaTable, "التاريخ", DateTime.Now.ToString("yyyy-MM-dd"), textFont);
                    AddMetaRow(metaTable, "اجمالي السعر", $"{totalPrice:C}", textFont);
                    pdfDoc.Add(metaTable);
                    pdfDoc.Add(new Paragraph("\n\n"));

                    // Add transactions
                    foreach (int transactionId in transactionIds)
                    {
                        DataTable transactionItems = GetTransactionItemsFromDatabase(transactionId);

                        // Add transaction date as title
                        string transactionDate = transactionDates[transactionId];
                        Paragraph transactionTitle = new Paragraph($"           {transactionDate}              \n\n", headerFont)
                        {
                            Alignment = Element.ALIGN_RIGHT
                        };
                        pdfDoc.Add(transactionTitle);

                        PdfPTable pdfTable = new PdfPTable(transactionItems.Columns.Count)
                        {
                            DefaultCell = { Padding = 5, BorderWidth = 1 },
                            WidthPercentage = 80,
                            RunDirection = PdfWriter.RUN_DIRECTION_RTL
                        };

                        // Add table headers
                        foreach (DataColumn column in transactionItems.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, headerFont))
                            {
                                BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240),
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                MinimumHeight = 25f
                            };
                            pdfTable.AddCell(cell);
                        }

                        // Add table rows
                        foreach (DataRow row in transactionItems.Rows)
                        {

                            foreach (var cellValue in row.ItemArray)
                            {
                                PdfPCell cellText = new PdfPCell(new Phrase(cellValue?.ToString() ?? "", textFont))
                                {
                                    HorizontalAlignment = Element.ALIGN_CENTER,
                                    MinimumHeight = 25f
                                };
                                pdfTable.AddCell(cellText);
                            }
                        }

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Add(new Paragraph("\n\n")); // Space between transactions
                    }

                    pdfDoc.Close();
                    writer.Close();
                    stream.Close();
                }
            }
        }

        private DataTable GetTransactionItemsFromDatabase(int transactionId)
        {

            string query = @"
    SELECT 
    p.Name AS 'Product Name', 
    sti.Quantity AS 'Quantity', 
    sti.UnitPrice AS 'Unit Price', 
    sti.TotalPrice AS 'Total Price'
FROM dbo.SupplierTransactionItems sti
INNER JOIN dbo.Product p ON sti.ProductID = p.ProductID
WHERE sti.TransactionID = @TransactionID";


            DataTable transactionItems = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TransactionID", transactionId);
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(transactionItems);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching transaction items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return transactionItems;
        }

        private string GetTransactionDateFromDatabase(int transactionId)
        {
            string query = "SELECT TransactionDate FROM SupplierTransaction WHERE TransactionID = @TransactionID";

            try
            {
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TransactionID", transactionId);
                        connection.Open();
                        var result = command.ExecuteScalar();
                        return result != null ? Convert.ToDateTime(result).ToString("yyyy-MM-dd") : "Unknown Date";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching transaction date: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }

        private void AddMetaRow(PdfPTable table, string label, string value, iTextSharp.text.Font font)
        {
            PdfPCell labelCell = new PdfPCell(new Phrase(label, font))
            {
                BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240),
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 5
            };
            table.AddCell(labelCell);

            PdfPCell valueCell = new PdfPCell(new Phrase(value, font))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                Padding = 5
            };
            table.AddCell(valueCell);
        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTransactions.Columns[e.ColumnIndex].Name == "dgvDate")
            {
                int transactionId = Convert.ToInt32(dgvTransactions.Rows[e.RowIndex].Cells["dgvId"].Value);

                frmSupplierTransactionItems supplierTransactionItemsForm = new frmSupplierTransactionItems(transactionId.ToString());
                supplierTransactionItemsForm.ShowDialog();
                if (cbTransactionSelector.SelectedIndex == 0)
                {
                    this.supplierTransactionTableAdapter.FillBySpecificSupplierID(this.alhamdDBDataSet.SupplierTransaction, Convert.ToInt32(_supplierID));
                }
                else if (cbTransactionSelector.SelectedIndex == 1)
                {
                    this.supplierTransactionTableAdapter.FillBySpecificSupplierID(this.alhamdDBDataSet.SupplierTransaction, Convert.ToInt32(_supplierID));
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
                    this.supplierTransactionTableAdapter.FillBySpecificSupplierDate(this.alhamdDBDataSet.SupplierTransaction, Convert.ToInt32(_supplierID), startDateFormatted, endDateFormatted);
                }

                cbTransactionSelector.SelectedIndex = 0;
            }
            else if (e.RowIndex >= 0 && dgvTransactions.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                int transactionId = Convert.ToInt32(dgvTransactions.Rows[e.RowIndex].Cells["dgvId"].Value);

                // Confirm deletion
                var confirmResult = MessageBox.Show("هل انت متأكد من حذف هذا التعامل", "حذف التعامل",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Start a transaction
                            using (SqlTransaction sqlTransaction = connection.BeginTransaction())
                            {
                                try
                                {
                                    // Delete from SupplierTransactionItems
                                    string deleteItemsQuery = "DELETE FROM SupplierTransactionItems WHERE TransactionID = @TransactionID";
                                    using (SqlCommand deleteItemsCommand = new SqlCommand(deleteItemsQuery, connection, sqlTransaction))
                                    {
                                        deleteItemsCommand.Parameters.AddWithValue("@TransactionID", transactionId);
                                        deleteItemsCommand.ExecuteNonQuery();
                                    }

                                    // Delete from SupplierTransaction
                                    string deleteTransactionQuery = "DELETE FROM SupplierTransaction WHERE TransactionID = @TransactionID";
                                    using (SqlCommand deleteTransactionCommand = new SqlCommand(deleteTransactionQuery, connection, sqlTransaction))
                                    {
                                        deleteTransactionCommand.Parameters.AddWithValue("@TransactionID", transactionId);
                                        deleteTransactionCommand.ExecuteNonQuery();
                                    }

                                    // Commit the transaction
                                    sqlTransaction.Commit();

                                    // Refresh the DataGridView
                                    dgvTransactions.Rows.RemoveAt(e.RowIndex);
                                }
                                catch (Exception ex)
                                {
                                    // Rollback the transaction on error
                                    sqlTransaction.Rollback();
                                    MessageBox.Show("An error occurred while deleting the transaction: " + ex.Message,
                                                    "Error",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while connecting to the database: " + ex.Message,
                                            "Database Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
            lblTotalSalesValue.Text = CalculateSupplierTotalBought(_supplierID).ToString();
            lblRecievedMoney.Text = CalculateSupplierPaidMoney(_supplierID).ToString();
            lblRemainingMoneyValue.Text = CalculateSupplierRemainingMoney(_supplierID).ToString();
        }
    }
}