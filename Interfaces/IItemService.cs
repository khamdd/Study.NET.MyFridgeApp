using MyFridgeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFridgeApp.Interfaces
{
    internal interface IItemService
    {
        Task<List<Item>> GetAllAsync(bool includeDeleted = false);
        Task<List<Item>> SearchAsync(
            string? name = null,
            int? categoryId = null,
            DateTime? importFrom = null,
            DateTime? importTo = null,
            DateTime? expireFrom = null,
            DateTime? expireTo = null,
            bool includeDeleted = false
            );
        Task<Item?> GetByIdAsync(int id);
        Task<List<Item>> GetExpiringSoonAsync(int days);
        Task<Item> CreateAsync(Item item);
        Task<bool> UpdateAsync(Item item);
        Task<bool> SoftDeleteAsync(int id);
        Task<int?> GetCategoryIdByNameAsync(string name);
    }
}
