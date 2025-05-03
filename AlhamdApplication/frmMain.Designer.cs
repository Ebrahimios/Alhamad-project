namespace AlhamdApplication
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.langbtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnExpenses = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.imgProfileImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.imgLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPanel
            // 
            this.pnlPanel.Controls.Add(this.langbtn);
            this.pnlPanel.Controls.Add(this.btnExpenses);
            this.pnlPanel.Controls.Add(this.lblEmployeeName);
            this.pnlPanel.Controls.Add(this.imgProfileImage);
            this.pnlPanel.Controls.Add(this.btnDashboard);
            this.pnlPanel.Controls.Add(this.btnEmployee);
            this.pnlPanel.Controls.Add(this.btnSupplier);
            this.pnlPanel.Controls.Add(this.btnProduct);
            this.pnlPanel.Controls.Add(this.btnCustomer);
            this.pnlPanel.Controls.Add(this.imgLogo);
            this.pnlPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.pnlPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(237, 759);
            this.pnlPanel.TabIndex = 2;
            // 
            // langbtn
            // 
            this.langbtn.BackColor = System.Drawing.Color.Transparent;
            this.langbtn.BorderRadius = 10;
            this.langbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.langbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.langbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.langbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.langbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.langbtn.FillColor = System.Drawing.Color.Transparent;
            this.langbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langbtn.ForeColor = System.Drawing.Color.White;
            this.langbtn.Image = global::AlhamdApplication.Properties.Resources.lang;
            this.langbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.langbtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.langbtn.Location = new System.Drawing.Point(0, 555);
            this.langbtn.Name = "langbtn";
            this.langbtn.Size = new System.Drawing.Size(231, 45);
            this.langbtn.TabIndex = 9;
            this.langbtn.Tag = "lang";
            this.langbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.langbtn.TextOffset = new System.Drawing.Point(-5, 0);
            this.langbtn.Click += new System.EventHandler(this.lang_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackColor = System.Drawing.Color.Transparent;
            this.btnExpenses.BorderRadius = 10;
            this.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpenses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExpenses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExpenses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExpenses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExpenses.FillColor = System.Drawing.Color.Transparent;
            this.btnExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.ForeColor = System.Drawing.Color.White;
            this.btnExpenses.Image = global::AlhamdApplication.Properties.Resources.spending;
            this.btnExpenses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExpenses.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnExpenses.Location = new System.Drawing.Point(0, 460);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(231, 45);
            this.btnExpenses.TabIndex = 8;
            this.btnExpenses.Tag = "expenses";
            this.btnExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExpenses.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmployeeName.Location = new System.Drawing.Point(3, 621);
            this.lblEmployeeName.MaximumSize = new System.Drawing.Size(165, 31);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(165, 31);
            this.lblEmployeeName.TabIndex = 5;
            this.lblEmployeeName.Tag = "employeeName";
            this.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmployeeName.Click += new System.EventHandler(this.lblEmployeeName_Click);
            // 
            // imgProfileImage
            // 
            this.imgProfileImage.BackColor = System.Drawing.Color.Transparent;
            this.imgProfileImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgProfileImage.Image = global::AlhamdApplication.Properties.Resources.cropped_image;
            this.imgProfileImage.ImageRotate = 0F;
            this.imgProfileImage.Location = new System.Drawing.Point(174, 606);
            this.imgProfileImage.Name = "imgProfileImage";
            this.imgProfileImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgProfileImage.Size = new System.Drawing.Size(47, 58);
            this.imgProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfileImage.TabIndex = 7;
            this.imgProfileImage.TabStop = false;
            this.imgProfileImage.UseTransparentBackground = true;
            this.imgProfileImage.Click += new System.EventHandler(this.imgProfileImage_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderRadius = 10;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::AlhamdApplication.Properties.Resources.dashboard_white;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDashboard.Location = new System.Drawing.Point(0, 511);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(231, 45);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Tag = "dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.BorderRadius = 10;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = global::AlhamdApplication.Properties.Resources.employee_white;
            this.btnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnEmployee.Location = new System.Drawing.Point(0, 409);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(231, 45);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Tag = "employee";
            this.btnEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnSupplier.BorderRadius = 10;
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupplier.FillColor = System.Drawing.Color.Transparent;
            this.btnSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Image = global::AlhamdApplication.Properties.Resources.supplier_white;
            this.btnSupplier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSupplier.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnSupplier.Location = new System.Drawing.Point(0, 358);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(231, 45);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Tag = "suppliers";
            this.btnSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSupplier.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.BorderRadius = 10;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::AlhamdApplication.Properties.Resources.box_white;
            this.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnProduct.Location = new System.Drawing.Point(0, 307);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(231, 45);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Tag = "products";
            this.btnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BorderRadius = 10;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::AlhamdApplication.Properties.Resources.customer_white;
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCustomer.Location = new System.Drawing.Point(0, 256);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(231, 45);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Tag = "customers";
            this.btnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = global::AlhamdApplication.Properties.Resources.brand_logo_white;
            this.imgLogo.ImageRotate = 0F;
            this.imgLogo.Location = new System.Drawing.Point(38, 37);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(166, 200);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(240, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelContainer.Size = new System.Drawing.Size(1130, 727);
            this.panelContainer.TabIndex = 3;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1370, 727);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.pnlPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlPanel;
        private System.Windows.Forms.Label lblEmployeeName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgProfileImage;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnSupplier;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2PictureBox imgLogo;
        private Guna.UI2.WinForms.Guna2Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btnExpenses;
        private Guna.UI2.WinForms.Guna2Button langbtn;
    }
}

