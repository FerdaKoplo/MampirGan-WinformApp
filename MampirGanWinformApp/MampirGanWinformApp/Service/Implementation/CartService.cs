using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Model;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.Utils;

namespace MampirGanWinformApp.Service.Implementation
{
    public class CartService : ICartService
    {
        private readonly LoadCartJson _LoadCartJson;
        private readonly SaveCartJson _SaveCartJson;
        private List<Cart> _Carts;
        private readonly IProductService _ProductService;

        public CartService(SaveCartJson SaveCartJson, LoadCartJson LoadCartJson, IProductService productService)
        {
            _LoadCartJson = LoadCartJson;
            _SaveCartJson = SaveCartJson;
            _ProductService = productService;

            _Carts = _LoadCartJson.Load();
        }

        public List<Cart> GetAllCarts()
        {

            foreach (var cart in _Carts)
            {
                cart.Product = _ProductService.GetProductById(cart.ProductId);
            }

            return _Carts;
        }

        public Cart AddItem(int ProductId, int Quantity)
        {
            var ExistingCart = _Carts.FirstOrDefault(Cart => Cart.ProductId == ProductId);
            var Product = _ProductService.GetProductById(ProductId);

            if (ExistingCart != null)
            {
                ExistingCart.Quantity += Quantity;
                ExistingCart.TotalPriceItem = ExistingCart.Quantity * Product.Price;
            }

            else
            {
                var NewCart = new Cart
                {
                    CartId = _Carts.Count > 0 ? _Carts.Max(Cart => Cart.ProductId) + 1 : 1,
                    ProductId = ProductId,
                    Quantity = Quantity,
                    TotalPriceItem = Quantity * Product.Price
                };
                _Carts.Add(NewCart);
                ExistingCart = NewCart;
            }

            _SaveCartJson.Carts = _Carts;
            _SaveCartJson.Save();

            return ExistingCart;
        }



        public Cart RemoveItem(int ProductId)
        {

            var ExistingCart = _Carts.FirstOrDefault(Cart => Cart.ProductId == ProductId);

            if (ExistingCart != null)
            {
                _Carts.Remove(ExistingCart);
                _SaveCartJson.Carts = _Carts;
                _SaveCartJson.Save();
            }

            return ExistingCart;
        }

        public void ClearCart()
        {
            _SaveCartJson.Carts.Clear();
            _SaveCartJson.Carts = _Carts;
            _SaveCartJson.Save();

        }
    }
}
