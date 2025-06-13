namespace MampirGanWinformApp.Views.Forms.Customer
{
    partial class DashboardCustomerForm
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
            LblCategory = new Label();
            SuspendLayout();
            // 
            // LblCategory
            // 
            LblCategory.AutoSize = true;
            LblCategory.Font = new Font("Segoe UI", 10F);
            LblCategory.Location = new Point(720, 398);
            LblCategory.Margin = new Padding(2, 0, 2, 0);
            LblCategory.Name = "LblCategory";
            LblCategory.Size = new Size(220, 23);
            LblCategory.TabIndex = 5;
            LblCategory.Text = "Selamat Datang, Customer!";
            // 
            // DashboardCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 819);
            Controls.Add(LblCategory);
            Name = "DashboardCustomerForm";
            Text = "DashboardCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCategory;
    }
}