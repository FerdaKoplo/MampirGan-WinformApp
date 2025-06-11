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
            LblQty.Text = $"Jumlah Barang : {cart.Quantity}";
            LblTotalPrice.Text = $"Total Harga: Rp {cart.TotalPriceItem}";

            string JsonProductPath = "C:\\Users\\IVAN\\Documents\\Project_C#\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\ProductDummy.json";
            string JsonCartPath = "C:\\Users\\IVAN\\Documents\\Project_C#\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\CartData.json";
            string JsonOrderPath = "C:\\Users\\IVAN\\Documents\\Project_C#\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\OrderData.json";

            var productLoader = new LoadProductListJson(JsonProductPath);
            productLoader.Load(); 
            var cartLoader = new LoadCartJson(JsonCartPath, productLoader.Products);
            var cartSaver = new SaveCartJson(JsonCartPath);
            var orderSaver = new SaveOrderJson(JsonOrderPath);

            var productService = new ProductService(productLoader);
            var cartService = new CartService(cartSaver, cartLoader, productService);
            var checkoutService = new CheckoutService(cartLoader, orderSaver, cartService);

            _CheckoutPresenter = new CheckoutPresenter(this, checkoutService);

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
