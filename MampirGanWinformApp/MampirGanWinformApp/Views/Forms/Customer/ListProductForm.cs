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
using MampirGanWinformApp.Service.Implementation;
using MampirGanWinformApp.Service.Interface;
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
            string JsonCategoryPath = "C:\\Users\\IVAN\\Documents\\Project_C#\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\CategoryDummy.json";
            var ProductLoader = new LoadProductListJson(JsonProductPath);
            var CategoryLoader = new LoadCategoryJson(JsonCategoryPath);

            IProductService ProductService = new ProductService(ProductLoader);
            ICategoryService CategoryService = new CategoryService(CategoryLoader);

            _ListProductPresenter = new ListProductPresenter(this, ProductService, CategoryService);

            _ListProductPresenter.LoadAllCategories();
            _ListProductPresenter.LoadProduct();

        }

        public void DisplayProducts(List<Product> Products)
        {
            FlowLayoutPanelListProduct.Controls.Clear();
            foreach (var Product in Products)
            {
                var Card = new ProductCard();

                Card.ProductNameLabel = Product.ProductName;
                Card.CategoryLabel = Product.Category?.CategoryName ?? "Tidak ditemukan";
                Card.PriceLabel = $"Rp {Product.Price : 0}";

                if (File.Exists(Product.ProductImageUrl))
                {
                    Card.ProductImage = Image.FromFile(Product.ProductImageUrl);
                }

                FlowLayoutPanelListProduct.Controls.Add(Card);
            }
        }

        public void DisplayCategories(List<Category> Categories)
        {
            foreach (var Category in Categories)
            {
                CheckBox CB = new CheckBox();
                CB.Text = Category.CategoryName;
                CB.Tag = Category;
                CB.AutoSize = true;
                CB.CheckedChanged += CategoryCheckBox_CheckedChanged;

                FlowLayoutCategoryPanel.Controls.Add(CB);

            }

        }

        public void CategoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var SelectedCategories = FlowLayoutCategoryPanel.Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked).Select(cb => cb.Text).ToList();

            if (SelectedCategories.Count > 0)
            {
                _ListProductPresenter.LoadProductByCategory(SelectedCategories);
            }

            else
            {
                _ListProductPresenter.LoadProduct();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
