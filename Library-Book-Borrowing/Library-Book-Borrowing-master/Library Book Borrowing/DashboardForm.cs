using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class DashboardForm : Form
    {
        public static List<Book> Books = new List<Book>();

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Enter both Title and Author");
                return;
            }

            Books.Add(new Book { Title = txtTitle.Text.Trim(), Author = txtAuthor.Text.Trim(), IsAvailable = true });
            MessageBox.Show("Book added successfully!");
            txtTitle.Clear();
            txtAuthor.Clear();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            BorrowBookForm borrowForm = new BorrowBookForm();
            borrowForm.ShowDialog();
        }

        private void btnViewBorrowed_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Books.FindAll(b => !b.IsAvailable);
        }
    }
}
