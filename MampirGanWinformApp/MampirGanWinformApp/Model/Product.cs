using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampirGanWinformApp.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public List<Category> Categories { get; set; } = new();
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stok { get; set; }
    }
}
