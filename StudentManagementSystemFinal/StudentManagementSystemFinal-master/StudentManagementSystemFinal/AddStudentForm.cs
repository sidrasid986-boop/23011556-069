using System;
using System.Windows.Forms;

namespace StudentManagementSystemFinal
{
    public class AddStudentForm : Form
    {
        TextBox txtName, txtAge, txtClass;
        Button btnSave;

        public AddStudentForm()
        {
            this.Text = "Add Student";
            this.Width = 300;
            this.Height = 250;

            Label lbl1 = new Label() { Text = "Name:", Top = 20, Left = 20 };
            Label lbl2 = new Label() { Text = "Age:", Top = 60, Left = 20 };
            Label lbl3 = new Label() { Text = "Class:", Top = 100, Left = 20 };

            txtName = new TextBox() { Top = 20, Left = 100, Width = 150 };
            txtAge = new TextBox() { Top = 60, Left = 100, Width = 150 };
            txtClass = new TextBox() { Top = 100, Left = 100, Width = 150 };

            btnSave = new Button() { Text = "Save", Top = 150, Left = 100, Width = 100 };
            btnSave.Click += BtnSave_Click;

            Controls.Add(lbl1);
            Controls.Add(lbl2);
            Controls.Add(lbl3);
            Controls.Add(txtName);
            Controls.Add(txtAge);
            Controls.Add(txtClass);
            Controls.Add(btnSave);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAge.Text == "" || txtClass.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            Student s = new Student()
            {
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text),
                ClassName = txtClass.Text
            };

            StudentData.Students.Add(s);
            MessageBox.Show("Student added successfully!");
            txtName.Clear();
            txtAge.Clear();
            txtClass.Clear();
        }
    }
}
