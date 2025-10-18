namespace MyFridgeApp.UserControls
{
    partial class LogControl
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
            Logdgv = new DataGridView();
            RemoveLogBtn = new Button();
            ClearLogsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Logdgv).BeginInit();
            SuspendLayout();
            // 
            // Logdgv
            // 
            Logdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Logdgv.Dock = DockStyle.Top;
            Logdgv.Location = new Point(0, 0);
            Logdgv.Name = "Logdgv";
            Logdgv.Size = new Size(784, 355);
            Logdgv.TabIndex = 0;
            Logdgv.CellContentClick += Logdgv_CellContentClick;
            // 
            // RemoveLogBtn
            // 
            RemoveLogBtn.BackColor = Color.FromArgb(64, 64, 64);
            RemoveLogBtn.Cursor = Cursors.Hand;
            RemoveLogBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            RemoveLogBtn.FlatAppearance.BorderSize = 0;
            RemoveLogBtn.FlatStyle = FlatStyle.Flat;
            RemoveLogBtn.Font = new Font("Tahoma", 10F);
            RemoveLogBtn.ForeColor = SystemColors.Menu;
            RemoveLogBtn.Location = new Point(235, 409);
            RemoveLogBtn.Name = "RemoveLogBtn";
            RemoveLogBtn.Size = new Size(71, 36);
            RemoveLogBtn.TabIndex = 13;
            RemoveLogBtn.Text = "Remove";
            RemoveLogBtn.UseVisualStyleBackColor = false;
            RemoveLogBtn.Click += RemoveLogBtn_Click;
            // 
            // ClearLogsBtn
            // 
            ClearLogsBtn.BackColor = Color.FromArgb(64, 64, 64);
            ClearLogsBtn.Cursor = Cursors.Hand;
            ClearLogsBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            ClearLogsBtn.FlatAppearance.BorderSize = 0;
            ClearLogsBtn.FlatStyle = FlatStyle.Flat;
            ClearLogsBtn.Font = new Font("Tahoma", 10F);
            ClearLogsBtn.ForeColor = SystemColors.Menu;
            ClearLogsBtn.Location = new Point(458, 409);
            ClearLogsBtn.Name = "ClearLogsBtn";
            ClearLogsBtn.Size = new Size(110, 36);
            ClearLogsBtn.TabIndex = 14;
            ClearLogsBtn.Text = "Clear All Logs";
            ClearLogsBtn.UseVisualStyleBackColor = false;
            ClearLogsBtn.Click += ClearLogsBtn_Click;
            // 
            // LogControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClearLogsBtn);
            Controls.Add(RemoveLogBtn);
            Controls.Add(Logdgv);
            Name = "LogControl";
            Size = new Size(784, 501);
            Load += LogControl_Load;
            ((System.ComponentModel.ISupportInitialize)Logdgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Logdgv;
        private Button RemoveLogBtn;
        private Button ClearLogsBtn;
    }
}
