using System;
using System.Windows.Forms;

namespace G15_11112022
{
    public partial class Form1 : Form
    {
        double result = 0;
        string performedOperation = string.Empty;
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (isOperationPerformed))
            {
                textBox1.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            performedOperation = button.Text;
            result = double.Parse(textBox1.Text);
            isOperationPerformed = true;
        }

        private void Ce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            performedOperation = string.Empty;
            isOperationPerformed = false;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            if (performedOperation == "+")
            {
                textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                isOperationPerformed = true;
            }
            else if (performedOperation == "-")
            {
                textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                isOperationPerformed = true;
            }
            else if (performedOperation == "X")
            {
                textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                isOperationPerformed = true;
            }
            else if (performedOperation == "/")
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "Cannot divide by zero";
                    isOperationPerformed = true;
                }
                else
                {
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    isOperationPerformed = true;
                }
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "0";
            }
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text) * -1;
            textBox1.Text = num.ToString();
        }
    }
}
