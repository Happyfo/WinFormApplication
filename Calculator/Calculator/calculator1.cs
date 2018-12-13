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
    public partial class calculator1 : Form
    {
        public calculator1()
        {
            InitializeComponent();
        }

        private void textBoxNum1_Click(object sender, EventArgs e)
        {

        }

        private void calculator1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Num1 = Convert.ToDouble(textBoxNum1.Text);
            var Num2 = Convert.ToDouble(textBoxNum2.Text);
            //textBoxResult.Text = (Num1 + Num2).ToString();
            textBoxResult.Text = Convert.ToString(calculate.Add(Num1, Num2));
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            var Num1 = Convert.ToDouble(textBoxNum1.Text);
            var Num2 = Convert.ToDouble(textBoxNum2.Text);
            //textBoxResult.Text = (Num1 - Num2).ToString();
            textBoxResult.Text = Convert.ToString(calculate.Subtract(Num1, Num2));
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            var Num1 = Convert.ToDouble(textBoxNum1.Text);
            var Num2 = Convert.ToDouble(textBoxNum2.Text);
            //textBoxResult.Text = (Num1 * Num2).ToString();
            textBoxResult.Text = Convert.ToString(calculate.Multiply(Num1, Num2));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            var Num1 = Convert.ToDouble(textBoxNum1.Text);
            var Num2 = Convert.ToDouble(textBoxNum2.Text);
            //textBoxResult.Text = (Num1 / Num2).ToString();
            textBoxResult.Text = Convert.ToString(calculate.Divide(Num1, Num2));
        }
    }
}
