using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MampirGanWinformApp.Factory.Interface;
using MampirGanWinformApp.Model;
using MampirGanWinformApp.Presenter;
using MampirGanWinformApp.Service.Implementation;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.UIComponents;
using MampirGanWinformApp.Utils;
using MampirGanWinformApp.Views.Interfaces.Customer;


namespace MampirGanWinformApp.Views.Forms.Customer
{
    public partial class ListProductForm : Form, IListProductView, ICartView
    {
        private readonly ListProductPresenter _ListProductPresenter;
        private readonly CartPresenter _CartPresenter;
        //private readonly IViewFactory _ViewFactory;

        //string JsonProductPath = "C:\\Users\\IVAN\\Documents\\Project_C#\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\ProductDummy.json";
        string JsonProductPath = "C:\\Users\\Dita\\source\\repos\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\ProductDummy.json";
        //string JsonCategoryPath = "C:\\Users\\IVAN\\Documents\\Project_C#\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\CategoryDummy.json";
        string JsonCategoryPath = "C:\\Users\\Dita\\source\\repos\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\CategoryDummy.json";
        //string JsonCartPath = "C:\\Users\\IVAN\\Documents\\Project_C#\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\CartData.json";
        string JsonCartPath = "C:\\Users\\Dita\\source\\repos\\MampirGan-WinformApp\\MampirGanWinformApp\\MampirGanWinformApp\\Json\\CartData.json";

        public ListProductForm()
        {
            InitializeComponent();

            var ProductLoader = new LoadProductListJson(JsonProductPath);
            var CategoryLoader = new LoadCategoryJson(JsonCategoryPath);

            ProductLoader.Load();
            var ProductList = ProductLoader.Products;

            var CartLoader = new LoadCartJson(JsonCartPath, ProductList);
            var CartSaver = new SaveCartJson(JsonCartPath);


            IProductService ProductService = new ProductService(ProductLoader);
            ICategoryService CategoryService = new CategoryService(CategoryLoader);
            ICartService CartService = new CartService(CartSaver, CartLoader, ProductService);

            _ListProductPresenter = new ListProductPresenter(this, ProductService, CategoryService);
            _CartPresenter = new CartPresenter(this, CartService);

            _ListProductPresenter.LoadAllCategories();
            _ListProductPresenter.LoadProduct();
            _CartPresenter.LoadCarts();
        }

        public void DisplayProducts(List<Product> Products)
        {
            FlowLayoutPanelListProduct.Controls.Clear();
            foreach (var Product in Products)
            {
                var Card = new ProductCard();

                Card.ProductNameLabel = Product.ProductName;
                Card.CategoryLabel = Product.Category?.CategoryName ?? "Tidak ditemukan";
                Card.PriceLabel = $"Rp {Product.Price}";
                Card.ProductDetailData = Product;

                if (File.Exists(Product.ProductImageUrl))
                {
                    Card.ProductImage = Image.FromFile(Product.ProductImageUrl);
                }

                
                Card.DetailClicked += (State, Event) =>
                {
                    var ClickedCard = State as ProductCard;
                    if (ClickedCard == null) return;

                    IDetailProductVIew DetailVIew = new DetailProductForm();
                    IProductService ProductService = new ProductService(new LoadProductListJson(JsonProductPath));

                    var DetailPresenter = new DetailProductPresenter(DetailVIew, ProductService);
                    DetailPresenter.LoadProductDetail(ClickedCard.ProductDetailData.ProductId);

                    ((Form)DetailVIew).Show();

                    DetailVIew.AddToCart += (ProductId, Quantity) =>
                    {
                        _CartPresenter.AddToCart(ProductId, Quantity);
                        _CartPresenter.LoadCarts();
                    };
                };

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

        public void DisplayCart(List<Cart> Carts)
        {
            flowLayoutCartPanel.Controls.Clear();

            foreach (var Cart in Carts)
            {
                var CartItem = new CartItem();

                CartItem.ProductId = Cart.ProductId;
                CartItem.ProductNameLabel = Cart.Product?.ProductName ?? "Tidak ditemukan";
                CartItem.Quantity = $"{Cart.Quantity}";
                CartItem.TotalPrice = $"{Cart.TotalPriceItem}";

                CartItem.RemoveCartClicked += (Sender, ProductId) =>
                {
                    _CartPresenter.RemoveFromCart(ProductId);
                    MessageBox.Show("Berhasil dihapus");
                    _CartPresenter.LoadCarts();

                };

                CartItem.CheckoutClicked += (Sender, ProductId) =>
                {
                    var CartToCheckout = Carts.FirstOrDefault(c => c.ProductId == ProductId);
                    if (CartToCheckout != null)
                    {
                        ICheckoutView CheckoutView = new CheckoutForm(CartToCheckout);
                        ((Form)CheckoutView).Show();
                    }
                };

                flowLayoutCartPanel.Controls.Add(CartItem);
            }
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBoxIcon_Click(object sender, EventArgs e)
        {
            IHomeCustomerPanel _HomeCustomerPanel = new HomeCustomerPanelForm();
            _HomeCustomerPanel.DisplayHomeCustomerPanel();
            this.Hide();
        }

        private void ListProductForm_Load(object sender, EventArgs e)
        {

        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCariMenu_TextChanged(object sender, EventArgs e)
        {
            textBoxCariMenu.Multiline = true;
            textBoxCariMenu.TextAlign = HorizontalAlignment.Center;
            textBoxCariMenu.Font = new Font("Segoe UI", 12);
            textBoxCariMenu.Height = 40;

            this.textBoxCariMenu.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);

        }

        private void FlowLayoutPanelListProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SearchMenuClicked?.Invoke(this, EventArgs.Empty);

        }

        public event EventHandler SearchMenuClicked;

        public string Keyword => textBoxCariMenu.Text;

        public void DisplaySearchResult(List<Product> hasil)
        {
            FlowLayoutPanelListProduct.Controls.Clear();

            if (hasil.Count == 0)
            {
                Label kosong = new Label();
                kosong.Text = "Tidak ada hasil pencarian.";
                kosong.Font = new Font("Segoe UI", 8, FontStyle.Italic);
                kosong.AutoSize = true;
                FlowLayoutPanelListProduct.Controls.Add(kosong);
                return;
            }

            foreach (var product in hasil)
            {
                var card = new ProductCard();
                card.ProductNameLabel = product.ProductName;
                card.PriceLabel = $"Rp {product.Price}";
                card.ProductDetailData = product;

                if (File.Exists(product.ProductImageUrl))
                    card.ProductImage = Image.FromFile(product.ProductImageUrl);

                FlowLayoutPanelListProduct.Controls.Add(card);
            }

        }


    }
}
