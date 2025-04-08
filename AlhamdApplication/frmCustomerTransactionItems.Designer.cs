namespace AlhamdApplication
{
    partial class frmCustomerTransactionItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerTransactionItems));
            this.dgvPayedProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.customerTransactionItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alhamdDBDataSet = new AlhamdApplication.AlhamdDBDataSet();
            this.customerTransactionItemsTableAdapter = new AlhamdApplication.AlhamdDBDataSetTableAdapters.CustomerTransactionItemsTableAdapter();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTranactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransactionItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alhamdDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPayedProducts
            // 
            this.dgvPayedProducts.AllowUserToAddRows = false;
            this.dgvPayedProducts.AllowUserToDeleteRows = false;
            this.dgvPayedProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPayedProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayedProducts.AutoGenerateColumns = false;
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
            this.dgvTranactionId,
            this.dgvProductName,
            this.dgvQuantity,
            this.dgvUnitPrice,
            this.dgvTotalPrice});
            this.dgvPayedProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPayedProducts.DataSource = this.customerTransactionItemsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayedProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayedProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayedProducts.Location = new System.Drawing.Point(29, 25);
            this.dgvPayedProducts.MultiSelect = false;
            this.dgvPayedProducts.Name = "dgvPayedProducts";
            this.dgvPayedProducts.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayedProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayedProducts.RowTemplate.Height = 35;
            this.dgvPayedProducts.Size = new System.Drawing.Size(610, 353);
            this.dgvPayedProducts.TabIndex = 37;
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
            this.dgvPayedProducts.ThemeStyle.ReadOnly = false;
            this.dgvPayedProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayedProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayedProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayedProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPayedProducts.ThemeStyle.RowsStyle.Height = 35;
            this.dgvPayedProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayedProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPayedProducts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayedProducts_CellValueChanged);
            // 
            // customerTransactionItemsBindingSource
            // 
            this.customerTransactionItemsBindingSource.DataMember = "CustomerTransactionItems";
            this.customerTransactionItemsBindingSource.DataSource = this.alhamdDBDataSet;
            // 
            // alhamdDBDataSet
            // 
            this.alhamdDBDataSet.DataSetName = "AlhamdDBDataSet";
            this.alhamdDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTransactionItemsTableAdapter
            // 
            this.customerTransactionItemsTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 15;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(29, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 45);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewImageColumn1.FillWeight = 111.6751F;
            this.dataGridViewImageColumn1.HeaderText = "حذف";
            this.dataGridViewImageColumn1.Image = global::AlhamdApplication.Properties.Resources.delete;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 55;
            // 
            // dgvId
            // 
            this.dgvId.DataPropertyName = "TransactionItemID";
            this.dgvId.HeaderText = "TransactionItemID";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Visible = false;
            // 
            // dgvTranactionId
            // 
            this.dgvTranactionId.DataPropertyName = "TransactionID";
            this.dgvTranactionId.HeaderText = "TransactionID";
            this.dgvTranactionId.Name = "dgvTranactionId";
            this.dgvTranactionId.ReadOnly = true;
            this.dgvTranactionId.Visible = false;
            // 
            // dgvProductName
            // 
            this.dgvProductName.DataPropertyName = "ProductName";
            this.dgvProductName.HeaderText = "اسم المنتج";
            this.dgvProductName.Name = "dgvProductName";
            this.dgvProductName.ReadOnly = true;
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.DataPropertyName = "Quantity";
            this.dgvQuantity.HeaderText = "الكمية";
            this.dgvQuantity.Name = "dgvQuantity";
            // 
            // dgvUnitPrice
            // 
            this.dgvUnitPrice.DataPropertyName = "UnitPrice";
            this.dgvUnitPrice.HeaderText = "السعر";
            this.dgvUnitPrice.Name = "dgvUnitPrice";
            this.dgvUnitPrice.ReadOnly = true;
            // 
            // dgvTotalPrice
            // 
            this.dgvTotalPrice.DataPropertyName = "TotalPrice";
            this.dgvTotalPrice.HeaderText = "السعر الكلي";
            this.dgvTotalPrice.Name = "dgvTotalPrice";
            this.dgvTotalPrice.ReadOnly = true;
            // 
            // frmCustomerTransactionItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(680, 461);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPayedProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomerTransactionItems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محتوي الفاتورة";
            this.Load += new System.EventHandler(this.frmCustomerTransactionItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransactionItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alhamdDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvPayedProducts;
        private AlhamdDBDataSet alhamdDBDataSet;
        private System.Windows.Forms.BindingSource customerTransactionItemsBindingSource;
        private AlhamdDBDataSetTableAdapters.CustomerTransactionItemsTableAdapter customerTransactionItemsTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTranactionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
    }
}