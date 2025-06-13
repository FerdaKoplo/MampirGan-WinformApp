//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MampirGanWinformApp.Model;
//using MampirGanWinformApp.Service.Interface;
//using MampirGanWinformApp.Utils;

//namespace MampirGanWinformApp.Service.Implementation
//{
//    public class OrderHistoryService : IOrderHistoryService
//    {
//        private readonly LoadOrderHistoryJson _loader;

//        public OrderHistoryService(LoadOrderHistoryJson loader)
//        {
//            _loader = loader;
//            _loader.Load();
//        }

//        public List<Order> GetAll()
//        {
//            return _loader.Orders;
//        }

//        public List<Order> GetByCustomer(string customerName)
//        {
//            return _loader.Orders
//                .Where(o => o.CustomerName.Equals(customerName, StringComparison.OrdinalIgnoreCase))
//                .ToList();
//        }
//    }
//}


