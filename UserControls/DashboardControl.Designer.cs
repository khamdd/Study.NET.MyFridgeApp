namespace MyFridgeApp.UserControls
{
    partial class DashboardControl
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
            AboutExpiredPanel = new Panel();
            TotalItemsPanel = new Panel();
            AboutExpiredInventoryBtn = new Button();
            GoToInventoryBtn = new Button();
            SuspendLayout();
            // 
            // AboutExpiredPanel
            // 
            AboutExpiredPanel.Location = new Point(470, 126);
            AboutExpiredPanel.Name = "AboutExpiredPanel";
            AboutExpiredPanel.Size = new Size(200, 200);
            AboutExpiredPanel.TabIndex = 10;
            AboutExpiredPanel.Paint += AboutExpiredPanel_Paint;
            // 
            // TotalItemsPanel
            // 
            TotalItemsPanel.Location = new Point(115, 126);
            TotalItemsPanel.Name = "TotalItemsPanel";
            TotalItemsPanel.Size = new Size(200, 200);
            TotalItemsPanel.TabIndex = 9;
            TotalItemsPanel.Paint += TotalItemsPanel_Paint;
            // 
            // AboutExpiredInventoryBtn
            // 
            AboutExpiredInventoryBtn.BackColor = Color.FromArgb(64, 64, 64);
            AboutExpiredInventoryBtn.Cursor = Cursors.Hand;
            AboutExpiredInventoryBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            AboutExpiredInventoryBtn.FlatAppearance.BorderSize = 0;
            AboutExpiredInventoryBtn.FlatStyle = FlatStyle.Flat;
            AboutExpiredInventoryBtn.Font = new Font("Tahoma", 10F);
            AboutExpiredInventoryBtn.ForeColor = SystemColors.Menu;
            AboutExpiredInventoryBtn.Location = new Point(538, 338);
            AboutExpiredInventoryBtn.Name = "AboutExpiredInventoryBtn";
            AboutExpiredInventoryBtn.Size = new Size(71, 36);
            AboutExpiredInventoryBtn.TabIndex = 11;
            AboutExpiredInventoryBtn.Text = "Check";
            AboutExpiredInventoryBtn.UseVisualStyleBackColor = false;
            // 
            // GoToInventoryBtn
            // 
            GoToInventoryBtn.BackColor = Color.FromArgb(64, 64, 64);
            GoToInventoryBtn.Cursor = Cursors.Hand;
            GoToInventoryBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            GoToInventoryBtn.FlatAppearance.BorderSize = 0;
            GoToInventoryBtn.FlatStyle = FlatStyle.Flat;
            GoToInventoryBtn.Font = new Font("Tahoma", 10F);
            GoToInventoryBtn.ForeColor = SystemColors.Menu;
            GoToInventoryBtn.Location = new Point(157, 338);
            GoToInventoryBtn.Name = "GoToInventoryBtn";
            GoToInventoryBtn.Size = new Size(122, 36);
            GoToInventoryBtn.TabIndex = 12;
            GoToInventoryBtn.Text = "Check Inventory";
            GoToInventoryBtn.UseVisualStyleBackColor = false;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AboutExpiredInventoryBtn);
            Controls.Add(GoToInventoryBtn);
            Controls.Add(AboutExpiredPanel);
            Controls.Add(TotalItemsPanel);
            Name = "DashboardControl";
            Size = new Size(784, 501);
            Load += DashboardControl_Load_1;
            ResumeLayout(false);
        }

        #endregion
        private Panel AboutExpiredPanel;
        private Panel TotalItemsPanel;
        private Button AboutExpiredInventoryBtn;
        private Button GoToInventoryBtn;
    }
}
