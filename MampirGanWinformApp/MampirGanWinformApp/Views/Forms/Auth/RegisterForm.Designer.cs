namespace MampirGanWinformApp.Views.Forms.Auth
{
    partial class RegisterForm
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
            label3 = new Label();
            tbEmail = new TextBox();
            label4 = new Label();
            tbUsername = new TextBox();
            label5 = new Label();
            tbPassword = new TextBox();
            bRegister = new Button();
            label6 = new Label();
            bLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 149);
            label1.Name = "label1";
            label1.Size = new Size(194, 38);
            label1.TabIndex = 1;
            label1.Text = "Register Page";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 187);
            label2.Name = "label2";
            label2.Size = new Size(266, 23);
            label2.TabIndex = 2;
            label2.Text = "Enter your information to register";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(130, 261);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 4;
            label3.Text = "E-Mail";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(261, 260);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Enter your E-mail";
            tbEmail.Size = new Size(305, 27);
            tbEmail.TabIndex = 5;
            tbEmail.TextChanged += tbUsername_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(130, 306);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 6;
            label4.Text = "Username";
            label4.Click += label4_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(261, 305);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Enter your Username";
            tbUsername.Size = new Size(305, 27);
            tbUsername.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(130, 350);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(261, 350);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Enter your Password";
            tbPassword.Size = new Size(305, 27);
            tbPassword.TabIndex = 9;
            // 
            // bRegister
            // 
            bRegister.BackColor = Color.FromArgb(192, 255, 255);
            bRegister.ForeColor = SystemColors.ActiveCaptionText;
            bRegister.Location = new Point(261, 402);
            bRegister.Name = "bRegister";
            bRegister.Size = new Size(305, 39);
            bRegister.TabIndex = 10;
            bRegister.Text = "Register";
            bRegister.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(353, 472);
            label6.Name = "label6";
            label6.Size = new Size(120, 23);
            label6.TabIndex = 11;
            label6.Text = "have account?";
            // 
            // bLogin
            // 
            bLogin.Location = new Point(336, 498);
            bLogin.Name = "bLogin";
            bLogin.RightToLeft = RightToLeft.No;
            bLogin.Size = new Size(149, 29);
            bLogin.TabIndex = 12;
            bLogin.Text = "Login";
            bLogin.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 819);
            Controls.Add(bLogin);
            Controls.Add(label6);
            Controls.Add(bRegister);
            Controls.Add(tbPassword);
            Controls.Add(label5);
            Controls.Add(tbUsername);
            Controls.Add(label4);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbEmail;
        private Label label4;
        private TextBox tbUsername;
        private Label label5;
        private TextBox tbPassword;
        private Button bRegister;
        private Label label6;
        private Button bLogin;
    }
}