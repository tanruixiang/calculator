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
            Mod.Click += EV2;
            Square.Click += EV2;
            EventHandler EV3 = new EventHandler(ModeSelected);
            Scientist.Click += EV3;
            Standard.Click += EV3;
            Two.Click += EV3;
            Eight.Click += EV3;
            Sixty.Click += EV3;
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
            if (Judge.isResult == true)
            {
                ANS.Text = null;
                Judge.isResult = false;
            }
            if (ANS.Text != "0")
                ANS.Text += StrClickNum;
            else
                ANS.Text = StrClickNum;
            ANS.Location = new Point(Result.Width - ANS.Width, ANS.Location.Y);
            if (R.LastSymbol != null)
                R.Number2 = int.Parse(StrClickNum);
            else
                R.Number1 = int.Parse(StrClickNum);
        }
        private void Operators_Click(object sender,EventArgs e)
        {
            if (Cal.isChanged == false)
            {
                Cal.a = double.Parse(ANS.Text);
                Cal.isChanged = true;
                string StrClickOpe = ((Button)sender).Text;
                if (R.Symbol == null)
                {
                    R.Symbol = StrClickOpe;
                    R.LastSymbol=StrClickOpe;
                }
                else
                {
                    R.LastSymbol = R.Symbol;
                    R.Symbol = StrClickOpe;
                }
            }
            else
            {
                 string StrClickOpe = ((Button)sender).Text;
                if (R.LastSymbol == "=")
                {
                    R.LastSymbol = StrClickOpe;
                    goto Gothere;
                }
                Cal.b = int.Parse(ANS.Text);

                if(Cal.isLastChanged==true)
                {
                    Cal.a = Cal.Last;
                }
               
                if(R.Symbol==null)
                {
                    R.Symbol = StrClickOpe;
                }
                else
                {
                    R.LastSymbol = R.Symbol;
                    R.Symbol = StrClickOpe;
                }
                //ExpressionL.Text += StrClickOpe;
                switch (R.LastSymbol)
                {
                    case "+":
                       
                        Cal.Last = Cal.a + Cal.b;
                        ANS.Text = (Cal.Last).ToString();
                        Cal.isLastChanged = true;
                        break;
                    case "-":
                      
                        Cal.Last = Cal.a - Cal.b;
                        ANS.Text = (Cal.Last).ToString();
                        Cal.isLastChanged = true;
                        break;
                    case "x":
                      
                        Cal.Last = Cal.a * Cal.b;
                        ANS.Text = (Cal.Last).ToString();
                        Cal.isLastChanged = true;
                        break;
                    case "÷":
                        if (Cal.b == 0)
                        {
                            MessageBox.Show("被除数不能为零,已被强制C");
                            C.PerformClick();
                        }
                        Cal.Last =double.Parse( Cal.a.ToString() )/double.Parse( Cal.b.ToString());
                        ANS.Text = (Cal.Last).ToString();
                        Cal.isLastChanged = true;
                        break;
                }
            }
            
            //if(ExpressionL.Right>panel2.Width-10)
            //    ExpressionL.Location = new Point(panel2.Width - ExpressionL.Width-30,ExpressionL.Top);
            //ExpressionL.Text += ANS.Text;
            ANS.Location = new Point(Result.Width - ANS.Width, ANS.Location.Y);
            Judge.isResult = true;
        Gothere:
            ;
        }
        private void Status_Click(object sender, EventArgs e)
        {
            Chosen.Visible = true;
            Chosen.BringToFront();
        }
        private void ModeSelected(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            Chosen.Visible = false;
            StatusName.Text = button.Text;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            
            if(StatusName.Text=="二进制")
            {
                ANS.Text = Convert.ToString(int.Parse(ANS.Text),2);
                ANS.Location = new Point(Result.Width - ANS.Width, ANS.Location.Y);
            }
            if(StatusName.Text=="八进制")
            {
                ANS.Text = Convert.ToString(int.Parse(ANS.Text), 8);
                ANS.Location = new Point(Result.Width - ANS.Width, ANS.Location.Y);
            }
            if (StatusName.Text == "十六进制")
            {
                ANS.Text = Convert.ToString(int.Parse(ANS.Text), 16);
                ANS.Location = new Point(Result.Width - ANS.Width, ANS.Location.Y);
            }
           
            Cal.b = double.Parse(ANS.Text);
            switch (R.LastSymbol)
            {
                case "+":
                 
                    Cal.Last = Cal.a + Cal.b;
                    ANS.Text = (Cal.Last).ToString();
                    Cal.isLastChanged = true;
                    break;
                case "-":
                
                    Cal.Last = Cal.a - Cal.b;
                    ANS.Text = (Cal.Last).ToString();
                    Cal.isLastChanged = true;
                    break;
                case "x":
               
                    Cal.Last = Cal.a * Cal.b;
                    ANS.Text = (Cal.Last).ToString();
                    Cal.isLastChanged = true;
                    break;
                case "÷":
                    if (Cal.b == 0)
                    {
                        MessageBox.Show("被除数不能为零,已被强制C");
                        C.PerformClick();
                    }
                    Cal.Last = double.Parse(Cal.a.ToString()) / double.Parse(Cal.b.ToString());
                    ANS.Text = (Cal.Last).ToString();
                    Cal.isLastChanged = true;
                    break;
                case "Sin":
                    ANS.Text= Math.Sin(Cal.a).ToString();
                    break;
                case "x^y":
                   ANS.Text= Math.Pow(Cal.a, Cal.b).ToString();
                    break;
            }
            ANS.Location = new Point(Result.Width - ANS.Width, ANS.Location.Y);
            Cal.a = Cal.Last;
          //  Cal.Last = 0;
            R.LastSymbol = "=";
            //Cal.isChanged = false;
            Judge.isResult = true;
        }

        private void CE_Click(object sender, EventArgs e)
        {
           
            ANS.Text = "0";
        }

        private void C_Click(object sender, EventArgs e)
        {
            ANS.Text = "0";
            Cal.Last = 0;
            Cal.isLastChanged = false;
            Cal.a = 0;
            Cal.b = 0;
            Cal.isChanged = false;
            R.Symbol = null;
            R.LastSymbol = null;
        }

        private void _Point_Click(object sender, EventArgs e)
        {
            ANS.Text += ".";
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            try
            {
                if(ANS.Text.Length>3)
                ANS.Text = ANS.Text.Remove(ANS.Text.Length - 2, 1);
                else
                ANS.Text = ANS.Text.Remove(ANS.Text.Length - 1, 1);
            }
            catch (Exception ex) {; }
            finally
            {
                ANS.Location = new Point(Result.Width - ANS.Width, ANS.Location.Y);
            }
           
        }

        private void Scientist_Click(object sender, EventArgs e)
        {
            Mod.Text = "Sin";
            Square.Text = "x^y";
        }

        private void Standard_Click(object sender, EventArgs e)
        {
            Mod.Text = "÷";
        }
    }
}
