using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorV1._1
{
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }
        double result = 0;
        string operate = "";
        bool isOperated = false;
        private void numbersClick(object sender, EventArgs e)
        {
            if (calculateBox.Text=="0"||isOperated)
            {
                calculateBox.Clear();
            }
            Button button = (Button)sender;
            isOperated = false;
            if (button.Text==".")
            {
                if (!calculateBox.Text.Contains("."))
                {
                    calculateBox.Text = calculateBox.Text + button.Text;
                    if (calculateBox.Text[0].ToString() == ".")
                    {
                        calculateBox.Text = "0.";
                    }
                }
            }
            else
                calculateBox.Text = calculateBox.Text + button.Text;
        }

        private void operationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                btnEqual.PerformClick();
                operate = button.Text;
                currentOperation.Text = result + " " + operate;
                isOperated = true;
            }
            else
            {
                operate = button.Text;
                result = double.Parse(calculateBox.Text);
                currentOperation.Text = result + " " + operate;
                isOperated = true;
            }
        }

        private void ceClick(object sender, EventArgs e)
        {
            calculateBox.Text = "0";
        }

        private void clearClick(object sender, EventArgs e)
        {
            calculateBox.Text = "0";
            result = 0;
            currentOperation.Text = "";
        }

        private void equalClick(object sender, EventArgs e)
        {
            switch (operate)
            {
                case "+":
                    calculateBox.Text = (result + double.Parse(calculateBox.Text)).ToString();
                    break;
                case "-":
                    calculateBox.Text = (result - double.Parse(calculateBox.Text)).ToString();
                    break;
                case "*":
                    calculateBox.Text = (result * double.Parse(calculateBox.Text)).ToString();
                    break;
                case "/":
                    if (calculateBox.Text=="0")
                    {
                        currentOperation.Text = "Cannot divide by zero";
                    }
                    else
                    calculateBox.Text = (result / double.Parse(calculateBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(calculateBox.Text);
            currentOperation.Text = "";
        }

        private void backSpaceClick(object sender, EventArgs e)
        {
            calculateBox.Text = calculateBox.Text.Substring(0,calculateBox.Text.Length-1);
            if (calculateBox.Text == "")
            {
                calculateBox.Text = "0";
            }
        }

        private void keyboard(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.NumPad0 || e.KeyValue == (char)Keys.D0)
            {
                btn0.PerformClick();
            }
            if (e.KeyValue==(char)Keys.NumPad1|| e.KeyValue == (char)Keys.D1)
            {
                btn1.PerformClick();
            }
            if (e.KeyValue == (char)Keys.NumPad2 || e.KeyValue == (char)Keys.D2)
            {
                btn2.PerformClick();
            }
            if (e.KeyValue == (char)Keys.NumPad3 || e.KeyValue == (char)Keys.D3)
            {
                btn3.PerformClick();
            }
            if (e.KeyValue == (char)Keys.NumPad4 || e.KeyValue == (char)Keys.D4)
            {
                btn4.PerformClick();
            }
            if (e.KeyValue == (char)Keys.NumPad5 || e.KeyValue == (char)Keys.D5)
            {
                btn5.PerformClick();
            }
            if (e.KeyValue == (char)Keys.NumPad6 || e.KeyValue == (char)Keys.D6)
            {
                btn6.PerformClick();
            }
            if (e.KeyValue == (char)Keys.NumPad7 || e.KeyValue == (char)Keys.D7)
            {
                btn7.PerformClick();
            }
            if (e.KeyValue == (char)Keys.NumPad8 || e.KeyValue == (char)Keys.D8)
            {
                btn8.PerformClick();
            }
            if (e.KeyValue == (char)Keys.NumPad9 || e.KeyValue == (char)Keys.D9)
            {
                btn9.PerformClick();
            }
        }
    }
}
