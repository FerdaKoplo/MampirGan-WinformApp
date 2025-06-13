using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Service.Implementation;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.StateMachine.Event;
using MampirGanWinformApp.StateMachine.Implementation;
using MampirGanWinformApp.Views.Interfaces.Customer;

namespace MampirGanWinformApp.Presenter
{
    public class CheckoutPresenter
    {
        private readonly ICheckoutView _CheckoutView;
        private readonly ICheckoutService _CheckoutService;
        private readonly CheckoutStateMachine _CheckoutStateMachine;

        public CheckoutPresenter(ICheckoutView CheckoutVIew, CheckoutService CheckoutService)
        {
            _CheckoutView = CheckoutVIew;
            _CheckoutService = CheckoutService;
            _CheckoutStateMachine = new CheckoutStateMachine();
        }

        public void Checkout()
        {
            try
            {
                _CheckoutStateMachine.HandleEventCheckout(CheckoutEvent.ConfirmCheckout); 
                _CheckoutStateMachine.HandleEventCheckout(CheckoutEvent.Pay);             
                _CheckoutService.ProcessCheckout();
                _CheckoutStateMachine.HandleEventCheckout(CheckoutEvent.Success);
                _CheckoutStateMachine.HandleEventCheckout(CheckoutEvent.Reset);
                _CheckoutView.ShowSuccess("Checkout Sukses!");
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show($"Tidak bisa melakukan checkout: {ex.Message}", "State Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

    }
}
