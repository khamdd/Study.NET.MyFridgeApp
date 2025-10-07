namespace MyFridgeApp.UserControls
{
    partial class AddNewItemControl
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
            lblTitle = new Label();
            tlpMain = new TableLayoutPanel();
            lblName = new Label();
            lblCategory = new Label();
            lblExpiry = new Label();
            lblQuantity = new Label();
            lblNotes = new Label();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            dtpExpiry = new DateTimePicker();
            numQuantity = new NumericUpDown();
            flpUnit = new FlowLayoutPanel();
            lblUnit = new Label();
            txtUnit = new TextBox();
            txtNotes = new TextBox();
            btnAdd = new Button();
            tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            flpUnit.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(0, 20, 0, 0);
            lblTitle.Size = new Size(1387, 126);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Item";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle());
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.ColumnStyles.Add(new ColumnStyle());
            tlpMain.Controls.Add(lblName, 0, 0);
            tlpMain.Controls.Add(lblCategory, 0, 1);
            tlpMain.Controls.Add(lblExpiry, 0, 2);
            tlpMain.Controls.Add(lblQuantity, 0, 3);
            tlpMain.Controls.Add(lblNotes, 0, 4);
            tlpMain.Controls.Add(txtName, 1, 0);
            tlpMain.Controls.Add(cmbCategory, 1, 1);
            tlpMain.Controls.Add(dtpExpiry, 1, 2);
            tlpMain.Controls.Add(numQuantity, 1, 3);
            tlpMain.Controls.Add(flpUnit, 2, 3);
            tlpMain.Controls.Add(txtNotes, 1, 4);
            tlpMain.Controls.Add(btnAdd, 0, 5);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 126);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(26, 20, 26, 26);
            tlpMain.RowCount = 6;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMain.Size = new Size(1387, 783);
            tlpMain.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.Location = new Point(29, 46);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.Left;
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(29, 126);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(108, 28);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category:";
            // 
            // lblExpiry
            // 
            lblExpiry.Anchor = AnchorStyles.Left;
            lblExpiry.AutoSize = true;
            lblExpiry.Location = new Point(29, 206);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(132, 28);
            lblExpiry.TabIndex = 2;
            lblExpiry.Text = "Expiry Date:";
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Left;
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(29, 286);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(105, 28);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity:";
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Left;
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(29, 366);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(77, 28);
            lblNotes.TabIndex = 4;
            lblNotes.Text = "Notes:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tlpMain.SetColumnSpan(txtName, 2);
            txtName.Location = new Point(167, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(1191, 34);
            txtName.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tlpMain.SetColumnSpan(cmbCategory, 2);
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(167, 122);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(1191, 36);
            cmbCategory.TabIndex = 6;
            // 
            // dtpExpiry
            // 
            dtpExpiry.Anchor = AnchorStyles.Left;
            tlpMain.SetColumnSpan(dtpExpiry, 2);
            dtpExpiry.Format = DateTimePickerFormat.Short;
            dtpExpiry.Location = new Point(167, 203);
            dtpExpiry.Name = "dtpExpiry";
            dtpExpiry.Size = new Size(350, 34);
            dtpExpiry.TabIndex = 7;
            // 
            // numQuantity
            // 
            numQuantity.Anchor = AnchorStyles.Left;
            numQuantity.Location = new Point(167, 283);
            numQuantity.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(100, 34);
            numQuantity.TabIndex = 8;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // flpUnit
            // 
            flpUnit.Anchor = AnchorStyles.Left;
            flpUnit.AutoSize = true;
            flpUnit.Controls.Add(lblUnit);
            flpUnit.Controls.Add(txtUnit);
            flpUnit.Location = new Point(1166, 280);
            flpUnit.Name = "flpUnit";
            flpUnit.Size = new Size(192, 40);
            flpUnit.TabIndex = 9;
            flpUnit.WrapContents = false;
            // 
            // lblUnit
            // 
            lblUnit.Anchor = AnchorStyles.Left;
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(3, 6);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(60, 28);
            lblUnit.TabIndex = 0;
            lblUnit.Text = "Unit:";
            // 
            // txtUnit
            // 
            txtUnit.Anchor = AnchorStyles.Left;
            txtUnit.Location = new Point(69, 3);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(120, 34);
            txtUnit.TabIndex = 1;
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpMain.SetColumnSpan(txtNotes, 2);
            txtNotes.Location = new Point(167, 343);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(1191, 74);
            txtNotes.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(64, 64, 64);
            tlpMain.SetColumnSpan(btnAdd, 3);
            btnAdd.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(543, 538);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(300, 100);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddNewItemControl
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpMain);
            Controls.Add(lblTitle);
            Name = "AddNewItemControl";
            Size = new Size(1387, 909);
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            flpUnit.ResumeLayout(false);
            flpUnit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private TableLayoutPanel tlpMain;
        private Label lblName;
        private Label lblCategory;
        private Label lblExpiry;
        private Label lblQuantity;
        private Label lblNotes;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private DateTimePicker dtpExpiry;
        private NumericUpDown numQuantity;
        private FlowLayoutPanel flpUnit;
        private Label lblUnit;
        private TextBox txtUnit;
        private TextBox txtNotes;
        private Button btnAdd;
    }
}
