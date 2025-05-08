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
    public partial class frmViewEmployee : Form, ITranslatable
    {
        public string Scope => "frmViewEmployee";
        public Control RootControl => this;
        public void ApplyTranslation()
        {
        }
        private string _employeeID;

        public frmViewEmployee(string id)
        {
            _employeeID = id;
            InitializeComponent();
            this.Tag = "title";
            lblName.Tag = "lblName";
            lblPhone.Tag = "lblPhone";
            lblPassword.Tag = "lblPassword";
            ckIsAdmin.Tag = "ckIsAdmin";
            btnEdit.Tag = "btnEdit";
            btnSave.Tag = "btnSave";

        }

        private void frmViewEmployee_Load(object sender, EventArgs e)
        {
            DataTable employeeDetails = GetEmployeeDetails(_employeeID);

            if (employeeDetails != null && employeeDetails.Rows.Count > 0)
            {
                DataRow row = employeeDetails.Rows[0];

                txtName.Text = row["EmployeeName"].ToString();
                txtPhone.Text = row["EmployeePhone"].ToString();
                txtPassword.Text = row["Password"].ToString();
                ckIsAdmin.Checked = Convert.ToBoolean(row["IsAdmin"]);
            }
            else
            {
                MessageBox.Show("No customer data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private DataTable GetEmployeeDetails(string employeeId)
        {
            string query = @"SELECT Name AS EmployeeName, Phone AS EmployeePhone, Password, IsAdmin FROM Employee WHERE EmployeeID = @EmployeeID";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeId);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable employeeDetails = new DataTable();
                        dataAdapter.Fill(employeeDetails);

                        return employeeDetails;
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
            txtPhone.ReadOnly = false;
            txtPassword.ReadOnly = false;
            ckIsAdmin.Enabled = true;
            txtName.FillColor = Color.White;
            txtPhone.FillColor = Color.White;
            txtPassword.FillColor = Color.White;
            ckIsAdmin.ForeColor = SystemColors.ActiveBorder;

            btnEdit.FillColor = Color.DarkGray;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation.IsValidName(txtName.Text))
            {
                MessageBox.Show("اسم الموظف غير صالح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsNameExists(txtName.Text))
            {
                MessageBox.Show("هذا الاسم موجود بالفعل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validation.IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("رقم الهاتف غير صالح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsPhoneExists(txtPhone.Text))
            {
                MessageBox.Show("رقم الهاتف موجود بالفعل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validation.IsValidPassword(txtPassword.Text))
            {
                MessageBox.Show("كلمة المرور يجب ان لا تقل عن 5 احرف انجليزية او ارقام", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من حفظ هذه البيانات", "حفظ البيانات", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "UPDATE Employee SET Name = @Name, Phone = @Phone, Password = @Password, IsAdmin = @IsAdmin WHERE EmployeeID = @EmployeeID";

                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EmployeeID", _employeeID);
                            command.Parameters.AddWithValue("@Name", txtName.Text.ToString());
                            command.Parameters.AddWithValue("@Phone", txtPhone.Text.ToString());
                            command.Parameters.AddWithValue("@Password", txtPassword.Text.ToString());
                            command.Parameters.AddWithValue("@IsAdmin", ckIsAdmin.Checked.ToString());

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
                txtPassword.ReadOnly = true;
                ckIsAdmin.Enabled = true;
                txtName.FillColor = Color.FromArgb(248, 249, 250);
                txtPassword.FillColor = Color.FromArgb(248, 249, 250);
                txtPhone.FillColor = Color.FromArgb(248, 249, 250);

                btnEdit.FillColor = Color.FromArgb(94, 148, 255);
            }
        }

        private bool IsPhoneExists(string phone)
        {
            string query = "SELECT COUNT(*) FROM Employee WHERE Phone = @Phone AND EmployeeID <> @EmployeeID AND IsActive = 1";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@EmployeeID", _employeeID);
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

        private bool IsNameExists(string name)
        {
            string query = "SELECT COUNT(*) FROM Employee WHERE Name = @Name AND EmployeeID <> @EmployeeID AND IsActive = 1";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@EmployeeID", _employeeID);
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

        private void ckIsAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ScopedTranslator.Instance.ApplyOnce(this);
        }
    }
}
