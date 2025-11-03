using System;
using System.Windows.Forms;

namespace SimpleCalculatorWithHistory
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "123")
            {
                CalculatorForm calc = new CalculatorForm();
                calc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login credentials!");
            }
        }
    }
}
