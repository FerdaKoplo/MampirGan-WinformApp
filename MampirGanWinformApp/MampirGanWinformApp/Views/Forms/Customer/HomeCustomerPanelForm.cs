using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MampirGanWinformApp.Views.Interfaces.Customer;

namespace MampirGanWinformApp.Views.Forms.Customer
{
    public partial class HomeCustomerPanelForm : Form, IHomeCustomerPanel
    {
        public HomeCustomerPanelForm()
        {
            InitializeComponent();
        }


        public void DisplayHomeCustomerPanel()
        {
            this.Show();
        }

        private void BtnListKatalog_Click(object sender, EventArgs e)
        {
            IListProductView ListProductView = new ListProductForm();
            ((Form)ListProductView).Show();
            this.Hide();
        }
    }
}
