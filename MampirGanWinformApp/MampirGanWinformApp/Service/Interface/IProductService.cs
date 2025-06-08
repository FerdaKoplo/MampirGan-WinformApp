using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Model;

namespace MampirGanWinformApp.Service.Interface
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        List<Product> GetByCategory(List<string> CategoryName);

        Product GetProductById(int ProductId);
    }
}
