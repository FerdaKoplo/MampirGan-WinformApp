namespace MampirGanWinformApp.UIComponents
{
    partial class ProductCard
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
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            LblCategory = new Label();
            LblPrice = new Label();
            LblProductName = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.PeachPuff;
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(LblCategory);
            splitContainer1.Panel2.Controls.Add(LblPrice);
            splitContainer1.Panel2.Controls.Add(LblProductName);
            splitContainer1.Panel2MinSize = 100;
            splitContainer1.Size = new Size(297, 448);
            splitContainer1.SplitterDistance = 268;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(28, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 210);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LblCategory
            // 
            LblCategory.AutoSize = true;
            LblCategory.ForeColor = SystemColors.ControlDarkDark;
            LblCategory.Location = new Point(28, 50);
            LblCategory.Name = "LblCategory";
            LblCategory.Size = new Size(70, 25);
            LblCategory.TabIndex = 2;
            LblCategory.Text = "#label3";
            // 
            // LblPrice
            // 
            LblPrice.AutoSize = true;
            LblPrice.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPrice.Location = new Point(28, 116);
            LblPrice.Name = "LblPrice";
            LblPrice.Size = new Size(105, 45);
            LblPrice.TabIndex = 1;
            LblPrice.Text = "label2";
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblProductName.Location = new Point(24, 0);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(104, 41);
            LblProductName.TabIndex = 0;
            LblProductName.Text = "label1";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ProductCard";
            Size = new Size(297, 448);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label LblProductName;
        private Label LblPrice;
        private Label LblCategory;
    }
}
