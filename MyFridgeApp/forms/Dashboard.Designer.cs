﻿namespace MyFridgeApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeaderPanel = new Panel();
            AppNameLabel = new Label();
            sidebarPanel = new Panel();
            logBtn = new Button();
            shoppingBtn = new Button();
            ExitBtn = new Button();
            DashboardBtn = new Button();
            InventoryBtn = new Button();
            MenuLabel = new Label();
            AddItemBtn = new Button();
            MainPanel = new Panel();
            HeaderPanel.SuspendLayout();
            sidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = SystemColors.Window;
            HeaderPanel.Controls.Add(AppNameLabel);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(200, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(784, 60);
            HeaderPanel.TabIndex = 0;
            // 
            // AppNameLabel
            // 
            AppNameLabel.AutoSize = true;
            AppNameLabel.Cursor = Cursors.Hand;
            AppNameLabel.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppNameLabel.Location = new Point(6, 9);
            AppNameLabel.Name = "AppNameLabel";
            AppNameLabel.Size = new Size(224, 35);
            AppNameLabel.TabIndex = 0;
            AppNameLabel.Text = "My Fridge App";
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(64, 64, 64);
            sidebarPanel.Controls.Add(logBtn);
            sidebarPanel.Controls.Add(shoppingBtn);
            sidebarPanel.Controls.Add(ExitBtn);
            sidebarPanel.Controls.Add(DashboardBtn);
            sidebarPanel.Controls.Add(InventoryBtn);
            sidebarPanel.Controls.Add(MenuLabel);
            sidebarPanel.Controls.Add(AddItemBtn);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(200, 561);
            sidebarPanel.TabIndex = 1;
            // 
            // logBtn
            // 
            logBtn.BackColor = Color.FromArgb(64, 64, 64);
            logBtn.Cursor = Cursors.Hand;
            logBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            logBtn.FlatAppearance.BorderSize = 0;
            logBtn.FlatStyle = FlatStyle.Flat;
            logBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logBtn.ForeColor = SystemColors.Menu;
            logBtn.Location = new Point(12, 399);
            logBtn.Name = "logBtn";
            logBtn.Size = new Size(164, 36);
            logBtn.TabIndex = 7;
            logBtn.Text = "Log";
            logBtn.UseVisualStyleBackColor = false;
            logBtn.Click += logBtn_Click;
            // 
            // shoppingBtn
            // 
            shoppingBtn.BackColor = Color.FromArgb(64, 64, 64);
            shoppingBtn.Cursor = Cursors.Hand;
            shoppingBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            shoppingBtn.FlatAppearance.BorderSize = 0;
            shoppingBtn.FlatStyle = FlatStyle.Flat;
            shoppingBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shoppingBtn.ForeColor = SystemColors.Menu;
            shoppingBtn.Location = new Point(12, 342);
            shoppingBtn.Name = "shoppingBtn";
            shoppingBtn.Size = new Size(164, 36);
            shoppingBtn.TabIndex = 6;
            shoppingBtn.Text = "Shopping";
            shoppingBtn.UseVisualStyleBackColor = false;
            shoppingBtn.Click += shoppingBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.FromArgb(64, 64, 64);
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitBtn.ForeColor = SystemColors.Menu;
            ExitBtn.Location = new Point(12, 453);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(164, 36);
            ExitBtn.TabIndex = 5;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // DashboardBtn
            // 
            DashboardBtn.BackColor = Color.FromArgb(64, 64, 64);
            DashboardBtn.Cursor = Cursors.Hand;
            DashboardBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            DashboardBtn.FlatAppearance.BorderSize = 0;
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DashboardBtn.ForeColor = SystemColors.Menu;
            DashboardBtn.Location = new Point(12, 160);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(164, 36);
            DashboardBtn.TabIndex = 4;
            DashboardBtn.Text = "Dashboard";
            DashboardBtn.UseVisualStyleBackColor = false;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // InventoryBtn
            // 
            InventoryBtn.BackColor = Color.FromArgb(64, 64, 64);
            InventoryBtn.Cursor = Cursors.Hand;
            InventoryBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            InventoryBtn.FlatAppearance.BorderSize = 0;
            InventoryBtn.FlatStyle = FlatStyle.Flat;
            InventoryBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InventoryBtn.ForeColor = SystemColors.Menu;
            InventoryBtn.Location = new Point(12, 217);
            InventoryBtn.Name = "InventoryBtn";
            InventoryBtn.Size = new Size(164, 36);
            InventoryBtn.TabIndex = 3;
            InventoryBtn.Text = "Inventory";
            InventoryBtn.UseVisualStyleBackColor = false;
            InventoryBtn.Click += InventoryBtn_Click;
            // 
            // MenuLabel
            // 
            MenuLabel.AutoSize = true;
            MenuLabel.BackColor = Color.FromArgb(64, 64, 64);
            MenuLabel.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuLabel.ForeColor = SystemColors.Menu;
            MenuLabel.Location = new Point(12, 100);
            MenuLabel.Name = "MenuLabel";
            MenuLabel.Size = new Size(69, 25);
            MenuLabel.TabIndex = 1;
            MenuLabel.Text = "Menu";
            // 
            // AddItemBtn
            // 
            AddItemBtn.BackColor = Color.FromArgb(64, 64, 64);
            AddItemBtn.Cursor = Cursors.Hand;
            AddItemBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            AddItemBtn.FlatAppearance.BorderSize = 0;
            AddItemBtn.FlatStyle = FlatStyle.Flat;
            AddItemBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddItemBtn.ForeColor = SystemColors.Menu;
            AddItemBtn.Location = new Point(12, 276);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(164, 36);
            AddItemBtn.TabIndex = 0;
            AddItemBtn.Text = "Add New Item";
            AddItemBtn.UseVisualStyleBackColor = false;
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(200, 60);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(784, 501);
            MainPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(984, 561);
            Controls.Add(MainPanel);
            Controls.Add(HeaderPanel);
            Controls.Add(sidebarPanel);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private Panel sidebarPanel;
        private Label AppNameLabel;
        private Button AddItemBtn;
        private Label MenuLabel;
        private Button InventoryBtn;
        private Button ExitBtn;
        private Button DashboardBtn;
        private Panel MainPanel;
        private Button logBtn;
        private Button shoppingBtn;
    }
}
