using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    partial class LoginForm
    {
        private IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUser;
        private Label lblPass;
        private Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.lblUser = new Label();
            this.lblPass = new Label();
            this.btnLogin = new Button();

            this.lblUser.AutoSize = true;
            this.lblUser.Text = "Username:";
            this.lblUser.Location = new Point(30, 30);

            this.txtUsername.Location = new Point(120, 27);
            this.txtUsername.Width = 150;
            this.txtUsername.Name = "txtUsername";

            this.lblPass.AutoSize = true;
            this.lblPass.Text = "Password:";
            this.lblPass.Location = new Point(30, 70);

            this.txtPassword.Location = new Point(120, 67);
            this.txtPassword.Width = 150;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';

            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new Point(120, 110);
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
            this.btnLogin.Name = "btnLogin";

            this.ClientSize = new Size(320, 180);
            this.Controls.AddRange(new Control[] { txtUsername, txtPassword, lblUser, lblPass, btnLogin });
            this.Text = "Login Form";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
    }
}
