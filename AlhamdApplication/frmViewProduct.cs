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
    public partial class frmViewProduct : Form
    {
        private string _productID;

        public frmViewProduct(string id)
        {
            _productID = id;
            InitializeComponent();
        }

        private void frmViewProduct_Load(object sender, EventArgs e)
        {
            DataTable productDetails = GetProductDetails(_productID);

            if (productDetails != null && productDetails.Rows.Count > 0)
            {
                DataRow row = productDetails.Rows[0];

                txtName.Text = row["ProductName"].ToString();
                txtInitialPrice.Text = row["InitialPrice"].ToString();
                txtPrice.Text = row["PayingPrice"].ToString();
            }
            else
            {
                MessageBox.Show("No product data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            LoadPaidQuantityForProduct(_productID);
            LoadAvailableQuantity(_productID);
        }

        private DataTable GetProductDetails(string productId)
        {
            string query = @"SELECT Name AS ProductName, InitialPrice, PayingPrice, Quantity FROM Product WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productId);

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtInitialPrice.ReadOnly = false;
            txtPrice.ReadOnly = false;
            txtName.FillColor = Color.White;
            txtInitialPrice.BackColor = Color.White;
            txtPrice.BackColor = Color.White;

            btnEdit.FillColor = Color.DarkGray;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                MessageBox.Show("يجب ادخال اسم المنتج بشكل صحيح", "اسم غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (IsNameExists(txtName.Text))
            {
                MessageBox.Show("هذا المنتج موجود بالفعل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtInitialPrice.Value > txtPrice.Value)
            {
                MessageBox.Show("يجب ان يكون سعر البيع اكبر من سعر الجملة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من حفظ هذه البيانات", "حفظ التعديلات", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "UPDATE Product SET Name = @Name, InitialPrice = @InitialPrice, PayingPrice = @PayingPrice WHERE ProductID = @ProductID";

                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", _productID);
                            command.Parameters.AddWithValue("@Name", txtName.Text.ToString());
                            command.Parameters.AddWithValue("@InitialPrice", txtInitialPrice.Text.ToString());
                            command.Parameters.AddWithValue("@PayingPrice", txtPrice.Text.ToString());

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                txtName.ReadOnly = true;
                txtInitialPrice.ReadOnly = true;
                txtPrice.ReadOnly = true;

                txtName.FillColor = Color.FromArgb(248, 249, 250);
                txtInitialPrice.BackColor = Color.FromArgb(248, 249, 250);
                txtPrice.BackColor = Color.FromArgb(248, 249, 250);

                btnEdit.FillColor = Color.FromArgb(94, 148, 255);
            }
        }

        private bool IsNameExists(string name)
        {
            string query = "SELECT COUNT(*) FROM Product WHERE Name = @Name AND ProductID <> @ProductID AND IsActive = 1";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@ProductID", _productID);
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

        private void LoadPaidQuantityForProduct(string productId)
        {
            string query = @"
        SELECT 
            ISNULL(SUM(c.Quantity), 0) AS Quantity
        FROM 
            Product p
        LEFT JOIN 
            CustomerTransactionItems c ON p.ProductID = c.ProductID
        WHERE 
            p.ProductID = @ProductID
        GROUP BY 
            p.ProductID";

            try
            {
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the product ID parameter
                        command.Parameters.AddWithValue("@ProductID", productId);

                        connection.Open();

                        // Execute the query and get the result
                        object result = command.ExecuteScalar();

                        // Convert the result to decimal (default to 0 if null)
                        decimal paidQuantity = result != null ? Convert.ToDecimal(result) : 0;

                        // Display the result in the TextBox
                        txtPayedQuantity.Text = paidQuantity.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvailableQuantity(string productId)
        {
            string query = @"
    SELECT 
        ISNULL(SUM(s.Quantity), 0) - ISNULL(SUM(c.Quantity), 0) AS AvailableQuantity
    FROM 
        Product p
    LEFT JOIN 
        SupplierTransactionItems s ON p.ProductID = s.ProductID
    LEFT JOIN 
        CustomerTransactionItems c ON p.ProductID = c.ProductID
    WHERE 
        p.ProductID = @ProductID
    GROUP BY 
        p.ProductID";

            try
            {
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the product ID parameter
                        command.Parameters.AddWithValue("@ProductID", productId);

                        connection.Open();

                        // Execute the query and get the result
                        object result = command.ExecuteScalar();

                        // Convert the result to decimal (default to 0 if null)
                        decimal availableQuantity = result != null ? Convert.ToDecimal(result) : 0;

                        // Display the result in the TextBox
                        txtAvaliableQuantity.Text = availableQuantity.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
