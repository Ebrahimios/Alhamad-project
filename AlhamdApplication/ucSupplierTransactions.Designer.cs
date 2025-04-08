namespace AlhamdApplication
{
    partial class ucSupplierTransactions
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.txtRemainingMoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalProfit = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpSupplierEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpSupplierStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbTransactionSelector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvSupplierTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPayedMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRemainingMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alhamdDBDataSet = new AlhamdApplication.AlhamdDBDataSet();
            this.supplierTransactionTableAdapter = new AlhamdApplication.AlhamdDBDataSetTableAdapters.SupplierTransactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alhamdDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(627, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "مبالغ متبقية";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.ForeColor = System.Drawing.Color.Black;
            this.lblTotalProfit.Location = new System.Drawing.Point(885, 13);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(104, 25);
            this.lblTotalProfit.TabIndex = 77;
            this.lblTotalProfit.Text = "اجمالي المبيعات";
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
            this.txtRemainingMoney.Location = new System.Drawing.Point(445, 42);
            this.txtRemainingMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemainingMoney.Name = "txtRemainingMoney";
            this.txtRemainingMoney.PasswordChar = '\0';
            this.txtRemainingMoney.PlaceholderText = "";
            this.txtRemainingMoney.ReadOnly = true;
            this.txtRemainingMoney.SelectedText = "";
            this.txtRemainingMoney.Size = new System.Drawing.Size(257, 41);
            this.txtRemainingMoney.TabIndex = 76;
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
            this.txtTotalProfit.Location = new System.Drawing.Point(727, 42);
            this.txtTotalProfit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalProfit.Name = "txtTotalProfit";
            this.txtTotalProfit.PasswordChar = '\0';
            this.txtTotalProfit.PlaceholderText = "";
            this.txtTotalProfit.ReadOnly = true;
            this.txtTotalProfit.SelectedText = "";
            this.txtTotalProfit.Size = new System.Drawing.Size(257, 41);
            this.txtTotalProfit.TabIndex = 75;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.lblEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEndDate.Location = new System.Drawing.Point(484, 95);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(33, 27);
            this.lblEndDate.TabIndex = 74;
            this.lblEndDate.Text = "الي";
            this.lblEndDate.Visible = false;
            // 
            // dtpSupplierEndDate
            // 
            this.dtpSupplierEndDate.BorderRadius = 5;
            this.dtpSupplierEndDate.Checked = true;
            this.dtpSupplierEndDate.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpSupplierEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSupplierEndDate.ForeColor = System.Drawing.Color.White;
            this.dtpSupplierEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpSupplierEndDate.Location = new System.Drawing.Point(278, 93);
            this.dtpSupplierEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSupplierEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSupplierEndDate.Name = "dtpSupplierEndDate";
            this.dtpSupplierEndDate.Size = new System.Drawing.Size(200, 36);
            this.dtpSupplierEndDate.TabIndex = 73;
            this.dtpSupplierEndDate.Value = new System.DateTime(2025, 12, 30, 8, 50, 0, 0);
            this.dtpSupplierEndDate.Visible = false;
            this.dtpSupplierEndDate.ValueChanged += new System.EventHandler(this.dtpSupplierEndDate_ValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.lblStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStartDate.Location = new System.Drawing.Point(753, 95);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(30, 27);
            this.lblStartDate.TabIndex = 71;
            this.lblStartDate.Text = "من";
            this.lblStartDate.Visible = false;
            // 
            // dtpSupplierStartDate
            // 
            this.dtpSupplierStartDate.BorderRadius = 5;
            this.dtpSupplierStartDate.Checked = true;
            this.dtpSupplierStartDate.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpSupplierStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSupplierStartDate.ForeColor = System.Drawing.Color.White;
            this.dtpSupplierStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpSupplierStartDate.Location = new System.Drawing.Point(547, 93);
            this.dtpSupplierStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSupplierStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSupplierStartDate.Name = "dtpSupplierStartDate";
            this.dtpSupplierStartDate.Size = new System.Drawing.Size(200, 36);
            this.dtpSupplierStartDate.TabIndex = 72;
            this.dtpSupplierStartDate.Value = new System.DateTime(2025, 1, 1, 8, 50, 0, 0);
            this.dtpSupplierStartDate.Visible = false;
            this.dtpSupplierStartDate.ValueChanged += new System.EventHandler(this.dtpSupplierStartDate_ValueChanged);
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
            this.cbTransactionSelector.Location = new System.Drawing.Point(846, 96);
            this.cbTransactionSelector.Name = "cbTransactionSelector";
            this.cbTransactionSelector.Size = new System.Drawing.Size(140, 36);
            this.cbTransactionSelector.StartIndex = 0;
            this.cbTransactionSelector.TabIndex = 70;
            this.cbTransactionSelector.SelectedIndexChanged += new System.EventHandler(this.cbTransactionSelector_SelectedIndexChanged);
            // 
            // dgvSupplierTransactions
            // 
            this.dgvSupplierTransactions.AllowUserToAddRows = false;
            this.dgvSupplierTransactions.AllowUserToDeleteRows = false;
            this.dgvSupplierTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSupplierTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplierTransactions.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupplierTransactions.ColumnHeadersHeight = 35;
            this.dgvSupplierTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvSupplierName,
            this.dgvTotalPrice,
            this.dgvPayedMoney,
            this.dgvRemainingMoney,
            this.dgvEmployeeName,
            this.dgvDate});
            this.dgvSupplierTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSupplierTransactions.DataSource = this.supplierTransactionBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplierTransactions.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSupplierTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSupplierTransactions.Location = new System.Drawing.Point(208, 147);
            this.dgvSupplierTransactions.Name = "dgvSupplierTransactions";
            this.dgvSupplierTransactions.ReadOnly = true;
            this.dgvSupplierTransactions.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupplierTransactions.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSupplierTransactions.RowTemplate.Height = 35;
            this.dgvSupplierTransactions.Size = new System.Drawing.Size(778, 342);
            this.dgvSupplierTransactions.TabIndex = 69;
            this.dgvSupplierTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSupplierTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSupplierTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSupplierTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSupplierTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSupplierTransactions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSupplierTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSupplierTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSupplierTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSupplierTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupplierTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSupplierTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSupplierTransactions.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvSupplierTransactions.ThemeStyle.ReadOnly = true;
            this.dgvSupplierTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSupplierTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSupplierTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupplierTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSupplierTransactions.ThemeStyle.RowsStyle.Height = 35;
            this.dgvSupplierTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSupplierTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvId
            // 
            this.dgvId.DataPropertyName = "TransactionID";
            this.dgvId.HeaderText = "TransactionID";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Visible = false;
            // 
            // dgvSupplierName
            // 
            this.dgvSupplierName.DataPropertyName = "SupplierName";
            this.dgvSupplierName.HeaderText = "اسم المورد";
            this.dgvSupplierName.Name = "dgvSupplierName";
            this.dgvSupplierName.ReadOnly = true;
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
            this.dgvPayedMoney.ReadOnly = true;
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
            // supplierTransactionTableAdapter
            // 
            this.supplierTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // ucSupplierTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalProfit);
            this.Controls.Add(this.txtRemainingMoney);
            this.Controls.Add(this.txtTotalProfit);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpSupplierEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpSupplierStartDate);
            this.Controls.Add(this.cbTransactionSelector);
            this.Controls.Add(this.dgvSupplierTransactions);
            this.Name = "ucSupplierTransactions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(987, 680);
            this.Load += new System.EventHandler(this.ucSupplierTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alhamdDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalProfit;
        private Guna.UI2.WinForms.Guna2TextBox txtRemainingMoney;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalProfit;
        private System.Windows.Forms.Label lblEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSupplierEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSupplierStartDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbTransactionSelector;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSupplierTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmployeeId;
        private System.Windows.Forms.BindingSource supplierTransactionBindingSource;
        private AlhamdDBDataSet alhamdDBDataSet;
        private AlhamdDBDataSetTableAdapters.SupplierTransactionTableAdapter supplierTransactionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPayedMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRemainingMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
    }
}
