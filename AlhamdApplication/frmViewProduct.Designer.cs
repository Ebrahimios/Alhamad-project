namespace AlhamdApplication
{
    partial class frmViewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewProduct));
            this.lblPayedQuantity = new System.Windows.Forms.Label();
            this.lblAvaliableQuantity = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.txtInitialPrice = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInitialPrice = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPayedQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAvaliableQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPayedQuantity
            // 
            this.lblPayedQuantity.AutoSize = true;
            this.lblPayedQuantity.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayedQuantity.Location = new System.Drawing.Point(22, 90);
            this.lblPayedQuantity.Name = "lblPayedQuantity";
            this.lblPayedQuantity.Size = new System.Drawing.Size(119, 31);
            this.lblPayedQuantity.TabIndex = 14;
            this.lblPayedQuantity.Text = "الكمية المباعة:";
            // 
            // lblAvaliableQuantity
            // 
            this.lblAvaliableQuantity.AutoSize = true;
            this.lblAvaliableQuantity.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaliableQuantity.Location = new System.Drawing.Point(22, 158);
            this.lblAvaliableQuantity.Name = "lblAvaliableQuantity";
            this.lblAvaliableQuantity.Size = new System.Drawing.Size(121, 31);
            this.lblAvaliableQuantity.TabIndex = 16;
            this.lblAvaliableQuantity.Text = "الكمية المتاحة:";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(79)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(179, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 36);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(26, 325);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 36);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtInitialPrice
            // 
            this.txtInitialPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialPrice.Location = new System.Drawing.Point(28, 263);
            this.txtInitialPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtInitialPrice.Name = "txtInitialPrice";
            this.txtInitialPrice.ReadOnly = true;
            this.txtInitialPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInitialPrice.Size = new System.Drawing.Size(131, 26);
            this.txtInitialPrice.TabIndex = 23;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(223, 263);
            this.txtPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrice.Size = new System.Drawing.Size(131, 26);
            this.txtPrice.TabIndex = 25;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(218, 235);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 25);
            this.lblPrice.TabIndex = 24;
            this.lblPrice.Text = "سعر البيع";
            // 
            // lblInitialPrice
            // 
            this.lblInitialPrice.AutoSize = true;
            this.lblInitialPrice.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialPrice.Location = new System.Drawing.Point(23, 235);
            this.lblInitialPrice.Name = "lblInitialPrice";
            this.lblInitialPrice.Size = new System.Drawing.Size(75, 25);
            this.lblInitialPrice.TabIndex = 22;
            this.lblInitialPrice.Text = "سعر الجملة";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
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
            this.txtName.Location = new System.Drawing.Point(149, 27);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(232, 36);
            this.txtName.TabIndex = 19;
            // 
            // txtPayedQuantity
            // 
            this.txtPayedQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtPayedQuantity.BorderRadius = 10;
            this.txtPayedQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPayedQuantity.DefaultText = "";
            this.txtPayedQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPayedQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPayedQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPayedQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPayedQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtPayedQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPayedQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayedQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPayedQuantity.Location = new System.Drawing.Point(147, 90);
            this.txtPayedQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPayedQuantity.Name = "txtPayedQuantity";
            this.txtPayedQuantity.PasswordChar = '\0';
            this.txtPayedQuantity.PlaceholderText = "";
            this.txtPayedQuantity.ReadOnly = true;
            this.txtPayedQuantity.SelectedText = "";
            this.txtPayedQuantity.Size = new System.Drawing.Size(234, 36);
            this.txtPayedQuantity.TabIndex = 29;
            // 
            // txtAvaliableQuantity
            // 
            this.txtAvaliableQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtAvaliableQuantity.BorderRadius = 10;
            this.txtAvaliableQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAvaliableQuantity.DefaultText = "";
            this.txtAvaliableQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAvaliableQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAvaliableQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAvaliableQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAvaliableQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtAvaliableQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAvaliableQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvaliableQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAvaliableQuantity.Location = new System.Drawing.Point(149, 153);
            this.txtAvaliableQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAvaliableQuantity.Name = "txtAvaliableQuantity";
            this.txtAvaliableQuantity.PasswordChar = '\0';
            this.txtAvaliableQuantity.PlaceholderText = "";
            this.txtAvaliableQuantity.ReadOnly = true;
            this.txtAvaliableQuantity.SelectedText = "";
            this.txtAvaliableQuantity.Size = new System.Drawing.Size(232, 36);
            this.txtAvaliableQuantity.TabIndex = 28;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 31);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "اسم المنتج:";
            // 
            // frmViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(419, 400);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPayedQuantity);
            this.Controls.Add(this.txtAvaliableQuantity);
            this.Controls.Add(this.lblPayedQuantity);
            this.Controls.Add(this.lblAvaliableQuantity);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtInitialPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInitialPrice);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المنتج";
            this.Load += new System.EventHandler(this.frmViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPayedQuantity;
        private System.Windows.Forms.Label lblAvaliableQuantity;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.NumericUpDown txtInitialPrice;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInitialPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtPayedQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtAvaliableQuantity;
        private System.Windows.Forms.Label lblName;
    }
}