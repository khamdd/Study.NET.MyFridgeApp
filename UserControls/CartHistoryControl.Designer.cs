namespace MyFridgeApp.UserControls
{
    partial class CartHistoryControl
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
            pageHost = new Panel();
            pageHistory = new Panel();
            dgvCarts = new DataGridView();
            lblHistoryTitle = new Label();
            colCartId = new DataGridViewTextBoxColumn();
            colTotalItems = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            colCartStatus = new DataGridViewTextBoxColumn();
            flpHistoryButtons = new FlowLayoutPanel();
            btnClearHistory = new Button();
            pageDetail = new Panel();
            lblDetailTitle = new Label();
            dgvItems = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
            tlpDetailButtons = new TableLayoutPanel();
            btnBackToHistory = new Button();
            btnDeleteCart = new Button();
            tlpMain.SuspendLayout();
            pageHost.SuspendLayout();
            pageHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarts).BeginInit();
            pageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            tlpDetailButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Controls.Add(pageHost, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.Size = new Size(1374, 986);
            tlpMain.TabIndex = 0;
            // 
            // pageHost
            // 
            pageHost.Controls.Add(pageDetail);
            pageHost.Controls.Add(pageHistory);
            pageHost.Dock = DockStyle.Fill;
            pageHost.Location = new Point(3, 3);
            pageHost.Name = "pageHost";
            pageHost.Size = new Size(1368, 980);
            pageHost.TabIndex = 0;
            // 
            // pageHistory
            // 
            pageHistory.Controls.Add(btnClearHistory);
            pageHistory.Controls.Add(flpHistoryButtons);
            pageHistory.Controls.Add(dgvCarts);
            pageHistory.Controls.Add(lblHistoryTitle);
            pageHistory.Dock = DockStyle.Fill;
            pageHistory.Location = new Point(0, 0);
            pageHistory.Name = "pageHistory";
            pageHistory.Size = new Size(1368, 980);
            pageHistory.TabIndex = 0;
            // 
            // dgvCarts
            // 
            dgvCarts.AllowUserToAddRows = false;
            dgvCarts.AllowUserToDeleteRows = false;
            dgvCarts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarts.Columns.AddRange(new DataGridViewColumn[] { colCartId, colTotalItems, colCreatedAt, colCartStatus });
            dgvCarts.Location = new Point(0, 123);
            dgvCarts.MultiSelect = false;
            dgvCarts.Name = "dgvCarts";
            dgvCarts.RowHeadersVisible = false;
            dgvCarts.RowHeadersWidth = 72;
            dgvCarts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarts.Size = new Size(1368, 645);
            dgvCarts.TabIndex = 1;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.Dock = DockStyle.Top;
            lblHistoryTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistoryTitle.Location = new Point(0, 0);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Padding = new Padding(0, 20, 0, 20);
            lblHistoryTitle.Size = new Size(1368, 123);
            lblHistoryTitle.TabIndex = 0;
            lblHistoryTitle.Text = "Cart History";
            lblHistoryTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // colCartId
            // 
            colCartId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCartId.FillWeight = 25F;
            colCartId.HeaderText = "Cart ID";
            colCartId.MinimumWidth = 9;
            colCartId.Name = "colCartId";
            // 
            // colTotalItems
            // 
            colTotalItems.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTotalItems.FillWeight = 25F;
            colTotalItems.HeaderText = "Total Items";
            colTotalItems.MinimumWidth = 9;
            colTotalItems.Name = "colTotalItems";
            // 
            // colCreatedAt
            // 
            colCreatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCreatedAt.FillWeight = 25F;
            colCreatedAt.HeaderText = "Created At";
            colCreatedAt.MinimumWidth = 9;
            colCreatedAt.Name = "colCreatedAt";
            // 
            // colCartStatus
            // 
            colCartStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCartStatus.FillWeight = 25F;
            colCartStatus.HeaderText = "Cart Status";
            colCartStatus.MinimumWidth = 9;
            colCartStatus.Name = "colCartStatus";
            // 
            // flpHistoryButtons
            // 
            flpHistoryButtons.AutoSize = true;
            flpHistoryButtons.Dock = DockStyle.Bottom;
            flpHistoryButtons.Location = new Point(0, 970);
            flpHistoryButtons.Name = "flpHistoryButtons";
            flpHistoryButtons.Padding = new Padding(0, 10, 0, 0);
            flpHistoryButtons.Size = new Size(1368, 10);
            flpHistoryButtons.TabIndex = 2;
            // 
            // btnClearHistory
            // 
            btnClearHistory.BackColor = Color.FromArgb(64, 64, 64);
            btnClearHistory.Cursor = Cursors.Hand;
            btnClearHistory.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearHistory.ForeColor = SystemColors.ControlLight;
            btnClearHistory.Location = new Point(537, 814);
            btnClearHistory.Name = "btnClearHistory";
            btnClearHistory.Size = new Size(300, 100);
            btnClearHistory.TabIndex = 3;
            btnClearHistory.Text = "Clear History";
            btnClearHistory.UseVisualStyleBackColor = false;
            // 
            // pageDetail
            // 
            pageDetail.Controls.Add(tlpDetailButtons);
            pageDetail.Controls.Add(dgvItems);
            pageDetail.Controls.Add(lblDetailTitle);
            pageDetail.Dock = DockStyle.Fill;
            pageDetail.Location = new Point(0, 0);
            pageDetail.Name = "pageDetail";
            pageDetail.Size = new Size(1368, 980);
            pageDetail.TabIndex = 4;
            pageDetail.Visible = false;
            // 
            // lblDetailTitle
            // 
            lblDetailTitle.Dock = DockStyle.Top;
            lblDetailTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailTitle.Location = new Point(0, 0);
            lblDetailTitle.Name = "lblDetailTitle";
            lblDetailTitle.Padding = new Padding(0, 10, 0, 10);
            lblDetailTitle.Size = new Size(1368, 123);
            lblDetailTitle.TabIndex = 0;
            lblDetailTitle.Text = "Cart Detail";
            lblDetailTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colName, colCategory, colQty, colUnit, colNote });
            dgvItems.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvItems.Location = new Point(69, 138);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowHeadersWidth = 72;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(1229, 563);
            dgvItems.TabIndex = 2;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.FillWeight = 20F;
            colName.HeaderText = "Name";
            colName.MinimumWidth = 9;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategory.FillWeight = 20F;
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 9;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colQty.FillWeight = 20F;
            colQty.HeaderText = "Quantity";
            colQty.MinimumWidth = 9;
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUnit.FillWeight = 20F;
            colUnit.HeaderText = "Unit";
            colUnit.MinimumWidth = 9;
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            // 
            // colNote
            // 
            colNote.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNote.FillWeight = 20F;
            colNote.HeaderText = "Note";
            colNote.MinimumWidth = 9;
            colNote.Name = "colNote";
            colNote.ReadOnly = true;
            // 
            // tlpDetailButtons
            // 
            tlpDetailButtons.ColumnCount = 3;
            tlpDetailButtons.ColumnStyles.Add(new ColumnStyle());
            tlpDetailButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDetailButtons.ColumnStyles.Add(new ColumnStyle());
            tlpDetailButtons.Controls.Add(btnBackToHistory, 0, 0);
            tlpDetailButtons.Controls.Add(btnDeleteCart, 2, 0);
            tlpDetailButtons.Dock = DockStyle.Bottom;
            tlpDetailButtons.Location = new Point(0, 805);
            tlpDetailButtons.Name = "tlpDetailButtons";
            tlpDetailButtons.RowCount = 1;
            tlpDetailButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDetailButtons.Size = new Size(1368, 175);
            tlpDetailButtons.TabIndex = 3;
            // 
            // btnBackToHistory
            // 
            btnBackToHistory.BackColor = Color.FromArgb(64, 64, 64);
            btnBackToHistory.Cursor = Cursors.Hand;
            btnBackToHistory.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToHistory.ForeColor = SystemColors.ControlLight;
            btnBackToHistory.Location = new Point(70, 3);
            btnBackToHistory.Margin = new Padding(70, 3, 3, 3);
            btnBackToHistory.Name = "btnBackToHistory";
            btnBackToHistory.Size = new Size(300, 100);
            btnBackToHistory.TabIndex = 0;
            btnBackToHistory.Text = "Back To History";
            btnBackToHistory.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCart
            // 
            btnDeleteCart.BackColor = Color.FromArgb(64, 64, 64);
            btnDeleteCart.Cursor = Cursors.Hand;
            btnDeleteCart.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteCart.ForeColor = SystemColors.ControlLight;
            btnDeleteCart.Location = new Point(998, 3);
            btnDeleteCart.Margin = new Padding(3, 3, 70, 3);
            btnDeleteCart.Name = "btnDeleteCart";
            btnDeleteCart.Size = new Size(300, 100);
            btnDeleteCart.TabIndex = 1;
            btnDeleteCart.Text = "Delete Cart";
            btnDeleteCart.UseVisualStyleBackColor = false;
            // 
            // CartHistoryControl
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpMain);
            Name = "CartHistoryControl";
            Size = new Size(1374, 986);
            tlpMain.ResumeLayout(false);
            pageHost.ResumeLayout(false);
            pageHistory.ResumeLayout(false);
            pageHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarts).EndInit();
            pageDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            tlpDetailButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pageHost;
        private Panel pageHistory;
        private Label lblHistoryTitle;
        private DataGridView dgvCarts;
        private FlowLayoutPanel flpHistoryButtons;
        private DataGridViewTextBoxColumn colCartId;
        private DataGridViewTextBoxColumn colTotalItems;
        private DataGridViewTextBoxColumn colCreatedAt;
        private DataGridViewTextBoxColumn colCartStatus;
        private Button btnClearHistory;
        private Panel pageDetail;
        private Label lblDetailTitle;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colNote;
        private TableLayoutPanel tlpDetailButtons;
        private Button btnBackToHistory;
        private Button btnDeleteCart;
    }
}
