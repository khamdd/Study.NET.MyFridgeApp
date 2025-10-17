using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFridgeApp.Data;
using MyFridgeApp.Interfaces;
using MyFridgeApp.Models;

namespace MyFridgeApp.Services
{
    /// <summary>
    /// Item operations backed by EF Core.
    /// Keep it simple: create a fresh AppDbContext per call.
    /// </summary>
    internal class ItemService : IItemService
    {
        public ItemService()
        {
        }
        // ---------- Query ----------

        /// <summary>
        /// Get all items. By default returns only Active (soft-delete filtered).
        /// </summary>
        public async Task<List<Item>> GetAllAsync(bool includeDeleted = false)
        {
            using var context = new Context();
            context.Database.EnsureCreated();
            var q = context.Items
                        .Include(i => i.Category)
                        .AsNoTracking();

            if (!includeDeleted)
                q = q.Where(i => i.Status == ItemStatus.Active);

            return await q.OrderBy(i => i.ExpiryDate)
                            .ThenBy(i => i.Name)
                            .ToListAsync();
            
        }

        /// <summary>
        /// Get a single item by id (includes Category).
        /// </summary>
        public async Task<Item?> GetByIdAsync(int id)
        {
            using var context = new Context();
            return await context.Items
                           .Include(i => i.Category)
                           .FirstOrDefaultAsync(i => i.Id == id);
        }

        /// <summary>
        /// Search by name (contains), optional category, optional date range, and includeDeleted.
        /// </summary>
        public async Task<List<Item>> SearchAsync(
            string? name = null,
            int? categoryId = null,
            DateTime? importFrom = null,
            DateTime? importTo = null,
            DateTime? expireFrom = null,
            DateTime? expireTo = null,
            bool includeDeleted = false
            )
        {
            using var context = new Context();
            var q = context.Items.Include(i => i.Category).AsQueryable();

            if (!includeDeleted)
                q = q.Where(i => i.Status == ItemStatus.Active);

            if (!string.IsNullOrWhiteSpace(name))
                q = q.Where(i => i.Name.Contains(name));

            if (categoryId.HasValue)
                q = q.Where(i => i.CategoryId == categoryId.Value);

            if (importFrom.HasValue)
                q = q.Where(i => i.ImportDate >= importFrom.Value);

            if (importTo.HasValue)
                q = q.Where(i => i.ImportDate <= importTo.Value);

            if (expireFrom.HasValue)
                q = q.Where(i => i.ExpiryDate >= expireFrom.Value);

            if (expireTo.HasValue)
                q = q.Where(i => i.ExpiryDate <= expireTo.Value);

            return await q.AsNoTracking()
                          .OrderBy(i => i.ExpiryDate)
                          .ThenBy(i => i.Name)
                          .ToListAsync();
        }

        /// <summary>
        /// Items that will expire within the next N days (Active only).
        /// </summary>
        public async Task<List<Item>> GetExpiringSoonAsync(int days)
        {
            var today = DateTime.Today;
            var until = today.AddDays(days);
            using var context = new Context();
            return await context.Items
                           .Include(i => i.Category)
                           .Where(i => i.Status == ItemStatus.Active &&
                                       i.ExpiryDate >= today &&
                                       i.ExpiryDate <= until)
                           .AsNoTracking()
                           .OrderBy(i => i.ExpiryDate)
                           .ToListAsync();
        }

        // ---------- Commands ----------

        /// <summary>
        /// Create a new item. ImportDate defaults to today if unspecified.
        /// </summary>
        public async Task<Item> CreateAsync(Item item)
        {
            using var context = new Context();
            if (item.ImportDate == default)
                item.ImportDate = DateTime.Today;

            context.Items.Add(item);
            await context.SaveChangesAsync();
            return item;
        }

        /// <summary>
        /// Update an existing item (full update).
        /// </summary>
        public async Task<bool> UpdateAsync(Item item)
        {
            using var context = new Context();
            var exists = await context.Items.AnyAsync(i => i.Id == item.Id);
            if (!exists) return false;

            context.Items.Update(item);
            await context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Increase or decrease quantity. Negative delta allowed.
        /// </summary>
        //public static async Task<bool> ChangeQuantityAsync(int itemId, int delta)
        //{
        //    using var db = new Context();
        //    var entity = await db.Items.FirstOrDefaultAsync(i => i.Id == itemId);
        //    if (entity == null) return false;

        //    entity.Quantity += delta;
        //    if (entity.Quantity < 0) entity.Quantity = 0;

        //    await db.SaveChangesAsync();
        //    return true;
        //}

        /// <summary>
        /// Soft delete: mark item as Deleted, keep the row for history.
        /// </summary>
        public async Task<bool> SoftDeleteAsync(int id)
        {
            using var context = new Context();
            var entity = await context.Items.FirstOrDefaultAsync(i => i.Id == id);
            if (entity == null) return false;

            if (entity.Status != ItemStatus.Deleted)
            {
                entity.Status = ItemStatus.Deleted;
                await context.SaveChangesAsync();
            }
            return true;
        }

        /// <summary>
        /// Restore a soft-deleted item back to Active.
        /// </summary>
        //public static async Task<bool> RestoreAsync(int id)
        //{
        //    using var db = new Context();
        //    var entity = await db.Items.FirstOrDefaultAsync(i => i.Id == id);
        //    if (entity == null) return false;

        //    if (entity.Status != ItemStatus.Active)
        //    {
        //        entity.Status = ItemStatus.Active;
        //        entity.StatusChangedAt = DateTime.Now;
        //        await db.SaveChangesAsync();
        //    }
        //    return true;
        //}

        /// <summary>
        /// Permanently remove all soft-deleted items (used by History -> Clear).
        /// </summary>
        //public static async Task<int> PurgeDeletedAsync()
        //{
        //    using var db = new Context();
        //    var deleted = await db.Items.Where(i => i.Status == ItemStatus.Deleted).ToListAsync();
        //    if (deleted.Count == 0) return 0;

        //    db.Items.RemoveRange(deleted);
        //    return await db.SaveChangesAsync();
        //}

        // ---------- Helpers ----------

        /// <summary>
        /// Map a category name (case-insensitive) to CategoryId. Returns null if not found.
        /// Useful when user selects by name.
        /// </summary>
        public async Task<int?> GetCategoryIdByNameAsync(string name)
        {
            using var context = new Context();
            if (string.IsNullOrWhiteSpace(name)) return null;
            var cat = await context.Categories
                              .AsNoTracking()
                              .FirstOrDefaultAsync(c => c.Name == name || c.Name.ToLower() == name.ToLower());
            return cat?.Id;
        }
    }
}
