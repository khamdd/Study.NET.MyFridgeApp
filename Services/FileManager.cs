using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyFridgeApp.Services
{
    internal class FileManager<T>
    {
        protected string filePath;
        public FileManager(string filePath)
        {
            this.filePath = filePath;
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }
        }

        public static List<T> ReadFile(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return [];
            }
        }
        public static void WriteFile(List<T> data, string filePath)
        {
            try
            {
                string json = JsonSerializer.Serialize(data);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing file: {ex.Message}");
            }
        }
    }
}
