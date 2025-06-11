namespace MampirGanWinformApp.UIComponents
{
    partial class CartItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnDecrease = new Button();
            BtnIncrease = new Button();
            LblQty = new Label();
            LblTotalPrice = new Label();
            LblProductName = new Label();
            BtnCheckout = new Button();
            BtnRemoveCart = new Label();
            SuspendLayout();
            // 
            // BtnDecrease
            // 
            BtnDecrease.Location = new Point(22, 101);
            BtnDecrease.Name = "BtnDecrease";
            BtnDecrease.Size = new Size(35, 37);
            BtnDecrease.TabIndex = 0;
            BtnDecrease.Text = "-";
            BtnDecrease.UseVisualStyleBackColor = true;
            // 
            // BtnIncrease
            // 
            BtnIncrease.Location = new Point(228, 101);
            BtnIncrease.Name = "BtnIncrease";
            BtnIncrease.Size = new Size(35, 37);
            BtnIncrease.TabIndex = 1;
            BtnIncrease.Text = "+";
            BtnIncrease.UseVisualStyleBackColor = true;
            // 
            // LblQty
            // 
            LblQty.AutoSize = true;
            LblQty.Location = new Point(125, 107);
            LblQty.Name = "LblQty";
            LblQty.Size = new Size(22, 25);
            LblQty.TabIndex = 2;
            LblQty.Text = "9";
            // 
            // LblTotalPrice
            // 
            LblTotalPrice.AutoSize = true;
            LblTotalPrice.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTotalPrice.Location = new Point(105, 161);
            LblTotalPrice.Name = "LblTotalPrice";
            LblTotalPrice.Size = new Size(70, 30);
            LblTotalPrice.TabIndex = 3;
            LblTotalPrice.Text = "label1";
            LblTotalPrice.Click += LblTotalPrice_Click;
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblProductName.Location = new Point(66, 16);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(96, 38);
            LblProductName.TabIndex = 4;
            LblProductName.Text = "label1";
            // 
            // BtnCheckout
            // 
            BtnCheckout.BackColor = Color.Black;
            BtnCheckout.ForeColor = Color.White;
            BtnCheckout.Location = new Point(22, 212);
            BtnCheckout.Name = "BtnCheckout";
            BtnCheckout.Size = new Size(241, 42);
            BtnCheckout.TabIndex = 5;
            BtnCheckout.Text = "Checkout";
            BtnCheckout.UseVisualStyleBackColor = false;
            BtnCheckout.Click += BtnCheckout_Click;
            // 
            // BtnRemoveCart
            // 
            BtnRemoveCart.AutoSize = true;
            BtnRemoveCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRemoveCart.ForeColor = Color.Red;
            BtnRemoveCart.Location = new Point(3, 0);
            BtnRemoveCart.Name = "BtnRemoveCart";
            BtnRemoveCart.Size = new Size(30, 32);
            BtnRemoveCart.TabIndex = 6;
            BtnRemoveCart.Text = "X";
            BtnRemoveCart.Click += BtnRemoveCart_Click;
            // 
            // CartItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(BtnRemoveCart);
            Controls.Add(BtnCheckout);
            Controls.Add(LblProductName);
            Controls.Add(LblTotalPrice);
            Controls.Add(LblQty);
            Controls.Add(BtnIncrease);
            Controls.Add(BtnDecrease);
            Name = "CartItem";
            Size = new Size(288, 275);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDecrease;
        private Button BtnIncrease;
        private Label LblQty;
        private Label LblTotalPrice;
        private Label LblProductName;
        private Button BtnCheckout;
        private Label BtnRemoveCart;
    }
}
