using System;
using System.Windows.Forms;

namespace LoginNavigationApp
{
    partial class HomePage
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Button btnProfile;
        private Button btnSettings;
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new Label();
            this.btnProfile = new Button();
            this.btnSettings = new Button();
            this.btnLogout = new Button();
            this.SuspendLayout();

            // Label
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(50, 30);
            this.lblWelcome.AutoSize = true;

            // Profile Button
            this.btnProfile.Text = "Profile";
            this.btnProfile.Location = new System.Drawing.Point(50, 80);
            this.btnProfile.Click += new EventHandler(this.btnProfile_Click);

            // Settings Button
            this.btnSettings.Text = "Settings";
            this.btnSettings.Location = new System.Drawing.Point(150, 80);
            this.btnSettings.Click += new EventHandler(this.btnSettings_Click);

            // Logout Button
            this.btnLogout.Text = "Logout";
            this.btnLogout.Location = new System.Drawing.Point(250, 80);
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // HomePage Form
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLogout);
            this.Text = "Home Page";
            this.StartPosition = FormStartPosition.CenterScreen;

            // 🎨 Background color
            this.BackColor = System.Drawing.Color.LightSkyBlue;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
