using System;
using System.Windows.Forms;

namespace LoginNavigationApp
{
    public partial class HomePage : Form
    {
        string username;

        public HomePage(string user)
        {
            InitializeComponent();
            username = user;
            lblWelcome.Text = $"Welcome, {username}!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile Page (Demo)", "Profile");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings Page (Demo)", "Settings");
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}

