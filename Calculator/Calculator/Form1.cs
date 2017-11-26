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
    public partial class Form1 : Form
    {
        double result = 0;
        string operationPerformd = "";
        bool isOperationPerformd = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0")||(isOperationPerformd))
                txtResult.Clear();
            isOperationPerformd = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                {
                    txtResult.Text = txtResult.Text + button.Text;
                }
            }else
                txtResult.Text = txtResult.Text + button.Text;

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                btnEqual.PerformClick();
                operationPerformd = button.Text;
                lblCurrentOperation.Text = result + " " + operationPerformd;
                isOperationPerformd = true;
            }
            else
            {
                operationPerformd = button.Text;
                result = Double.Parse(txtResult.Text);
                lblCurrentOperation.Text = result + " " + operationPerformd;
                isOperationPerformd = true;
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            result = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformd)
            {
                case "+":
                    txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            result= Double.Parse(txtResult.Text);
            lblCurrentOperation.Text = "";
        }
    }
}
