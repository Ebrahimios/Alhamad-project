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
using System.Web.Util;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace AlhamdApplication
{
    public partial class frmViewCustomer : Form, ITranslatable
    {
        public string Scope => "frmViewCustomer";
        public Control RootControl => this;
        public void ApplyTranslation()
        {
            // Apply translation logic here
            // Example: this.Text = translator.Translate(Scope, "formTitle");
        }
        private string _customerID;
        private string _customerName;

        public frmViewCustomer(string id)
        {
            _customerID = id;
            InitializeComponent();
            this.Tag = "title";
            lblNameTitle.Tag = "lblCustomerName";
            lblPhoneTitle.Tag = "lblCustomerPhone";
            lblNotes.Tag = "lblNotes";
            lblTotalSalesValue.Tag = "lblTotalSalesValue";
            lblRecievedMoney.Tag = "lblRecievedMoney";
            lblRemainingMoneyValue.Tag = "lblRemainingMoneyValue";
            btnEdit.Tag = "btnEdit";
            btnSave.Tag = "btnSave";
            btnGeneratePdf.Tag = "btnGeneratePdf";
            cbTransactionSelector.Tag = "cbTransactionSelector";
            lblCustomerStartDate.Tag = "lblCustomerStartDate";
            lblCustomerEndDate.Tag = "lblCustomerEndDate";
            dgvId.Tag = "dgvId";
            dgvDate.Tag = "dgvDate";
            dgvTotalPrice.Tag = "dgvTotalPrice";
            dgvPayedMoney.Tag = "dgvPaidMoney";
            dgvRemainingMoney.Tag = "dgvRemainingMoney";
            dgvDelete.Tag = "dgvDelete";
        }

        private void frmViewCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alhamdDBDataSet.CustomerTransaction' table. You can move, or remove it, as needed.
            this.customerTransactionTableAdapter.FillBySpecificCustomerID(this.alhamdDBDataSet.CustomerTransaction, Convert.ToInt32(_customerID));
            
            DataTable customerDetails = GetCustomerDetails(_customerID);

            if (customerDetails != null && customerDetails.Rows.Count > 0)
            {
                DataRow row = customerDetails.Rows[0];

                txtName.Text = row["CustomerName"].ToString();
                _customerName = row["CustomerName"].ToString();
                txtPhone.Text = row["CustomerPhone"].ToString();
                txtNotes.Text = row["Notes"].ToString();
                lblTotalSalesValue.Text = CalculateCustomerTotalBought(_customerID).ToString();
                lblRecievedMoney.Text = CalculateCustomerPaidMoney(_customerID).ToString();
                lblRemainingMoneyValue.Text = CalculateCustomerRemainingMoney(_customerID).ToString();
            }
            else
            {
                MessageBox.Show("No customer data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            dgvCustomerTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomerTransactions.MultiSelect = true;
        }

        private void cbTransactionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransactionSelector.SelectedIndex == 0)
            {
                this.customerTransactionTableAdapter.FillBySpecificCustomerID(this.alhamdDBDataSet.CustomerTransaction, Convert.ToInt32(_customerID));

                lblCustomerStartDate.Visible = false;
                lblCustomerEndDate.Visible = false;
                dtpCustomerStartDate.Visible = false;
                dtpCustomerEndDate.Visible = false;
            }
            else if (cbTransactionSelector.SelectedIndex == 1)
            {
                this.customerTransactionTableAdapter.FillBySpecificIDRemainingMoney(this.alhamdDBDataSet.CustomerTransaction, Convert.ToInt32(_customerID));


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
                this.customerTransactionTableAdapter.FillBySpecificCustomerDate(this.alhamdDBDataSet.CustomerTransaction, Convert.ToInt32(_customerID), startDateFormatted, endDateFormatted);
            }
        }

        private void dtpCustomerStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpCustomerStartDate.Value.Date;
            DateTime endDate = dtpCustomerEndDate.Value.Date;

            string startDateFormatted = startDate.ToString("yyyy-MM-dd");
            string endDateFormatted = endDate.ToString("yyyy-MM-dd");

            this.customerTransactionTableAdapter.FillBySpecificCustomerDate(this.alhamdDBDataSet.CustomerTransaction, Convert.ToInt32(_customerID), startDateFormatted, endDateFormatted);

        }

        private void dtpCustomerEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpCustomerStartDate.Value.Date;
            DateTime endDate = dtpCustomerEndDate.Value.Date;

            string startDateFormatted = startDate.ToString("yyyy-MM-dd");
            string endDateFormatted = endDate.ToString("yyyy-MM-dd");

            this.customerTransactionTableAdapter.FillBySpecificCustomerDate(this.alhamdDBDataSet.CustomerTransaction, Convert.ToInt32(_customerID), startDateFormatted, endDateFormatted);
        }

        private DataTable GetCustomerDetails(string customerId)
        {
            string query = @"SELECT Name AS CustomerName, Phone AS CustomerPhone, Notes FROM Customer WHERE CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable customerDetails = new DataTable();
                        dataAdapter.Fill(customerDetails);

                        return customerDetails;
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
            string query = "SELECT COUNT(*) FROM Customer WHERE Name = @Name AND CustomerID <> @CustomerID AND IsActive = 1";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@CustomerID", _customerID);
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
                string query = "UPDATE Customer SET Name = @Name, Phone = @Phone, Notes = @Notes WHERE CustomerID = @CustomerID";

                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CustomerID", _customerID);
                            command.Parameters.AddWithValue("@Name", txtName.Text.ToString());
                            command.Parameters.AddWithValue("@Phone", txtPhone.Text.ToString());
                            command.Parameters.AddWithValue("@Notes", txtNotes.Text.ToString());

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

        private void dgvCustomerTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCustomerTransactions.Columns[e.ColumnIndex].Name == "dgvDate")
            {
                int transactionId = Convert.ToInt32(dgvCustomerTransactions.Rows[e.RowIndex].Cells["dgvId"].Value);

                frmCustomerTransactionItems customerTransactionItemsForm = new frmCustomerTransactionItems(transactionId.ToString());
                customerTransactionItemsForm.ShowDialog();
                if (cbTransactionSelector.SelectedIndex == 0)
                {
                    this.customerTransactionTableAdapter.FillBySpecificCustomerID(this.alhamdDBDataSet.CustomerTransaction, Convert.ToInt32(_customerID));
                }
                else if (cbTransactionSelector.SelectedIndex == 1)
                {
                    this.customerTransactionTableAdapter.FillBySpecificIDRemainingMoney(this.alhamdDBDataSet.CustomerTransaction, Convert.ToInt32(_customerID));
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
                    this.customerTransactionTableAdapter.FillBySpecificCustomerDate(this.alhamdDBDataSet.CustomerTransaction, Convert.ToInt32(_customerID), startDateFormatted, endDateFormatted);
                }

                cbTransactionSelector.SelectedIndex = 0;
            }
            else if (e.RowIndex >= 0 && dgvCustomerTransactions.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                int transactionId = Convert.ToInt32(dgvCustomerTransactions.Rows[e.RowIndex].Cells["dgvId"].Value);

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
                                    // Delete from CustomerTransactionItems
                                    string deleteItemsQuery = "DELETE FROM CustomerTransactionItems WHERE TransactionID = @TransactionID";
                                    using (SqlCommand deleteItemsCommand = new SqlCommand(deleteItemsQuery, connection, sqlTransaction))
                                    {
                                        deleteItemsCommand.Parameters.AddWithValue("@TransactionID", transactionId);
                                        deleteItemsCommand.ExecuteNonQuery();
                                    }

                                    // Delete from CustomerTransaction
                                    string deleteTransactionQuery = "DELETE FROM CustomerTransaction WHERE TransactionID = @TransactionID";
                                    using (SqlCommand deleteTransactionCommand = new SqlCommand(deleteTransactionQuery, connection, sqlTransaction))
                                    {
                                        deleteTransactionCommand.Parameters.AddWithValue("@TransactionID", transactionId);
                                        deleteTransactionCommand.ExecuteNonQuery();
                                    }

                                    // Commit the transaction
                                    sqlTransaction.Commit();

                                    // Refresh the DataGridView
                                    dgvCustomerTransactions.Rows.RemoveAt(e.RowIndex);
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

            lblTotalSalesValue.Text = CalculateCustomerTotalBought(_customerID).ToString();
            lblRecievedMoney.Text = CalculateCustomerPaidMoney(_customerID).ToString();
            lblRemainingMoneyValue.Text = CalculateCustomerRemainingMoney(_customerID).ToString();
        }

        private void dgvCustomerTransactions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomerTransactions.Rows[e.RowIndex];
                string transactionId = row.Cells["dgvId"].Value.ToString();

                decimal newValue = Convert.ToDecimal(row.Cells[e.ColumnIndex].Value);

                if (string.IsNullOrEmpty(newValue.ToString()) || newValue < 0 )
                {
                    this.customerTransactionTableAdapter.FillBySpecificCustomerID(this.alhamdDBDataSet.CustomerTransaction, Convert.ToInt32(_customerID));
                    return;
                }

                // Get the total price from the "TotalPrice" column (assuming the column name is "dgvTotalPrice")
                decimal totalPrice = Convert.ToDecimal(row.Cells["dgvTotalPrice"].Value);

                // Check if the received money is greater than the total price
                if (dgvCustomerTransactions.Columns[e.ColumnIndex].Name == "dgvPayedMoney")
                {
                    if (newValue > totalPrice)
                    {
                        MessageBox.Show("المبلغ المدفوع اكبر من المبلغ الكلي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.customerTransactionTableAdapter.FillBySpecificCustomerID(this.alhamdDBDataSet.CustomerTransaction, Convert.ToInt32(_customerID));
                        return; 
                    }
                    UpdatePayedMoney(transactionId, newValue);
                }
            }

            lblRemainingMoneyValue.Text = CalculateCustomerRemainingMoney(_customerID).ToString();
            lblRecievedMoney.Text = CalculateCustomerPaidMoney(_customerID).ToString();
            lblTotalSalesValue.Text = CalculateCustomerTotalBought(_customerID).ToString();

            cbTransactionSelector.SelectedIndex = 0;
            this.customerTransactionTableAdapter.FillBySpecificCustomerID(this.alhamdDBDataSet.CustomerTransaction, Convert.ToInt32(_customerID));
        }

        private void UpdatePayedMoney(string transactionId, decimal newValue)
        {
            if (int.TryParse(transactionId, out int transactionIdInt))
            {
                string updateQuery = $"UPDATE CustomerTransaction SET PayedMoney = @NewValue WHERE TransactionID = @TransactionID";
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
            UPDATE CustomerTransaction SET RemainingMoney = TotalPrice - PayedMoney WHERE TransactionID = @TransactionID";

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

        private decimal CalculateCustomerRemainingMoney(string customerId)
        {
            decimal totalRemainingMoney = 0;

            string query = @"
        SELECT SUM(RemainingMoney) 
        FROM CustomerTransaction 
        WHERE CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerId);

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

        private decimal CalculateCustomerTotalBought(string customerId)
        {
            decimal totalRemainingMoney = 0;

            string query = @"
        SELECT SUM(TotalPrice) 
        FROM CustomerTransaction 
        WHERE CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerId);

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

        private decimal CalculateCustomerPaidMoney(string customerId)
        {
            decimal totalRemainingMoney = 0;

            string query = @"
        SELECT SUM(PayedMoney) 
        FROM CustomerTransaction 
        WHERE CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerId);

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

        private void btnPdfMultiple_Click(object sender, EventArgs e)
        {
            List<int> selectedTransactionIds = new List<int>();

            foreach (DataGridViewRow row in dgvCustomerTransactions.SelectedRows)
            {
                int transactionId = Convert.ToInt32(row.Cells["dgvId"].Value);
                selectedTransactionIds.Add(transactionId);
            }

            if (selectedTransactionIds.Count > 0)
            {
                ExportMultipleTransactionsPdf(selectedTransactionIds, _customerName, frmMain.EmployeeName);
            }
            else
            {
                MessageBox.Show("Please select at least one transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ExportMultipleTransactionsPdf(List<int> transactionIds, string customerName, string employeeName)
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
                    if (decimal.TryParse(row["السعر الكلي"].ToString(), out decimal itemPrice))
                    {
                        totalPrice += itemPrice;
                    }
                }
            }

            var saveFileDialog = new SaveFileDialog { FileName = $"{_customerName}_{DateTime.Now:yyyy-MM-dd HH-mm-ss}", DefaultExt = ".pdf" };
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
                    AddMetaRow(metaTable, "اسم العميل", customerName, textFont);
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
    p.Name AS 'اسم المنتج', 
    cti.Quantity AS 'الكمية', 
    cti.UnitPrice AS 'السعر', 
    cti.TotalPrice AS 'السعر الكلي'
FROM dbo.CustomerTransactionItems cti
INNER JOIN dbo.Product p ON cti.ProductID = p.ProductID
WHERE cti.TransactionID = @TransactionID";


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
            string query = "SELECT TransactionDate FROM dbo.CustomerTransaction WHERE TransactionID = @TransactionID";

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

        private void customerTransactionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ScopedTranslator.Instance.ApplyOnce(this);
        }
    }
}
