namespace AlhamdApplication
{
    partial class frmSupplierBuy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierBuy));
            this.txtTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.btnPdf = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtFinalPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSeparator = new Guna.UI2.WinForms.Guna2Panel();
            this.txtRecievedMoney = new System.Windows.Forms.NumericUpDown();
            this.txtPercentageDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtValueDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblRecievedMoney = new System.Windows.Forms.Label();
            this.lblPercentageDiscount = new System.Windows.Forms.Label();
            this.lblValueDiscount = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cbProductName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvPayedProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecievedMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentageDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValueDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayedProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.DecimalPlaces = 2;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTotalPrice.Location = new System.Drawing.Point(34, 63);
            this.txtTotalPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalPrice.Size = new System.Drawing.Size(153, 29);
            this.txtTotalPrice.TabIndex = 58;
            // 
            // btnPdf
            // 
            this.btnPdf.BorderRadius = 10;
            this.btnPdf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPdf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPdf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPdf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPdf.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPdf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Image = global::AlhamdApplication.Properties.Resources.pdf;
            this.btnPdf.Location = new System.Drawing.Point(176, 409);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(117, 36);
            this.btnPdf.TabIndex = 57;
            this.btnPdf.Text = "تحويل الي";
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(34, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 36);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.DecimalPlaces = 2;
            this.txtFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalPrice.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtFinalPrice.Location = new System.Drawing.Point(225, 63);
            this.txtFinalPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.ReadOnly = true;
            this.txtFinalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFinalPrice.Size = new System.Drawing.Size(153, 29);
            this.txtFinalPrice.TabIndex = 42;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::AlhamdApplication.Properties.Resources.add_white;
            this.btnAdd.Location = new System.Drawing.Point(377, 338);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 36);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BorderRadius = 10;
            this.pnlSeparator.FillColor = System.Drawing.Color.Silver;
            this.pnlSeparator.Location = new System.Drawing.Point(34, 271);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(450, 5);
            this.pnlSeparator.TabIndex = 49;
            // 
            // txtRecievedMoney
            // 
            this.txtRecievedMoney.DecimalPlaces = 2;
            this.txtRecievedMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecievedMoney.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtRecievedMoney.Location = new System.Drawing.Point(34, 216);
            this.txtRecievedMoney.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtRecievedMoney.Name = "txtRecievedMoney";
            this.txtRecievedMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRecievedMoney.Size = new System.Drawing.Size(153, 29);
            this.txtRecievedMoney.TabIndex = 48;
            this.txtRecievedMoney.ValueChanged += new System.EventHandler(this.txtRecievedMoney_ValueChanged);
            // 
            // txtPercentageDiscount
            // 
            this.txtPercentageDiscount.DecimalPlaces = 2;
            this.txtPercentageDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentageDiscount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPercentageDiscount.Location = new System.Drawing.Point(225, 137);
            this.txtPercentageDiscount.Name = "txtPercentageDiscount";
            this.txtPercentageDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPercentageDiscount.Size = new System.Drawing.Size(153, 29);
            this.txtPercentageDiscount.TabIndex = 46;
            this.txtPercentageDiscount.ValueChanged += new System.EventHandler(this.txtPercentageDiscount_ValueChanged);
            // 
            // txtValueDiscount
            // 
            this.txtValueDiscount.DecimalPlaces = 2;
            this.txtValueDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValueDiscount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtValueDiscount.Location = new System.Drawing.Point(34, 137);
            this.txtValueDiscount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtValueDiscount.Name = "txtValueDiscount";
            this.txtValueDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValueDiscount.Size = new System.Drawing.Size(153, 29);
            this.txtValueDiscount.TabIndex = 44;
            this.txtValueDiscount.ValueChanged += new System.EventHandler(this.txtValueDiscount_ValueChanged);
            // 
            // lblRecievedMoney
            // 
            this.lblRecievedMoney.AutoSize = true;
            this.lblRecievedMoney.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecievedMoney.Location = new System.Drawing.Point(29, 188);
            this.lblRecievedMoney.Name = "lblRecievedMoney";
            this.lblRecievedMoney.Size = new System.Drawing.Size(93, 25);
            this.lblRecievedMoney.TabIndex = 47;
            this.lblRecievedMoney.Text = "المبلغ المدفوع";
            // 
            // lblPercentageDiscount
            // 
            this.lblPercentageDiscount.AutoSize = true;
            this.lblPercentageDiscount.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentageDiscount.Location = new System.Drawing.Point(220, 109);
            this.lblPercentageDiscount.Name = "lblPercentageDiscount";
            this.lblPercentageDiscount.Size = new System.Drawing.Size(91, 25);
            this.lblPercentageDiscount.TabIndex = 45;
            this.lblPercentageDiscount.Text = "الخصم بالنسبة";
            // 
            // lblValueDiscount
            // 
            this.lblValueDiscount.AutoSize = true;
            this.lblValueDiscount.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueDiscount.Location = new System.Drawing.Point(29, 109);
            this.lblValueDiscount.Name = "lblValueDiscount";
            this.lblValueDiscount.Size = new System.Drawing.Size(92, 25);
            this.lblValueDiscount.TabIndex = 43;
            this.lblValueDiscount.Text = "الخصم بالقيمة";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPrice.Location = new System.Drawing.Point(220, 32);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(107, 25);
            this.lblFinalPrice.TabIndex = 41;
            this.lblFinalPrice.Text = "السعر بعد الخصم";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(29, 32);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(109, 25);
            this.lblTotalPrice.TabIndex = 40;
            this.lblTotalPrice.Text = "السعر قبل الخصم";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(198, 315);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 25);
            this.lblQuantity.TabIndex = 52;
            this.lblQuantity.Text = "الكمية";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(203, 343);
            this.txtQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantity.Size = new System.Drawing.Size(153, 29);
            this.txtQuantity.TabIndex = 53;
            this.txtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(29, 315);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(45, 25);
            this.lblProductName.TabIndex = 50;
            this.lblProductName.Text = "المنتج";
            // 
            // cbProductName
            // 
            this.cbProductName.BackColor = System.Drawing.Color.Transparent;
            this.cbProductName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbProductName.ItemHeight = 30;
            this.cbProductName.Location = new System.Drawing.Point(34, 343);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(140, 36);
            this.cbProductName.TabIndex = 51;
            // 
            // dgvPayedProducts
            // 
            this.dgvPayedProducts.AllowUserToAddRows = false;
            this.dgvPayedProducts.AllowUserToDeleteRows = false;
            this.dgvPayedProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPayedProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayedProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayedProducts.ColumnHeadersHeight = 35;
            this.dgvPayedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvName,
            this.dgvQuantity,
            this.dgvPrice,
            this.dgvTotalPrice,
            this.dgvDelete});
            this.dgvPayedProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayedProducts.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayedProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayedProducts.Location = new System.Drawing.Point(500, 32);
            this.dgvPayedProducts.MultiSelect = false;
            this.dgvPayedProducts.Name = "dgvPayedProducts";
            this.dgvPayedProducts.ReadOnly = true;
            this.dgvPayedProducts.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayedProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPayedProducts.RowTemplate.Height = 35;
            this.dgvPayedProducts.Size = new System.Drawing.Size(538, 413);
            this.dgvPayedProducts.TabIndex = 56;
            this.dgvPayedProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayedProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPayedProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPayedProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPayedProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPayedProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayedProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayedProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPayedProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayedProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayedProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPayedProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayedProducts.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvPayedProducts.ThemeStyle.ReadOnly = true;
            this.dgvPayedProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayedProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayedProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayedProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPayedProducts.ThemeStyle.RowsStyle.Height = 35;
            this.dgvPayedProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayedProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPayedProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayedProducts_CellContentClick);
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "ProductID";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.FillWeight = 96.10829F;
            this.dgvName.HeaderText = "اسم المنتج";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.FillWeight = 96.10829F;
            this.dgvQuantity.HeaderText = "الكمية";
            this.dgvQuantity.Name = "dgvQuantity";
            this.dgvQuantity.ReadOnly = true;
            // 
            // dgvPrice
            // 
            this.dgvPrice.FillWeight = 96.10829F;
            this.dgvPrice.HeaderText = "السعر";
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            // 
            // dgvTotalPrice
            // 
            this.dgvTotalPrice.HeaderText = "السعر الكلي";
            this.dgvTotalPrice.Name = "dgvTotalPrice";
            this.dgvTotalPrice.ReadOnly = true;
            // 
            // dgvDelete
            // 
            this.dgvDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            this.dgvDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDelete.FillWeight = 111.6751F;
            this.dgvDelete.HeaderText = "حذف";
            this.dgvDelete.Image = global::AlhamdApplication.Properties.Resources.delete;
            this.dgvDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            this.dgvDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelete.Width = 55;
            // 
            // frmSupplierBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1067, 477);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFinalPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.txtRecievedMoney);
            this.Controls.Add(this.txtPercentageDiscount);
            this.Controls.Add(this.txtValueDiscount);
            this.Controls.Add(this.lblRecievedMoney);
            this.Controls.Add(this.lblPercentageDiscount);
            this.Controls.Add(this.lblValueDiscount);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.cbProductName);
            this.Controls.Add(this.dgvPayedProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSupplierBuy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة جديدة";
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecievedMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentageDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValueDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayedProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtTotalPrice;
        private Guna.UI2.WinForms.Guna2Button btnPdf;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.NumericUpDown txtFinalPrice;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Panel pnlSeparator;
        private System.Windows.Forms.NumericUpDown txtRecievedMoney;
        private System.Windows.Forms.NumericUpDown txtPercentageDiscount;
        private System.Windows.Forms.NumericUpDown txtValueDiscount;
        private System.Windows.Forms.Label lblRecievedMoney;
        private System.Windows.Forms.Label lblPercentageDiscount;
        private System.Windows.Forms.Label lblValueDiscount;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label lblProductName;
        private Guna.UI2.WinForms.Guna2ComboBox cbProductName;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPayedProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
    }
}