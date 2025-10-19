using MyFridgeApp.Models;
using MyFridgeApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyFridgeApp.UserControls
{
    public partial class AddNewItemControl : UserControl
    {
     
        // Local ErrorProvider
        private readonly ErrorProvider _errorProvider = new ErrorProvider();

        private readonly CategoryService _categoryService;
        private readonly ItemService _itemService;
        private readonly HistoryService _historyService;
        private readonly bool _isEditMode;
        private readonly Item? _editingItem;

        public AddNewItemControl()
        {
            InitializeComponent();

            // Initialize services
            _categoryService = new CategoryService();
            _itemService = new ItemService();
            _historyService = new HistoryService();

            // Configure ErrorProvider
            _errorProvider.ContainerControl = this;
            _isEditMode = false;
            _editingItem = null;
        }

        public AddNewItemControl(Item itemToEdit)
        {
            InitializeComponent();

            _categoryService = new CategoryService();
            _itemService = new ItemService();
            _historyService = new HistoryService();
            _errorProvider.ContainerControl = this;

            _isEditMode = true;
            _editingItem = itemToEdit;
        }

        /// <summary>
        /// Load-time initialization: bind category list once the control is about to be shown.
        /// </summary>
        private async void AddNewItemControl_Load(object sender, EventArgs e)
        {
            await LoadCategoriesAsync();

            // If in edit mode, populate fields with existing item data
            if (_isEditMode && _editingItem != null)
            {
                txtName.Text = _editingItem.Name;
                cmbCategory.SelectedValue = _editingItem.CategoryId;
                dtpExpiry.Value = _editingItem.ExpiryDate;
                numQuantity.Value = _editingItem.Quantity;
                txtUnit.Text = _editingItem.Unit;
                txtNotes.Text = _editingItem.Notes;

                btnAdd.Text = "Update Item";  // change button text
            }
        }

        /// <summary>
        /// Asynchronously loads category data and binds it to the ComboBox.
        /// </summary>
        public async Task LoadCategoriesAsync()
        {
            var categories = await _categoryService.GetAllAsync();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.DataSource = categories.ToList();
    
            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;
        }

        /// <summary>
        /// Clears all ErrorProvider messages.
        /// </summary>
        private void ClearErrors()
        {
            _errorProvider.SetError(txtName, string.Empty);
            _errorProvider.SetError(cmbCategory, string.Empty);
            _errorProvider.SetError(numQuantity, string.Empty);
        }


        /// <summary>
        /// Validates user input. Displays inline error icons using ErrorProvider.
        /// </summary>
        /// <returns>True if valid, false otherwise.</returns>
        private bool ValidateInputs()
        {
            bool ok = true;
            ClearErrors();
            // Name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                _errorProvider?.SetError(txtName, "Name is required.");
                ok = false;
            }
            // Category
            if (cmbCategory.SelectedValue is null)
            {
                _errorProvider?.SetError(cmbCategory, "Please select a category.");
                ok = false;
            }
            // Quantity
            if (numQuantity.Value <= 0)
            {
                _errorProvider?.SetError(numQuantity, "Quantity must be greater than 0.");
                ok = false;
            }
            // Unit 
            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                _errorProvider?.SetError(txtUnit, "Unit is required.");
                ok = false;
            }

            return ok;
        }

        /// <summary>
        /// Button click handler: Validates inputs, saves the new item, and resets the form.
        /// </summary>
        private async void btnAdd_Click(object? sender, EventArgs e)
        {
           
            if (!ValidateInputs()) return;

            //var item = new Item
            //{
            //    Name = txtName.Text.Trim(),
            //    CategoryId = (int)cmbCategory.SelectedValue!,
            //    ImportDate = DateTime.Today,              
            //    ExpiryDate = dtpExpiry.Value.Date,
            //    Quantity = (int)numQuantity.Value,
            //    Unit = txtUnit.Text.Trim(),
            //    Notes = txtNotes.Text.Trim(),
            //    Status = ItemStatus.Active
            //};

            // Try to save the item via ItemService
            try
            {
                if (_isEditMode && _editingItem != null)
                {
                    // Update existing item
                    _editingItem.Name = txtName.Text.Trim();
                    _editingItem.CategoryId = (int)cmbCategory.SelectedValue!;
                    _editingItem.ExpiryDate = dtpExpiry.Value.Date;
                    _editingItem.Quantity = (int)numQuantity.Value;
                    _editingItem.Unit = txtUnit.Text.Trim();
                    _editingItem.Notes = txtNotes.Text.Trim();

                    await _itemService.UpdateAsync(_editingItem);
                    _historyService.RecordAction($"Updated item: {_editingItem.Name}", DateTime.Now);



                    MessageBox.Show("Item updated successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Add new item
                    var item = new Item
                    {
                        Name = txtName.Text.Trim(),
                        CategoryId = (int)cmbCategory.SelectedValue!,
                        ImportDate = DateTime.Today,
                        ExpiryDate = dtpExpiry.Value.Date,
                        Quantity = (int)numQuantity.Value,
                        Unit = txtUnit.Text.Trim(),
                        Notes = txtNotes.Text.Trim(),
                        Status = ItemStatus.Active
                    };

                    await _itemService.CreateAsync(item);
                    _historyService.RecordAction($"Added item: {item.Name}", DateTime.Now);

                    MessageBox.Show("Item saved successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetForm();
                }
                // Use your actual service method name (CreateAsync or Add)
                //await _itemService.CreateAsync(item);
                //_historyService.RecordAction($"Added item: {item.Name}", DateTime.Now);

                //MessageBox.Show("Item saved successfully.", "Success",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //ResetForm(); // Clear the form after successful save
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save item.\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Resets all fields to default state.
        /// </summary>
        public void ResetForm()
        {
            txtName.Clear();
            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
            dtpExpiry.Value = DateTime.Today;
            numQuantity.Value = 1;
            txtUnit.Clear();
            txtNotes.Clear();
            ClearErrors();
            txtName.Focus();
        }
    }
}

