using MyFridgeApp.Models;
using MyFridgeApp.Services;

namespace MyFridgeApp
{
    public partial class MainForm : Form
    {
        private List<Item> items = [];
        private int totalItems;
        public MainForm()
        {
            items = ItemService.GetAllItems();
            totalItems = items.Count;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {

        }

        private void CategoryBtn_Click(object sender, EventArgs e)
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
            int totalItems = 10; // Your List<FoodItem>

            // Draw circle
            using (Pen pen = new Pen(Color.Red, 5))
            {
                e.Graphics.DrawEllipse(pen, 5, 5, TotalItemsPanel.Width - 10, TotalItemsPanel.Height - 10);
            }

            // Draw text in the center
            string text = "About to expire \n" + totalItems.ToString();
            using (Font font = new Font("Arial", 16, FontStyle.Bold))
            using (Brush brush = new SolidBrush(Color.Black))
            {
                SizeF textSize = e.Graphics.MeasureString(text, font);
                float x = (TotalItemsPanel.Width - textSize.Width) / 2;
                float y = (TotalItemsPanel.Height - textSize.Height) / 2;
                e.Graphics.DrawString(text, font, brush, x, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
