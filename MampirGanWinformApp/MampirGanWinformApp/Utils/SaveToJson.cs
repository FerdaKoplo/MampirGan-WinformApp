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
            File.WriteAllText(JsonString, _FilePath);
        }

    }
}
