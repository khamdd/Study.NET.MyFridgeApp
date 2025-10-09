namespace MyFridgeApp.UserControls
{
    partial class AddCartItemControl
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
            tlpOuter = new TableLayoutPanel();
            tlpForm = new TableLayoutPanel();
            lblName = new Label();
            lblCategory = new Label();
            lblQuantity = new Label();
            lblNotes = new Label();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            numQuantity = new NumericUpDown();
            flpUnit = new FlowLayoutPanel();
            lblUnit = new Label();
            txtUnit = new TextBox();
            txtNotes = new TextBox();
            flpFormButtons = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            tlpOuter.SuspendLayout();
            tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            flpUnit.SuspendLayout();
            flpFormButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpOuter
            // 
            tlpOuter.ColumnCount = 1;
            tlpOuter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpOuter.Controls.Add(tlpForm, 0, 1);
            tlpOuter.Controls.Add(lblTitle, 0, 0);
            tlpOuter.Dock = DockStyle.Fill;
            tlpOuter.Location = new Point(0, 0);
            tlpOuter.Name = "tlpOuter";
            tlpOuter.Padding = new Padding(16);
            tlpOuter.RowCount = 2;
            tlpOuter.RowStyles.Add(new RowStyle());
            tlpOuter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpOuter.Size = new Size(1217, 896);
            tlpOuter.TabIndex = 0;
            // 
            // tlpForm
            // 
            tlpForm.ColumnCount = 3;
            tlpForm.ColumnStyles.Add(new ColumnStyle());
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpForm.ColumnStyles.Add(new ColumnStyle());
            tlpForm.Controls.Add(lblName, 0, 0);
            tlpForm.Controls.Add(lblCategory, 0, 1);
            tlpForm.Controls.Add(lblQuantity, 0, 2);
            tlpForm.Controls.Add(lblNotes, 0, 3);
            tlpForm.Controls.Add(txtName, 1, 0);
            tlpForm.Controls.Add(cmbCategory, 1, 1);
            tlpForm.Controls.Add(numQuantity, 1, 2);
            tlpForm.Controls.Add(flpUnit, 2, 2);
            tlpForm.Controls.Add(txtNotes, 1, 3);
            tlpForm.Controls.Add(flpFormButtons, 1, 4);
            tlpForm.Dock = DockStyle.Fill;
            tlpForm.Location = new Point(19, 108);
            tlpForm.Name = "tlpForm";
            tlpForm.Padding = new Padding(26, 20, 26, 26);
            tlpForm.RowCount = 5;
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpForm.Size = new Size(1179, 769);
            tlpForm.TabIndex = 2;
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
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Left;
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(29, 206);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(105, 28);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity:";
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Left;
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(29, 286);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(77, 28);
            lblNotes.TabIndex = 4;
            lblNotes.Text = "Notes:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tlpForm.SetColumnSpan(txtName, 2);
            txtName.Cursor = Cursors.IBeam;
            txtName.Location = new Point(143, 43);
            txtName.Margin = new Padding(3, 3, 30, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(980, 34);
            txtName.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tlpForm.SetColumnSpan(cmbCategory, 2);
            cmbCategory.Cursor = Cursors.Hand;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(143, 122);
            cmbCategory.Margin = new Padding(3, 3, 30, 3);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(980, 36);
            cmbCategory.TabIndex = 6;
            // 
            // numQuantity
            // 
            numQuantity.Anchor = AnchorStyles.Left;
            numQuantity.Cursor = Cursors.Hand;
            numQuantity.Location = new Point(143, 203);
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
            flpUnit.Location = new Point(931, 200);
            flpUnit.Name = "flpUnit";
            flpUnit.Size = new Size(219, 40);
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
            txtUnit.Cursor = Cursors.IBeam;
            txtUnit.Location = new Point(69, 3);
            txtUnit.Margin = new Padding(3, 3, 30, 3);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(120, 34);
            txtUnit.TabIndex = 1;
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpForm.SetColumnSpan(txtNotes, 2);
            txtNotes.Cursor = Cursors.IBeam;
            txtNotes.Location = new Point(143, 263);
            txtNotes.Margin = new Padding(3, 3, 30, 3);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(980, 74);
            txtNotes.TabIndex = 10;
            // 
            // flpFormButtons
            // 
            flpFormButtons.Anchor = AnchorStyles.None;
            flpFormButtons.AutoSize = true;
            tlpForm.SetColumnSpan(flpFormButtons, 3);
            flpFormButtons.Controls.Add(btnSave);
            flpFormButtons.Controls.Add(btnCancel);
            flpFormButtons.Location = new Point(199, 521);
            flpFormButtons.Name = "flpFormButtons";
            flpFormButtons.Size = new Size(780, 120);
            flpFormButtons.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ControlLight;
            btnSave.Location = new Point(10, 10);
            btnSave.Margin = new Padding(10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(300, 100);
            btnSave.TabIndex = 0;
            btnSave.Text = "Add Item";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.UseWaitCursor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.FromArgb(64, 64, 64);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ControlLight;
            btnCancel.Location = new Point(470, 10);
            btnCancel.Margin = new Padding(150, 10, 10, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(300, 100);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(19, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(0, 20, 0, 20);
            lblTitle.Size = new Size(1179, 89);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Item";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddCartItemControl
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpOuter);
            Name = "AddCartItemControl";
            Size = new Size(1217, 896);
            Load += AddCartItemControl_Load;
            tlpOuter.ResumeLayout(false);
            tlpOuter.PerformLayout();
            tlpForm.ResumeLayout(false);
            tlpForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            flpUnit.ResumeLayout(false);
            flpUnit.PerformLayout();
            flpFormButtons.ResumeLayout(false);
            flpFormButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpOuter;
        private Label lblTitle;
        private TableLayoutPanel tlpForm;
        private Label lblName;
        private Label lblCategory;
        private Label lblQuantity;
        private Label lblNotes;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private NumericUpDown numQuantity;
        private FlowLayoutPanel flpUnit;
        private Label lblUnit;
        private TextBox txtUnit;
        private TextBox txtNotes;
        private FlowLayoutPanel flpFormButtons;
        private Button btnSave;
        private Button btnCancel;
    }
}
