namespace MyFridgeApp.UserControls
{
    partial class ShoppingCartControl
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
            tlpMain = new TableLayoutPanel();
            lblTitle = new Label();
            agvCart = new DataGridView();
            flpButtons = new FlowLayoutPanel();
            btnAddNewItem = new Button();
            btnPlaceOrder = new Button();
            btnClearCart = new Button();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)agvCart).BeginInit();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(lblTitle, 0, 0);
            tlpMain.Controls.Add(flpButtons, 0, 2);
            tlpMain.Controls.Add(agvCart, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(16);
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.Size = new Size(1326, 957);
            tlpMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(16, 36);
            lblTitle.Margin = new Padding(0, 20, 0, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1294, 49);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Shopping Cart";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // agvCart
            // 
            agvCart.AllowUserToAddRows = false;
            agvCart.AllowUserToDeleteRows = false;
            agvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            agvCart.Columns.AddRange(new DataGridViewColumn[] { colName, colCategory, colQty, colUnit, colNote, colEdit, colDelete });
            agvCart.Dock = DockStyle.Fill;
            agvCart.EditMode = DataGridViewEditMode.EditOnEnter;
            agvCart.Location = new Point(19, 108);
            agvCart.MultiSelect = false;
            agvCart.Name = "agvCart";
            agvCart.RowHeadersVisible = false;
            agvCart.RowHeadersWidth = 72;
            agvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            agvCart.Size = new Size(1288, 712);
            agvCart.TabIndex = 1;
            // 
            // flpButtons
            // 
            flpButtons.Anchor = AnchorStyles.None;
            flpButtons.AutoSize = true;
            flpButtons.Controls.Add(btnAddNewItem);
            flpButtons.Controls.Add(btnPlaceOrder);
            flpButtons.Controls.Add(btnClearCart);
            flpButtons.Location = new Point(173, 826);
            flpButtons.Name = "flpButtons";
            flpButtons.Padding = new Padding(0, 12, 0, 0);
            flpButtons.Size = new Size(980, 112);
            flpButtons.TabIndex = 2;
            flpButtons.WrapContents = false;
            // 
            // btnAddNewItem
            // 
            btnAddNewItem.AutoSize = true;
            btnAddNewItem.BackColor = Color.FromArgb(64, 64, 64);
            btnAddNewItem.Cursor = Cursors.Hand;
            btnAddNewItem.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewItem.ForeColor = SystemColors.ControlLight;
            btnAddNewItem.Location = new Point(0, 12);
            btnAddNewItem.Margin = new Padding(0);
            btnAddNewItem.Name = "btnAddNewItem";
            btnAddNewItem.Size = new Size(300, 100);
            btnAddNewItem.TabIndex = 0;
            btnAddNewItem.Text = "Add New Item";
            btnAddNewItem.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddNewItem.UseVisualStyleBackColor = false;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.AutoSize = true;
            btnPlaceOrder.BackColor = Color.FromArgb(64, 64, 64);
            btnPlaceOrder.Cursor = Cursors.Hand;
            btnPlaceOrder.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlaceOrder.ForeColor = SystemColors.ControlLight;
            btnPlaceOrder.Location = new Point(340, 12);
            btnPlaceOrder.Margin = new Padding(40, 0, 0, 0);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(300, 100);
            btnPlaceOrder.TabIndex = 1;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // btnClearCart
            // 
            btnClearCart.AutoSize = true;
            btnClearCart.BackColor = Color.FromArgb(64, 64, 64);
            btnClearCart.Cursor = Cursors.Hand;
            btnClearCart.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCart.ForeColor = SystemColors.ControlLight;
            btnClearCart.Location = new Point(680, 12);
            btnClearCart.Margin = new Padding(40, 0, 0, 0);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(300, 100);
            btnClearCart.TabIndex = 2;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.FillWeight = 14F;
            colName.HeaderText = "Name";
            colName.MinimumWidth = 9;
            colName.Name = "colName";
            // 
            // colCategory
            // 
            colCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategory.FillWeight = 14F;
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 9;
            colCategory.Name = "colCategory";
            // 
            // colQty
            // 
            colQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colQty.FillWeight = 14F;
            colQty.HeaderText = "Quantity";
            colQty.MinimumWidth = 9;
            colQty.Name = "colQty";
            // 
            // colUnit
            // 
            colUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUnit.FillWeight = 14F;
            colUnit.HeaderText = "Unit";
            colUnit.MinimumWidth = 9;
            colUnit.Name = "colUnit";
            // 
            // colNote
            // 
            colNote.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNote.FillWeight = 14F;
            colNote.HeaderText = "Note";
            colNote.MinimumWidth = 9;
            colNote.Name = "colNote";
            // 
            // colEdit
            // 
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEdit.FillWeight = 14F;
            colEdit.HeaderText = "Edit";
            colEdit.MinimumWidth = 9;
            colEdit.Name = "colEdit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDelete.FillWeight = 14F;
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 9;
            colDelete.Name = "colDelete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // ShoppingCartControl
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpMain);
            Name = "ShoppingCartControl";
            Size = new Size(1326, 957);
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)agvCart).EndInit();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Label lblTitle;
        private DataGridView agvCart;
        private FlowLayoutPanel flpButtons;
        private Button btnAddNewItem;
        private Button btnPlaceOrder;
        private Button btnClearCart;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colNote;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
    }
}
