using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    partial class DashboardForm
    {
        private IContainer components = null;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Button btnAddBook;
        private Button btnBorrowBook;
        private Button btnViewBorrowed;
        private DataGridView dataGridView1;
        private Label lblTitle;
        private Label lblAuthor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.txtTitle = new TextBox();
            this.txtAuthor = new TextBox();
            this.btnAddBook = new Button();
            this.btnBorrowBook = new Button();
            this.btnViewBorrowed = new Button();
            this.dataGridView1 = new DataGridView();
            this.lblTitle = new Label();
            this.lblAuthor = new Label();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Text = "Title:";
            this.lblTitle.Location = new Point(30, 30);

            this.txtTitle.Location = new Point(100, 27);
            this.txtTitle.Width = 250;
            this.txtTitle.Name = "txtTitle";

            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Text = "Author:";
            this.lblAuthor.Location = new Point(30, 70);

            this.txtAuthor.Location = new Point(100, 67);
            this.txtAuthor.Width = 250;
            this.txtAuthor.Name = "txtAuthor";

            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.Location = new Point(30, 110);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.BackColor = Color.LightSkyBlue;
            this.btnAddBook.Click += new EventHandler(this.btnAddBook_Click);

            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.Location = new Point(140, 110);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Click += new EventHandler(this.btnBorrowBook_Click);

            this.btnViewBorrowed.Text = "View Borrowed Books";
            this.btnViewBorrowed.Location = new Point(260, 110);
            this.btnViewBorrowed.Name = "btnViewBorrowed";
            this.btnViewBorrowed.Click += new EventHandler(this.btnViewBorrowed_Click);

            this.dataGridView1.Location = new Point(30, 160);
            this.dataGridView1.Width = 520;
            this.dataGridView1.Height = 240;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ReadOnly = true;

            this.ClientSize = new Size(600, 430);
            this.Controls.AddRange(new Control[] { lblTitle, txtTitle, lblAuthor, txtAuthor, btnAddBook, btnBorrowBook, btnViewBorrowed, dataGridView1 });
            this.Text = "Dashboard";
        }
    }
}
