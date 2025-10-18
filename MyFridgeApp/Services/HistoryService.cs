using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using MyFridgeApp.Data;
using MyFridgeApp.Interfaces;
using MyFridgeApp.Models;

namespace MyFridgeApp.Services
{
    /// <summary>
    /// History operations for Items (soft-deleted) and Carts (Ordered/Cleared).
    /// Keep it minimal and UI-friendly.
    /// </summary>
    public class HistoryService : IHistory
    {
        public HistoryService()
        {
        }
        public void RecordAction(string actionDescription, DateTime logDate)
        {
            using var context = new Context();
            context.Database.EnsureCreated();
            FridgeLog log = new()
            {
                ActionDescription = actionDescription,
                LogDate = logDate
            };

            context.FridgeLogs.Add(log);
            context.SaveChanges();
        }

        public List<FridgeLog> GetHistory()
        {
            using var context = new Context();
            context.Database.EnsureCreated();
            var logs = context.FridgeLogs
                              .AsNoTracking()
                              .OrderByDescending(l => l.LogDate)
                              .ToList();
            return logs;
        }

        public void ClearHistory()
        {
            using var context = new Context();
            context.Database.EnsureCreated();
            
        }
    }
}
