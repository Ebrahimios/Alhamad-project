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
    public partial class frmAddProduct : Form
    {
        private string ProductName => txtName.Text.Trim();
        private decimal ProductInitialPrice => Math.Round(txtInitialPrice.Value, 2);
        private decimal ProductPrice => Math.Round(txtPrice.Value, 2);

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                MessageBox.Show("يجب ادخال اسم المنتج بشكل صحيح", "اسم غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (IsNameExists(ProductName))
            {
                MessageBox.Show("هذا الاسم موجود بالفعل", "اسم موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (ProductInitialPrice < 1 || ProductInitialPrice > ProductPrice)
            {
                MessageBox.Show("ادخل الاسعار بشكل صحيح", "قيم غير صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            AddProductToDatabase(ProductName, ProductInitialPrice, ProductPrice);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddProductToDatabase(string name, decimal initialPrice, decimal price)
        {
            string query = "INSERT INTO Product (Name, InitialPrice, PayingPrice, IsActive) VALUES (@Name, @InitialPrice, @PayingPrice, 1)";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@InitialPrice", initialPrice);
                        command.Parameters.AddWithValue("@PayingPrice", price);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsNameExists(string name)
        {
            string query = "SELECT COUNT(*) FROM Product WHERE Name = @Name AND IsActive = 1";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }
    }
}
