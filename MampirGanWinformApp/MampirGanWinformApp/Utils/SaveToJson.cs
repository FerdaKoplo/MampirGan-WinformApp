using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MampirGanWinformApp.Model;


namespace MampirGanWinformApp.Utils
{
    public interface SaveToJson
    {
        void Save();
    }

    public class SaveProductsJson : SaveToJson
    {
        private readonly string _FilePath;
        public List<Product> Products { get; set; } = new List<Product>();

        public SaveProductsJson(string FilePath)
        {
            _FilePath = FilePath;
        }

        public void Save()
        {
            var JsonString = JsonSerializer.Serialize(Products);
            File.WriteAllText(_FilePath, JsonString);
        }
    }
    public class SaveCartJson : SaveToJson
    {
        private readonly string _FilePath;
        public List<Cart> Carts { get; set; } = new List<Cart>();

        public SaveCartJson(string FilePath)
        {
            _FilePath = FilePath;
        }

        public void Save()
        {
            var JsonString = JsonSerializer.Serialize(Carts);
            File.WriteAllText(_FilePath, JsonString);
        }
    }

    public class SaveOrderJson : SaveToJson
    {
        private readonly string _FilePath;
        public List<Order> Orders { get; set; } = new List<Order>();

        public SaveOrderJson(string FilePath)
        {
            _FilePath = FilePath;
        }

        public void Save()
        {
            var JsonString = JsonSerializer.Serialize(Orders);
            File.WriteAllText(_FilePath, JsonString);
        }
    }
}
