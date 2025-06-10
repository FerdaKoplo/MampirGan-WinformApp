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
            FlowLayoutCategoryPanel = new FlowLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            LblTitle = new Label();
            FlowLayoutPanelListProduct = new FlowLayoutPanel();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            splitContainer1.Size = new Size(1898, 1024);
            splitContainer1.SplitterDistance = 400;
            splitContainer1.TabIndex = 0;
            // 
            // FlowLayoutCategoryPanel
            // 
            FlowLayoutCategoryPanel.Location = new Point(37, 265);
            FlowLayoutCategoryPanel.Name = "FlowLayoutCategoryPanel";
            FlowLayoutCategoryPanel.Size = new Size(334, 733);
            FlowLayoutCategoryPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.Location = new Point(31, 190);
            label1.Name = "label1";
            label1.Size = new Size(144, 45);
            label1.TabIndex = 1;
            label1.Text = "Kategori";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(848, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 1024);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(647, 1024);
            panel2.TabIndex = 6;
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.Location = new Point(28, 181);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(326, 54);
            LblTitle.TabIndex = 1;
            LblTitle.Text = "List Produk Kami";
            // 
            // FlowLayoutPanelListProduct
            // 
            FlowLayoutPanelListProduct.AutoScroll = true;
            FlowLayoutPanelListProduct.Location = new Point(28, 265);
            FlowLayoutPanelListProduct.Name = "FlowLayoutPanelListProduct";
            FlowLayoutPanelListProduct.Size = new Size(804, 733);
            FlowLayoutPanelListProduct.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.Location = new Point(454, 190);
            label2.Name = "label2";
            label2.Size = new Size(168, 45);
            label2.TabIndex = 3;
            label2.Text = "Keranjang";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(20, 265);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(602, 756);
            flowLayoutPanel1.TabIndex = 4;
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
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
    }
}