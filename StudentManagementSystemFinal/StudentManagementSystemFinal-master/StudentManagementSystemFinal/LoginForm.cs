using System;
using System.Windows.Forms;

namespace StudentManagementSystemFinal
{
    public class LoginForm : Form
    {
        TextBox txtUsername, txtPassword;
        Button btnLogin;

        public LoginForm()
        {
            this.Text = "Login Form";
            this.Width = 300;
            this.Height = 200;

            Label lblUser = new Label() { Text = "Username:", Top = 20, Left = 20 };
            Label lblPass = new Label() { Text = "Password:", Top = 60, Left = 20 };
            txtUsername = new TextBox() { Top = 20, Left = 100, Width = 150 };
            txtPassword = new TextBox() { Top = 60, Left = 100, Width = 150, UseSystemPasswordChar = true };
            btnLogin = new Button() { Text = "Login", Top = 100, Left = 100, Width = 100 };

            btnLogin.Click += BtnLogin_Click;

            Controls.Add(lblUser);
            Controls.Add(lblPass);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                DashboardForm dash = new DashboardForm();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}
