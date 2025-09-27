using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFridgeApp.Models;
using MyFridgeApp.Utils;

namespace MyFridgeApp.Services
{
    internal class ItemService
    {
        public ItemService() { }

        public static List<Item> GetAllItems()
        {
            return FileManager<Item>.ReadFile(Constants.itemFilePath);
        }
    }
}
