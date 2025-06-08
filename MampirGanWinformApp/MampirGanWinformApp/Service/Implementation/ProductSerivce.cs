using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Model;
using MampirGanWinformApp.Service.Interface;
using MampirGanWinformApp.Utils;

namespace MampirGanWinformApp.Service.Implementation
{
    public class ProductService : IProductService
    {
        public readonly LoadProductListJson _Loader;

        public ProductService(LoadProductListJson Loader)
        {
            _Loader = Loader;
            Loader.Load();
        }

        public List<Product> GetAllProducts()
        {
            return _Loader.Products;
        }

        public List<Product> GetByCategory(List<string> CategoryName)
        {
            return _Loader.Products
             .Where(p => p.Category != null &&
             CategoryName.Any(InputCategory => p.Category.CategoryName.Equals(InputCategory, StringComparison.OrdinalIgnoreCase)))
        .    ToList();
        }
    }
}
