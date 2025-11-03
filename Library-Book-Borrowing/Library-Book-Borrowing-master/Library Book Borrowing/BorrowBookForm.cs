using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BorrowBookForm : Form
    {
        public BorrowBookForm()
        {
            InitializeComponent();
        }

        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            var availableBooks = DashboardForm.Books.Where(b => b.IsAvailable).ToList();
            comboBoxBooks.DataSource = availableBooks;
            comboBoxBooks.DisplayMember = "Title";
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (comboBoxBooks.SelectedItem is Book selectedBook)
            {
                selectedBook.IsAvailable = false;
                MessageBox.Show($"You borrowed '{selectedBook.Title}'!");
                this.Close();
            }
            else
            {
                MessageBox.Show("No book selected.");
            }
        }
    }
}
