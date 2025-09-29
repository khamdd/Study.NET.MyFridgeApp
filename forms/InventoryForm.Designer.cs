namespace MyFridgeApp.forms
{
    partial class InventoryForm
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
            inventorydgv = new DataGridView();
            GoToDashboardBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)inventorydgv).BeginInit();
            SuspendLayout();
            // 
            // inventorydgv
            // 
            inventorydgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventorydgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventorydgv.Location = new Point(142, 44);
            inventorydgv.Name = "inventorydgv";
            inventorydgv.Size = new Size(776, 399);
            inventorydgv.TabIndex = 0;
            inventorydgv.CellContentClick += inventorydgv_CellContentClick;
            // 
            // GoToDashboardBtn
            // 
            GoToDashboardBtn.BackColor = Color.FromArgb(64, 64, 64);
            GoToDashboardBtn.Cursor = Cursors.Hand;
            GoToDashboardBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            GoToDashboardBtn.FlatAppearance.BorderSize = 0;
            GoToDashboardBtn.FlatStyle = FlatStyle.Flat;
            GoToDashboardBtn.Font = new Font("Tahoma", 10F);
            GoToDashboardBtn.ForeColor = SystemColors.Menu;
            GoToDashboardBtn.Location = new Point(212, 476);
            GoToDashboardBtn.Name = "GoToDashboardBtn";
            GoToDashboardBtn.Size = new Size(122, 36);
            GoToDashboardBtn.TabIndex = 5;
            GoToDashboardBtn.Text = "Dashboard";
            GoToDashboardBtn.UseVisualStyleBackColor = false;
            GoToDashboardBtn.Click += GoToDashboardBtn_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(GoToDashboardBtn);
            Controls.Add(inventorydgv);
            Name = "InventoryForm";
            Text = "InventoryForm";
            Load += InventoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)inventorydgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView inventorydgv;
        private Button GoToDashboardBtn;
    }
}