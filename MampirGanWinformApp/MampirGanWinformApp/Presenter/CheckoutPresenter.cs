using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Service.Implementation;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.Views.Interfaces.Customer;

namespace MampirGanWinformApp.Presenter
{
    public class CheckoutPresenter
    {
        private readonly ICheckoutView _CheckoutView;
        private readonly ICheckoutService _CheckoutService;

        public CheckoutPresenter(ICheckoutView CheckoutVIew, CheckoutService CheckoutService)
        {
            _CheckoutView = CheckoutVIew;
            _CheckoutService = CheckoutService;
        }

        public void Checkout()
        {
            _CheckoutService.ProcessCheckout();
            _CheckoutView.ShowSuccess("Checkout Sukses!");
        }


    }
}
