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
    public partial class ShoppingCartControl : UserControl
    {
        /// <summary>
        /// Navigation event (child -> MainForm).
        /// MainForm subscribes to this and calls its private LoadScreen(UserControl).
        /// </summary>
        public event Action<UserControl>? RequestNavigate;

        private readonly CartService _cartService;
        private readonly BindingSource _bs;
        public ShoppingCartControl()
        {
            InitializeComponent();

            _cartService = new CartService();
            _bs = new BindingSource();
        }

        /// <summary>
        /// Load-time initialization: bind the grid to the BindingSource and fetch data.
        /// Designer: wire control's Load event to this method.
        /// </summary>
        private async void ShoppingCartControl_Load(object sender, EventArgs e)
        {
            dgvCart.DataSource = _bs;

            await ReloadAsync();
        }

        /// <summary>
        /// Fetch open-cart items, project to anonymous rows (flat), and bind.
        /// </summary>
        private async Task ReloadAsync()
        {
            var items = await _cartService.GetOpenCartItemsAsync();

            var rows = items.Select(it => new
            {
                Id = it.Id,
                Name = it.Name,
                Category = it.Category?.Name ?? "Unknown",
                Quantity = it.Quantity,
                Unit = it.Unit,
                Notes = it.Notes
            }).ToList();

            _bs.DataSource = rows; 
        }

        /// <summary>
        /// Navigate to "Add cart item" page (create mode).
        /// </summary>
        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            RequestNavigate?.Invoke(new AddCartItemControl());
        }
        /// <summary>
        /// Place current open cart as Ordered and show success message.
        /// </summary>
        private async void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (_bs.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "Place Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            await _cartService.PlaceOrderAsync();

            MessageBox.Show("Order placed successfully.", "Place Order",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            await ReloadAsync();
        }

        /// <summary>
        /// Clear all items from the current open cart.
        /// </summary>
        private async void btnClearCart_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Clear all items in the cart?",
                "Clear Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            await _cartService.ClearOpenCartAsync();

            await ReloadAsync();
        }

        /// <summary>
        /// Handle Edit/Delete button clicks in the grid.
        /// Wire in designer: dgvCart.CellContentClick → dgvCart_CellContentClick
        /// </summary>
        private async void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header

            var column = dgvCart.Columns[e.ColumnIndex];
            var bound = dgvCart.Rows[e.RowIndex].DataBoundItem;
            if (bound is null) return;

            // Anonymous type: read Id by reflection
            var idProp = bound.GetType().GetProperty("Id");
            if (idProp is null) return;

            int cartItemId = (int)idProp.GetValue(bound)!;

            // Edit
            if (column == colEdit)
            {
                var item = await _cartService.GetCartItemByIdAsync(cartItemId);
                if (item is null)
                {
                    MessageBox.Show("This cart item no longer exists.", "Edit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    await ReloadAsync();
                    return;
                }

                var editor = new AddCartItemControl();
                editor.LoadForEdit(item);
                RequestNavigate?.Invoke(editor);
            }
            // Delete
            else if (column == colDelete)
            {
                var confirm = MessageBox.Show("Delete this item?",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes) return;

                await _cartService.DeleteCartItemAsync(cartItemId);

                // Simplest: reload once. For fewer DB calls, you could remove from _bs and ResetBindings.
                await ReloadAsync();
            }
        }
    }
}
