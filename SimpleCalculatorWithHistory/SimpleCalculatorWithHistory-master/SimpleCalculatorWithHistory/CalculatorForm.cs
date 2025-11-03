using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleCalculatorWithHistory
{
    public partial class CalculatorForm : Form
    {
        public static List<string> History = new List<string>();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private double GetNumber(TextBox txt)
        {
            if (double.TryParse(txt.Text, out double val)) return val;
            MessageBox.Show("Enter valid numbers!");
            throw new Exception("Invalid number");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double result = GetNumber(txtNum1) + GetNumber(txtNum2);
                lblResult.Text = $"Result: {result}";
                History.Add($"{txtNum1.Text} + {txtNum2.Text} = {result}");
            }
            catch { }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                double result = GetNumber(txtNum1) - GetNumber(txtNum2);
                lblResult.Text = $"Result: {result}";
                History.Add($"{txtNum1.Text} - {txtNum2.Text} = {result}");
            }
            catch { }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                double result = GetNumber(txtNum1) * GetNumber(txtNum2);
                lblResult.Text = $"Result: {result}";
                History.Add($"{txtNum1.Text} × {txtNum2.Text} = {result}");
            }
            catch { }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                double n2 = GetNumber(txtNum2);
                if (n2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero!");
                    return;
                }
                double result = GetNumber(txtNum1) / n2;
                lblResult.Text = $"Result: {result}";
                History.Add($"{txtNum1.Text} ÷ {txtNum2.Text} = {result}");
            }
            catch { }
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }
    }
}
