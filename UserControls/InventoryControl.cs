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
        private readonly List<Item>? _providedItems = [];
        public event Action<UserControl>? RequestNavigate;
        public InventoryControl()
        {
            InitializeComponent();
            _providedItems = null;
        }
        public InventoryControl(List<Item> items)
        {
            InitializeComponent();
            _providedItems = items;
        }

        private async void InventoryControl_Load(object sender, EventArgs e)
        {
            // Disable buttons initially
            UpdateBtn.Enabled = false;
            UpdateBtn.BackColor = Color.LightGray;

            // Only allow full row selection
            inventorydgv.MultiSelect = false;
            inventorydgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (_providedItems != null)
            {
                inventoryItems = _providedItems;
            }
            else
            {
                using var context = new Context();
                inventoryItems = await context.Items
                    .Include(i => i.Category)       // eager load Category
                    .AsNoTracking()                 // read-only, prevents disposed context issues
                    .OrderBy(i => i.ExpiryDate)
                    .ThenBy(i => i.Name)
                    .ToListAsync();
            }
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
            cmbSearchBy.Items.Add("Expiring in X Days");
            cmbSearchBy.SelectedIndex = 0; // Default to first item
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string keyword = searchTextbox.Text.Trim().ToLower();
            string field = cmbSearchBy.SelectedItem?.ToString() ?? "Name";

            bool isInt = int.TryParse(keyword, out int daysUntilExpiry);

            if (field == "Expiring in X Days" && !isInt)
            {
                MessageBox.Show("Please enter a valid number of days.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop search
            }
            // Filter items based on selected field
            var filtered = inventoryItems.Where(item =>
            {
                return field switch
                {
                    "Name" => item.Name?.ToLower().Contains(keyword) ?? false,
                    "Category" => item.Category?.Name?.ToLower().Contains(keyword) ?? false,
                    "Notes" => item.Notes?.ToLower().Contains(keyword) ?? false,
                    "Expiring in X Days" => isInt &&
                                 (item.ExpiryDate - DateTime.Now).TotalDays >= 0 &&
                                 (item.ExpiryDate - DateTime.Now).TotalDays <= daysUntilExpiry,
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

        private void inventorydgv_SelectionChanged(object sender, EventArgs e)
        {
            if (inventorydgv.SelectedRows.Count > 0)
            {
                UpdateBtn.Enabled = true;           // enable button
                UpdateBtn.BackColor = Color.Black; // change color when enabled
            }
            else
            {
                UpdateBtn.Enabled = false;          // disable button
                UpdateBtn.BackColor = Color.Gray;   // change color when disabled
            }
        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (inventorydgv.SelectedRows.Count == 0) return;

            // Get selected item Id
            int selectedItemId = (int)inventorydgv.SelectedRows[0].Cells["Id"].Value;
            // Retrieve the item from the database
            using var context = new Context();
            var item = await context.Items
                                    .Include(i => i.Category)
                                    .FirstOrDefaultAsync(i => i.Id == selectedItemId);

            if (item == null)
            {
                MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Navigate to UpdateItemControl
            var updateControl = new AddNewItemControl(item);
            RequestNavigate?.Invoke(updateControl);
        }
    }
}
