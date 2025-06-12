using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MampirGanWinformApp.Model;
using MampirGanWinformApp.Views.Interfaces.Customer;

namespace MampirGanWinformApp.Views.Forms.Customer
{
    public partial class DetailProductForm : Form, IDetailProductVIew
    {
        public event Action<int, int> AddToCart;

        private int SelectedQuantity = 1;
        private decimal Price = 0;
        private int ProductId = 0;


        public DetailProductForm()
        {
            InitializeComponent();
        }

        public void DisplayDetailProduct(Product Product)
        {
            ProductId = Product.ProductId;
            Price = Product.Price;

            LblProductName.Text = Product.ProductName;
            LblCategory.Text = $"#{Product.Category?.CategoryName ?? "Kategori Tidak Ditemukan"}";
            LblPrice.Text = $"Rp {Product.Price}";
            LblStock.Text = $"Jumlah Stok : {Product.Stock}";
            LblTotalPrice.Text = $"Rp {Price:0}";


            if (File.Exists(Product.ProductImageUrl))
            {
                PictureProduct.Image = Image.FromFile(Product.ProductImageUrl);
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            IListProductView ListProductView = new ListProductForm();
            ((Form)ListProductView).Show();
            this.Hide();
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

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart?.Invoke(ProductId, SelectedQuantity);
            MessageBox.Show("Berhasil ditambahkan ke keranjang");
        }


        private void LblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}


                