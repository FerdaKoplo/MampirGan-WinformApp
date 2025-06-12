using System;
using System.Windows.Forms;
using MampirGanWinformApp.Model;
using MampirGanWinformApp.Service.Implementation;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.Utils;
using MampirGanWinformApp.Views.Interfaces.Customer;
using MampirGanWinformApp.Presenter;

namespace MampirGanWinformApp.Views.Forms.Customer
{
    public partial class CheckoutForm : Form, ICheckoutView
    {
        private readonly Cart _Cart;
        private readonly CheckoutPresenter _CheckoutPresenter;

        public CheckoutForm(Cart cart)
        {
            InitializeComponent();
            _Cart = cart;

            LblProductName.Text = cart.Product.ProductName;
            LblQty.Text = $"{cart.Quantity}";
            LblTotalPrice.Text = $"Rp {cart.TotalPriceItem}";

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
