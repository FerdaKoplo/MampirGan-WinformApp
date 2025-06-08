using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.Views.Interfaces.Customer;

namespace MampirGanWinformApp.Presenter
{
    public class DetailProductPresenter
    {
        private readonly IDetailProductVIew _DetailProdutView;
        private readonly IProductService _ProductService;

        
        public DetailProductPresenter(IDetailProductVIew DetailProductVIew,  IProductService ProductService)
        {
            _DetailProdutView = DetailProductVIew;
            _ProductService = ProductService;
        }
        public void LoadProductDetail(int ProductId)
        {
            var Product = _ProductService.GetProductById(ProductId);
            _DetailProdutView.DisplayDetailProduct(Product);
        }

    }
}
