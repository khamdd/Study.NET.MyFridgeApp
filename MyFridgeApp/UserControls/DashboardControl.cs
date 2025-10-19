using MyFridgeApp.Data;
using MyFridgeApp.Models;
using MyFridgeApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFridgeApp.UserControls
{
    public partial class DashboardControl : UserControl
    {
        private List<Item> items = [];
        private int totalItems;
        private readonly ItemService itemService;
        public event Action<UserControl>? RequestNavigate;
        private int daysThreshold = 5; // Define "about to expire" as within the next 5 days
        private int aboutExpireItemCount = 0;
        public DashboardControl()
        {
            InitializeComponent();
            itemService = new();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TotalItemsPanel_Paint(object sender, PaintEventArgs e)
        {
            // Draw circle
            using (Pen pen = new Pen(Color.Green, 5))
            {
                e.Graphics.DrawEllipse(pen, 5, 5, TotalItemsPanel.Width - 10, TotalItemsPanel.Height - 10);
            }

            // Draw text in the center
            string text = "Total Items \n" + totalItems.ToString();
            using (Font font = new Font("Arial", 16, FontStyle.Bold))
            using (Brush brush = new SolidBrush(Color.Black))
            {
                SizeF textSize = e.Graphics.MeasureString(text, font);
                float x = (TotalItemsPanel.Width - textSize.Width) / 2;
                float y = (TotalItemsPanel.Height - textSize.Height) / 2;
                e.Graphics.DrawString(text, font, brush, x, y);
            }
        }

        private void AboutExpiredPanel_Paint(object sender, PaintEventArgs e)
        {
            // Draw circle
            using (Pen pen = new Pen(Color.Red, 5))
            {
                e.Graphics.DrawEllipse(pen, 5, 5, TotalItemsPanel.Width - 10, TotalItemsPanel.Height - 10);
            }

            // Draw text in the center
            string text = "About to expire \n" + aboutExpireItemCount.ToString();
            using (Font font = new Font("Arial", 16, FontStyle.Bold))
            using (Brush brush = new SolidBrush(Color.Black))
            {
                SizeF textSize = e.Graphics.MeasureString(text, font);
                float x = (TotalItemsPanel.Width - textSize.Width) / 2;
                float y = (TotalItemsPanel.Height - textSize.Height) / 2;
                e.Graphics.DrawString(text, font, brush, x, y);
            }
        }

        private async void DashboardControl_Load_1(object sender, EventArgs e)
        {
            items = await itemService.GetAllAsync();
            totalItems = items.Count;
            aboutExpireItemCount = items.Count(i => (i.ExpiryDate - DateTime.Now).TotalDays <= daysThreshold && i.Status == ItemStatus.Active && i.ExpiryDate >= DateTime.Now);
        }

        private void GoToInventoryBtn_Click(object sender, EventArgs e)
        {
            var inventoryControl = new InventoryControl();
            RequestNavigate?.Invoke(inventoryControl);
        }

        private async void AboutExpiredInventoryBtn_Click(object sender, EventArgs e)
        {
            int daysThreshold = 5; // Define "about to expire" as within the next 5 days
            List<Item> items = await itemService.GetExpiringSoonAsync(daysThreshold);

            var inventoryControl = new InventoryControl(items);
            RequestNavigate?.Invoke(inventoryControl);
        }
    }
}
