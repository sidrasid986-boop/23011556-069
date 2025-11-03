using System;
using System.Windows.Forms;

namespace StudentManagementSystemFinal
{
    public class DashboardForm : Form
    {
        Button btnAdd, btnView, btnExit;

        public DashboardForm()
        {
            this.Text = "Question No 2";
            this.Width = 350;
            this.Height = 250;

            btnAdd = new Button() { Text = "Add Student", Top = 30, Left = 100, Width = 120 };
            btnView = new Button() { Text = "View Students", Top = 80, Left = 100, Width = 120 };
            btnExit = new Button() { Text = "Exit", Top = 130, Left = 100, Width = 120 };

            btnAdd.Click += (s, e) => new AddStudentForm().ShowDialog();
            btnView.Click += (s, e) => new ViewStudentsForm().ShowDialog();
            btnExit.Click += (s, e) => Application.Exit();

            Controls.Add(btnAdd);
            Controls.Add(btnView);
            Controls.Add(btnExit);
        }
    }
}
