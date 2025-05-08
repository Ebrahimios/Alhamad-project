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
    public partial class frmAddExpenses : Form, ITranslatable

    {
        public string Scope => "addExpenses";
        public Control RootControl => this;
        public void ApplyTranslation()
        {
        }
        private string SupplierName => txtExpensesType.Text.Trim();
        private decimal ExpensesValue => txtExpenses.Value;

        public frmAddExpenses()
        {
            InitializeComponent();
            lblTitle.Tag = "addExpenses";
            lblName.Tag = "name";
            label1.Tag = "value";
            this.Tag = "title";
            btnAdd.Tag = "add";
            btnCancel.Tag = "cancel";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Validation.IsValidName(txtExpensesType.Text))
            {
                MessageBox.Show(ScopedTranslator.Instance.Translate(Scope,"nameInvaild"), ScopedTranslator.Instance.Translate(Scope, "nameInvaildTitle"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtExpenses.Value < 1)
            {
                MessageBox.Show(ScopedTranslator.Instance.Translate(Scope, "amountInvaild"), ScopedTranslator.Instance.Translate(Scope, "amountInvaildTitle"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            AddExpensesToDatabase(SupplierName, ExpensesValue, frmMain.LoggedInEmployeeID.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddExpensesToDatabase(string expensesType, decimal expensesAmount, string employeeId)
        {
            string query = "INSERT INTO Expenses (ExpenseType, ExpenseAmount, CreatorID) VALUES (@ExpenseType, @ExpenseAmount, @CreatorID)";

            using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ExpenseType", expensesType);
                        command.Parameters.AddWithValue("@ExpenseAmount", expensesAmount);
                        command.Parameters.AddWithValue("@CreatorID", employeeId);

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
