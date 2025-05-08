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
    public partial class frmAddCustomer : Form, ITranslatable
    {
        public string Scope => "frmAddCustomer";
        public Control RootControl => this;
        

        private string CustomerName => txtName.Text.Trim();
        private string CustomerPhone => txtPhone.Text.Trim();
        private string CustomerNotes => txtNotes.Text.Trim();

        public frmAddCustomer()
        {
            InitializeComponent();
            this.Tag = "title";
            lblName.Tag = "name";
            lblPhone.Tag = "phone";
            lblNotes.Tag = "notes";
            btnAdd.Tag = "add";
            btnCancel.Tag = "cancel";
            ScopedTranslator.Instance.Register(this);

        }
        public void ApplyTranslation()
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Validation.IsValidName(CustomerName))
            {
                MessageBox.Show(ScopedTranslator.Instance.Translate(Scope, "nameInvaild"), ScopedTranslator.Instance.Translate(Scope, "nameInvaildTitle"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (IsNameExists(txtName.Text))
            {
                MessageBox.Show(ScopedTranslator.Instance.Translate(Scope, "nameExists"), ScopedTranslator.Instance.Translate(Scope, "nameExistsTitle"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!string.IsNullOrEmpty(CustomerPhone))
            {
                if (!Validation.IsValidPhone(CustomerPhone))
                {
                    MessageBox.Show(ScopedTranslator.Instance.Translate(Scope, "phoneInvaild"), ScopedTranslator.Instance.Translate(Scope, "phoneInvaildTitle"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ScopedTranslator.Instance.ApplyOnce(this);

        }



        private void frmAddCustomer_Shown(object sender, EventArgs e)
        {

        }
    }
}
