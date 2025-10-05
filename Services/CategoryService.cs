using Microsoft.EntityFrameworkCore;
using MyFridgeApp.Data;
using MyFridgeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFridgeApp.Services
{
    /// <summary>
    /// Service for Categories (fixed list, seeded in DB).
    /// Users cannot add/delete categories.
    /// </summary>
    internal static class CategoryService
    {
        /// <summary>
        /// Get all categories (ordered by Name).
        /// </summary>
        public static async Task<List<Category>> GetAllAsync()
        {
            using var db = new Context();
            return await db.Categories
                           .AsNoTracking()
                           .OrderBy(c => c.Name)
                           .ToListAsync();
        }

        /// <summary>
        /// Get a single category by Id.
        /// </summary>
        public static async Task<Category?> GetByIdAsync(int id)
        {
            using var db = new Context();
            return await db.Categories
                           .AsNoTracking()
                           .FirstOrDefaultAsync(c => c.Id == id);
        }

        /// <summary>
        /// Find a category Id by name (case-insensitive).
        /// </summary>
        public static async Task<int?> GetIdByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;
            using var db = new Context();
            var cat = await db.Categories
                              .AsNoTracking()
                              .FirstOrDefaultAsync(c => c.Name.ToLower() == name.ToLower());
            return cat?.Id;
        }
    }
}
