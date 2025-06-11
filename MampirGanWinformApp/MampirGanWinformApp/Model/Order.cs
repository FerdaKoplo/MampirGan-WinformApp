using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampirGanWinformApp.Model
{
    public class Order
    {
        public int OrderId { get; set; }    
        public int UserId { get; set; } 
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new();
    }
}
