namespace MampirGanWinformApp.Views.Forms.Customer
{
    partial class DetailProductForm
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
            LblPrice = new Label();
            LblProductName = new Label();
            LblCategory = new Label();
            PictureProduct = new PictureBox();
            BtnKeranjang = new Button();
            button2 = new Button();
            label1 = new Label();
            BtnDecrease = new Button();
            LblQty = new Label();
            BtnIncrease = new Button();
            LblStock = new Label();
            LblTotalPrice = new Label();
            BtnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureProduct).BeginInit();
            SuspendLayout();
            // 
            // LblPrice
            // 
            LblPrice.AutoSize = true;
            LblPrice.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPrice.Location = new Point(1066, 164);
            LblPrice.Name = "LblPrice";
            LblPrice.Size = new Size(137, 54);
            LblPrice.TabIndex = 7;
            LblPrice.Text = "label1";
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblProductName.Location = new Point(1066, 109);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(110, 45);
            LblProductName.TabIndex = 6;
            LblProductName.Text = "label1";
            // 
            // LblCategory
            // 
            LblCategory.AutoSize = true;
            LblCategory.Font = new Font("Segoe UI", 10F);
            LblCategory.Location = new Point(436, 627);
            LblCategory.Name = "LblCategory";
            LblCategory.Size = new Size(92, 28);
            LblCategory.TabIndex = 4;
            LblCategory.Text = "Category";
            // 
            // PictureProduct
            // 
            PictureProduct.Location = new Point(436, 109);
            PictureProduct.Name = "PictureProduct";
            PictureProduct.Size = new Size(583, 478);
            PictureProduct.TabIndex = 5;
            PictureProduct.TabStop = false;
            // 
            // BtnKeranjang
            // 
            BtnKeranjang.BackColor = Color.Black;
            BtnKeranjang.ForeColor = Color.White;
            BtnKeranjang.Location = new Point(1068, 732);
            BtnKeranjang.Name = "BtnKeranjang";
            BtnKeranjang.Size = new Size(294, 68);
            BtnKeranjang.TabIndex = 8;
            BtnKeranjang.Text = "Keranjang";
            BtnKeranjang.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1068, 823);
            button2.Name = "button2";
            button2.Size = new Size(294, 68);
            button2.TabIndex = 9;
            button2.Text = "Checkout";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1066, 503);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 10;
            label1.Text = "Jumlah";
            // 
            // BtnDecrease
            // 
            BtnDecrease.Location = new Point(1068, 567);
            BtnDecrease.Name = "BtnDecrease";
            BtnDecrease.Size = new Size(32, 33);
            BtnDecrease.TabIndex = 11;
            BtnDecrease.Text = "-";
            BtnDecrease.UseVisualStyleBackColor = true;
            BtnDecrease.Click += BtnDecrease_Click;
            // 
            // LblQty
            // 
            LblQty.AutoSize = true;
            LblQty.Font = new Font("Segoe UI", 10F);
            LblQty.Location = new Point(1135, 569);
            LblQty.Name = "LblQty";
            LblQty.Size = new Size(23, 28);
            LblQty.TabIndex = 12;
            LblQty.Text = "0";
            // 
            // BtnIncrease
            // 
            BtnIncrease.Location = new Point(1195, 567);
            BtnIncrease.Name = "BtnIncrease";
            BtnIncrease.Size = new Size(32, 33);
            BtnIncrease.TabIndex = 13;
            BtnIncrease.Text = "+";
            BtnIncrease.UseVisualStyleBackColor = true;
            BtnIncrease.Click += BtnIncrease_Click;
            // 
            // LblStock
            // 
            LblStock.AutoSize = true;
            LblStock.Location = new Point(1068, 239);
            LblStock.Name = "LblStock";
            LblStock.Size = new Size(59, 25);
            LblStock.TabIndex = 14;
            LblStock.Text = "label3";
            // 
            // LblTotalPrice
            // 
            LblTotalPrice.AutoSize = true;
            LblTotalPrice.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTotalPrice.Location = new Point(1068, 655);
            LblTotalPrice.Name = "LblTotalPrice";
            LblTotalPrice.Size = new Size(118, 48);
            LblTotalPrice.TabIndex = 15;
            LblTotalPrice.Text = "label3";
            // 
            // BtnKembali
            // 
            BtnKembali.Location = new Point(257, 109);
            BtnKembali.Name = "BtnKembali";
            BtnKembali.Size = new Size(128, 45);
            BtnKembali.TabIndex = 16;
            BtnKembali.Text = "Kembali";
            BtnKembali.UseVisualStyleBackColor = true;
            BtnKembali.Click += BtnKembali_Click;
            // 
            // DetailProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1898, 1024);
            Controls.Add(BtnKembali);
            Controls.Add(LblTotalPrice);
            Controls.Add(LblStock);
            Controls.Add(BtnIncrease);
            Controls.Add(LblQty);
            Controls.Add(BtnDecrease);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(BtnKeranjang);
            Controls.Add(LblPrice);
            Controls.Add(LblProductName);
            Controls.Add(LblCategory);
            Controls.Add(PictureProduct);
            Name = "DetailProductForm";
            Text = "DetailProductForm";
            ((System.ComponentModel.ISupportInitialize)PictureProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblPrice;
        private Label LblProductName;
        private Label LblCategory;
        private PictureBox PictureProduct;
        private Button BtnKeranjang;
        private Button button2;
        private Label label1;
        private Button BtnDecrease;
        private Label LblQty;
        private Button BtnIncrease;
        private Label LblStock;
        private Label LblTotalPrice;
        private Button BtnKembali;
    }
}