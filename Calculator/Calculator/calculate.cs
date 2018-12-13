using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class calculate
    {
        public static double Add(double Num1, double Num2)
        {
            return Num1 + Num2;
        }
        public static double Subtract(double Num1, double Num2)
        {
            return Num1 - Num2;
        }
        public static double Multiply(double Num1, double Num2)
        {
            return Num1 * Num2;
        }
        public static double Divide(double Num1, double Num2)
        {
            if(Num2 == 0)
            {
                throw new Exception("Num2 should not be equal to zero");
            }
            return Num1 / Num2;
        }
    }
}
