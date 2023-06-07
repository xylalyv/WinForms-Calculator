using System.Data;
using System.Net.Sockets;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string option;
        public string num1_str;
        public bool check_next_num;

        public Form1()
        {
            check_next_num = true;
            InitializeComponent();
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (check_next_num)
            {
                check_next_num = false;
                label1.Text = "0";
            }
            Button button = (Button)sender;
            if (label1.Text == "0")
                label1.Text = button.Text.ToString();
            else
                label1.Text += button.Text.ToString();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }


        private void btn_operator_Click(object sender, EventArgs e)
        {
            if (option == "+" || option == "-" || option == "X" || option == "÷" || option == "1/x" || option == "x^2" || option == "√x")
            {
                btn_equal_Click(sender, e);
            }
            Button button = (Button)sender;
            option = button.Text;
            num1_str = label1.Text;
            check_next_num = true;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            result = 0;
            num1 = Convert.ToDouble(num1_str);
            num2 = Convert.ToDouble(label1.Text);
            if (option == "+")
            {
                result = num1 + num2;
            }
            if (option == "-")
            {
                result = num1 - num2;
            }
            if (option == "X")
            {
                result = num1 * num2;
            }
            if (option == "÷")
            {
                result = num1 / num2;
            }
            if (option == "%")
            {
                result = num1 * num2 / 100;
            }
            if (option == "1/x")
            {
                result = (1/num1) * num2;
            }
            if (option == "x^2")
            {
                result = Math.Pow(num1, 2) * num2;

            }
            if (option == "√x")
            {
                result = Math.Sqrt(num2) * num2;
            }
            option = "=";
            check_next_num = true;
            label1.Text = result.ToString();
        }

        private void btn_plus_Minus_Click(object sender, EventArgs e)
        {
            double num, result;
            num = Convert.ToDouble(label1.Text);
            result = -num;
            label1.Text = result.ToString();
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Contains(".")) label1.Text += ".";
        }
        private void btn_BackSpace_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 0) MessageBox.Show("Number is already empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else label1.Text = label1.Text.Remove(label1.Text.Length - 1);
        }

    }
}