using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Service.Implementation;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.StateMachine.Event;
using MampirGanWinformApp.StateMachine.Implementation;
using MampirGanWinformApp.Views.Interfaces.Customer;

namespace MampirGanWinformApp.Presenter
{
    public class ListProductPresenter
    {
        private readonly IListProductView _ProductView;
        private readonly IProductService _ProductService;
        private readonly ICategoryService _CategoryService;
        private readonly CategoryStateMachine _CategoryStateMachine;

        public ListProductPresenter(IListProductView ProductView, IProductService ProductService, ICategoryService CategoryService)
        {
            _ProductView = ProductView;
            _ProductView.SearchMenuClicked += HandleSearchMenu;
            _ProductService = ProductService;
            _CategoryService = CategoryService;
            _CategoryStateMachine = new CategoryStateMachine(); 

        }

        public void LoadAllCategories()
        {
            _CategoryStateMachine.HandleEventCategory(CategoryEvent.ViewAll);
            var AllCategories = _CategoryService.GetAllCategories();
            _ProductView.DisplayCategories(AllCategories);
        }

        public void LoadProductByCategory(List<string> CategoryName)
        {
            _CategoryStateMachine.HandleEventCategory(CategoryEvent.ViewProductByCategory);
            var Filtered = _ProductService.GetByCategory(CategoryName);
            _ProductView.DisplayProducts(Filtered);
        }

        public void LoadProduct()
        {
            _CategoryStateMachine.HandleEventCategory(CategoryEvent.ViewAll);
            var AllProducts = _ProductService.GetAllProducts();
            _ProductView.DisplayProducts(AllProducts);
        }

        private void HandleSearchMenu(object sender, EventArgs e)
        {
            string keyword = _ProductView.Keyword.ToLower();
            var allProducts = _ProductService.GetAllProducts();
            
            var hasil = allProducts
                .Where(p => p.ProductName.ToLower().Contains(keyword))
                .ToList();

            _ProductView.DisplayProducts(hasil);
        }

    }
}
