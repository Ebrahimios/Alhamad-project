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
    public partial class frmAddSupplier : Form, ITranslatable
    {
        public string Scope => "frmAddSupplier";
        public Control RootControl => this;
        public void ApplyTranslation()
        {
        }
        private string SupplierName => txtName.Text.Trim();
        private string SupplierPhone => txtPhone.Text.Trim();
        private string SupplierNotes => txtNotes.Text.Trim();

        public frmAddSupplier()
        {
            InitializeComponent();
            this.Tag = "title";
            lblTitle.Tag = "addSupplier";
            lblName.Tag = "name";
            lblPhone.Tag = "phone";
            lblNotes.Tag = "notes";
            btnAdd.Tag = "add";
            btnCancel.Tag = "cancel";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Validation.IsValidName(SupplierName))
            {
                MessageBox.Show("يجب ادخال اسم المورد بشكل صحيح", "اسم غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (IsNameExists(SupplierName))
            {
                MessageBox.Show("هذا الاسم موجود بالفعل", "اسم موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!Validation.IsValidPhone(SupplierPhone))
            {
                    MessageBox.Show("يجب ادخال رقم الهاتف بشكل صحيح", "رقم الهاتف غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }

            AddSupplierToDatabase(SupplierName, SupplierPhone, SupplierNotes);
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
            string query = "SELECT COUNT(*) FROM Supplier WHERE Name = @Name AND IsActive = 1";

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
                    MessageBox.Show("Database Error" + ex.Message, "Name Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }

        private void AddSupplierToDatabase(string name, string phone, string notes)
        {
            string query = "INSERT INTO Supplier (Name, Phone, Notes, IsActive) VALUES (@Name, @Phone, @Notes, 1)";

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
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ScopedTranslator.Instance.ApplyOnce(this);

        }
    }
}
