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

        int result;
        int numb1;
        int numb2;
        string option;
        bool reset;

        private void setOutputToZero()
        {
            if (tbOutput.Text == "0")
            {
                tbOutput.Text = "";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            tbOutput.Text += "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            tbOutput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            tbOutput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            tbOutput.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            setOutputToZero();

            tbOutput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            tbOutput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            tbOutput.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            tbOutput.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            tbOutput.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            setOutputToZero();

            tbOutput.Text += "9";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "0";


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";

            numb1 = int.Parse(tbOutput.Text);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";

            numb1 = int.Parse(tbOutput.Text);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            option = "*";

            numb1 = int.Parse(tbOutput.Text);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            option = "/";

            numb1 = int.Parse(tbOutput.Text);
        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            numb2 = int.Parse(tbOutput.Text);

            if (option == "-")
            {
                result = numb1 - numb2;
            }
            else if (option == "+")
            {
                result = numb1 + numb2;
            }
            else if(option == "*")
            {
                result =  numb1 * numb2;
            }
            else if(option == "/")
            {
                result = numb1 / numb2;
            }

            tbOutput.Text = result.ToString();

            reset = true;
        }
    }
}
