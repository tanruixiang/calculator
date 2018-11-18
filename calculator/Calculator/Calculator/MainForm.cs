using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        Results R = new Results();
        public MainForm()
        {
            InitializeComponent();
            EventHandler EV = new EventHandler(Numbers_Click);
            Num_0.Click += EV;
            Num_1.Click += EV;
            Num_2.Click += EV;
            Num_3.Click += EV;
            Num_4.Click += EV;
            Num_5.Click += EV;
            Num_6.Click += EV;
            Num_7.Click += EV;
            Num_8.Click += EV;
            Num_9.Click += EV;
            EventHandler EV2 = new EventHandler(Operators_Click);
            Multiply.Click += EV2;
            Divide.Click += EV2;
            Minus.Click += EV2;
            Plus.Click += EV2;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Num_0.PerformClick();
        }

        private void Num_1_Click(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
        private void Numbers_Click(object sender, EventArgs e)
        {
            string StrClickNum = ((Button)sender).Text;
            ANS.Text = StrClickNum;
            if (R.Symbol != null)
                R.Number2 = int.Parse(StrClickNum);
            else
                R.Number1 = int.Parse(StrClickNum);
        }
        private void Operators_Click(object sender,EventArgs e)
        {
            if(ExpressionL.Right>panel2.Width-10)
                ExpressionL.Location = new Point(panel2.Width - ExpressionL.Width-20,ExpressionL.Top);
            ExpressionL.Text += ANS.Text;
            string StrClickOpe = ((Button)sender).Text;
            ExpressionL.Text += StrClickOpe;
            switch (StrClickOpe)
            {
                case "+":
                    R.Symbol = "+";
                    break;
                case "-":
                    R.Symbol = "-";
                    break;
                case "x":
                    R.Symbol = "*";
                    break;
                case "/":
                    R.Symbol = "/";
                    break;
            }
           
        }
    }
}
