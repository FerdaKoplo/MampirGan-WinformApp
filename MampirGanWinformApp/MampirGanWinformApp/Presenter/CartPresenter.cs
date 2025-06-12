using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Model;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.StateMachine.Event;
using MampirGanWinformApp.StateMachine.Implementation;
using MampirGanWinformApp.Utils;
using MampirGanWinformApp.Views.Interfaces.Customer;

namespace MampirGanWinformApp.Presenter
{
    public class CartPresenter
    {
        private readonly ICartView _CartView;
        private readonly ICartService _CartService;
        private readonly CartStateMachine  _CartStateMachine;

        public CartPresenter(ICartView CartView, ICartService CartService)
        {
            _CartView = CartView;
            _CartService = CartService;
            _CartStateMachine = new CartStateMachine();
        }

        public void LoadCarts()
        {
            var Carts = _CartService.GetAllCarts();
            _CartView.DisplayCart(Carts);
        }

        public void AddToCart(int ProductId, int Quantity)
        {

            try
            {
                _CartStateMachine.HandleEventCart(CartEvent.AddItem);
                _CartService.AddItem(ProductId, Quantity);
                LoadCarts();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Tidak bisa menambahkan item ke cart: {ex.Message}", "State Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            _CartService.AddItem(ProductId, Quantity);
            LoadCarts();  

        }

        public void RemoveFromCart(int ProductId)
        {
            try
            {
                _CartStateMachine.HandleEventCart(CartEvent.RemoveItem);
                _CartService.RemoveItem(ProductId);
                LoadCarts();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Tidak bisa menghapus item dari cart: {ex.Message}", "State Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
