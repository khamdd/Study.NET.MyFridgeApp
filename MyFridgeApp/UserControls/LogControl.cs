using MyFridgeApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFridgeApp.UserControls
{
    public partial class LogControl : UserControl
    {
        public LogControl()
        {
            InitializeComponent();
        }

        private void Logdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LogControl_Load(object sender, EventArgs e)
        {
            // Log Datagridview Config
            Logdgv.MultiSelect = false;
            Logdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Logdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Load logs from database
            using var context = new Context();
            var logs = context.FridgeLogs
                .OrderByDescending(l => l.LogDate)
                .Select(l => new
                {
                    l.Id,
                    l.ActionDescription,
                    Timestamp = l.LogDate.ToString("yyyy-MM-dd HH:mm:ss")
                })
                .ToList();
            Logdgv.DataSource = logs;

        }

        private void RemoveLogBtn_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (Logdgv.SelectedRows.Count == 0) return;

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected log entry?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Get selected log Id
            if (Logdgv.SelectedRows[0].Cells["Id"].Value is int selectedLogId && result == DialogResult.Yes)
            {
                // Proceed with the selectedLogId
                using var context = new Context();
                var logEntry = context.FridgeLogs.FirstOrDefault(l => l.Id == selectedLogId);
                if (logEntry != null)
                {
                    context.FridgeLogs.Remove(logEntry);
                    context.SaveChanges();
                    // Refresh DataGridView
                    var logs = context.FridgeLogs
                        .OrderByDescending(l => l.LogDate)
                        .Select(l => new
                        {
                            l.Id,
                            l.ActionDescription,
                            Timestamp = l.LogDate.ToString("yyyy-MM-dd HH:mm:ss")
                        })
                        .ToList();
                    Logdgv.DataSource = logs;
                }
            }
        }

        private void ClearLogsBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all logs?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using var context = new Context();
                context.FridgeLogs.RemoveRange(context.FridgeLogs); // Remove all logs
                context.SaveChanges();
                // Refresh DataGridView
                Logdgv.DataSource = null; // Clear the DataGridView
            }
        }
    }
}
