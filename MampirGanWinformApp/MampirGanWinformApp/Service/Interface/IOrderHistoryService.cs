using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Model;

namespace MampirGanWinformApp.Service.Interface
{
    public interface IOrderHistoryService
    {
        List<Order> GetAll();
        List<Order> GetByCustomer(string customerName);
    }
}


