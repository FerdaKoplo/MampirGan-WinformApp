using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using MampirGanWinformApp.Model;

namespace MampirGanWinformApp.Utils
{
    public class LoadOrderHistoryJson
    {
        public List<Order> Orders { get; private set; } = new();

        public void Load()
        {
            var filePath = Path.Combine(AppContext.BaseDirectory, "Data", "OrderHistory.json");

            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var data = JsonSerializer.Deserialize<List<Order>>(json);
                Orders = data ?? new List<Order>();
            }
        }
    }
}
