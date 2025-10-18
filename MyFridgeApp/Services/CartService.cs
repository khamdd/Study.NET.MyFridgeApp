using Microsoft.EntityFrameworkCore;
using MyFridgeApp.Data;
using MyFridgeApp.Interfaces;
using MyFridgeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFridgeApp.Services
{
    internal class CartService : ICartService
    {
        /// <summary>
        /// Ensure there is exactly one Open cart; create if none.
        /// </summary>
        private static async Task<Cart> EnsureOpenCartAsync(Context context)
        {
            // Prefer the latest open cart if (unexpectedly) multiple exist.
            var open = await context.Carts
                .Where(c => c.Status == CartStatus.Open)
                .OrderByDescending(c => c.Id)
                .FirstOrDefaultAsync();

            if (open == null)
            {
                open = new Cart
                {
                    Status = CartStatus.Open,
                };
                context.Carts.Add(open);
                await context.SaveChangesAsync();
            }
            return open;
        }

        // ----------------------- open cart ----------------------------------

        /// <summary>
        /// Get all items in the current open cart.
        /// If no open cart exists, a new one will be created automatically.
        /// </summary>
        public async Task<List<CartItem>> GetOpenCartItemsAsync()
        {
            using var context = new Context();

            var open = await EnsureOpenCartAsync(context);

            return await context.CartItems
                .Where(i => i.CartId == open.Id)
                .Include(i => i.Category)
                .AsNoTracking()
                .OrderBy(i => i.Name)
                .ToListAsync();
        }

        // <summary>
        /// Get a single cart item by its Id from the current open cart.
        /// </summary>
        public async Task<CartItem?> GetCartItemByIdAsync(int cartItemId)
        {
            using var context = new Context();

            return await context.CartItems
                .Include(i => i.Category)
                .FirstOrDefaultAsync(i => i.Id == cartItemId);
        }

        /// <summary>
        /// Add a new item to the current open cart.
        /// If no open cart exists, it will be created automatically.
        /// </summary>
        public async Task AddToCartAsync(string name, int categoryId, int quantity, string unit, string? notes)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is required.", nameof(name));
            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be greater than 0.");

            using var context = new Context();

            var open = await EnsureOpenCartAsync(context);

            // Validate category existence
            var category = await context.Categories.FindAsync(categoryId);
            if (category == null)
                throw new InvalidOperationException("Category not found.");

            var item = new CartItem
            {
                CartId = open.Id,
                Name = name.Trim(),
                CategoryId = categoryId,
                Quantity = quantity,
                Unit = (unit ?? string.Empty).Trim(),
                Notes = string.IsNullOrWhiteSpace(notes) ? string.Empty : notes!.Trim()
            };

            context.CartItems.Add(item);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Update an existing item in the current open cart.
        /// </summary>
        public async Task UpdateCartItemAsync(int cartItemId, string name, int categoryId, int quantity, string unit, string? notes)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is required.", nameof(name));
            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be greater than 0.");

            using var context = new Context();

            var ci = await context.CartItems.FirstOrDefaultAsync(i => i.Id == cartItemId);
            if (ci == null)
                throw new InvalidOperationException("Cart item not found.");

            // Validate category existence
            var category = await context.Categories.FindAsync(categoryId);
            if (category == null)
                throw new InvalidOperationException("Category not found.");

            ci.Name = name.Trim();
            ci.CategoryId = categoryId;
            ci.Quantity = quantity;
            ci.Unit = (unit ?? string.Empty).Trim();
            ci.Notes = string.IsNullOrWhiteSpace(notes) ? string.Empty : notes!.Trim();

            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete a specific item from the current open cart.
        /// </summary>
        /// <param name="cartItemId">The ID of the cart item to delete.</param>
        public async Task DeleteCartItemAsync(int cartItemId)
        {
            using var context = new Context();

            var ci = await context.CartItems.FirstOrDefaultAsync(i => i.Id == cartItemId);
            if (ci != null)
            {
                context.CartItems.Remove(ci);
                await context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Clear the current open cart and delete all its items.
        /// </summary>
        public async Task ClearOpenCartAsync()
        {
            using var context = new Context();

            var open = await context.Carts
                .Include(c => c.Items)
                .FirstOrDefaultAsync(c => c.Status == CartStatus.Open);

            if (open == null) return;

            context.Carts.Remove(open);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Place an order by marking the current open cart as Ordered.
        /// After placing an order, a new cart will be created on the next add.
        /// </summary>
        public async Task PlaceOrderAsync()
        {
            using var context = new Context();

            var open = await context.Carts.FirstOrDefaultAsync(c => c.Status == CartStatus.Open);
            if (open == null) return;

            open.Status = CartStatus.Ordered;
            open.PlacedAt = DateTime.Now;
            await context.SaveChangesAsync();
        }

        // ---------------------Cart History -----------------------------

        /// <summary>
        /// Get all carts that have been placed (status = Ordered).
        /// Ordered by CreatedAt descending.
        /// </summary>
        //public async Task<List<Cart>> GetOrderedCartsAsync()
        //{
        //    using var context = new Context();

        //    return await context.Carts
        //        .Where(c => c.Status == CartStatus.Ordered)
        //        .AsNoTracking()
        //        .OrderByDescending(c => c.PlacedAt)
        //        .ToListAsync();
        //}

        /// <summary>
        /// Get all items for a specific ordered cart.
        /// </summary>
        //public async Task<List<CartItem>> GetCartItemsByCartIdAsync(int cartId)
        //{
        //    using var context = new Context();

        //    return await context.CartItems
        //        .Where(i => i.CartId == cartId)
        //        .Include(i => i.Category)
        //        .AsNoTracking()
        //        .OrderBy(i => i.Name)
        //        .ToListAsync();
        //}

        /// <summary>
        /// Delete a specific ordered cart and all its items from the database.
        /// </summary>
        //public async Task DeleteOrderedCartAsync(int cartId)
        //{
        //    using var context = new Context();

        //    var cart = await context.Carts
        //        .FirstOrDefaultAsync(c => c.Id == cartId && c.Status == CartStatus.Ordered);

        //    if (cart == null) return;

        //    context.Carts.Remove(cart);
        //    await context.SaveChangesAsync();
        //}

        /// <summary>
        /// Delete all ordered carts (clear all history).
        /// </summary>
        //public async Task ClearAllOrderedCartsAsync()
        //{
        //    using var context = new Context();

        //    var ordered = await context.Carts
        //        .Where(c => c.Status == CartStatus.Ordered)
        //        .ToListAsync();

        //    if (ordered.Count == 0) return;

        //    context.Carts.RemoveRange(ordered);
        //    await context.SaveChangesAsync();
        //}
    }
}
