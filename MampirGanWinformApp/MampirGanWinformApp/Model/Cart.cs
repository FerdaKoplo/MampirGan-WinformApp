using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampirGanWinformApp.Model
{
    public class Cart
    {
        public int cartID { get; set; }
        public int productID { get; set; }
        public List<Product> Products { get; set; } = new();
        public int Quantity { get; set; }

    }
}
