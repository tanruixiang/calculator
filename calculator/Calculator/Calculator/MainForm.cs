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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
      
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
        }
    }
}
