//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MampirGanWinformApp.Service.Interface;
//using MampirGanWinformApp.Views.Interfaces.Customer;

//namespace MampirGanWinformApp.Presenter
//{
//    public class CartPresenter
//    {
//        private readonly ICartView _CartView;
//        private readonly ICartService _CartService;

//        public CartPresenter(ICartView CartView, ICartService CartService)
//        {
//            _CartView = CartView;
//            _CartService = CartService;
//        }

//        public void LoadCarts()
//        {
//            var Carts = _CartService.GetAllCarts();
//            _CartView.DisplayCart(Carts);
//        }

//        public void AddToCart(int ProductId, int )
//    }
//}
