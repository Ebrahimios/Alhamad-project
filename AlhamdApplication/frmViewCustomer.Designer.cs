namespace AlhamdApplication
{
    partial class frmViewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewCustomer));
            this.dgvCustomerTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPayedMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRemainingMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.customerTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alhamdDBDataSet = new AlhamdApplication.AlhamdDBDataSet();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.pnlSales = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlRemainingMoney = new Guna.UI2.WinForms.Guna2Panel();
            this.imgRemainingMoney = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblRemainingMoneyValue = new System.Windows.Forms.Label();
            this.lblRemainingMoney = new System.Windows.Forms.Label();
            this.lblRecievedMoney = new System.Windows.Forms.Label();
            this.lblRecievedMoneyTitle = new System.Windows.Forms.Label();
            this.lblTotalSalesValue = new System.Windows.Forms.Label();
            this.pnlCurrentYearSales = new Guna.UI2.WinForms.Guna2Panel();
            this.imgCurrentYearSales = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.pnlTotalSales = new Guna.UI2.WinForms.Guna2Panel();
            this.imgTotalSales = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbTransactionSelector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCustomerEndDate = new System.Windows.Forms.Label();
            this.dtpCustomerEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblCustomerStartDate = new System.Windows.Forms.Label();
            this.dtpCustomerStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnGeneratePdf = new Guna.UI2.WinForms.Guna2Button();
            this.customerTransactionTableAdapter = new AlhamdApplication.AlhamdDBDataSetTableAdapters.CustomerTransactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alhamdDBDataSet)).BeginInit();
            this.pnlSales.SuspendLayout();
            this.pnlRemainingMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRemainingMoney)).BeginInit();
            this.pnlCurrentYearSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCurrentYearSales)).BeginInit();
            this.pnlTotalSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerTransactions
            // 
            this.dgvCustomerTransactions.AllowUserToAddRows = false;
            this.dgvCustomerTransactions.AllowUserToDeleteRows = false;
            this.dgvCustomerTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvCustomerTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomerTransactions.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCustomerTransactions.ColumnHeadersHeight = 35;
            this.dgvCustomerTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvDate,
            this.dgvTotalPrice,
            this.dgvPayedMoney,
            this.dgvRemainingMoney,
            this.dgvEmployeeName,
            this.dgvDelete});
            this.dgvCustomerTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCustomerTransactions.DataSource = this.customerTransactionBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerTransactions.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCustomerTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerTransactions.Location = new System.Drawing.Point(31, 355);
            this.dgvCustomerTransactions.Name = "dgvCustomerTransactions";
            this.dgvCustomerTransactions.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerTransactions.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCustomerTransactions.RowTemplate.Height = 35;
            this.dgvCustomerTransactions.Size = new System.Drawing.Size(778, 306);
            this.dgvCustomerTransactions.TabIndex = 37;
            this.dgvCustomerTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomerTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomerTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomerTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomerTransactions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCustomerTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomerTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomerTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomerTransactions.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvCustomerTransactions.ThemeStyle.ReadOnly = false;
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.Height = 35;
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomerTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerTransactions_CellContentClick);
            this.dgvCustomerTransactions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerTransactions_CellEndEdit);
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
            // dgvPayedMoney
            // 
            this.dgvPayedMoney.DataPropertyName = "PayedMoney";
            this.dgvPayedMoney.HeaderText = "المبلغ المدفوع";
            this.dgvPayedMoney.Name = "dgvPayedMoney";
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
            // customerTransactionBindingSource
            // 
            this.customerTransactionBindingSource.DataMember = "CustomerTransaction";
            this.customerTransactionBindingSource.DataSource = this.alhamdDBDataSet;
            // 
            // alhamdDBDataSet
            // 
            this.alhamdDBDataSet.DataSetName = "AlhamdDBDataSet";
            this.alhamdDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnSave.Location = new System.Drawing.Point(428, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 30;
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
            this.btnEdit.Location = new System.Drawing.Point(324, 244);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 36);
            this.btnEdit.TabIndex = 29;
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
            this.txtPhone.Location = new System.Drawing.Point(323, 166);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(268, 36);
            this.txtPhone.TabIndex = 26;
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
            this.txtName.Location = new System.Drawing.Point(31, 166);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(268, 36);
            this.txtName.TabIndex = 24;
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneTitle.Location = new System.Drawing.Point(318, 135);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(88, 28);
            this.lblPhoneTitle.TabIndex = 25;
            this.lblPhoneTitle.Text = "رقم الهاتف";
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTitle.Location = new System.Drawing.Point(26, 135);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(87, 28);
            this.lblNameTitle.TabIndex = 23;
            this.lblNameTitle.Text = "اسم العميل";
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
            this.txtNotes.Location = new System.Drawing.Point(31, 244);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(268, 36);
            this.txtNotes.TabIndex = 42;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(26, 213);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(71, 28);
            this.lblNotes.TabIndex = 41;
            this.lblNotes.Text = "ملاحظات";
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
            this.pnlSales.Location = new System.Drawing.Point(31, 18);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlSales.Size = new System.Drawing.Size(847, 100);
            this.pnlSales.TabIndex = 53;
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
            this.lblRecievedMoneyTitle.Size = new System.Drawing.Size(94, 25);
            this.lblRecievedMoneyTitle.TabIndex = 4;
            this.lblRecievedMoneyTitle.Text = "المبلغ المستلم";
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
            this.cbTransactionSelector.Location = new System.Drawing.Point(31, 304);
            this.cbTransactionSelector.Name = "cbTransactionSelector";
            this.cbTransactionSelector.Size = new System.Drawing.Size(140, 36);
            this.cbTransactionSelector.StartIndex = 0;
            this.cbTransactionSelector.TabIndex = 54;
            this.cbTransactionSelector.SelectedIndexChanged += new System.EventHandler(this.cbTransactionSelector_SelectedIndexChanged);
            // 
            // lblCustomerEndDate
            // 
            this.lblCustomerEndDate.AutoSize = true;
            this.lblCustomerEndDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.lblCustomerEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCustomerEndDate.Location = new System.Drawing.Point(464, 306);
            this.lblCustomerEndDate.Name = "lblCustomerEndDate";
            this.lblCustomerEndDate.Size = new System.Drawing.Size(33, 27);
            this.lblCustomerEndDate.TabIndex = 58;
            this.lblCustomerEndDate.Text = "الي";
            this.lblCustomerEndDate.Visible = false;
            // 
            // dtpCustomerEndDate
            // 
            this.dtpCustomerEndDate.BorderRadius = 5;
            this.dtpCustomerEndDate.Checked = true;
            this.dtpCustomerEndDate.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpCustomerEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCustomerEndDate.ForeColor = System.Drawing.Color.White;
            this.dtpCustomerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCustomerEndDate.Location = new System.Drawing.Point(503, 304);
            this.dtpCustomerEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCustomerEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCustomerEndDate.Name = "dtpCustomerEndDate";
            this.dtpCustomerEndDate.Size = new System.Drawing.Size(200, 36);
            this.dtpCustomerEndDate.TabIndex = 57;
            this.dtpCustomerEndDate.Value = new System.DateTime(2025, 12, 30, 8, 50, 0, 0);
            this.dtpCustomerEndDate.Visible = false;
            this.dtpCustomerEndDate.ValueChanged += new System.EventHandler(this.dtpCustomerEndDate_ValueChanged);
            // 
            // lblCustomerStartDate
            // 
            this.lblCustomerStartDate.AutoSize = true;
            this.lblCustomerStartDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.lblCustomerStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCustomerStartDate.Location = new System.Drawing.Point(218, 306);
            this.lblCustomerStartDate.Name = "lblCustomerStartDate";
            this.lblCustomerStartDate.Size = new System.Drawing.Size(30, 27);
            this.lblCustomerStartDate.TabIndex = 55;
            this.lblCustomerStartDate.Text = "من";
            this.lblCustomerStartDate.Visible = false;
            // 
            // dtpCustomerStartDate
            // 
            this.dtpCustomerStartDate.BorderRadius = 5;
            this.dtpCustomerStartDate.Checked = true;
            this.dtpCustomerStartDate.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpCustomerStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCustomerStartDate.ForeColor = System.Drawing.Color.White;
            this.dtpCustomerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCustomerStartDate.Location = new System.Drawing.Point(254, 304);
            this.dtpCustomerStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCustomerStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCustomerStartDate.Name = "dtpCustomerStartDate";
            this.dtpCustomerStartDate.Size = new System.Drawing.Size(200, 36);
            this.dtpCustomerStartDate.TabIndex = 56;
            this.dtpCustomerStartDate.Value = new System.DateTime(2025, 1, 1, 8, 50, 0, 0);
            this.dtpCustomerStartDate.Visible = false;
            this.dtpCustomerStartDate.ValueChanged += new System.EventHandler(this.dtpCustomerStartDate_ValueChanged);
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
            this.btnGeneratePdf.Location = new System.Drawing.Point(723, 304);
            this.btnGeneratePdf.Name = "btnGeneratePdf";
            this.btnGeneratePdf.Size = new System.Drawing.Size(86, 36);
            this.btnGeneratePdf.TabIndex = 59;
            this.btnGeneratePdf.Text = "طباعة";
            this.btnGeneratePdf.Click += new System.EventHandler(this.btnPdfMultiple_Click);
            // 
            // customerTransactionTableAdapter
            // 
            this.customerTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(923, 730);
            this.Controls.Add(this.btnGeneratePdf);
            this.Controls.Add(this.lblCustomerEndDate);
            this.Controls.Add(this.dtpCustomerEndDate);
            this.Controls.Add(this.lblCustomerStartDate);
            this.Controls.Add(this.dtpCustomerStartDate);
            this.Controls.Add(this.cbTransactionSelector);
            this.Controls.Add(this.pnlSales);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.dgvCustomerTransactions);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNameTitle);
            this.Controls.Add(this.lblPhoneTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العميل";
            this.Load += new System.EventHandler(this.frmViewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alhamdDBDataSet)).EndInit();
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlRemainingMoney.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgRemainingMoney)).EndInit();
            this.pnlCurrentYearSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCurrentYearSales)).EndInit();
            this.pnlTotalSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomerTransactions;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblPhoneTitle;
        private System.Windows.Forms.Label lblNameTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private Guna.UI2.WinForms.Guna2Panel pnlSales;
        private Guna.UI2.WinForms.Guna2Panel pnlRemainingMoney;
        private Guna.UI2.WinForms.Guna2PictureBox imgRemainingMoney;
        private System.Windows.Forms.Label lblRemainingMoneyValue;
        private System.Windows.Forms.Label lblRemainingMoney;
        private System.Windows.Forms.Label lblRecievedMoney;
        private System.Windows.Forms.Label lblRecievedMoneyTitle;
        private System.Windows.Forms.Label lblTotalSalesValue;
        private Guna.UI2.WinForms.Guna2Panel pnlCurrentYearSales;
        private Guna.UI2.WinForms.Guna2PictureBox imgCurrentYearSales;
        private System.Windows.Forms.Label lblTotalSales;
        private Guna.UI2.WinForms.Guna2Panel pnlTotalSales;
        private Guna.UI2.WinForms.Guna2PictureBox imgTotalSales;
        private Guna.UI2.WinForms.Guna2ComboBox cbTransactionSelector;
        private System.Windows.Forms.Label lblCustomerEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCustomerEndDate;
        private System.Windows.Forms.Label lblCustomerStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCustomerStartDate;
        private Guna.UI2.WinForms.Guna2Button btnGeneratePdf;
        private AlhamdDBDataSet alhamdDBDataSet;
        private System.Windows.Forms.BindingSource customerTransactionBindingSource;
        private AlhamdDBDataSetTableAdapters.CustomerTransactionTableAdapter customerTransactionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPayedMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRemainingMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmployeeName;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
    }
}