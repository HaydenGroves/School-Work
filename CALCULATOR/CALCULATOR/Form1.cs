using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            string Operator;
            string Operator2;

            number1 = int.Parse(txtNumber1.Text);
            number2 = int.Parse(txtNumber2.Text);
            Operator = txtOperator1.Text;
            Operator2 = txtOperator2.Text;

            switch (Operator)
            {
                case "+":
                    txtOutput.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txtOutput.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    txtOutput.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    txtOutput.Text = (number1 / number2).ToString();
                    break;
                case "%":
                    txtOutput.Text = (number1 % number2).ToString();
                    break;

                case "+":
                    txtOutput.Text = (number1 + number2).ToString();
                    break;
            
               }
            }
        }
    }
}
