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
    public partial class frmAddEmployee : Form
    {
        private string EmployeeName => txtName.Text.Trim();
        private string EmployeePhone => txtPhone.Text.Trim();
        private string EmployeePassword => txtPassword.Text.Trim();
        private bool IsAdmin => ckIsAdmin.Checked;

        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Validation.IsValidName(EmployeeName))
            {
                MessageBox.Show("اسم الموظف غير صالح", "اسم غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (IsNameExists(EmployeeName))
            {
                MessageBox.Show("هذا الاسم موجود بالفعل", "اسم موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!Validation.IsValidPhone(EmployeePhone))
            {
                MessageBox.Show("رقم الهاتف غير صالح", "رقم هاتف غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (IsPhoneExists(EmployeePhone))
            {
                MessageBox.Show("رقم الهاتف موجود بالفعل", "رقم هاتف غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!Validation.IsValidPassword(EmployeePassword))
            {
                MessageBox.Show("يجب ادخال كلمة المرور بشكل صحيح, 5 احرف انجليزية او ارقام", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddEmployeeToDatabase(EmployeeName, EmployeePhone, EmployeePassword, IsAdmin);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool IsNameExists(string name)
        {
            string query = "SELECT COUNT(*) FROM Employee WHERE Name = @Name AND IsActive = 1";

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

        private bool IsPhoneExists(string Phone)
        {
            string query = "SELECT COUNT(*) FROM Employee WHERE Phone = @Phone AND IsActive = 1";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Phone", Phone);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("رقم الهاتف موجود بالفعل" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }

        private void AddEmployeeToDatabase(string name, string phone, string password, bool isAdim)
        {
            string query = "INSERT INTO Employee (Name, Phone, Password, IsAdmin, IsActive) VALUES (@Name, @Phone, @Password, @IsAdmin, 1)";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@IsAdmin", isAdim);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
