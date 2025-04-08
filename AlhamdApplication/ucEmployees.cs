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
    public partial class ucEmployees : UserControl
    {
        public ucEmployees()
        {
            InitializeComponent();
        }

        private void ucEmployees_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.alhamdDBDataSet.Employee);

            int newWidth = (int)(this.Width * 0.8);
            newWidth = Math.Max(newWidth, 100);
            dgvEmployee.Width = newWidth;

            txtSearchBar.Width = newWidth - btnAddEmployee.Width - 20;
            btnAddEmployee.Width = newWidth - txtSearchBar.Width;
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
                string employeeId = row.Cells["dgvId"].Value.ToString();

                if (dgvEmployee.Columns[e.ColumnIndex].Name == "dgvShow")
                {
                    frmViewEmployee viewCustomerForm = new frmViewEmployee(employeeId);
                    viewCustomerForm.ShowDialog();
                    this.employeeTableAdapter.Fill(this.alhamdDBDataSet.Employee);
                }
                else if (dgvEmployee.Columns[e.ColumnIndex].Name == "dgvDelete")
                {
                    DialogResult dialogResult = MessageBox.Show("هل انت متأكد من ازالة هذا الموظف?", "ازالة موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DeactivateEmployee(employeeId);
                        this.employeeTableAdapter.Fill(this.alhamdDBDataSet.Employee);
                    }
                }
            }
        }

        private void DeactivateEmployee(string employeeId)
        {
            if (int.TryParse(employeeId, out int employeeIdInt))
            {
                string updateQuery = "UPDATE Employee SET IsActive = 0 WHERE EmployeeID = @EmployeeID";
                using (SqlConnection connection = new SqlConnection(frmMain.connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@EmployeeID", employeeIdInt);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            this.employeeTableAdapter.FillBySearchWord(this.alhamdDBDataSet.Employee, $"%{txtSearchBar.Text}%");
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee addEmployeeForm = new frmAddEmployee();
            addEmployeeForm.ShowDialog();
            this.employeeTableAdapter.Fill(this.alhamdDBDataSet.Employee);
        }
    }
}
