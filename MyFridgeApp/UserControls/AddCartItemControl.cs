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
    public partial class AddCartItemControl : UserControl
    {
        /// <summary>
        /// Child-to-parent navigation event. MainForm subscribes and switches pages.
        /// </summary>
        public event Action<UserControl>? RequestNavigate;

        private readonly ErrorProvider _errorProvider;
        private readonly CategoryService _categoryService;
        private readonly CartService _cartService;

        // Null → create mode; Non-null → edit mode
        private int? _editingCartItemId = null;

        public AddCartItemControl()
        {
            InitializeComponent();

            // Initialize services
            _errorProvider = new ErrorProvider();
            _categoryService = new CategoryService();
            _cartService = new CartService();

            // Configure ErrorProvider
            _errorProvider.ContainerControl = this;
        }

        /// <summary>
        /// Pre-fill fields for edit mode. Call this BEFORE showing this control.
        /// CategoryId is stored temporarily in ComboBox.Tag and applied after binding.
        /// </summary>
        internal void LoadForEdit(CartItem item)
        {
            _editingCartItemId = item.Id;

            txtName.Text = item.Name;
            numQuantity.Value = Math.Max(1, item.Quantity);
            txtUnit.Text = item.Unit;
            txtNotes.Text = item.Notes ?? string.Empty;

            // Category binding happens on Load; stash id here and apply after data is bound
            cmbCategory.Tag = item.CategoryId;

            lblTitle.Text = "Edit";
            btnSave.Text = "Save";
        }

        /// <summary>
        /// Load-time initialization: bind categories list.
        /// </summary>
        private async void AddCartItemControl_Load(object sender, EventArgs e)
        {
            var categories = await _categoryService.GetAllAsync();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.DataSource = categories;

            // Apply edit-mode CategoryId after binding
            if (cmbCategory.Tag is int cid)
            {
                cmbCategory.SelectedValue = cid;
                cmbCategory.Tag = null;
            }
            else if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }
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
        /// Save (create or update) then navigate back to ShoppingCartControl.
        /// </summary>
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var Cartitem = new CartItem
            {
                Name = txtName.Text.Trim(),
                CategoryId = (int)cmbCategory.SelectedValue!,
                Quantity = (int)numQuantity.Value,
                Unit = txtUnit.Text.Trim(),
                Notes = txtNotes.Text.Trim(),
            };
            try
            {
                if (_editingCartItemId.HasValue)
                {
                    // ---- Edit mode ----
                    await _cartService.UpdateCartItemAsync(
                        _editingCartItemId.Value,
                        Cartitem.Name,
                        Cartitem.CategoryId,
                        Cartitem.Quantity,
                        Cartitem.Unit,
                        string.IsNullOrWhiteSpace(Cartitem.Notes) ? null : Cartitem.Notes);

                    MessageBox.Show("Cart item updated.", "Save",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Back to cart page
                    RequestNavigate?.Invoke(new ShoppingCartControl());
                    return;
                }

                // ---- Create mode ----
                await _cartService.AddToCartAsync(
                    Cartitem.Name,
                    Cartitem.CategoryId,
                    Cartitem.Quantity,
                    Cartitem.Unit,
                    string.IsNullOrWhiteSpace(Cartitem.Notes) ? null : Cartitem.Notes);

                var dialog = MessageBox.Show(
                    "Added to cart successfully.\nDo you want to add another item?",
                    "Success",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    // Continue adding: clear most fields but keep Category & Unit for faster input
                    ResetForm();
                    return;
                }

                // No → back to cart
                RequestNavigate?.Invoke(new ShoppingCartControl());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save.\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cancel and go back to ShoppingCartControl without saving.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            RequestNavigate?.Invoke(new ShoppingCartControl());
        }

        /// <summary>
        /// Resets all fields to default state.
        /// </summary>
        public void ResetForm()
        {
            txtName.Clear();
            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
            numQuantity.Value = 1;
            txtUnit.Clear();
            txtNotes.Clear();
            ClearErrors();
            txtName.Focus();
        }
    }
}
