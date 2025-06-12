using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Views.Interfaces.Customer;

namespace MampirGanWinformApp.Factory.Interface
{
    public interface IViewFactory
    {
        IDetailProductVIew CreateDetailProductView();
    }
}
