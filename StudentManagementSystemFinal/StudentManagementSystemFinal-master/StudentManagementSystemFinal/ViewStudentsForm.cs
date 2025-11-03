using System;
using System.Windows.Forms;

namespace StudentManagementSystemFinal
{
    public class ViewStudentsForm : Form
    {
        DataGridView grid;
        Button btnDelete;

        public ViewStudentsForm()
        {
            this.Text = "View Students";
            this.Width = 450;
            this.Height = 300;

            grid = new DataGridView() { Top = 20, Left = 20, Width = 400, Height = 180 };
            btnDelete = new Button() { Text = "Delete Selected", Top = 220, Left = 150, Width = 120 };

            btnDelete.Click += BtnDelete_Click;
            this.Load += ViewStudentsForm_Load;

            Controls.Add(grid);
            Controls.Add(btnDelete);
        }

        private void ViewStudentsForm_Load(object sender, EventArgs e)
        {
            grid.DataSource = null;
            grid.DataSource = StudentData.Students;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                int index = grid.CurrentRow.Index;
                if (index >= 0 && index < StudentData.Students.Count)
                {
                    StudentData.Students.RemoveAt(index);
                    MessageBox.Show("Student deleted!");
                    grid.DataSource = null;
                    grid.DataSource = StudentData.Students;
                }
            }
        }
    }
}
