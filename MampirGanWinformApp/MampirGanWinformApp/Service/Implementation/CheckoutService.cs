using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Model;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.UIComponents;
using MampirGanWinformApp.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MampirGanWinformApp.Service.Implementation
{
    public class CheckoutService : ICheckoutService
    {

        private readonly LoadCartJson _LoadCartJson;
        private readonly SaveProductsJson _SaveProductsJson;
        private readonly LoadProductListJson _LoadProductListJson;
        private readonly SaveOrderJson _SaveOrderJson;
        private readonly ICartService _CartService;
        private List<Order> _Order = new List<Order>();

        public CheckoutService(LoadCartJson LoadCartJson, SaveOrderJson SaveOrderJson, CartService CartService, LoadProductListJson LoadProductListJson, SaveProductsJson SaveProductsJson)
        {
            _LoadCartJson = LoadCartJson;
            _SaveOrderJson = SaveOrderJson;
            _CartService = CartService;
            _SaveProductsJson = SaveProductsJson;
            _LoadProductListJson = LoadProductListJson;
        }

        public void ProcessCheckout()
        {
            var CartItems = _CartService.GetAllCarts();
            var Products = _LoadProductListJson.Products;


            foreach (var Cart in CartItems)
            {
                var Product = Products.FirstOrDefault(Product => Product.ProductId == Cart.ProductId);
                if (Product != null)
                {
                    if (Product.Stock >= Cart.Quantity)
                    {
                        Product.Stock -= Cart.Quantity;
                    }

                    else
                    {
                        throw new Exception($"Insufficient stock for product {Product.ProductName}");
                    }
                }
            }

            _SaveProductsJson.Products = Products;
            _SaveProductsJson.Save();

            var OrderItems = CartItems.Select(Cart => new OrderItem
            {
                ProductId = Cart.ProductId,
                ProductName = Cart.Product.ProductName,
                UnitPrice = Cart.TotalPriceItem,
                Quantity = Cart.Quantity,
                Cart = Cart
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
