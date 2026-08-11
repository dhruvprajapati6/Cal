using System;
using System.Data;
using System.Windows.Forms;

namespace Cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double firstNumber = 0;
        string operation = "";
        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textdata.Text += btn.Text;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

            try
            {
                string exp = textdata.Text;

                // Divide by zero check
                if (exp.Contains("/0"))
                {
                    textdata.Text = "Error";
                    return;
                }

                DataTable dt = new DataTable();
                var result = dt.Compute(exp, "");

                textdata.Text = result.ToString();
            }
            catch
            {
                textdata.Text = "Error";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textdata.Text.Length > 0)
            {
                textdata.Text = textdata.Text.Remove(textdata.Text.Length - 1, 1);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textdata.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(textdata.Text);

                if (number < 0)
                {
                    textdata.Text = "Error";
                    return;
                }

                double result = Math.Sqrt(number);

                textdata.Text = result.ToString();
            }
            catch
            {
                textdata.Text = "Error";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(textdata.Text);

                if (operation == "+" || operation == "-")
                {
                    number = firstNumber * number / 100;
                }
                else
                {
                    number = number / 100;
                }

                textdata.Text = number.ToString();
            }
            catch
            {
                textdata.Text = "Error";
            }
        }
    }
}
