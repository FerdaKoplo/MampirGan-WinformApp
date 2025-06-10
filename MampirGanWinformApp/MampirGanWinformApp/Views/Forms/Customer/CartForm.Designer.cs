namespace MampirGanWinformApp.Views.Forms.Customer
{
    partial class CartForm
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
            panel1 = new Panel();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            FlowLayoutCartItemPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1898, 1024);
            splitContainer1.SplitterDistance = 1250;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(FlowLayoutCartItemPanel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(41, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(1169, 879);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(828, 160);
            label6.Name = "label6";
            label6.Size = new Size(115, 28);
            label6.TabIndex = 5;
            label6.Text = "Total Harga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(491, 160);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 4;
            label5.Text = "Jumlah";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(122, 160);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 3;
            label4.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(942, 55);
            label3.Name = "label3";
            label3.Size = new Size(188, 28);
            label3.TabIndex = 2;
            label3.Text = "Bersihkan Keranjang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(225, 55);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 1;
            label2.Text = "(label2)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.Location = new Point(26, 35);
            label1.Name = "label1";
            label1.Size = new Size(205, 54);
            label1.TabIndex = 0;
            label1.Text = "Keranjang";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Font = new Font("Segoe UI", 9F);
            panel2.Location = new Point(37, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(572, 417);
            panel2.TabIndex = 0;
            // 
            // FlowLayoutCartItemPanel
            // 
            FlowLayoutCartItemPanel.Location = new Point(26, 239);
            FlowLayoutCartItemPanel.Name = "FlowLayoutCartItemPanel";
            FlowLayoutCartItemPanel.Size = new Size(1104, 615);
            FlowLayoutCartItemPanel.TabIndex = 1;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(splitContainer1);
            Name = "CartForm";
            Text = "CartForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button1;
        private FlowLayoutPanel FlowLayoutCartItemPanel;
    }
}