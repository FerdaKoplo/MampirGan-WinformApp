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


        public DetailProductPresenter(IDetailProductVIew DetailProductVIew, IProductService ProductService)
        {
            _DetailProdutView = DetailProductVIew;
            _ProductService = ProductService;
        }
        public void LoadProductDetail(int ProductId)
        {
            try
            {
                var Product = _ProductService.GetProductById(ProductId);
                _DetailProdutView.DisplayDetailProduct(Product);

            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show($"Tidak bisa Mengakses Detail Produk: {ex.Message}", "State Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

    }
}
