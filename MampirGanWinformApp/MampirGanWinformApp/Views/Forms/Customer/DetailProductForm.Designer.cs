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
            ((System.ComponentModel.ISupportInitialize)PictureProduct).BeginInit();
            SuspendLayout();
            // 
            // LblPrice
            // 
            LblPrice.AutoSize = true;
            LblPrice.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPrice.Location = new Point(1122, 172);
            LblPrice.Name = "LblPrice";
            LblPrice.Size = new Size(137, 54);
            LblPrice.TabIndex = 7;
            LblPrice.Text = "label1";
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblProductName.Location = new Point(1122, 103);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(110, 45);
            LblProductName.TabIndex = 6;
            LblProductName.Text = "label1";
            // 
            // LblCategory
            // 
            LblCategory.AutoSize = true;
            LblCategory.Font = new Font("Segoe UI", 10F);
            LblCategory.Location = new Point(492, 621);
            LblCategory.Name = "LblCategory";
            LblCategory.Size = new Size(92, 28);
            LblCategory.TabIndex = 4;
            LblCategory.Text = "Category";
            // 
            // PictureProduct
            // 
            PictureProduct.Location = new Point(492, 103);
            PictureProduct.Name = "PictureProduct";
            PictureProduct.Size = new Size(583, 476);
            PictureProduct.TabIndex = 5;
            PictureProduct.TabStop = false;
            // 
            // DetailProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
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
    }
}