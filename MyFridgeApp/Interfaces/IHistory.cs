using MyFridgeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFridgeApp.Interfaces
{
    internal interface IHistory
    {
        void RecordAction(string actionDescription, DateTime logDate);
        List<FridgeLog> GetHistory();
        void ClearHistory();
    }
}
