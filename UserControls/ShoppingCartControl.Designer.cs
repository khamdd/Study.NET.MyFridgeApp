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
            flpButtons = new FlowLayoutPanel();
            btnAddNewItem = new Button();
            btnPlaceOrder = new Button();
            btnClearCart = new Button();
            dgvCart = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colNotes = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            tlpMain.SuspendLayout();
            flpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(lblTitle, 0, 0);
            tlpMain.Controls.Add(flpButtons, 0, 2);
            tlpMain.Controls.Add(dgvCart, 0, 1);
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
            btnAddNewItem.Click += btnAddNewItem_Click;
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
            btnPlaceOrder.Click += btnPlaceOrder_Click;
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
            btnClearCart.Click += btnClearCart_Click;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCategory, colQuantity, colUnit, colNotes, colEdit, colDelete });
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvCart.Location = new Point(19, 108);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersVisible = false;
            dgvCart.RowHeadersWidth = 72;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(1288, 712);
            dgvCart.TabIndex = 1;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colId.DataPropertyName = "Id";
            colId.FillWeight = 12.5F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 9;
            colId.Name = "colId";
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.DataPropertyName = "Name";
            colName.FillWeight = 12.5F;
            colName.HeaderText = "Name";
            colName.MinimumWidth = 9;
            colName.Name = "colName";
            // 
            // colCategory
            // 
            colCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategory.DataPropertyName = "Category";
            colCategory.FillWeight = 12.5F;
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 9;
            colCategory.Name = "colCategory";
            // 
            // colQuantity
            // 
            colQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.FillWeight = 12.5F;
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 9;
            colQuantity.Name = "colQuantity";
            // 
            // colUnit
            // 
            colUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUnit.DataPropertyName = "Unit";
            colUnit.FillWeight = 12.5F;
            colUnit.HeaderText = "Unit";
            colUnit.MinimumWidth = 9;
            colUnit.Name = "colUnit";
            // 
            // colNotes
            // 
            colNotes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNotes.DataPropertyName = "Notes";
            colNotes.FillWeight = 12.5F;
            colNotes.HeaderText = "Notes";
            colNotes.MinimumWidth = 9;
            colNotes.Name = "colNotes";
            // 
            // colEdit
            // 
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEdit.FillWeight = 12.5F;
            colEdit.HeaderText = "Edit";
            colEdit.MinimumWidth = 9;
            colEdit.Name = "colEdit";
            colEdit.Text = "Edit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDelete.FillWeight = 12.5F;
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 9;
            colDelete.Name = "colDelete";
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // ShoppingCartControl
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpMain);
            Name = "ShoppingCartControl";
            Size = new Size(1326, 957);
            Load += ShoppingCartControl_Load;
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Label lblTitle;
        private DataGridView dgvCart;
        private FlowLayoutPanel flpButtons;
        private Button btnAddNewItem;
        private Button btnPlaceOrder;
        private Button btnClearCart;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colNotes;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
    }
}
