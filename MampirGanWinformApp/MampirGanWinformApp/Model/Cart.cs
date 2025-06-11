using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MampirGanWinformApp.Model
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }

        public decimal TotalPriceItem { get; set; }

    }
}
