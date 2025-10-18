using MyFridgeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFridgeApp.Interfaces
{
    //internal interface IShoppingCart
    //{
    //    void AddItem(int itemId, int quantity);
    //    void RemoveItem(int itemId);
    //    void UpdateItemQuantity(int itemId, int quantity);
    //    decimal GetTotalPrice();
    //    void ClearCart();
    //    Dictionary<int, int> GetCartItems();
    //}

    internal interface ICartService
    {
        // open cart
        Task<List<CartItem>> GetOpenCartItemsAsync();
        Task<CartItem?> GetCartItemByIdAsync(int cartItemId);
        Task AddToCartAsync(string name, int categoryId, int quantity, string unit, string? notes);
        Task UpdateCartItemAsync(int cartItemId, string name, int categoryId, int quantity, string unit, string? notes);
        Task DeleteCartItemAsync(int cartItemId);
        Task ClearOpenCartAsync();
        Task PlaceOrderAsync();

        // cart history
        //Task<List<Cart>> GetOrderedCartsAsync();
        //Task<List<CartItem>> GetCartItemsByCartIdAsync(int cartId);
        //Task DeleteOrderedCartAsync(int cartId);
        //Task ClearAllOrderedCartsAsync();
    }
}
