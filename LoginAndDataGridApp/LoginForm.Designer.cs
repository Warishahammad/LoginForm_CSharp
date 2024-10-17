﻿namespace LoginAndDataGridApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_usename = new Label();
            txt_password = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btn_exit = new Button();
            Welcome = new Label();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // txt_usename
            // 
            txt_usename.AutoSize = true;
            txt_usename.Font = new Font("Segoe UI", 12F);
            txt_usename.Location = new Point(309, 220);
            txt_usename.Name = "txt_usename";
            txt_usename.Size = new Size(108, 28);
            txt_usename.TabIndex = 0;
            txt_usename.Text = "User Name";
            // 
            // txt_password
            // 
            txt_password.AutoSize = true;
            txt_password.Font = new Font("Segoe UI", 12F);
            txt_password.Location = new Point(309, 283);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(93, 28);
            txt_password.TabIndex = 1;
            txt_password.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(435, 216);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(284, 34);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(435, 279);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(284, 34);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(283, 362);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 49);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += Btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = SystemColors.Control;
            btn_exit.Font = new Font("Segoe UI", 12F);
            btn_exit.Location = new Point(681, 362);
            btn_exit.Margin = new Padding(3, 4, 3, 4);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(120, 49);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Microsoft Sans Serif", 14F);
            Welcome.Location = new Point(370, 73);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(217, 29);
            Welcome.TabIndex = 6;
            Welcome.Text = "Welcome To Login";
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.Control;
            btn_clear.Font = new Font("Segoe UI", 12F);
            btn_clear.Location = new Point(491, 362);
            btn_clear.Margin = new Padding(3, 4, 3, 4);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(120, 49);
            btn_clear.TabIndex = 7;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += Btn_clear_CLick;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(971, 600);
            Controls.Add(btn_clear);
            Controls.Add(Welcome);
            Controls.Add(btn_exit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txt_password);
            Controls.Add(txt_usename);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_usename;
        private Label txt_password;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btn_exit;
        private Label Welcome;
        private Button btn_clear;
    }
}
