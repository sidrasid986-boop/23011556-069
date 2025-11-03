using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalculatorWithHistory
{
    partial class HistoryForm
    {
        private IContainer components = null;
        private ListBox listBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.listBox1 = new ListBox();

            this.listBox1.Location = new Point(20, 20);
            this.listBox1.Size = new Size(300, 200);

            this.ClientSize = new Size(350, 250);
            this.Controls.Add(listBox1);
            this.Text = "Calculation History";
            this.Load += new EventHandler(this.HistoryForm_Load);
        }
    }
}
