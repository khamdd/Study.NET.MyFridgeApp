using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace MyFridgeApp.Models
{
    internal enum CartStatus 
    { 
        Open = 0, 
        Ordered = 1, 
        //Cleared = 2 
    }

    internal class Cart
    {
        public int Id { get; set; }
        //public DateTime CreatedAt { get; set; } = DateTime.Now;
        public CartStatus Status { get; set; } = CartStatus.Open;
        public DateTime? PlacedAt { get; set; }
        public List<CartItem> Items { get; set; } = new();
    }
}
