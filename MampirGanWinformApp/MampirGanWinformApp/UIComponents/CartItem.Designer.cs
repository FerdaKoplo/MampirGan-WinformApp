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
            Quantity = new Label();
            LblTotalPrice = new Label();
            BtnDelete = new Button();
            SuspendLayout();
            // 
            // BtnDecrease
            // 
            BtnDecrease.BackColor = Color.White;
            BtnDecrease.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDecrease.Location = new Point(437, 84);
            BtnDecrease.Name = "BtnDecrease";
            BtnDecrease.Size = new Size(40, 45);
            BtnDecrease.TabIndex = 12;
            BtnDecrease.Text = "-";
            BtnDecrease.UseVisualStyleBackColor = false;
            // 
            // BtnIncrease
            // 
            BtnIncrease.BackColor = Color.White;
            BtnIncrease.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIncrease.Location = new Point(559, 84);
            BtnIncrease.Name = "BtnIncrease";
            BtnIncrease.Size = new Size(40, 45);
            BtnIncrease.TabIndex = 11;
            BtnIncrease.Text = "+";
            BtnIncrease.UseVisualStyleBackColor = false;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Quantity.Location = new Point(507, 92);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(23, 28);
            Quantity.TabIndex = 10;
            Quantity.Text = "0";
            // 
            // LblTotalPrice
            // 
            LblTotalPrice.AutoSize = true;
            LblTotalPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTotalPrice.Location = new Point(822, 92);
            LblTotalPrice.Name = "LblTotalPrice";
            LblTotalPrice.Size = new Size(56, 28);
            LblTotalPrice.TabIndex = 14;
            LblTotalPrice.Text = "9999";
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.White;
            BtnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDelete.ForeColor = Color.Red;
            BtnDelete.Location = new Point(1146, 84);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(40, 45);
            BtnDelete.TabIndex = 15;
            BtnDelete.Text = "X";
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // CartItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(BtnDelete);
            Controls.Add(LblTotalPrice);
            Controls.Add(BtnDecrease);
            Controls.Add(BtnIncrease);
            Controls.Add(Quantity);
            Name = "CartItem";
            Size = new Size(1280, 213);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDecrease;
        private Button BtnIncrease;
        private Label Quantity;
        private Label Price;
        private Label LblTotalPrice;
        private Button BtnDelete;
    }
}
