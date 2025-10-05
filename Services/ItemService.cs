using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFridgeApp.Data;
using MyFridgeApp.Interfaces;
using MyFridgeApp.Models;
using MyFridgeApp.Utils;

namespace MyFridgeApp.Services
{
    internal class ItemService : IItemService
    {
        private readonly Context _context;
        public ItemService(Context context) 
        {
            _context = context;
        }

        public List<Item> GetAllItems()
        {
            return FileManager<Item>.ReadFile(Constants.itemFilePath);
        }

        public void AddItem(Item item)
        {
            try
            {
                _context.Items.Add(item);
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw new ApplicationException("An error occurred while adding the item.", ex);
            }
        }

        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public Item? GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
