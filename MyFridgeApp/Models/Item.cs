using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFridgeApp.Models
{
    public enum ItemStatus
    {
        Active = 0,
        Deleted = 1
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        // FK => Category
        public Category Category { get; set; } = null!;
        public DateTime ImportDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public ItemStatus Status { get; set; } = ItemStatus.Active;
    }
}
