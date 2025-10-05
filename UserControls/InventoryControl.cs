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
    public partial class InventoryControl : UserControl
    {
        private List<Item> inventoryItems = [];
        private List<Category> categories = [];
        public InventoryControl()
        {
            InitializeComponent();
        }
        private void InventoryControl_Load(object sender, EventArgs e)
        {
            // Load Inventory
            ItemService itemService = new();
            inventoryItems = itemService.GetAllItems();

            // Load Categories
            CategoryService categoryService = new();
            categories = categoryService.GetAllCategories();
            var categoryDict = categories.ToDictionary(c => c.Id, c => c.Name);

            // Join items with category names for display
            var itemsWithCategoryName = inventoryItems.Select(item => new
            {
                item.Id,
                item.Name,
                Category = categoryDict.TryGetValue(item.CategoryId, out string? value) ? value : "Unknown",
                item.Quantity,
                item.Unit,
                item.ImportDate,
                item.ExpiryDate,
                item.Notes
            }).ToList();

            // Bind to DataGridView
            inventorydgv.DataSource = itemsWithCategoryName;

            // Load Search ComboBox
            cmbSearchBy.Items.Add("Name");
            cmbSearchBy.Items.Add("Category");
            cmbSearchBy.Items.Add("Notes");
            cmbSearchBy.SelectedIndex = 0; // Default to first item
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string keyword = searchTextbox.Text.ToLower();
            string field = cmbSearchBy.SelectedItem.ToString();
            var categoryDict = categories.ToDictionary(c => c.Id, c => c.Name);

            var filtered = inventoryItems.Where(item =>
            {
                return field switch
                {
                    "Name" => item.Name.ToLower().Contains(keyword),
                    "Category" => categoryDict.TryGetValue(item.CategoryId, out string? catName)
                          && catName.ToLower().Contains(keyword),
                    "Notes" => item.Notes.ToLower().Contains(keyword),
                    _ => false
                };
            }).ToList();

            var itemsWithCategoryName = filtered.Select(item => new
            {
                item.Id,
                item.Name,
                Category = categoryDict.TryGetValue(item.CategoryId, out string? value) ? value : "Unknown",
                item.Quantity,
                item.Unit,
                item.ImportDate,
                item.ExpiryDate,
                item.Notes
            }).ToList();

            inventorydgv.DataSource = null;
            inventorydgv.DataSource = itemsWithCategoryName;
        }
    }
}
