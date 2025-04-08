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
    public partial class ucExpenses : UserControl
    {
        public ucExpenses()
        {
            InitializeComponent();
        }

        private void ucExpenses_Load(object sender, EventArgs e)
        {
            this.expensesTableAdapter.Fill(this.alhamdDBDataSet.Expenses);

            int newWidth = (int)(this.Width * 0.8);
            newWidth = Math.Max(newWidth, 100);
            dgvExpenses.Width = newWidth;
        }

        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvExpenses.Rows[e.RowIndex];
                string expensesId = row.Cells["dgvId"].Value.ToString();

                if (dgvExpenses.Columns[e.ColumnIndex].Name == "dgvDelete")
                {
                    DialogResult dialogResult = MessageBox.Show("هل انت متأكد من ازالة هذه المصاريف?", "ازالة المصاريف", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DeleteExpenses(expensesId);
                        this.expensesTableAdapter.Fill(this.alhamdDBDataSet.Expenses);
                    }
                }
            }
        }

        private void DeleteExpenses(string expensesId)
        {
            if (int.TryParse(expensesId, out int expensesIdInt))
            {
                string deleteQuery = "DELETE FROM Expenses WHERE ExpenseID = @ExpenseID";
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(deleteQuery, connection);
                        command.Parameters.AddWithValue("@ExpenseID", expensesIdInt);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnAddExpenses_Click(object sender, EventArgs e)
        {
            frmAddExpenses addExpensesForm = new frmAddExpenses();
            addExpensesForm.ShowDialog();
            this.expensesTableAdapter.Fill(this.alhamdDBDataSet.Expenses);
        }

        private void dgvExpenses_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvExpenses.Rows[e.RowIndex];
                string expensesId = row.Cells["dgvId"].Value.ToString();
                //string columnName = dgvExpenses.Columns[e.ColumnIndex].Name;
                decimal newValue = Convert.ToDecimal(row.Cells[e.ColumnIndex].Value);

                if (string.IsNullOrEmpty(newValue.ToString()) || newValue < 1) return;

                if (dgvExpenses.Columns[e.ColumnIndex].Name == "dgvPrice") // Replace with the actual column name for ExpensesValue
                {
                    UpdateExpenses(expensesId, newValue);
                }
            }
        }

        private void UpdateExpenses(string expensesId, decimal newValue)
        {
            if (int.TryParse(expensesId, out int expensesIdInt))
            {
                string updateQuery = $"UPDATE Expenses SET ExpenseAmount = @NewValue WHERE ExpenseID = @ExpenseID";
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@NewValue", newValue);
                        command.Parameters.AddWithValue("@ExpenseID", expensesIdInt);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
    }
}
