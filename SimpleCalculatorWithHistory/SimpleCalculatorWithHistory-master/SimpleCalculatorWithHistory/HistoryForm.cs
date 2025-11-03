using System;
using System.Windows.Forms;

namespace SimpleCalculatorWithHistory
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in CalculatorForm.History)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
