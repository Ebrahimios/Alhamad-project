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
    public partial class frmAddExpenses : Form
    {
        private string SupplierName => txtExpensesType.Text.Trim();
        private decimal ExpensesValue => txtExpenses.Value;

        public frmAddExpenses()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Validation.IsValidName(txtExpensesType.Text))
            {
                MessageBox.Show("يجب ادخال اسم المصاريف بشكل صحيح", "اسم غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtExpenses.Value < 1)
            {
                MessageBox.Show("يجب ادخال قيمة المصاريف بشكل صحيح", "قيم غير صالحة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
