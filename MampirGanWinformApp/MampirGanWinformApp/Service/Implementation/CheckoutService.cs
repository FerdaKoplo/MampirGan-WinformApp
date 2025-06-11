using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Model;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.UIComponents;
using MampirGanWinformApp.Utils;

namespace MampirGanWinformApp.Service.Implementation
{
    public class CheckoutService : ICheckoutService
    {

        private readonly LoadCartJson _LoadCartJson;
        private readonly SaveOrderJson _SaveOrderJson;
        private readonly ICartService _CartService;
        private List<Order> _Order = new List<Order>();

        public CheckoutService(LoadCartJson LoadCartJson, SaveOrderJson SaveOrderJson, CartService CartService) { 
            _LoadCartJson = LoadCartJson;
            _SaveOrderJson = SaveOrderJson;
            _CartService = CartService;
        }

        public void ProcessCheckout()
        {
            var CartItems = _CartService.GetAllCarts();

            var OrderItems = CartItems.Select(cart => new OrderItem
            {
                ProductId = cart.ProductId,
                ProductName = cart.Product.ProductName,
                UnitPrice = cart.TotalPriceItem,
                Quantity = cart.Quantity,
                Cart = cart
            }).ToList();

            var Order = new Order
            {
                Date = DateTime.Now,
                UserId = 1,
                OrderItem = OrderItems,
                TotalAmount = CartItems.Sum(c => c.TotalPriceItem)
            };
            var newOrderList = new List<Order> { Order };

            _SaveOrderJson.Orders = newOrderList;

            _SaveOrderJson.Save();

            _CartService.ClearCart();
        }

    }
}
