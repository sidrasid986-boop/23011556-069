using System;
using System.Windows.Forms;

namespace LoginNavigationApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUser;
        private Label lblPass;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.lblUser = new Label();
            this.lblPass = new Label();
            this.SuspendLayout();

            // Username Label
            this.lblUser.Text = "Username:";
            this.lblUser.Location = new System.Drawing.Point(40, 40);
            this.lblUser.AutoSize = true;

            // Password Label
            this.lblPass.Text = "Password:";
            this.lblPass.Location = new System.Drawing.Point(40, 80);
            this.lblPass.AutoSize = true;

            // Username TextBox
            this.txtUsername.Location = new System.Drawing.Point(130, 40);
            this.txtUsername.Width = 150;

            // Password TextBox
            this.txtPassword.Location = new System.Drawing.Point(130, 80);
            this.txtPassword.Width = 150;
            this.txtPassword.PasswordChar = '*';

            // Login Button
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(130, 120);
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Text = "Login Form";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

