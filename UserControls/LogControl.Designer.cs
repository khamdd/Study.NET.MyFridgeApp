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
            // LogControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Logdgv);
            Name = "LogControl";
            Size = new Size(784, 501);
            Load += LogControl_Load;
            ((System.ComponentModel.ISupportInitialize)Logdgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Logdgv;
    }
}
