using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUIsko
{
    public partial class Home1 : UserControl
    {
        private double result = 0;
        private string currentInputNum = "";
        private char lastOperator = ' ';

        public Home1()
        {
            InitializeComponent();
        }

        private void InputNumber(string text)
        {
            currentInputNum += text;
            valueBox1.Text = currentInputNum;
        }

        private void One1_Click(object sender, EventArgs e)
        {
            InputNumber(One1.Text);
        }

        private void Two1_Click(object sender, EventArgs e)
        {
            InputNumber(Two1.Text);
        }

        private void Three1_Click(object sender, EventArgs e)
        {
            InputNumber(Three1.Text);
        }

        private void Four1_Click(object sender, EventArgs e)
        {
            InputNumber(Four1.Text);
        }

        private void Five1_Click(object sender, EventArgs e)
        {
            InputNumber(Five1.Text);
        }

        private void Six1_Click(object sender, EventArgs e)
        {
            InputNumber(Six1.Text);
        }

        private void Seven1_Click(object sender, EventArgs e)
        {
            InputNumber(Seven1.Text);
        }

        private void Eight1_Click(object sender, EventArgs e)
        {
            InputNumber(Eight1.Text);
        }

        private void Nine1_Click(object sender, EventArgs e)
        {
            InputNumber(Nine1.Text);
        }

        private void Zero1_Click(object sender, EventArgs e)
        {
            InputNumber(Zero1.Text);
        }

        private void Decimal1_Click(object sender, EventArgs e)
        {
            InputNumber(Decimal1.Text);
        }

        private void Equal1_Click(object sender, EventArgs e)
        {
            if (lastOperator != ' ' && !string.IsNullOrEmpty(currentInputNum))
            {
                PerformOperation();
                lastOperator = ' ';
            }
        }

        private void Plus1_Click(object sender, EventArgs e)
        {
            InputOperator('+');
        }

        private void Minus1_Click(object sender, EventArgs e)
        {
            InputOperator('-');
        }

        private void Multiply1_Click(object sender, EventArgs e)
        {
            InputOperator('*');
        }

        private void Divide1_Click(object sender, EventArgs e)
        {
            InputOperator('/');
        }

        private void InputOperator(char operatorChar)
        {
            if (!string.IsNullOrEmpty(currentInputNum))
            {
                if (lastOperator != ' ')
                {
                    PerformOperation();
                }
                result = double.Parse(currentInputNum);
                currentInputNum = "";
                lastOperator = operatorChar;
            }
        }

        private void PerformOperation()
        {
            double operand = double.Parse(currentInputNum);

            switch (lastOperator)
            {
                case '+':
                    result += operand;
                    break;
                case '-':
                    result -= operand;
                    break;
                case '*':
                    result *= operand;
                    break;
                case '/':
                    result /= operand;
                    break;
                default:
                    break;
            }

            currentInputNum = result.ToString();
            valueBox1.Text = currentInputNum;
        }

        private void Clear1_Click(object sender, EventArgs e)
        {
            valueBox1.Clear();
            result = 0;
            currentInputNum = "";
            lastOperator = ' ';
        }

        private void Delete1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInputNum))
            {
                currentInputNum = currentInputNum.Substring(0, currentInputNum.Length - 1);
                valueBox1.Text = currentInputNum;
            }
        }
    }
}
