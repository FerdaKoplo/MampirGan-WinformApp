using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MampirGanWinformApp.Model;

namespace MampirGanWinformApp.Utils
{

    public interface ILoadJson
    {
        void Load();
    }
    public class LoadProductListJson : ILoadJson
    {
        private readonly string _FilePath;
        public List<Product> Products { get; set; }

        public LoadProductListJson(string FilePath)
        {
            _FilePath = FilePath;
        }

        public void Load()
        {
            var JsonString = File.ReadAllText(_FilePath);
            Products = JsonSerializer.Deserialize<List<Product>>(JsonString);
        }
    }

    public class LoadCategoryJson : ILoadJson
    {
        private readonly string _FilePath;
        public List<Category> Categories { get; set; }

        public LoadCategoryJson(string FilePath)
        {
            _FilePath = FilePath;
        }

        public void Load()
        {
            var JsonString = File.ReadAllText(_FilePath);
            Categories = JsonSerializer.Deserialize<List<Category>>(JsonString);
        }
    }

}
