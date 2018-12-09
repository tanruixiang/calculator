using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
    public class Results
    {
        public int Number1=0;
        public int Number2=0;
        public string Symbol;
        public string LastSymbol;
        public int Result1;
    }
    public static class Judge
    {
      public  static bool isResult = false;
    }
    public static class Cal
    {
        public static double a =0;
        public static double b =0;
        public static double Last = 0;
        public static bool isLastChanged = false;
        public static bool isChanged = false;
        public static char Symbol;
    }
}
