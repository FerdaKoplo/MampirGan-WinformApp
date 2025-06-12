    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace MampirGanWinformApp.UIComponents
    {
    public partial class CartItem : UserControl
    {
        public event EventHandler<int> RemoveCartClicked;
        public event EventHandler<int> CheckoutClicked;
        public int SelectedQuantity = 1;
        public decimal Price = 0;
        public int ProductId { get; set; }

        public CartItem()
        {
            InitializeComponent();
        }

        public string ProductNameLabel
        {
            get => LblProductName.Text;
            set => LblProductName.Text = value;
        }

        public string TotalPrice
        {
            get => LblTotalPrice.Text;
            set => LblTotalPrice.Text = value;
        }

        public string Quantity
        {
            get => LblQty.Text;
            set => LblQty.Text = value;
        }

        private void BtnIncrease_Click(object sender, EventArgs e)
        {
            SelectedQuantity++;
            LblQty.Text = SelectedQuantity.ToString();
            UpdateTotal();

        }

        private void BtnDecrease_Click(object sender, EventArgs e)
        {
            if (SelectedQuantity > 1)
            {
                SelectedQuantity--;
                LblQty.Text = SelectedQuantity.ToString();
                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            LblTotalPrice.Text = $"Rp {(SelectedQuantity * Price): 0}";
        }

        private void BtnRemoveCart_Click(object sender, EventArgs e)
        {
            RemoveCartClicked?.Invoke(this, ProductId);
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            CheckoutClicked?.Invoke(this, ProductId);
        }

        private void LblTotalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
