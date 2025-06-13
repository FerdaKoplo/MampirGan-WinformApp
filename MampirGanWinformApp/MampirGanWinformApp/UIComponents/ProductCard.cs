using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MampirGanWinformApp.Model;

namespace MampirGanWinformApp.UIComponents
{
    public partial class ProductCard : UserControl
    {
        public event EventHandler DetailClicked;
        
        public Product ProductDetailData { get; set; }
        public ProductCard()
        {
            InitializeComponent();

        }
        public string ProductNameLabel
        {
            get => LblProductName.Text;
            set => LblProductName.Text = value;
        }

        public string CategoryLabel
        {
            get => LblCategory.Text;
            set => LblCategory.Text = value;
        }

        public string PriceLabel
        {
            get => LblPrice.Text;
            set => LblPrice.Text = value;
        }

        public Image ProductImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        private void LblLihat_Click(object sender, EventArgs e)
        {
            DetailClicked?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
