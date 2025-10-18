namespace MyFridgeApp.UserControls
{
    partial class InventoryControl
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
            inventorydgv = new DataGridView();
            searchTextbox = new TextBox();
            searchLabel = new Label();
            UpdateBtn = new Button();
            cmbSearchBy = new ComboBox();
            SearchBtn = new Button();
            deleteItemBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)inventorydgv).BeginInit();
            SuspendLayout();
            // 
            // inventorydgv
            // 
            inventorydgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventorydgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventorydgv.Dock = DockStyle.Top;
            inventorydgv.Location = new Point(0, 0);
            inventorydgv.Name = "inventorydgv";
            inventorydgv.Size = new Size(784, 327);
            inventorydgv.TabIndex = 1;
            inventorydgv.SelectionChanged += inventorydgv_SelectionChanged;
            // 
            // searchTextbox
            // 
            searchTextbox.Location = new Point(247, 427);
            searchTextbox.Name = "searchTextbox";
            searchTextbox.Size = new Size(331, 23);
            searchTextbox.TabIndex = 3;
            searchTextbox.TextChanged += searchTextbox_TextChanged;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchLabel.Location = new Point(45, 429);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(69, 16);
            searchLabel.TabIndex = 4;
            searchLabel.Text = "Search By:";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(64, 64, 64);
            UpdateBtn.Cursor = Cursors.Hand;
            UpdateBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Tahoma", 10F);
            UpdateBtn.ForeColor = SystemColors.Menu;
            UpdateBtn.Location = new Point(281, 362);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(115, 36);
            UpdateBtn.TabIndex = 12;
            UpdateBtn.Text = "Update Item";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // cmbSearchBy
            // 
            cmbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Location = new Point(120, 427);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new Size(121, 23);
            cmbSearchBy.TabIndex = 13;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(64, 64, 64);
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Tahoma", 10F);
            SearchBtn.ForeColor = SystemColors.Menu;
            SearchBtn.Location = new Point(601, 424);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(82, 27);
            SearchBtn.TabIndex = 14;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // deleteItemBtn
            // 
            deleteItemBtn.BackColor = Color.FromArgb(64, 64, 64);
            deleteItemBtn.Cursor = Cursors.Hand;
            deleteItemBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            deleteItemBtn.FlatAppearance.BorderSize = 0;
            deleteItemBtn.FlatStyle = FlatStyle.Flat;
            deleteItemBtn.Font = new Font("Tahoma", 10F);
            deleteItemBtn.ForeColor = SystemColors.Menu;
            deleteItemBtn.Location = new Point(450, 362);
            deleteItemBtn.Name = "deleteItemBtn";
            deleteItemBtn.Size = new Size(115, 36);
            deleteItemBtn.TabIndex = 15;
            deleteItemBtn.Text = "Delete Item";
            deleteItemBtn.UseVisualStyleBackColor = false;
            deleteItemBtn.Click += deleteItemBtn_Click;
            // 
            // InventoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteItemBtn);
            Controls.Add(SearchBtn);
            Controls.Add(cmbSearchBy);
            Controls.Add(UpdateBtn);
            Controls.Add(searchLabel);
            Controls.Add(searchTextbox);
            Controls.Add(inventorydgv);
            Name = "InventoryControl";
            Size = new Size(784, 501);
            Load += InventoryControl_Load;
            ((System.ComponentModel.ISupportInitialize)inventorydgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView inventorydgv;
        private TextBox searchTextbox;
        private Label searchLabel;
        private Button UpdateBtn;
        private ComboBox cmbSearchBy;
        private Button SearchBtn;
        private Button deleteItemBtn;
    }
}
