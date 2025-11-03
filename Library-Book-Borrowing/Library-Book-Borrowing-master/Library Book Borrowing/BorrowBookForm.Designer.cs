using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    partial class BorrowBookForm
    {
        private IContainer components = null;
        private ComboBox comboBoxBooks;
        private Button btnBorrow;
        private Label lblSelect;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.comboBoxBooks = new ComboBox();
            this.btnBorrow = new Button();
            this.lblSelect = new Label();

            this.lblSelect.AutoSize = true;
            this.lblSelect.Text = "Select a Book:";
            this.lblSelect.Location = new Point(20, 20);

            this.comboBoxBooks.Location = new Point(120, 17);
            this.comboBoxBooks.Width = 240;
            this.comboBoxBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxBooks.Name = "comboBoxBooks";

            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.Location = new Point(120, 55);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Click += new EventHandler(this.btnBorrow_Click);

            this.ClientSize = new Size(400, 110);
            this.Controls.AddRange(new Control[] { lblSelect, comboBoxBooks, btnBorrow });
            this.Text = "Borrow Book";
            this.Load += new EventHandler(this.BorrowBookForm_Load);
        }
    }
}
