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

            public CartService()
            {

            }

            public List<Cart> GetAllCarts()
            {
                return _LoadCartJson.Carts;
            }

            public Cart AddItem(int ProductId, int Quantity)
            {
                var Carts = _LoadCartJson.Carts;
                var ExistingCart = Carts.FirstOrDefault(Cart => Cart.ProductId == ProductId);

                if (ExistingCart != null)
                {
                    ExistingCart.Quantity += Quantity;
                }

                else
                {
                    var NewCart = new Cart{
                        CartId = Carts.Count > 0 ? Carts.Max(Cart => Cart.ProductId) + 1 : 1,
                        ProductId = ProductId,
                        Quantity = Quantity
                    };
                }

                _SaveCartJson.Carts = Carts;
                _SaveCartJson.Save();

                return ExistingCart;
            }



            //public Cart RemoveItem(int ProductId)
            //{

            //}
        }
    }
