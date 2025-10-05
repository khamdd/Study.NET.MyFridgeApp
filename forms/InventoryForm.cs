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

namespace MyFridgeApp.forms
{
    public partial class InventoryForm : Form
    {
        private List<Item> inventoryItems = [];
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            ItemService itemService = new();
            inventoryItems = itemService.GetAllItems();
            inventorydgv.DataSource = inventoryItems;
        }

        private void GoToDashboardBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new();
            this.Hide();
            mainForm.FormClosed += (s, args) => this.Close(); // close dashboard too
            mainForm.Show();
        }

        private void inventorydgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
            }   
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
