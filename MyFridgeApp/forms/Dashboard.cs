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

            // Subscribe to Navigation Events
            if (control is ShoppingCartControl sc)
                sc.RequestNavigate += LoadScreen;

            if (control is AddCartItemControl ac)
                ac.RequestNavigate += LoadScreen;

            if (control is DashboardControl dc)
                dc.RequestNavigate += LoadScreen;

            if (control is InventoryControl ic)
                ic.RequestNavigate += LoadScreen;
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
            LoadScreen(new AddNewItemControl());
        }

        private void shoppingBtn_Click(object sender, EventArgs e)
        {
            LoadScreen(new ShoppingCartControl());
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            LoadScreen(new LogControl());
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
