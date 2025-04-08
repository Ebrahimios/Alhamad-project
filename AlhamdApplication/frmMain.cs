using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Configuration;

namespace AlhamdApplication
{
    public partial class frmMain : Form
    {
        // Employee Data
        public static int LoggedInEmployeeID;
        public static bool IsEmployeeAdmin;
        public static string EmployeeName;

        // Other Date// frmMain.connectionString
        public static int UserControlWidth;
        public static int UserControlHeight;

        // Static Connection String
        public static string connectionString = ConfigurationManager.ConnectionStrings["AlhamdApplication.Properties.Settings.AlhamdDBConnectionString"].ConnectionString;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlPanel.Height = 4000;

            frmLogin frmLogin = new frmLogin();

            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
                return;
            }

            panelContainer.Height = this.Height;
            panelContainer.Width = this.Width - pnlPanel.Width;

            lblEmployeeName.Text = frmMain.EmployeeName;

            DefaultContent();
        }

        private void LoadScreen(UserControl screen)
        {
            panelContainer.Controls.Clear();

            screen.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(screen);
        }

        private void DefaultContent()
        {
            btnExpenses.FillColor = Color.Transparent;
            btnCustomer.FillColor = Color.FromArgb(50, 50, 255, 250);
            btnSupplier.FillColor = Color.Transparent;
            btnEmployee.FillColor = Color.Transparent;
            btnProduct.FillColor = Color.Transparent;
            btnDashboard.FillColor = Color.Transparent;
            LoadScreen(new ucCustomers());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            btnExpenses.FillColor = Color.Transparent;
            btnCustomer.FillColor = Color.FromArgb(50, 50, 255, 250);
            btnSupplier.FillColor = Color.Transparent;
            btnEmployee.FillColor = Color.Transparent;
            btnProduct.FillColor = Color.Transparent;
            btnDashboard.FillColor = Color.Transparent;
            LoadScreen(new ucCustomers());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            btnExpenses.FillColor = Color.Transparent;
            btnCustomer.FillColor = Color.Transparent;
            btnSupplier.FillColor = Color.Transparent;
            btnEmployee.FillColor = Color.Transparent;
            btnProduct.FillColor = Color.FromArgb(100, 100, 255, 250);
            btnDashboard.FillColor = Color.Transparent;
            LoadScreen(new ucProducts());
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            btnExpenses.FillColor = Color.Transparent;
            btnCustomer.FillColor = Color.Transparent;
            btnSupplier.FillColor = Color.FromArgb(100, 100, 255, 250);
            btnEmployee.FillColor = Color.Transparent;
            btnProduct.FillColor = Color.Transparent;
            btnDashboard.FillColor = Color.Transparent;
            LoadScreen(new ucSuppliers());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (!IsEmployeeAdmin)
            {
                MessageBox.Show("لا يمكنك الاطلاع علي هذة الصفحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            btnExpenses.FillColor = Color.Transparent;
            btnCustomer.FillColor = Color.Transparent;
            btnSupplier.FillColor = Color.Transparent;
            btnEmployee.FillColor = Color.FromArgb(100, 100, 255, 250);
            btnProduct.FillColor = Color.Transparent;
            btnDashboard.FillColor = Color.Transparent;
            LoadScreen(new ucEmployees());
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            btnCustomer.FillColor = Color.Transparent;
            btnSupplier.FillColor = Color.Transparent;
            btnEmployee.FillColor = Color.Transparent;
            btnProduct.FillColor = Color.Transparent;
            btnDashboard.FillColor = Color.Transparent;
            btnExpenses.FillColor = Color.FromArgb(100, 100, 255, 250);
            LoadScreen(new ucExpenses());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (!IsEmployeeAdmin)
            {
                MessageBox.Show("لا يمكنك الاطلاع علي هذة الصفحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            btnExpenses.FillColor = Color.Transparent;
            btnCustomer.FillColor = Color.Transparent;
            btnSupplier.FillColor = Color.Transparent;
            btnEmployee.FillColor = Color.Transparent;
            btnProduct.FillColor = Color.Transparent;
            btnDashboard.FillColor = Color.FromArgb(100, 100, 255, 250);
            LoadScreen(new ucDashboard());
        }

        private void lblEmployeeName_Click(object sender, EventArgs e)
        {
            //frmViewEmployee viewEmployeeForm = new frmViewEmployee(LoggedInEmployeeID.ToString());
            //viewEmployeeForm.ShowDialog();
            //frmLogin.GetEmployeeIDAndRole(frmLogin.EmployeePhone);
            //lblEmployeeName.Text = EmployeeName;

            //if (btnEmployee.FillColor == Color.FromArgb(100, 100, 255, 250))
            //{
            //    btnEmployee_Click(null, EventArgs.Empty);
            //}
        }

        private void imgProfileImage_Click(object sender, EventArgs e)
        {
            //frmViewEmployee viewEmployeeForm = new frmViewEmployee(LoggedInEmployeeID.ToString());
            //viewEmployeeForm.ShowDialog();
            //frmLogin.GetEmployeeIDAndRole(frmLogin.EmployeePhone);
            //lblEmployeeName.Text = EmployeeName;

            //if (btnEmployee.FillColor == Color.FromArgb(100, 100, 255, 250))
            //{
            //    btnEmployee_Click(null, EventArgs.Empty);
            //}
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
