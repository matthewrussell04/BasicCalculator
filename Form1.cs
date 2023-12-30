using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        decimal num1, num2, result;
        char op;

        private void clearWelcome()
        {
            if (calcDisplay.Text == "Welcome")
            {
                calcDisplay.Text = "0";
            }
        }

        private void numEqualsOrAdd(string num)
        {
            if (calcDisplay.Text == "0")
            {
                calcDisplay.Text = $"{num}";
            }
            else
            {
                calcDisplay.Text += $"{num}";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            clearWelcome();
            numEqualsOrAdd("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            clearWelcome();
            numEqualsOrAdd("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            clearWelcome();
            numEqualsOrAdd("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            clearWelcome();
            numEqualsOrAdd("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            clearWelcome();
            numEqualsOrAdd("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            clearWelcome();
            numEqualsOrAdd("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            clearWelcome();
            numEqualsOrAdd("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            clearWelcome();
            numEqualsOrAdd("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            clearWelcome();
            numEqualsOrAdd("9");
        }

        private void zero_Click(object sender, EventArgs e)
        {
            clearWelcome();
            numEqualsOrAdd("0");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "0";
        }

        private void add_Click(object sender, EventArgs e)
        {
            op = '+';
            num1 = Convert.ToDecimal(calcDisplay.Text);
            calcDisplay.Text = "0";
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            op = '-';
            num1 = Convert.ToDecimal(calcDisplay.Text);
            calcDisplay.Text = "0";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            op = 'X';
            num1 = Convert.ToDecimal(calcDisplay.Text);
            calcDisplay.Text = "0";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            op = '÷';
            num1 = Convert.ToDecimal(calcDisplay.Text);
            calcDisplay.Text = "0";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDecimal(calcDisplay.Text);
            switch(op)
            {
                case '+':
                    result = (num1 + num2);
                    calcDisplay.Text = Convert.ToString(result);
                    break;

                case '-':
                    result = (num1 - num2);
                    calcDisplay.Text = Convert.ToString(result);
                    break;

                case 'X':
                    result = (num1 * num2);
                    calcDisplay.Text = Convert.ToString(result);
                    break;

                case '÷':
                    result = (num1 / num2);
                    calcDisplay.Text = Convert.ToString(result);
                    break;
            }
            op = ' ';
        }
    }
}
