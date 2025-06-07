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
using MampirGanWinformApp.Presenter;
using MampirGanWinformApp.UIComponents;
using MampirGanWinformApp.Utils;
using MampirGanWinformApp.Views.Interfaces.Customer;

namespace MampirGanWinformApp.Views.Forms.Customer
{
    public partial class ListProductForm : Form, IListProductView
    {
        private ListProductPresenter _ListProductPresenter;
        public ListProductForm()
        {
            InitializeComponent();
            string JsonProductPath = "C:\\Users\\IVAN\\Documents\\Project_C#\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\ProductDummy.json";
            //string JsonCategoryPath = "C:\\Users\\IVAN\\Documents\\Project_C#\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\CategoryDummy.json";

            var ProductLoader = new LoadProductListJson(JsonProductPath);
            ProductLoader.Load();
            var Products = ProductLoader.Products;

            //var CategoryLoader = new LoadCategoryJson(JsonCategoryPath);
            //CategoryLoader.Load();
            //var categories = CategoryLoader.Categories;

            //foreach (var Product in Products)
            //{
            //    Product.Categories = categories
            //        .Where(c => c.CategoryId == Product.CategoryId)
            //        .ToList();
            //}

            RenderProductCards(Products);

        }

        private void RenderProductCards(List<Product> Products)
        {
            foreach (var Product in Products)
            {
                var Card = new ProductCard();

                Card.ProductNameLabel = Product.ProductName;
                Card.CategoryLabel = Product.Categories.FirstOrDefault()?.CategoryName ?? "Unknown";
                Card.PriceLabel = $"Rp {Product.Price : 0}";

                if (File.Exists(Product.ProductImageUrl))
                {
                    Card.ProductImage = Image.FromFile(Product.ProductImageUrl);
                }

                FlowLayoutPanelListProduct.Controls.Add(Card);
            }
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
