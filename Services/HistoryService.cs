//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using MyFridgeApp.Data;
//using MyFridgeApp.Models;

//namespace MyFridgeApp.Services
//{
//    /// <summary>
//    /// History operations for Items (soft-deleted) and Carts (Ordered/Cleared).
//    /// Keep it minimal and UI-friendly.
//    /// </summary>
//    internal static class HistoryService
//    {
//        // -------------------- Item History (soft delete) --------------------

//        /// <summary>
//        /// Get all soft-deleted items, newest first.
//        /// Bind this to the History (Items) grid.
//        /// </summary>
//        public static async Task<List<Item>> GetDeletedItemsAsync()
//        {
//            using var db = new Context();
//            return await db.Items
//                           .Include(i => i.Category)
//                           .Where(i => i.Status == ItemStatus.Deleted)
//                           .OrderByDescending(i => i.StatusChangedAt) // deleted latest on top
//                           .AsNoTracking()
//                           .ToListAsync();
//        }

//        /// <summary>
//        /// Count soft-deleted items (for a small badge or summary).
//        /// </summary>
//        public static async Task<int> GetDeletedCountAsync()
//        {
//            using var db = new Context();
//            return await db.Items.CountAsync(i => i.Status == ItemStatus.Deleted);
//        }

//        /// <summary>
//        /// Restore one deleted item back to Active.
//        /// </summary>
//        public static async Task<bool> RestoreItemAsync(int itemId)
//        {
//            using var db = new Context();
//            var entity = await db.Items.FirstOrDefaultAsync(i => i.Id == itemId);
//            if (entity == null) return false;

//            if (entity.Status != ItemStatus.Active)
//            {
//                entity.Status = ItemStatus.Active;
//                entity.StatusChangedAt = DateTime.Now;
//                await db.SaveChangesAsync();
//            }
//            return true;
//        }

//        /// <summary>
//        /// Restore many items by ids (bulk restore).
//        /// </summary>
//        public static async Task<int> RestoreItemsAsync(IEnumerable<int> itemIds)
//        {
//            using var db = new Context();
//            var list = await db.Items.Where(i => itemIds.Contains(i.Id)).ToListAsync();
//            foreach (var it in list)
//            {
//                if (it.Status != ItemStatus.Active)
//                {
//                    it.Status = ItemStatus.Active;
//                    it.StatusChangedAt = DateTime.Now;
//                }
//            }
//            return await db.SaveChangesAsync();
//        }

//        /// <summary>
//        /// Permanently delete all soft-deleted items (History -> Clear).
//        /// </summary>
//        public static async Task<int> PurgeAllDeletedItemsAsync()
//        {
//            using var db = new Context();
//            var deleted = await db.Items.Where(i => i.Status == ItemStatus.Deleted).ToListAsync();
//            if (deleted.Count == 0) return 0;

//            db.Items.RemoveRange(deleted);
//            return await db.SaveChangesAsync();
//        }

//        /// <summary>
//        /// Permanently delete selected soft-deleted items.
//        /// </summary>
//        public static async Task<int> PurgeSelectedDeletedItemsAsync(IEnumerable<int> itemIds)
//        {
//            using var db = new Context();
//            var toRemove = await db.Items
//                                   .Where(i => i.Status == ItemStatus.Deleted && itemIds.Contains(i.Id))
//                                   .ToListAsync();
//            if (toRemove.Count == 0) return 0;

//            db.Items.RemoveRange(toRemove);
//            return await db.SaveChangesAsync();
//        }

//        // -------------------- Cart History (Ordered / Cleared) --------------------

//        /// <summary>
//        /// Get carts that are not Open (i.e., Ordered or Cleared), newest first.
//        /// Bind this to an optional Cart History grid.
//        /// </summary>
//        public static async Task<List<Cart>> GetCartHistoryAsync()
//        {
//            using var db = new Context();
//            return await db.Carts
//                           .Where(c => c.Status != CartStatus.Open)
//                           .Include(c => c.Items)
//                           .ThenInclude(ci => ci.Category)
//                           .AsNoTracking()
//                           .OrderByDescending(c => c.CreatedAt)
//                           .ToListAsync();
//        }

//        /// <summary>
//        /// Get a single cart with its items for detail view.
//        /// </summary>
//        public static async Task<Cart?> GetCartByIdAsync(int cartId)
//        {
//            using var db = new Context();
//            return await db.Carts
//                           .Include(c => c.Items)
//                           .ThenInclude(ci => ci.Category)
//                           .AsNoTracking()
//                           .FirstOrDefaultAsync(c => c.Id == cartId);
//        }

//        /// <summary>
//        /// (Optional) Permanently remove a cart from history.
//        /// Use carefully: this deletes the cart and its items.
//        /// </summary>
//        public static async Task<bool> DeleteCartFromHistoryAsync(int cartId)
//        {
//            using var db = new Context();
//            var cart = await db.Carts.Include(c => c.Items)
//                                     .FirstOrDefaultAsync(c => c.Id == cartId && c.Status != CartStatus.Open);
//            if (cart == null) return false;

//            db.Carts.Remove(cart); // cascade removes items
//            await db.SaveChangesAsync();
//            return true;
//        }
//    }
//}
