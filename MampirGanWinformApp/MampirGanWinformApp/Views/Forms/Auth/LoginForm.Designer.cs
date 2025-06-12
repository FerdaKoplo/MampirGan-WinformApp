namespace MampirGanWinformApp.Views.Forms.Auth
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            tbUsername = new TextBox();
            label3 = new Label();
            tbPassword = new TextBox();
            label4 = new Label();
            bLogin = new Button();
            label5 = new Label();
            bSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 137);
            label1.Name = "label1";
            label1.Size = new Size(173, 41);
            label1.TabIndex = 0;
            label1.Text = "Login Page";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 178);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter valid data";
            label2.Click += label2_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(115, 283);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Enter valid Username";
            tbUsername.Size = new Size(305, 27);
            tbUsername.TabIndex = 2;
            tbUsername.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 252);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 3;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(113, 363);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Enter valid Password";
            tbPassword.Size = new Size(305, 27);
            tbPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(113, 332);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 5;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // bLogin
            // 
            bLogin.BackColor = Color.FromArgb(192, 255, 255);
            bLogin.ForeColor = SystemColors.ActiveCaptionText;
            bLogin.Location = new Point(115, 420);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(305, 39);
            bLogin.TabIndex = 6;
            bLogin.Text = "Login";
            bLogin.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(217, 471);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 7;
            label5.Text = "New user?";
            label5.Click += label5_Click;
            // 
            // bSignUp
            // 
            bSignUp.Location = new Point(188, 497);
            bSignUp.Name = "bSignUp";
            bSignUp.RightToLeft = RightToLeft.No;
            bSignUp.Size = new Size(149, 29);
            bSignUp.TabIndex = 8;
            bSignUp.Text = "Register";
            bSignUp.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 819);
            Controls.Add(bSignUp);
            Controls.Add(label5);
            Controls.Add(bLogin);
            Controls.Add(label4);
            Controls.Add(tbPassword);
            Controls.Add(label3);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUsername;
        private Label label3;
        private TextBox tbPassword;
        private Label label4;
        private Button bLogin;
        private Label label5;
        private Button bSignUp;
    }
}