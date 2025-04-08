namespace AlhamdApplication
{
    partial class frmViewSupplier
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewSupplier));
            this.imgTotalSales = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblRemainingMoneyValue = new System.Windows.Forms.Label();
            this.lblRemainingMoney = new System.Windows.Forms.Label();
            this.lblRecievedMoney = new System.Windows.Forms.Label();
            this.lblRecievedMoneyTitle = new System.Windows.Forms.Label();
            this.lblTotalSalesValue = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.pnlRemainingMoney = new Guna.UI2.WinForms.Guna2Panel();
            this.imgRemainingMoney = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnGeneratePdf = new Guna.UI2.WinForms.Guna2Button();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbTransactionSelector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlCurrentYearSales = new Guna.UI2.WinForms.Guna2Panel();
            this.imgCurrentYearSales = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dgvTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPaidMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRemainingMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.supplierTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alhamdDBDataSet = new AlhamdApplication.AlhamdDBDataSet();
            this.pnlSales = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.pnlTotalSales = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.supplierTransactionTableAdapter = new AlhamdApplication.AlhamdDBDataSetTableAdapters.SupplierTransactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalSales)).BeginInit();
            this.pnlRemainingMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRemainingMoney)).BeginInit();
            this.pnlCurrentYearSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCurrentYearSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alhamdDBDataSet)).BeginInit();
            this.pnlSales.SuspendLayout();
            this.pnlTotalSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgTotalSales
            // 
            this.imgTotalSales.Image = global::AlhamdApplication.Properties.Resources.income_green;
            this.imgTotalSales.ImageRotate = 0F;
            this.imgTotalSales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgTotalSales.Location = new System.Drawing.Point(9, 10);
            this.imgTotalSales.Name = "imgTotalSales";
            this.imgTotalSales.Size = new System.Drawing.Size(56, 55);
            this.imgTotalSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTotalSales.TabIndex = 0;
            this.imgTotalSales.TabStop = false;
            // 
            // lblRemainingMoneyValue
            // 
            this.lblRemainingMoneyValue.AutoSize = true;
            this.lblRemainingMoneyValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRemainingMoneyValue.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.lblRemainingMoneyValue.ForeColor = System.Drawing.Color.Black;
            this.lblRemainingMoneyValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRemainingMoneyValue.Location = new System.Drawing.Point(69, 47);
            this.lblRemainingMoneyValue.Name = "lblRemainingMoneyValue";
            this.lblRemainingMoneyValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRemainingMoneyValue.Size = new System.Drawing.Size(134, 31);
            this.lblRemainingMoneyValue.TabIndex = 11;
            this.lblRemainingMoneyValue.Text = "5000000000";
            // 
            // lblRemainingMoney
            // 
            this.lblRemainingMoney.AutoSize = true;
            this.lblRemainingMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblRemainingMoney.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.lblRemainingMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblRemainingMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRemainingMoney.Location = new System.Drawing.Point(118, 21);
            this.lblRemainingMoney.Name = "lblRemainingMoney";
            this.lblRemainingMoney.Size = new System.Drawing.Size(80, 25);
            this.lblRemainingMoney.TabIndex = 10;
            this.lblRemainingMoney.Text = "مبالغ متبقية";
            // 
            // lblRecievedMoney
            // 
            this.lblRecievedMoney.AutoSize = true;
            this.lblRecievedMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblRecievedMoney.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.lblRecievedMoney.ForeColor = System.Drawing.Color.Black;
            this.lblRecievedMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRecievedMoney.Location = new System.Drawing.Point(332, 47);
            this.lblRecievedMoney.Name = "lblRecievedMoney";
            this.lblRecievedMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRecievedMoney.Size = new System.Drawing.Size(134, 31);
            this.lblRecievedMoney.TabIndex = 5;
            this.lblRecievedMoney.Text = "5000000000";
            // 
            // lblRecievedMoneyTitle
            // 
            this.lblRecievedMoneyTitle.AutoSize = true;
            this.lblRecievedMoneyTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRecievedMoneyTitle.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.lblRecievedMoneyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblRecievedMoneyTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRecievedMoneyTitle.Location = new System.Drawing.Point(370, 21);
            this.lblRecievedMoneyTitle.Name = "lblRecievedMoneyTitle";
            this.lblRecievedMoneyTitle.Size = new System.Drawing.Size(93, 25);
            this.lblRecievedMoneyTitle.TabIndex = 4;
            this.lblRecievedMoneyTitle.Text = "المبلغ المدفوع";
            // 
            // lblTotalSalesValue
            // 
            this.lblTotalSalesValue.AutoSize = true;
            this.lblTotalSalesValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSalesValue.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.lblTotalSalesValue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSalesValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalSalesValue.Location = new System.Drawing.Point(606, 47);
            this.lblTotalSalesValue.Name = "lblTotalSalesValue";
            this.lblTotalSalesValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalSalesValue.Size = new System.Drawing.Size(134, 31);
            this.lblTotalSalesValue.TabIndex = 2;
            this.lblTotalSalesValue.Text = "5000000000";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.lblEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEndDate.Location = new System.Drawing.Point(473, 310);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(33, 27);
            this.lblEndDate.TabIndex = 74;
            this.lblEndDate.Text = "الي";
            this.lblEndDate.Visible = false;
            // 
            // pnlRemainingMoney
            // 
            this.pnlRemainingMoney.BackColor = System.Drawing.Color.Transparent;
            this.pnlRemainingMoney.BorderRadius = 35;
            this.pnlRemainingMoney.Controls.Add(this.imgRemainingMoney);
            this.pnlRemainingMoney.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlRemainingMoney.Location = new System.Drawing.Point(206, 13);
            this.pnlRemainingMoney.Name = "pnlRemainingMoney";
            this.pnlRemainingMoney.Size = new System.Drawing.Size(75, 75);
            this.pnlRemainingMoney.TabIndex = 9;
            // 
            // imgRemainingMoney
            // 
            this.imgRemainingMoney.Image = global::AlhamdApplication.Properties.Resources.income_red;
            this.imgRemainingMoney.ImageRotate = 0F;
            this.imgRemainingMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgRemainingMoney.Location = new System.Drawing.Point(9, 10);
            this.imgRemainingMoney.Name = "imgRemainingMoney";
            this.imgRemainingMoney.Size = new System.Drawing.Size(56, 55);
            this.imgRemainingMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRemainingMoney.TabIndex = 0;
            this.imgRemainingMoney.TabStop = false;
            // 
            // btnGeneratePdf
            // 
            this.btnGeneratePdf.BorderRadius = 10;
            this.btnGeneratePdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePdf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePdf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePdf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeneratePdf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeneratePdf.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnGeneratePdf.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePdf.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePdf.Location = new System.Drawing.Point(732, 308);
            this.btnGeneratePdf.Name = "btnGeneratePdf";
            this.btnGeneratePdf.Size = new System.Drawing.Size(86, 36);
            this.btnGeneratePdf.TabIndex = 75;
            this.btnGeneratePdf.Text = "طباعة";
            this.btnGeneratePdf.Click += new System.EventHandler(this.btnGeneratePdf_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BorderRadius = 5;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.ForeColor = System.Drawing.Color.White;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(512, 308);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 36);
            this.dtpEndDate.TabIndex = 73;
            this.dtpEndDate.Value = new System.DateTime(2025, 12, 30, 8, 50, 0, 0);
            this.dtpEndDate.Visible = false;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.lblStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStartDate.Location = new System.Drawing.Point(227, 310);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(30, 27);
            this.lblStartDate.TabIndex = 71;
            this.lblStartDate.Text = "من";
            this.lblStartDate.Visible = false;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderRadius = 5;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.ForeColor = System.Drawing.Color.White;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(263, 308);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 36);
            this.dtpStartDate.TabIndex = 72;
            this.dtpStartDate.Value = new System.DateTime(2025, 1, 1, 8, 50, 0, 0);
            this.dtpStartDate.Visible = false;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // cbTransactionSelector
            // 
            this.cbTransactionSelector.BackColor = System.Drawing.Color.Transparent;
            this.cbTransactionSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTransactionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransactionSelector.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTransactionSelector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTransactionSelector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTransactionSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTransactionSelector.ItemHeight = 30;
            this.cbTransactionSelector.Items.AddRange(new object[] {
            "الكل",
            "مبالغ متبقية",
            "تاريخ محدد"});
            this.cbTransactionSelector.Location = new System.Drawing.Point(40, 308);
            this.cbTransactionSelector.Name = "cbTransactionSelector";
            this.cbTransactionSelector.Size = new System.Drawing.Size(140, 36);
            this.cbTransactionSelector.StartIndex = 0;
            this.cbTransactionSelector.TabIndex = 70;
            this.cbTransactionSelector.SelectedIndexChanged += new System.EventHandler(this.cbTransactionSelector_SelectedIndexChanged);
            // 
            // pnlCurrentYearSales
            // 
            this.pnlCurrentYearSales.BackColor = System.Drawing.Color.Transparent;
            this.pnlCurrentYearSales.BorderRadius = 35;
            this.pnlCurrentYearSales.Controls.Add(this.imgCurrentYearSales);
            this.pnlCurrentYearSales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.pnlCurrentYearSales.Location = new System.Drawing.Point(472, 13);
            this.pnlCurrentYearSales.Name = "pnlCurrentYearSales";
            this.pnlCurrentYearSales.Size = new System.Drawing.Size(75, 75);
            this.pnlCurrentYearSales.TabIndex = 3;
            // 
            // imgCurrentYearSales
            // 
            this.imgCurrentYearSales.Image = global::AlhamdApplication.Properties.Resources.income_green;
            this.imgCurrentYearSales.ImageRotate = 0F;
            this.imgCurrentYearSales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgCurrentYearSales.Location = new System.Drawing.Point(9, 10);
            this.imgCurrentYearSales.Name = "imgCurrentYearSales";
            this.imgCurrentYearSales.Size = new System.Drawing.Size(56, 55);
            this.imgCurrentYearSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCurrentYearSales.TabIndex = 0;
            this.imgCurrentYearSales.TabStop = false;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTransactions.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTransactions.ColumnHeadersHeight = 35;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvDate,
            this.dgvTotalPrice,
            this.dgvPaidMoney,
            this.dgvRemainingMoney,
            this.dgvEmployeeName,
            this.dgvDelete});
            this.dgvTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTransactions.DataSource = this.supplierTransactionBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.Location = new System.Drawing.Point(40, 359);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransactions.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTransactions.RowTemplate.Height = 35;
            this.dgvTransactions.Size = new System.Drawing.Size(778, 306);
            this.dgvTransactions.TabIndex = 66;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransactions.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvTransactions.ThemeStyle.ReadOnly = false;
            this.dgvTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.Height = 35;
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellContentClick);
            this.dgvTransactions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellEndEdit);
            // 
            // dgvId
            // 
            this.dgvId.DataPropertyName = "TransactionID";
            this.dgvId.HeaderText = "TransactionID";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Visible = false;
            // 
            // dgvDate
            // 
            this.dgvDate.DataPropertyName = "TransactionDate";
            this.dgvDate.HeaderText = "التاريخ";
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
            // 
            // dgvTotalPrice
            // 
            this.dgvTotalPrice.DataPropertyName = "TotalPrice";
            this.dgvTotalPrice.HeaderText = "السعر الكلي";
            this.dgvTotalPrice.Name = "dgvTotalPrice";
            this.dgvTotalPrice.ReadOnly = true;
            // 
            // dgvPaidMoney
            // 
            this.dgvPaidMoney.DataPropertyName = "PayedMoney";
            this.dgvPaidMoney.HeaderText = "المبلغ المدفوع";
            this.dgvPaidMoney.Name = "dgvPaidMoney";
            // 
            // dgvRemainingMoney
            // 
            this.dgvRemainingMoney.DataPropertyName = "RemainingMoney";
            this.dgvRemainingMoney.HeaderText = "المبلغ المتبقي";
            this.dgvRemainingMoney.Name = "dgvRemainingMoney";
            this.dgvRemainingMoney.ReadOnly = true;
            // 
            // dgvEmployeeName
            // 
            this.dgvEmployeeName.DataPropertyName = "EmployeeName";
            this.dgvEmployeeName.HeaderText = "اسم الموظف";
            this.dgvEmployeeName.Name = "dgvEmployeeName";
            this.dgvEmployeeName.ReadOnly = true;
            // 
            // dgvDelete
            // 
            this.dgvDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            this.dgvDelete.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDelete.HeaderText = "إرجاع";
            this.dgvDelete.Image = global::AlhamdApplication.Properties.Resources.delete;
            this.dgvDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvDelete.Width = 60;
            // 
            // supplierTransactionBindingSource
            // 
            this.supplierTransactionBindingSource.DataMember = "SupplierTransaction";
            this.supplierTransactionBindingSource.DataSource = this.alhamdDBDataSet;
            // 
            // alhamdDBDataSet
            // 
            this.alhamdDBDataSet.DataSetName = "AlhamdDBDataSet";
            this.alhamdDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlSales
            // 
            this.pnlSales.BorderRadius = 20;
            this.pnlSales.Controls.Add(this.pnlRemainingMoney);
            this.pnlSales.Controls.Add(this.lblRemainingMoneyValue);
            this.pnlSales.Controls.Add(this.lblRemainingMoney);
            this.pnlSales.Controls.Add(this.lblRecievedMoney);
            this.pnlSales.Controls.Add(this.lblRecievedMoneyTitle);
            this.pnlSales.Controls.Add(this.lblTotalSalesValue);
            this.pnlSales.Controls.Add(this.pnlCurrentYearSales);
            this.pnlSales.Controls.Add(this.lblTotalSales);
            this.pnlSales.Controls.Add(this.pnlTotalSales);
            this.pnlSales.FillColor = System.Drawing.Color.White;
            this.pnlSales.Location = new System.Drawing.Point(40, 22);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlSales.Size = new System.Drawing.Size(847, 100);
            this.pnlSales.TabIndex = 69;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSales.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.lblTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblTotalSales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalSales.Location = new System.Drawing.Point(635, 21);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(102, 25);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "قيمة المشتريات";
            // 
            // pnlTotalSales
            // 
            this.pnlTotalSales.BackColor = System.Drawing.Color.Transparent;
            this.pnlTotalSales.BorderRadius = 35;
            this.pnlTotalSales.Controls.Add(this.imgTotalSales);
            this.pnlTotalSales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.pnlTotalSales.Location = new System.Drawing.Point(743, 13);
            this.pnlTotalSales.Name = "pnlTotalSales";
            this.pnlTotalSales.Size = new System.Drawing.Size(75, 75);
            this.pnlTotalSales.TabIndex = 0;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNotes.BorderRadius = 10;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(40, 248);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(268, 36);
            this.txtNotes.TabIndex = 68;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(35, 217);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(71, 28);
            this.lblNotes.TabIndex = 67;
            this.lblNotes.Text = "ملاحظات";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(79)))));
            this.btnSave.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(437, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(333, 248);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 36);
            this.btnEdit.TabIndex = 64;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtPhone.BorderRadius = 10;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(332, 170);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(268, 36);
            this.txtPhone.TabIndex = 63;
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtName.BorderRadius = 10;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(40, 170);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(268, 36);
            this.txtName.TabIndex = 61;
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTitle.Location = new System.Drawing.Point(35, 139);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(83, 28);
            this.lblNameTitle.TabIndex = 60;
            this.lblNameTitle.Text = "اسم المورد";
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneTitle.Location = new System.Drawing.Point(327, 139);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(88, 28);
            this.lblPhoneTitle.TabIndex = 62;
            this.lblPhoneTitle.Text = "رقم الهاتف";
            // 
            // supplierTransactionTableAdapter
            // 
            this.supplierTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(923, 730);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.btnGeneratePdf);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cbTransactionSelector);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.pnlSales);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNameTitle);
            this.Controls.Add(this.lblPhoneTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewSupplier";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.Text = "المورد";
            this.Load += new System.EventHandler(this.frmViewSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalSales)).EndInit();
            this.pnlRemainingMoney.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgRemainingMoney)).EndInit();
            this.pnlCurrentYearSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCurrentYearSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alhamdDBDataSet)).EndInit();
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlTotalSales.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox imgTotalSales;
        private System.Windows.Forms.Label lblRemainingMoneyValue;
        private System.Windows.Forms.Label lblRemainingMoney;
        private System.Windows.Forms.Label lblRecievedMoney;
        private System.Windows.Forms.Label lblRecievedMoneyTitle;
        private System.Windows.Forms.Label lblTotalSalesValue;
        private System.Windows.Forms.Label lblEndDate;
        private Guna.UI2.WinForms.Guna2Panel pnlRemainingMoney;
        private Guna.UI2.WinForms.Guna2PictureBox imgRemainingMoney;
        private Guna.UI2.WinForms.Guna2Button btnGeneratePdf;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbTransactionSelector;
        private Guna.UI2.WinForms.Guna2Panel pnlCurrentYearSales;
        private Guna.UI2.WinForms.Guna2PictureBox imgCurrentYearSales;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTransactions;
        private Guna.UI2.WinForms.Guna2Panel pnlSales;
        private System.Windows.Forms.Label lblTotalSales;
        private Guna.UI2.WinForms.Guna2Panel pnlTotalSales;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblPhoneTitle;
        private AlhamdDBDataSet alhamdDBDataSet;
        private System.Windows.Forms.BindingSource supplierTransactionBindingSource;
        private AlhamdDBDataSetTableAdapters.SupplierTransactionTableAdapter supplierTransactionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPaidMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRemainingMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmployeeName;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
    }
}