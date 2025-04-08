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
    public partial class frmAddCustomer : Form
    {
        private string CustomerName => txtName.Text.Trim();
        private string CustomerPhone => txtPhone.Text.Trim();
        private string CustomerNotes => txtNotes.Text.Trim();

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Validation.IsValidName(CustomerName))
            {
                MessageBox.Show("اسم العميل غير صالح", "اسم غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (IsNameExists(txtName.Text))
            {
                MessageBox.Show("هذا الاسم موجود بالفعل", "اسم موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!string.IsNullOrEmpty(CustomerPhone))
            {
                if (!Validation.IsValidPhone(CustomerPhone))
                {
                    MessageBox.Show("رقم الهاتف غير صالح", "رقم هاتف غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            AddCustomerToDatabase(CustomerName, CustomerPhone, CustomerNotes);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddCustomerToDatabase(string name, string phone, string notes)
        {
            string query = "INSERT INTO Customer (Name, Phone, Notes, IsActive) VALUES (@Name, @Phone, @Notes, 1)";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Notes", notes);

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
            string query = "SELECT COUNT(*) FROM Customer WHERE Name = @Name AND IsActive = 1";

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
                    MessageBox.Show("Error in connection" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }
    }
}
