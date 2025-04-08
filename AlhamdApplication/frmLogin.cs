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
    public partial class frmLogin : Form
    {
        public static string EmployeePhone;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredPhone = txtPhone.Text;
            string enteredPassword = txtPassword.Text;
            EmployeePhone = txtPhone.Text;

            if (ValidateLogin(enteredPhone, enteredPassword))
            {
                GetEmployeeIDAndRole(enteredPhone);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("رقم الهاتف او كلمة المرور خاطئة! يمكنك المحاولة مرة أخرى", "خطأ في رقم الهاتف أو كلمة المرور", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool ValidateLogin(string phone, string password)
        {
            bool isValid = false;

            string query = "SELECT COUNT(*) FROM Employee WHERE Phone = @Phone AND Password = @Password AND IsActive = 1";

            try
            {
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();

                    int result = (int)command.ExecuteScalar();

                    if (result > 0) isValid = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return isValid;
        }

        public static bool GetEmployeeIDAndRole(string phone)
        {
            bool isValid = false;

            string query = "SELECT EmployeeID, IsAdmin, Name FROM Employee WHERE Phone = @Phone AND IsActive = 1";

            try
            {
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Phone", phone);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isValid = true;

                            frmMain.LoggedInEmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID"));
                            frmMain.IsEmployeeAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));
                            frmMain.EmployeeName = reader.GetString(reader.GetOrdinal("Name"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }
    }
}
