using MyFridgeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFridgeApp.Utils;
using MyFridgeApp.Interfaces;

namespace MyFridgeApp.Services
{
    internal class CategoryService : ICategoryService
    {
        public CategoryService() { }
        public List<Category> GetAllCategories()
        {
            return FileManager<Category>.ReadFile(Constants.categoryFilePath);
        }
    }
}
