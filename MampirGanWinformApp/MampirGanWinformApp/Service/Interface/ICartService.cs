using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Model;

namespace MampirGanWinformApp.Service.Interface
{
    internal interface ICartService
    {
        List<Cart> GetAllCarts();
        Cart AddItem(int ProductId, int Quantity);
        //Cart RemoveItem(int ProductId);
    }
}
