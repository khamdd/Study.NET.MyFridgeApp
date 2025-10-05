using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFridgeApp.Interfaces
{
    internal interface IShoppingCart
    {
        void AddItem(int itemId, int quantity);
        void RemoveItem(int itemId);
        void UpdateItemQuantity(int itemId, int quantity);
        decimal GetTotalPrice();
        void ClearCart();
        Dictionary<int, int> GetCartItems();
    }
}
