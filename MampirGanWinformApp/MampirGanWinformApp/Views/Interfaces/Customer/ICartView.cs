using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Model;

namespace MampirGanWinformApp.Views.Interfaces.Customer
{
    internal interface ICartView
    {
        void DisplayCart(List<Cart> Carts);
    }
}
