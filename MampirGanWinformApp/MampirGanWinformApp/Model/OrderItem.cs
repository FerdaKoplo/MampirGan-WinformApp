using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampirGanWinformApp.Model
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public List<Product> Products { get; set; } = new();
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }   
    }
}
