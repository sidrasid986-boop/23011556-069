using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalculatorWithHistory
{
    partial class LoginForm
    {
        private IContainer components = null;
        private TextBox txtUser;
        private TextBox txtPass;
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
            this.txtUser = new TextBox();
            this.txtPass = new TextBox();
            this.lblUser = new Label();
            this.lblPass = new Label();
            this.btnLogin = new Button();

            this.lblUser.Text = "Username:";
            this.lblUser.Location = new Point(30, 30);

            this.txtUser.Location = new Point(120, 27);
            this.txtUser.Width = 150;

            this.lblPass.Text = "Password:";
            this.lblPass.Location = new Point(30, 70);

            this.txtPass.Location = new Point(120, 67);
            this.txtPass.PasswordChar = '*';
            this.txtPass.Width = 150;

            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new Point(120, 110);
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            this.ClientSize = new Size(320, 180);
            this.Controls.AddRange(new Control[] { txtUser, txtPass, lblUser, lblPass, btnLogin });
            this.Text = "Login - Simple Calculator";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
    }
}
