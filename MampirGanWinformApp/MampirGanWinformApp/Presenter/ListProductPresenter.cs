using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Service.Implementation;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.Views.Interfaces.Customer;

namespace MampirGanWinformApp.Presenter
{
    public class ListProductPresenter
    {
        private readonly IListProductView _ProductView;
        private readonly IProductService _ProductService;

        public ListProductPresenter(IListProductView ProductView, IProductService ProductService)
        {
            _ProductView = ProductView;
            _ProductService = ProductService;
        }

        public void LoadProduct()
        {
            var Product = _ProductService.GetAllProducts();
            string SelectedCategory = _ProductView.SelectedCategory;
            var FilteredProductByCategory = _ProductService.GetByCategory(SelectedCategory);
            _ProductView.DisplayProducts(FilteredProductByCategory);
        }
    }
}
