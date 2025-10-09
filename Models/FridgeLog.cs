using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFridgeApp.Models
{
    internal enum LogStatus
    {
        Removed,
        Active
    }
    internal class FridgeLog
    {
        public int Id { get; set; }
        public string ActionDescription { get; set; } = string.Empty;
        public DateTime LogDate { get; set; }
        public LogStatus Status { get; set; } = LogStatus.Active;
    }
}
