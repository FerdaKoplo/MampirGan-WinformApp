using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.Factory.Interface;
using MampirGanWinformApp.Views.Forms.Customer;
using MampirGanWinformApp.Views.Interfaces.Customer;

namespace MampirGanWinformApp.Factory.Implementation
{
    public class ViewFactory : IViewFactory
    {
        public IDetailProductVIew CreateDetailProductView()
        {
            return new DetailProductForm();
        }
    }
}
