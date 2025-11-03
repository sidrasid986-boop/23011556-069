using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalculatorWithHistory
{
    partial class CalculatorForm
    {
        private IContainer components = null;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private Button btnShowHistory;
        private Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.txtNum1 = new TextBox();
            this.txtNum2 = new TextBox();
            this.btnAdd = new Button();
            this.btnSub = new Button();
            this.btnMul = new Button();
            this.btnDiv = new Button();
            this.btnShowHistory = new Button();
            this.lblResult = new Label();

            this.txtNum1.Location = new Point(40, 30);
            this.txtNum2.Location = new Point(180, 30);
            this.txtNum1.Width = 100;
            this.txtNum2.Width = 100;

            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new Point(40, 80);
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            this.btnSub.Text = "Subtract";
            this.btnSub.Location = new Point(130, 80);
            this.btnSub.Click += new EventHandler(this.btnSub_Click);

            this.btnMul.Text = "Multiply";
            this.btnMul.Location = new Point(230, 80);
            this.btnMul.Click += new EventHandler(this.btnMul_Click);

            this.btnDiv.Text = "Divide";
            this.btnDiv.Location = new Point(330, 80);
            this.btnDiv.Click += new EventHandler(this.btnDiv_Click);

            this.btnShowHistory.Text = "Show History";
            this.btnShowHistory.Location = new Point(40, 130);
            this.btnShowHistory.Click += new EventHandler(this.btnShowHistory_Click);

            this.lblResult.Text = "Result: ";
            this.lblResult.Location = new Point(40, 180);
            this.lblResult.AutoSize = true;

            this.ClientSize = new Size(450, 240);
            this.Controls.AddRange(new Control[] { txtNum1, txtNum2, btnAdd, btnSub, btnMul, btnDiv, btnShowHistory, lblResult });
            this.Text = "Simple Calculator - Sidra";
        }
    }
}
