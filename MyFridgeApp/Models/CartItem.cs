using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFridgeApp.Models
{
    public class CartItem
    {
        // Link to existing inventory item IF it came from Inventory
        public int Id { get; set; }
        // FK -> Cart
        public int CartId { get; set; }
        public Cart Cart { get; set; } = null!;

        // null if it's a brand-new purchase not in your fridge yet
        //public int? ItemId { get; set; }
        //public Item? Item { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public int Quantity { get; set; }
        public string Unit { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
