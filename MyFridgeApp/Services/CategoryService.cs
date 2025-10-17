using Microsoft.EntityFrameworkCore;
using MyFridgeApp.Data;
using MyFridgeApp.Interfaces;
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
    internal class CategoryService : ICategoryService
    {
        private readonly Context context;

        public CategoryService()
        {
            context = new Context();
        }
        /// <summary>
        /// Get all categories (ordered by Name).
        /// </summary>
        public async Task<List<Category>> GetAllAsync()
        {
            return await context.Categories
                           .AsNoTracking()
                           .OrderBy(c => c.Name)
                           .ToListAsync();
        }

        /// <summary>
        /// Get a single category by Id.
        /// </summary>
        public async Task<Category?> GetByIdAsync(int id)
        {
            return await context.Categories
                           .AsNoTracking()
                           .FirstOrDefaultAsync(c => c.Id == id);
        }

        /// <summary>
        /// Find a category Id by name (case-insensitive).
        /// </summary>
        public async Task<int?> GetIdByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;
            var cat = await context.Categories
                              .AsNoTracking()
                              .FirstOrDefaultAsync(c => c.Name.ToLower() == name.ToLower());
            return cat?.Id;
        }
    }
}
