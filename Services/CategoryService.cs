using MyFridgeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFridgeApp.Utils;

namespace MyFridgeApp.Services
{
    internal class CategoryService
    {
        public CategoryService() { }
        public static List<Category> GetAllCategories()
        {
            return FileManager<Category>.ReadFile(Constants.categoryFilePath);
        }
    }
}
