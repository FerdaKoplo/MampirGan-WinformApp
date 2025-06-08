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
        public DetailProductForm()
        {
            InitializeComponent();
        }

        public void DisplayDetailProduct(Product Product)
        {
            LblProductName.Text = Product.ProductName;
            LblCategory.Text = Product.Category?.CategoryName ?? "Kategori Tidak Ditemukan";
            LblPrice.Text = $"Rp {Product.Price}";
            

            if (File.Exists(Product.ProductImageUrl))
            {
                PictureProduct.Image = Image.FromFile(Product.ProductImageUrl);
            }
        }
    }
}
