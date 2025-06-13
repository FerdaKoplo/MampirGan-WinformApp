namespace MampirGanWinformApp.Views.Forms.Customer
{
    partial class ListProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            FlowLayoutCategoryPanel = new FlowLayoutPanel();
            label1 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            BtnCheckout = new Button();
            LblTotalQty = new Label();
            label6 = new Label();
            LblTotalPriceInCart = new Label();
            label4 = new Label();
            label3 = new Label();
            PictureBoxIcon = new PictureBox();
            panel7 = new Panel();
            flowLayoutCartPanel = new FlowLayoutPanel();
            panel8 = new Panel();
            label2 = new Label();
            LblTitle = new Label();
            FlowLayoutPanelListProduct = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(FlowLayoutCategoryPanel);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(panel5);
            splitContainer1.Panel1.Controls.Add(panel6);
            splitContainer1.Panel1MinSize = 10;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(LblTitle);
            splitContainer1.Panel2.Controls.Add(FlowLayoutPanelListProduct);
            splitContainer1.Size = new Size(1898, 1024);
            splitContainer1.SplitterDistance = 400;
            splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCoral;
            panel3.Location = new Point(0, 979);
            panel3.Name = "panel3";
            panel3.Size = new Size(1906, 45);
            panel3.TabIndex = 3;
            // 
            // FlowLayoutCategoryPanel
            // 
            FlowLayoutCategoryPanel.Location = new Point(30, 448);
            FlowLayoutCategoryPanel.Name = "FlowLayoutCategoryPanel";
            FlowLayoutCategoryPanel.Size = new Size(343, 409);
            FlowLayoutCategoryPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.Location = new Point(30, 369);
            label1.Name = "label1";
            label1.Size = new Size(144, 45);
            label1.TabIndex = 1;
            label1.Text = "Kategori";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Cornsilk;
            panel5.Location = new Point(0, 955);
            panel5.Name = "panel5";
            panel5.Size = new Size(406, 45);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightSkyBlue;
            panel6.Location = new Point(1, 926);
            panel6.Name = "panel6";
            panel6.Size = new Size(405, 45);
            panel6.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightCoral;
            panel4.Location = new Point(1166, 979);
            panel4.Name = "panel4";
            panel4.Size = new Size(965, 45);
            panel4.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1153, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 1024);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(BtnCheckout);
            panel2.Controls.Add(LblTotalQty);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(LblTotalPriceInCart);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(PictureBoxIcon);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(flowLayoutCartPanel);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(11, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 1024);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // BtnCheckout
            // 
            BtnCheckout.BackColor = Color.Black;
            BtnCheckout.ForeColor = Color.White;
            BtnCheckout.Location = new Point(15, 849);
            BtnCheckout.Name = "BtnCheckout";
            BtnCheckout.Size = new Size(301, 43);
            BtnCheckout.TabIndex = 14;
            BtnCheckout.Text = "Checkout";
            BtnCheckout.UseVisualStyleBackColor = false;
            BtnCheckout.Click += BtnCheckout_Click;
            // 
            // LblTotalQty
            // 
            LblTotalQty.AutoSize = true;
            LblTotalQty.Font = new Font("Segoe UI", 10F);
            LblTotalQty.ForeColor = Color.Silver;
            LblTotalQty.Location = new Point(226, 702);
            LblTotalQty.Name = "LblTotalQty";
            LblTotalQty.Size = new Size(56, 28);
            LblTotalQty.TabIndex = 13;
            LblTotalQty.Text = "9999";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(15, 702);
            label6.Name = "label6";
            label6.Size = new Size(129, 28);
            label6.TabIndex = 12;
            label6.Text = "Total Barang :";
            // 
            // LblTotalPriceInCart
            // 
            LblTotalPriceInCart.AutoSize = true;
            LblTotalPriceInCart.Font = new Font("Segoe UI", 10F);
            LblTotalPriceInCart.ForeColor = Color.Silver;
            LblTotalPriceInCart.Location = new Point(226, 768);
            LblTotalPriceInCart.Name = "LblTotalPriceInCart";
            LblTotalPriceInCart.Size = new Size(56, 28);
            LblTotalPriceInCart.TabIndex = 11;
            LblTotalPriceInCart.Text = "9999";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(15, 768);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 10;
            label4.Text = "Total Harga :";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 638);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 9;
            label3.Text = "Summary";
            // 
            // PictureBoxIcon
            // 
            PictureBoxIcon.Image = Properties.Resources.profileIcon;
            PictureBoxIcon.Location = new Point(264, 55);
            PictureBoxIcon.Name = "PictureBoxIcon";
            PictureBoxIcon.Size = new Size(44, 45);
            PictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxIcon.TabIndex = 8;
            PictureBoxIcon.TabStop = false;
            PictureBoxIcon.Click += PictureBoxIcon_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Cornsilk;
            panel7.Location = new Point(-1, 955);
            panel7.Name = "panel7";
            panel7.Size = new Size(639, 45);
            panel7.TabIndex = 6;
            // 
            // flowLayoutCartPanel
            // 
            flowLayoutCartPanel.Location = new Point(15, 221);
            flowLayoutCartPanel.Name = "flowLayoutCartPanel";
            flowLayoutCartPanel.Size = new Size(301, 394);
            flowLayoutCartPanel.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightSkyBlue;
            panel8.Location = new Point(0, 926);
            panel8.Name = "panel8";
            panel8.Size = new Size(638, 45);
            panel8.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.Location = new Point(150, 155);
            label2.Name = "label2";
            label2.Size = new Size(168, 45);
            label2.TabIndex = 3;
            label2.Text = "Keranjang";
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.Location = new Point(23, 153);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(326, 54);
            LblTitle.TabIndex = 1;
            LblTitle.Text = "List Produk Kami";
            // 
            // FlowLayoutPanelListProduct
            // 
            FlowLayoutPanelListProduct.AutoScroll = true;
            FlowLayoutPanelListProduct.Location = new Point(23, 247);
            FlowLayoutPanelListProduct.Name = "FlowLayoutPanelListProduct";
            FlowLayoutPanelListProduct.Size = new Size(1106, 753);
            FlowLayoutPanelListProduct.TabIndex = 0;
            // 
            // ListProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(splitContainer1);
            Name = "ListProductForm";
            Text = "ListProductForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel FlowLayoutPanelListProduct;
        private Label LblTitle;
        private Label label1;
        private FlowLayoutPanel FlowLayoutCategoryPanel;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutCartPanel;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private PictureBox PictureBoxIcon;
        private Label label3;
        private Label label4;
        private Label LblTotalPriceInCart;
        private Label LblTotalQty;
        private Label label6;
        private Button BtnCheckout;
    }
}