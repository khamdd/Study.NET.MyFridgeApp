using Microsoft.EntityFrameworkCore;
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
    public partial class InventoryControl : UserControl
    {
        private List<Item> inventoryItems = [];
        private List<Category> categories = [];
        private readonly ItemService itemService;
        private readonly CategoryService categoryService;
        public InventoryControl()
        {
            InitializeComponent();
            itemService = new();
            categoryService = new();
        }
        private async void InventoryControl_Load(object sender, EventArgs e)
        {
            // Load Inventory
            //inventoryItems = await itemService.GetAllAsync();

            //// Load Categories
            //categories = await categoryService.GetAllAsync();
            //var categoryDict = categories.ToDictionary(c => c.Id, c => c.Name);

            //// Join items with category names for display
            //var itemsWithCategoryName = inventoryItems.Select(item => new
            //{
            //    item.Id,
            //    item.Name,
            //    Category = categoryDict.TryGetValue(item.CategoryId, out string? value) ? value : "Unknown",
            //    item.Quantity,
            //    item.Unit,
            //    item.ImportDate,
            //    item.ExpiryDate,
            //    item.Notes
            //}).ToList();
            using var context = new Context();
            inventoryItems = await context.Items
                .Include(i => i.Category)       // eager load Category
                .AsNoTracking()                 // read-only, prevents disposed context issues
                .OrderBy(i => i.ExpiryDate)
                .ThenBy(i => i.Name)
                .ToListAsync();

            // Map items to display object
            var itemsWithCategoryName = inventoryItems.Select(item => new
            {
                item.Id,
                item.Name,
                Category = item.Category?.Name ?? "Unknown", // directly from navigation property
                item.Quantity,
                item.Unit,
                ImportDate = item.ImportDate.ToString("yyyy-MM-dd"),
                ExpiryDate = item.ExpiryDate.ToString("yyyy-MM-dd"),
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
            string keyword = searchTextbox.Text.Trim().ToLower();
            string field = cmbSearchBy.SelectedItem?.ToString() ?? "Name";

            // Filter items based on selected field
            var filtered = inventoryItems.Where(item =>
            {
                return field switch
                {
                    "Name" => item.Name?.ToLower().Contains(keyword) ?? false,
                    "Category" => item.Category?.Name?.ToLower().Contains(keyword) ?? false,
                    "Notes" => item.Notes?.ToLower().Contains(keyword) ?? false,
                    _ => false
                };
            }).ToList();

            // Map to display object
            var itemsWithCategoryName = filtered.Select(item => new
            {
                item.Id,
                item.Name,
                Category = item.Category?.Name ?? "Unknown",
                item.Quantity,
                item.Unit,
                ImportDate = item.ImportDate.ToString("yyyy-MM-dd"),
                ExpiryDate = item.ExpiryDate.ToString("yyyy-MM-dd"),
                item.Notes
            }).ToList();

            // Refresh DataGridView
            inventorydgv.DataSource = null;
            inventorydgv.DataSource = itemsWithCategoryName;
        }
    }
}
