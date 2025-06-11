namespace MampirGanWinformApp.Views.Forms.Customer
{
    partial class CheckoutForm
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
            panel1 = new Panel();
            LblQty = new Label();
            LblProductName = new Label();
            BtnCheckout = new Button();
            LblTotalPrice = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(LblQty);
            panel1.Controls.Add(LblProductName);
            panel1.Controls.Add(BtnCheckout);
            panel1.Controls.Add(LblTotalPrice);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 450);
            panel1.TabIndex = 0;
            // 
            // LblQty
            // 
            LblQty.AutoSize = true;
            LblQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblQty.Location = new Point(138, 195);
            LblQty.Name = "LblQty";
            LblQty.Size = new Size(78, 32);
            LblQty.TabIndex = 4;
            LblQty.Text = "label2";
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblProductName.Location = new Point(188, 86);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(94, 38);
            LblProductName.TabIndex = 3;
            LblProductName.Text = "label2";
            // 
            // BtnCheckout
            // 
            BtnCheckout.BackColor = Color.Black;
            BtnCheckout.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCheckout.ForeColor = Color.White;
            BtnCheckout.Location = new Point(89, 362);
            BtnCheckout.Name = "BtnCheckout";
            BtnCheckout.Size = new Size(359, 52);
            BtnCheckout.TabIndex = 2;
            BtnCheckout.Text = "Bayar";
            BtnCheckout.UseVisualStyleBackColor = false;
            BtnCheckout.Click += BtnCheckout_Click;
            // 
            // LblTotalPrice
            // 
            LblTotalPrice.AutoSize = true;
            LblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTotalPrice.Location = new Point(138, 276);
            LblTotalPrice.Name = "LblTotalPrice";
            LblTotalPrice.Size = new Size(78, 32);
            LblTotalPrice.TabIndex = 1;
            LblTotalPrice.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 21);
            label1.Name = "label1";
            label1.Size = new Size(179, 38);
            label1.TabIndex = 0;
            label1.Text = "Pembayaran";
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(578, 474);
            Controls.Add(panel1);
            Name = "CheckoutForm";
            Text = "CheckoutForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label LblTotalPrice;
        private Label LblQty;
        private Label LblProductName;
        private Button BtnCheckout;
    }
}