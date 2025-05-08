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
    public partial class frmAddEmployee : Form, ITranslatable
    {
        public string Scope => "addEmployee";
        public Control RootControl => this;
        public void ApplyTranslation()
        {
        }
        private string EmployeeName => txtName.Text.Trim();
        private string EmployeePhone => txtPhone.Text.Trim();
        private string EmployeePassword => txtPassword.Text.Trim();
        private bool IsAdmin => ckIsAdmin.Checked;

        public frmAddEmployee()
        {
            InitializeComponent();
            this.Tag = "title";
            lblName.Tag = "name";
            lblPhone.Tag = "phone";
            lblPassword.Tag = "password";
            btnAdd.Tag = "add";
            btnCancel.Tag = "cancel";
            lblTitle.Tag = "addEmployee";
            ckIsAdmin.Tag = "isAdmin";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Validation.IsValidName(EmployeeName))
            {
                MessageBox.Show(ScopedTranslator.Instance.Translate(Scope,"nameInvaild"), ScopedTranslator.Instance.Translate(Scope, "nameInvaildTitle"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (IsNameExists(EmployeeName))
            {
                MessageBox.Show(ScopedTranslator.Instance.Translate(Scope, "nameExists"), ScopedTranslator.Instance.Translate(Scope, "nameExistsTitle"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!Validation.IsValidPhone(EmployeePhone))
            {
                MessageBox.Show(ScopedTranslator.Instance.Translate(Scope, "phoneInvaild"), ScopedTranslator.Instance.Translate(Scope, "phoneInvaildTitle"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (IsPhoneExists(EmployeePhone))
            {
                MessageBox.Show(ScopedTranslator.Instance.Translate(Scope, "phoneExists"), ScopedTranslator.Instance.Translate(Scope, "phoneExistsTitle"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!Validation.IsValidPassword(EmployeePassword))
            {
                MessageBox.Show(ScopedTranslator.Instance.Translate(Scope, "passwordInvaild"), ScopedTranslator.Instance.Translate(Scope, "passwordInvaildTitle"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ScopedTranslator.Instance.ApplyOnce(this);
        }
    }
}
