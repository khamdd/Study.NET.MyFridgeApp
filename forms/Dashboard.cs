using MyFridgeApp.Models;
using MyFridgeApp.Services;
using MyFridgeApp.UserControls;

namespace MyFridgeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadScreen(new DashboardControl());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadScreen(UserControl control)
        {
            if (MainPanel.Controls.Count > 0)
                MainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(control);
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            LoadScreen(new InventoryControl());
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            LoadScreen(new DashboardControl());
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
