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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double result;
        double numb1;
        double numb2;
        string option;
        bool calculate = false;
        bool reset = false;

        private void setOutputToZero()
        {
            if (tbOutput.Text == "0")
            {
                tbOutput.Text = "";
            }
        }
        
        private void ShowCalcOnLabel1(double number, string option)
        {
            lblCalculation.Text = number.ToString() + " " + option;
        }

        private void ShowCalcOnLabel2(double number)
        {
            lblCalculation.Text += " " + number.ToString() + " = ";
        }

        private void ResetCalcualtionLabel()
        {
            if (reset == true)
            {
                lblCalculation.Text = "";
                reset = false;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            tbOutput.Text += "0";

            ResetCalcualtionLabel();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            ResetCalcualtionLabel();

            tbOutput.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            ResetCalcualtionLabel();

            tbOutput.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            ResetCalcualtionLabel();

            tbOutput.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            ResetCalcualtionLabel();

            tbOutput.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            ResetCalcualtionLabel();

            tbOutput.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            ResetCalcualtionLabel();


            tbOutput.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            ResetCalcualtionLabel();


            tbOutput.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            ResetCalcualtionLabel();


            tbOutput.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            ResetCalcualtionLabel();

            tbOutput.Text += "9";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            char Comma = ',';

            //Creates a boolean which is true or false depents on the function
            bool ContainsComma = CheckForComma(tbOutput.Text, Comma);

            if (!ContainsComma)
            {
                tbOutput.Text += ",";
            }

            //a function which returns a boolean
            bool CheckForComma(string number, char character)
            {
                return number.Contains(character);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Remove the last character
            string deletedCharOfNumb = RemoveLastCharacter(tbOutput.Text);

            if(tbOutput.Text.Length == 1)
            {
                tbOutput.Text = "0";
            }
            else
            {
                tbOutput.Text = deletedCharOfNumb;
            }

            string RemoveLastCharacter(string number)
            {
                //Check if the string is not empty
                if (!string.IsNullOrEmpty(number))
                {
                    //Use Substring to create a new string excluding the last character
                    return number.Substring(0, number.Length - 1);
                }

                //Return an empty string if the input is empty
                return string.Empty;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";

            numb1 = double.Parse(tbOutput.Text);

            ShowCalcOnLabel1(numb1, option);

            tbOutput.Text = "0";

            calculate = true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";

            numb1 = double.Parse(tbOutput.Text);

            ShowCalcOnLabel1(numb1, option);

            tbOutput.Text = "0";

            calculate = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            option = "*";

            numb1 = double.Parse(tbOutput.Text);

            ShowCalcOnLabel1(numb1, option);

            tbOutput.Text = "0";

            calculate = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            option = "/";

            numb1 = double.Parse(tbOutput.Text);

            ShowCalcOnLabel1(numb1, option);

            tbOutput.Text = "0";

            calculate = true;
        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            numb2 = double.Parse(tbOutput.Text);

            if(calculate == true)
            {
                if (option == "-")
                {
                    result = numb1 - numb2;
                }
                else if (option == "+")
                {
                    result = numb1 + numb2;
                }
                else if (option == "*")
                {
                    result = numb1 * numb2;
                }
                else if (option == "/")
                {
                    result = numb1 / numb2;
                }

                tbOutput.Text = result.ToString();

                ShowCalcOnLabel2(numb2);

                calculate = false;
                reset = true;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "0";

            //calculate = false;
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "0";
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            double percentNumb;

            percentNumb = Convert.ToDouble(tbOutput.Text);

            percentNumb /= 100;

            tbOutput.Text = percentNumb.ToString();
        }
    }
}
