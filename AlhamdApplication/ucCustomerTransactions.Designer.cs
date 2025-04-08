namespace AlhamdApplication
{
    partial class ucCustomerTransactions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCustomerEndDate = new System.Windows.Forms.Label();
            this.dtpCustomerEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblCustomerStartDate = new System.Windows.Forms.Label();
            this.dtpCustomerStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbTransactionSelector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvCustomerTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvTransactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPaidMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRemainingMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alhamdDBDataSet = new AlhamdApplication.AlhamdDBDataSet();
            this.txtTotalProfit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRemainingMoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerTransactionTableAdapter = new AlhamdApplication.AlhamdDBDataSetTableAdapters.CustomerTransactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alhamdDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerEndDate
            // 
            this.lblCustomerEndDate.AutoSize = true;
            this.lblCustomerEndDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.lblCustomerEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCustomerEndDate.Location = new System.Drawing.Point(474, 82);
            this.lblCustomerEndDate.Name = "lblCustomerEndDate";
            this.lblCustomerEndDate.Size = new System.Drawing.Size(33, 27);
            this.lblCustomerEndDate.TabIndex = 64;
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
            this.dtpCustomerEndDate.Location = new System.Drawing.Point(268, 80);
            this.dtpCustomerEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCustomerEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCustomerEndDate.Name = "dtpCustomerEndDate";
            this.dtpCustomerEndDate.Size = new System.Drawing.Size(200, 36);
            this.dtpCustomerEndDate.TabIndex = 63;
            this.dtpCustomerEndDate.Value = new System.DateTime(2025, 12, 30, 8, 50, 0, 0);
            this.dtpCustomerEndDate.Visible = false;
            this.dtpCustomerEndDate.ValueChanged += new System.EventHandler(this.dtpCustomerEndDate_ValueChanged);
            // 
            // lblCustomerStartDate
            // 
            this.lblCustomerStartDate.AutoSize = true;
            this.lblCustomerStartDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.lblCustomerStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCustomerStartDate.Location = new System.Drawing.Point(743, 82);
            this.lblCustomerStartDate.Name = "lblCustomerStartDate";
            this.lblCustomerStartDate.Size = new System.Drawing.Size(30, 27);
            this.lblCustomerStartDate.TabIndex = 61;
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
            this.dtpCustomerStartDate.Location = new System.Drawing.Point(537, 80);
            this.dtpCustomerStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCustomerStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCustomerStartDate.Name = "dtpCustomerStartDate";
            this.dtpCustomerStartDate.Size = new System.Drawing.Size(200, 36);
            this.dtpCustomerStartDate.TabIndex = 62;
            this.dtpCustomerStartDate.Value = new System.DateTime(2025, 1, 1, 8, 50, 0, 0);
            this.dtpCustomerStartDate.Visible = false;
            this.dtpCustomerStartDate.ValueChanged += new System.EventHandler(this.dtpCustomerStartDate_ValueChanged);
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
            this.cbTransactionSelector.Location = new System.Drawing.Point(836, 83);
            this.cbTransactionSelector.Name = "cbTransactionSelector";
            this.cbTransactionSelector.Size = new System.Drawing.Size(140, 36);
            this.cbTransactionSelector.StartIndex = 0;
            this.cbTransactionSelector.TabIndex = 60;
            this.cbTransactionSelector.SelectedIndexChanged += new System.EventHandler(this.cbTransactionSelector_SelectedIndexChanged);
            // 
            // dgvCustomerTransactions
            // 
            this.dgvCustomerTransactions.AllowUserToAddRows = false;
            this.dgvCustomerTransactions.AllowUserToDeleteRows = false;
            this.dgvCustomerTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCustomerTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerTransactions.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerTransactions.ColumnHeadersHeight = 35;
            this.dgvCustomerTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTransactionId,
            this.dgvCustomerName,
            this.dgvTotalPrice,
            this.dgvPaidMoney,
            this.dgvRemainingMoney,
            this.dgvEmployeeName,
            this.dgvDate});
            this.dgvCustomerTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCustomerTransactions.DataSource = this.customerTransactionBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerTransactions.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomerTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerTransactions.Location = new System.Drawing.Point(198, 134);
            this.dgvCustomerTransactions.Name = "dgvCustomerTransactions";
            this.dgvCustomerTransactions.ReadOnly = true;
            this.dgvCustomerTransactions.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerTransactions.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomerTransactions.RowTemplate.Height = 35;
            this.dgvCustomerTransactions.Size = new System.Drawing.Size(778, 342);
            this.dgvCustomerTransactions.TabIndex = 59;
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
            this.dgvCustomerTransactions.ThemeStyle.ReadOnly = true;
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.Height = 35;
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomerTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerTransactions_CellContentClick);
            // 
            // dgvTransactionId
            // 
            this.dgvTransactionId.DataPropertyName = "TransactionID";
            this.dgvTransactionId.HeaderText = "TransactionID";
            this.dgvTransactionId.Name = "dgvTransactionId";
            this.dgvTransactionId.ReadOnly = true;
            this.dgvTransactionId.Visible = false;
            // 
            // dgvCustomerName
            // 
            this.dgvCustomerName.DataPropertyName = "CustomerName";
            this.dgvCustomerName.HeaderText = "اسم العميل";
            this.dgvCustomerName.Name = "dgvCustomerName";
            this.dgvCustomerName.ReadOnly = true;
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
            this.dgvPaidMoney.ReadOnly = true;
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
            // dgvDate
            // 
            this.dgvDate.DataPropertyName = "TransactionDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = "dd/MM/yyyy";
            this.dgvDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDate.HeaderText = "التاريخ";
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
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
            // txtTotalProfit
            // 
            this.txtTotalProfit.BorderRadius = 10;
            this.txtTotalProfit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalProfit.DefaultText = "";
            this.txtTotalProfit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalProfit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalProfit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalProfit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalProfit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalProfit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProfit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalProfit.Location = new System.Drawing.Point(717, 29);
            this.txtTotalProfit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalProfit.Name = "txtTotalProfit";
            this.txtTotalProfit.PasswordChar = '\0';
            this.txtTotalProfit.PlaceholderText = "";
            this.txtTotalProfit.ReadOnly = true;
            this.txtTotalProfit.SelectedText = "";
            this.txtTotalProfit.Size = new System.Drawing.Size(257, 41);
            this.txtTotalProfit.TabIndex = 65;
            // 
            // txtRemainingMoney
            // 
            this.txtRemainingMoney.BorderRadius = 10;
            this.txtRemainingMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemainingMoney.DefaultText = "";
            this.txtRemainingMoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRemainingMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRemainingMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRemainingMoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRemainingMoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRemainingMoney.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainingMoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRemainingMoney.Location = new System.Drawing.Point(435, 29);
            this.txtRemainingMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemainingMoney.Name = "txtRemainingMoney";
            this.txtRemainingMoney.PasswordChar = '\0';
            this.txtRemainingMoney.PlaceholderText = "";
            this.txtRemainingMoney.ReadOnly = true;
            this.txtRemainingMoney.SelectedText = "";
            this.txtRemainingMoney.Size = new System.Drawing.Size(257, 41);
            this.txtRemainingMoney.TabIndex = 66;
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.ForeColor = System.Drawing.Color.Black;
            this.lblTotalProfit.Location = new System.Drawing.Point(875, 0);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(104, 25);
            this.lblTotalProfit.TabIndex = 67;
            this.lblTotalProfit.Text = "اجمالي المبيعات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(617, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "مبالغ متبقية";
            // 
            // customerTransactionTableAdapter
            // 
            this.customerTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // ucCustomerTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalProfit);
            this.Controls.Add(this.txtRemainingMoney);
            this.Controls.Add(this.txtTotalProfit);
            this.Controls.Add(this.lblCustomerEndDate);
            this.Controls.Add(this.dtpCustomerEndDate);
            this.Controls.Add(this.lblCustomerStartDate);
            this.Controls.Add(this.dtpCustomerStartDate);
            this.Controls.Add(this.cbTransactionSelector);
            this.Controls.Add(this.dgvCustomerTransactions);
            this.Name = "ucCustomerTransactions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(987, 680);
            this.Load += new System.EventHandler(this.ucCustomerTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alhamdDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCustomerEndDate;
        private System.Windows.Forms.Label lblCustomerStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCustomerStartDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbTransactionSelector;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomerTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmployeeId;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalProfit;
        private Guna.UI2.WinForms.Guna2TextBox txtRemainingMoney;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource customerTransactionBindingSource;
        private AlhamdDBDataSet alhamdDBDataSet;
        private AlhamdDBDataSetTableAdapters.CustomerTransactionTableAdapter customerTransactionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransactionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPaidMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRemainingMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
    }
}
