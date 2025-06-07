using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Model;

namespace MampirGanWinformApp.Views.Interfaces.Customer
{
    public interface IListProductView
    {
        void DisplayProducts(List<Product> Products);
        string SelectedCategory { get; }
        event EventHandler CategoryChanged;
    }
}
