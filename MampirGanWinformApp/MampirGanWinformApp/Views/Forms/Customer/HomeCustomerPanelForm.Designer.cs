namespace MampirGanWinformApp.Views.Forms.Customer
{
    partial class HomeCustomerPanelForm
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
            button3 = new Button();
            button2 = new Button();
            BtnListKatalog = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            buttonCari = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonCari);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(BtnListKatalog);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 1041);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 924);
            button3.Name = "button3";
            button3.Size = new Size(308, 62);
            button3.TabIndex = 2;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 355);
            button2.Name = "button2";
            button2.Size = new Size(308, 55);
            button2.TabIndex = 1;
            button2.Text = "History Pembelian";
            button2.UseVisualStyleBackColor = false;
            // 
            // BtnListKatalog
            // 
            BtnListKatalog.BackColor = Color.White;
            BtnListKatalog.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnListKatalog.ForeColor = Color.Black;
            BtnListKatalog.Location = new Point(12, 300);
            BtnListKatalog.Name = "BtnListKatalog";
            BtnListKatalog.Size = new Size(308, 49);
            BtnListKatalog.TabIndex = 0;
            BtnListKatalog.Text = "List Katalog";
            BtnListKatalog.UseVisualStyleBackColor = false;
            BtnListKatalog.Click += BtnListKatalog_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(81, 32);
            label1.Name = "label1";
            label1.Size = new Size(164, 45);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Location = new Point(341, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1562, 1029);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCoral;
            panel3.Location = new Point(1, 980);
            panel3.Name = "panel3";
            panel3.Size = new Size(1906, 45);
            panel3.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Cornsilk;
            panel5.Location = new Point(1, 956);
            panel5.Name = "panel5";
            panel5.Size = new Size(1559, 45);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightSkyBlue;
            panel6.Location = new Point(1, 927);
            panel6.Name = "panel6";
            panel6.Size = new Size(1558, 45);
            panel6.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AntiqueWhite;
            panel4.Location = new Point(341, 970);
            panel4.Name = "panel4";
            panel4.Size = new Size(332, 37);
            panel4.TabIndex = 2;
            // 
            // buttonCari
            // 
            buttonCari.BackColor = Color.Black;
            buttonCari.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCari.ForeColor = Color.White;
            buttonCari.Location = new Point(12, 228);
            buttonCari.Name = "buttonCari";
            buttonCari.Size = new Size(308, 55);
            buttonCari.TabIndex = 3;
            buttonCari.Text = "Search Menu";
            buttonCari.UseVisualStyleBackColor = false;
            buttonCari.Click += button1_Click;
            // 
            // HomeCustomerPanelForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "HomeCustomerPanelForm";
            Text = "HomeCustomerPanelForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button BtnListKatalog;
        private Panel panel4;
        private Button button3;
        private Button button2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Button buttonCari;
    }
}