using System;
using System.Windows.Forms;
using MampirGanWinformApp.Model;
using MampirGanWinformApp.Service.Implementation;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.Utils;
using MampirGanWinformApp.Views.Interfaces.Customer;
using MampirGanWinformApp.Presenter;
using MampirGanWinformApp.UIComponents;

namespace MampirGanWinformApp.Views.Forms.Customer
{
    public partial class CheckoutForm : Form, ICheckoutView
    {
        private readonly CheckoutPresenter _CheckoutPresenter;
        private List<Cart> _Carts;

        public CheckoutForm(List<Cart> CartItems)
        {
            InitializeComponent();

            _Carts = CartItems;
            LblTotalPrice.Text = $"Rp {CartItems.Sum(c => c.TotalPriceItem)}";
            LblQty.Text = $"{CartItems.Sum(c => c.Quantity)} item";

            string JsonProductPath = "C:\\Users\\IVAN\\Documents\\Project_C#\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\ProductDummy.json";
            string JsonCartPath = "C:\\Users\\IVAN\\Documents\\Project_C#\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\CartData.json";
            string JsonOrderPath = "C:\\Users\\IVAN\\Documents\\Project_C#\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\OrderData.json";

            var ProductLoader = new LoadProductListJson(JsonProductPath);
            ProductLoader.Load();
            var CartLoader = new LoadCartJson(JsonCartPath, ProductLoader.Products);
            var CartSaver = new SaveCartJson(JsonCartPath);
            var OrderSaver = new SaveOrderJson(JsonOrderPath);
            var ProductSaver = new SaveProductsJson(JsonProductPath);

            var ProductService = new ProductService(ProductLoader);
            var CartService = new CartService(CartSaver, CartLoader, ProductService);
            var CheckoutService = new CheckoutService(CartLoader, OrderSaver, CartService, ProductLoader, ProductSaver);

            _CheckoutPresenter = new CheckoutPresenter(this, CheckoutService);

            BtnCheckout.Click -= BtnCheckout_Click;
            BtnCheckout.Click += BtnCheckout_Click;
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            _CheckoutPresenter.Checkout();
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "terjadi kesalahan", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
