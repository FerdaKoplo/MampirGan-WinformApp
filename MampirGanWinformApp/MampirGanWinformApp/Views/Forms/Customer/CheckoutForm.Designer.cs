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
            label3 = new Label();
            label2 = new Label();
            LblQty = new Label();
            LblProductName = new Label();
            BtnCheckout = new Button();
            LblTotalPrice = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LblQty);
            panel1.Controls.Add(LblProductName);
            panel1.Controls.Add(BtnCheckout);
            panel1.Controls.Add(LblTotalPrice);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 395);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 223);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 6;
            label3.Text = "Total Harga";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(58, 157);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 5;
            label2.Text = "Total Barang";
            // 
            // LblQty
            // 
            LblQty.AutoSize = true;
            LblQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblQty.ForeColor = Color.Silver;
            LblQty.Location = new Point(460, 153);
            LblQty.Name = "LblQty";
            LblQty.Size = new Size(78, 32);
            LblQty.TabIndex = 4;
            LblQty.Text = "label2";
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            LblProductName.Location = new Point(58, 60);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(66, 28);
            LblProductName.TabIndex = 3;
            LblProductName.Text = "label2";
            // 
            // BtnCheckout
            // 
            BtnCheckout.BackColor = Color.Black;
            BtnCheckout.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCheckout.ForeColor = Color.White;
            BtnCheckout.Location = new Point(52, 322);
            BtnCheckout.Name = "BtnCheckout";
            BtnCheckout.Size = new Size(480, 52);
            BtnCheckout.TabIndex = 2;
            BtnCheckout.Text = "Bayar";
            BtnCheckout.UseVisualStyleBackColor = false;
            BtnCheckout.Click += BtnCheckout_Click;
            // 
            // LblTotalPrice
            // 
            LblTotalPrice.AutoSize = true;
            LblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTotalPrice.Location = new Point(460, 219);
            LblTotalPrice.Name = "LblTotalPrice";
            LblTotalPrice.Size = new Size(78, 32);
            LblTotalPrice.TabIndex = 1;
            LblTotalPrice.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 13);
            label1.Name = "label1";
            label1.Size = new Size(179, 38);
            label1.TabIndex = 0;
            label1.Text = "Pembayaran";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(58, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(474, 10);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Location = new Point(58, 285);
            panel3.Name = "panel3";
            panel3.Size = new Size(474, 10);
            panel3.TabIndex = 8;
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(614, 423);
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
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Panel panel2;
    }
}