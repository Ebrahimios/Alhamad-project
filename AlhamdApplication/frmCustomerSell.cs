using AlhamdApp;
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms.Design;

namespace AlhamdApplication
{
    public partial class frmCustomerSell : Form
    {
        private string _customerID;
        private string _customerName;
        private string _employeeID;
        private string _employeeName;

        public frmCustomerSell(string customerId)
        {
            InitializeComponent();
            _customerID = customerId;
            _customerName = GetCustomerNameById(_customerID);
            _employeeID = frmMain.LoggedInEmployeeID.ToString();
            _employeeName = GetEmployeeNameById(_employeeID);
            InitializeComboBoxFromDatabase();
        }

        private void InitializeComboBoxFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                connection.Open();
                string query = "SELECT Name FROM Product WHERE IsActive = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbProductName.Items.Add(reader["Name"].ToString());
                    }
                }
            }

            cbProductName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dgvPayedProducts.Rows)
            {
                totalPrice += (Convert.ToDecimal(row.Cells["dgvPrice"].Value) * Convert.ToDecimal(row.Cells["dgvQuantity"].Value));
            }

            txtTotalPrice.Text = totalPrice.ToString();
        }

        private void UpdateFinalPrice()
        {
            decimal finalPrice = 0;

            finalPrice += (Convert.ToDecimal(txtTotalPrice.Value) - Convert.ToDecimal(txtValueDiscount.Value));

            txtFinalPrice.Text = finalPrice.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbProductName.SelectedItem == null)
            {
                MessageBox.Show("يجب اختيار منتج", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtQuantity.Value < 1)
            {
                MessageBox.Show("يجب اختيار الكمية");
                return;
            }

            string selectedProduct = cbProductName.SelectedItem.ToString();
            int chosenQuantity = (int)txtQuantity.Value;

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                connection.Open();

                string query = @"SELECT Quantity FROM Product WHERE Name = @Name";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", selectedProduct);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int availableQuantity = Convert.ToInt32(reader["Quantity"]);

                            if (chosenQuantity > availableQuantity)
                            {
                                MessageBox.Show($"لا توجد كمية متاحة لهذا المنتج '{selectedProduct}'.\nالمتاح: {availableQuantity}, المطلوب: {chosenQuantity}",
                                                "كمية غير متاحة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
            }

            FetchProductDetails(selectedProduct, chosenQuantity);
            UpdateTotalPrice();
            UpdateFinalPrice();
        }

        public bool IsProductExist(DataGridView dgv, string productName, int newQuantity)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["dgvName"].Value != null &&
                    row.Cells["dgvName"].Value.ToString().Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    row.Cells["dgvQuantity"].Value = newQuantity;
                    row.Cells["dgvTotalPrice"].Value = Convert.ToDecimal(row.Cells["dgvQuantity"].Value) * Convert.ToDecimal(row.Cells["dgvPrice"].Value);
                    MessageBox.Show($"تم تحديث الكمية للمنتج: {productName}", "تم التحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }

            return false;
        }

        private void FetchProductDetails(string productName, int quantityToAdd)
        {
            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                connection.Open();

                string query = @"SELECT ProductID, PayingPrice FROM Product WHERE Name = @Name";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", productName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int productId = Convert.ToInt32(reader["ProductID"]);
                            decimal price = Convert.ToDecimal(reader["PayingPrice"]);
                            decimal totalPrice = price * quantityToAdd;

                            if (!IsProductExist(dgvPayedProducts, productName, quantityToAdd))
                                dgvPayedProducts.Rows.Add(productId, productName, quantityToAdd, price, totalPrice);
                        }
                        else
                        {
                            MessageBox.Show("Product not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private int InsertCustomerTransaction(SqlConnection connection, SqlTransaction transaction, string customerId, int employeeId, decimal totalPrice, decimal payedMoney, decimal percentageDiscount, decimal valueDiscount, DateTime transactionDate)
        {
            string query = @"
        INSERT INTO CustomerTransaction (CustomerID, EmployeeID, TotalPrice, PayedMoney, RemainingMoney, PercentageDiscount, ValueDiscount, TransactionDate) 
        OUTPUT INSERTED.TransactionID
        VALUES (@CustomerID, @EmployeeID, @TotalPrice, @PayedMoney, @RemainingMoney, @PercentageDiscount, @ValueDiscount, @TransactionDate)";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                decimal remainingMoney = totalPrice - payedMoney;

                command.Parameters.AddWithValue("@CustomerID", customerId);
                command.Parameters.AddWithValue("@EmployeeID", employeeId);
                command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                command.Parameters.AddWithValue("@PayedMoney", payedMoney);
                command.Parameters.AddWithValue("@RemainingMoney", remainingMoney);
                command.Parameters.AddWithValue("@PercentageDiscount", percentageDiscount);
                command.Parameters.AddWithValue("@ValueDiscount", valueDiscount);
                command.Parameters.AddWithValue("@TransactionDate", transactionDate);

                return (int)command.ExecuteScalar();
            }
        }

        private void InsertCustomerTransactionItem(SqlConnection connection, SqlTransaction transaction, int transactionId, int productId, decimal pricePerUnit, decimal totalPrice, int quantity)
        {
            string query = @"
        INSERT INTO CustomerTransactionItems (TransactionID, ProductID, UnitPrice, TotalPrice, Quantity) 
        VALUES (@TransactionID, @ProductID, @UnitPrice, @TotalPrice, @Quantity)";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@TransactionID", transactionId);
                command.Parameters.AddWithValue("@ProductID", productId);
                command.Parameters.AddWithValue("@UnitPrice", pricePerUnit);
                command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                command.Parameters.AddWithValue("@Quantity", quantity);

                command.ExecuteNonQuery();
            }
        }

        private void txtValueDiscount_ValueChanged(object sender, EventArgs e)
        {
            if (txtTotalPrice.Value > 0 && txtTotalPrice.Value <= txtTotalPrice.Value)
            {
                decimal percentageDiscount = txtValueDiscount.Value / txtTotalPrice.Value * 100;
                txtPercentageDiscount.Text = percentageDiscount.ToString();
                UpdateFinalPrice();
            }
            else
            {
                txtValueDiscount.Value = 0;
            }
        }

        private void txtPercentageDiscount_ValueChanged(object sender, EventArgs e)
        {
            if (txtTotalPrice.Value > 0)
            {
                decimal valueDiscount = txtPercentageDiscount.Value / 100 * txtTotalPrice.Value;
                txtValueDiscount.Text = valueDiscount.ToString();
                UpdateFinalPrice();
            }
            else
            {
                txtValueDiscount.Value = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    decimal totalTransactionPrice = txtFinalPrice.Value;
                    decimal payedMoney = Convert.ToDecimal(txtRecievedMoney.Text);
                    decimal percentageDiscount = txtPercentageDiscount.Value;
                    decimal valueDiscount = txtValueDiscount.Value;

                    int transactionId = InsertCustomerTransaction(
                        connection,
                        transaction,
                        _customerID,
                        frmMain.LoggedInEmployeeID,
                        totalTransactionPrice,
                        payedMoney,
                        percentageDiscount,
                        valueDiscount,
                        DateTime.Now
                    );

                    foreach (DataGridViewRow row in dgvPayedProducts.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int productId = Convert.ToInt32(row.Cells["dgvId"].Value);
                        int chosenQuantity = Convert.ToInt32(row.Cells["dgvQuantity"].Value);
                        decimal pricePerUnit = Convert.ToDecimal(row.Cells["dgvPrice"].Value);

                        int availableQuantity = GetAvailableQuantity(connection, transaction, productId);
                        if (chosenQuantity > availableQuantity)
                        {
                            MessageBox.Show($"لا يوجد كمية كافية من هذا المنتج. المتاح هو: {availableQuantity}, المطلوب هو: {chosenQuantity}",
                                            "كمية غير كافية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            transaction.Rollback();
                            return;
                        }

                        UpdateProductQuantity(connection, transaction, productId, chosenQuantity);

                        decimal itemTotalPrice = chosenQuantity * pricePerUnit;

                        InsertCustomerTransactionItem(
                            connection,
                            transaction,
                            transactionId,
                            productId,
                            pricePerUnit,
                            itemTotalPrice,
                            chosenQuantity
                        );
                    }

                    UpdateTransactionTotalPrice(connection, transaction, transactionId, totalTransactionPrice);

                    transaction.Commit();
                    MessageBox.Show("تمت العملية بنجاح", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error: {ex.Message}", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateTransactionTotalPrice(SqlConnection connection, SqlTransaction transaction, int transactionId, decimal totalPrice)
        {
            string query = @"UPDATE CustomerTransaction SET TotalPrice = @TotalPrice WHERE TransactionID = @TransactionID";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                command.Parameters.AddWithValue("@TransactionID", transactionId);

                command.ExecuteNonQuery();
            }
        }



        private int GetAvailableQuantity(SqlConnection connection, SqlTransaction transaction, int productId)
        {
            string query = "SELECT Quantity FROM Product WHERE ProductID = @ProductID";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@ProductID", productId);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void UpdateProductQuantity(SqlConnection connection, SqlTransaction transaction, int productId, int soldQuantity)
        {
            string query = "UPDATE Product SET Quantity = Quantity - @SoldQuantity WHERE ProductID = @ProductID";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@SoldQuantity", soldQuantity);
                command.Parameters.AddWithValue("@ProductID", productId);
                command.ExecuteNonQuery();
            }
        }

        private void dgvPayedProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPayedProducts.Columns["dgvDelete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("هل انت متأكد من ازالة هذا السطر", "تأكيد الازالة", MessageBoxButtons.YesNo); if (result == DialogResult.Yes)
                {
                    decimal pricePerUnit = Convert.ToDecimal(dgvPayedProducts.Rows[e.RowIndex].Cells["dgvPrice"].Value);
                    int selectedQuantity = Convert.ToInt32(dgvPayedProducts.Rows[e.RowIndex].Cells["dgvQuantity"].Value);

                    txtTotalPrice.Value -= pricePerUnit * selectedQuantity;
                    UpdateFinalPrice();
                    dgvPayedProducts.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            ExportPdfFile(dgvPayedProducts, $"{_customerName}_{DateTime.Now:yyyy-MM-dd HH-mm-ss}", _customerName, _employeeName, txtFinalPrice.Value);
        }

        public void ExportPdfFile(DataGridView dgv, string fileTitle, string customerName, string employeeName, decimal priceAfterDiscount)
        {
            var fontPath = Environment.GetEnvironmentVariable("SystemRoot") + @"\fonts\Arial.ttf";
            BaseFont bfArialUniCode = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font textFont = new iTextSharp.text.Font(bfArialUniCode, 14, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bfArialUniCode, 14, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bfArialUniCode, 18, iTextSharp.text.Font.BOLD);

            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count - 2)
            {
                DefaultCell = { Padding = 5, BorderWidth = 1 },
                WidthPercentage = 80,
                RunDirection = PdfWriter.RUN_DIRECTION_RTL
            };

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Index == 0 || column.Index == dgv.Columns.Count - 1) continue;

                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, headerFont))
                {
                    BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240),
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    MinimumHeight = 25f
                };
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                for (int colIndex = 0; colIndex < dgv.Columns.Count; colIndex++)
                {
                    if (colIndex == 0 || colIndex == dgv.Columns.Count - 1) continue;

                    var value = row.Cells[colIndex].Value?.ToString() ?? "";
                    PdfPCell cellText = new PdfPCell(new Phrase(value, textFont))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        MinimumHeight = 25f
                    };
                    pdfTable.AddCell(cellText);
                }
            }

            var saveFileDialog = new SaveFileDialog
            {
                FileName = fileTitle,
                DefaultExt = ".pdf"
            };

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

                    PdfPTable metaTable = new PdfPTable(2)
                    {
                        WidthPercentage = 100,
                        RunDirection = PdfWriter.RUN_DIRECTION_RTL
                    };

                    pdfDoc.Add(new Paragraph("\n\n"));

                    metaTable.SetWidths(new float[] { 80f, 20f }); 

                    AddMetaRow(metaTable, "اسم العميل", customerName, textFont);
                    AddMetaRow(metaTable, "اسم الموظف", employeeName, textFont);
                    AddMetaRow(metaTable, "التاريخ", DateTime.Now.ToString("yyyy-MM-dd"), textFont);
                    AddMetaRow(metaTable, "اجمالي السعر", $"{priceAfterDiscount:C}", textFont);

                    metaTable.WidthPercentage = 80;

                    pdfDoc.Add(metaTable);

                    pdfDoc.Add(new Paragraph("\n\n"));

                    pdfDoc.Add(pdfTable);

                    pdfDoc.Close();
                    writer.Close();
                    stream.Close();
                }
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

        private string GetCustomerNameById(string customerId)
        {
            string customerName = string.Empty;

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                connection.Open();

                string query = @"SELECT Name FROM Customer WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customerName = reader["Name"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            return customerName;
        }

        private string GetEmployeeNameById(string employeeId)
        {
            string employeeName = string.Empty;

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                connection.Open();

                string query = @"SELECT Name FROM Employee WHERE EmployeeID = @EmployeeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeName = reader["Name"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            return employeeName;
        }

        private void txtRecievedMoney_ValueChanged(object sender, EventArgs e)
        {
            if (txtRecievedMoney.Value > txtFinalPrice.Value)
            {
                MessageBox.Show("المبلغ المستلم اكبر من المبلغ الكلي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRecievedMoney.Value = 0;
            }
        }
    }
}