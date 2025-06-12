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
<<<<<<< HEAD
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
            panel4.Location = new Point(863, 979);
            panel4.Name = "panel4";
            panel4.Size = new Size(1268, 45);
            panel4.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(858, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 1024);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(PictureBoxIcon);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(flowLayoutCartPanel);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(5, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(637, 1024);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // PictureBoxIcon
            // 
            PictureBoxIcon.Image = Properties.Resources.profileIcon;
            PictureBoxIcon.Location = new Point(553, 42);
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
            flowLayoutCartPanel.Location = new Point(21, 247);
            flowLayoutCartPanel.Name = "flowLayoutCartPanel";
            flowLayoutCartPanel.Size = new Size(588, 614);
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
            label2.Location = new Point(441, 153);
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
            FlowLayoutPanelListProduct.Size = new Size(813, 753);
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
=======
        {
            splitContainer1 = new SplitContainer();
            FlowLayoutCategoryPanel = new FlowLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            LblTitle = new Label();
            FlowLayoutPanelListProduct = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2, 2, 2, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(FlowLayoutCategoryPanel);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1MinSize = 10;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(LblTitle);
            splitContainer1.Panel2.Controls.Add(FlowLayoutPanelListProduct);
            splitContainer1.Size = new Size(1518, 819);
            splitContainer1.SplitterDistance = 319;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // FlowLayoutCategoryPanel
            // 
            FlowLayoutCategoryPanel.Location = new Point(30, 212);
            FlowLayoutCategoryPanel.Margin = new Padding(2, 2, 2, 2);
            FlowLayoutCategoryPanel.Name = "FlowLayoutCategoryPanel";
            FlowLayoutCategoryPanel.Size = new Size(267, 586);
            FlowLayoutCategoryPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.Location = new Point(25, 152);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 37);
            label1.TabIndex = 1;
            label1.Text = "Kategori";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(678, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 819);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(2, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 819);
            panel2.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(16, 212);
            flowLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(482, 605);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.Location = new Point(363, 152);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 37);
            label2.TabIndex = 3;
            label2.Text = "Keranjang";
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.Location = new Point(22, 145);
            LblTitle.Margin = new Padding(2, 0, 2, 0);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(280, 46);
            LblTitle.TabIndex = 1;
            LblTitle.Text = "List Produk Kami";
            LblTitle.Click += LblTitle_Click;
            // 
            // FlowLayoutPanelListProduct
            // 
            FlowLayoutPanelListProduct.AutoScroll = true;
            FlowLayoutPanelListProduct.Location = new Point(22, 212);
            FlowLayoutPanelListProduct.Margin = new Padding(2, 2, 2, 2);
            FlowLayoutPanelListProduct.Name = "FlowLayoutPanelListProduct";
            FlowLayoutPanelListProduct.Size = new Size(643, 586);
            FlowLayoutPanelListProduct.TabIndex = 0;
            // 
            // ListProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 819);
            Controls.Add(splitContainer1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ListProductForm";
            Text = "ListProductForm";
            Load += ListProductForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
>>>>>>> b894aa5a4003dd8bb8eb2d63c0b5fe4647806152
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
    }
}