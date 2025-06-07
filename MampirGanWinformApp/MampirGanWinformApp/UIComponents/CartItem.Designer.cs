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
            decrease = new Button();
            increase = new Button();
            Quantity = new Label();
            Price = new Label();
            label2 = new Label();
            Delete = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // decrease
            // 
            decrease.BackColor = Color.White;
            decrease.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            decrease.Location = new Point(454, 67);
            decrease.Name = "decrease";
            decrease.Size = new Size(40, 45);
            decrease.TabIndex = 12;
            decrease.Text = "-";
            decrease.UseVisualStyleBackColor = false;
            // 
            // increase
            // 
            increase.BackColor = Color.White;
            increase.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            increase.Location = new Point(576, 67);
            increase.Name = "increase";
            increase.Size = new Size(40, 45);
            increase.TabIndex = 11;
            increase.Text = "+";
            increase.UseVisualStyleBackColor = false;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Quantity.Location = new Point(524, 75);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(23, 28);
            Quantity.TabIndex = 10;
            Quantity.Text = "0";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Price.Location = new Point(881, 75);
            Price.Name = "Price";
            Price.Size = new Size(23, 28);
            Price.TabIndex = 13;
            Price.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(839, 75);
            label2.Name = "label2";
            label2.Size = new Size(36, 28);
            label2.TabIndex = 14;
            label2.Text = "Rp";
            // 
            // Delete
            // 
            Delete.BackColor = Color.White;
            Delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.ForeColor = Color.Red;
            Delete.Location = new Point(1163, 67);
            Delete.Name = "Delete";
            Delete.Size = new Size(40, 45);
            Delete.TabIndex = 15;
            Delete.Text = "X";
            Delete.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(56, 21);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(139, 141);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // CartItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Delete);
            Controls.Add(label2);
            Controls.Add(Price);
            Controls.Add(decrease);
            Controls.Add(increase);
            Controls.Add(Quantity);
            Name = "CartItem";
            Size = new Size(1280, 178);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button decrease;
        private Button increase;
        private Label Quantity;
        private Label Price;
        private Label label2;
        private Button Delete;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
