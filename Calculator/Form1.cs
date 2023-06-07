using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private double secondNumber;
        private string? operation;

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text += button.Text;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            firstNumber = double.Parse(label1.Text);
            label1.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(label1.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "%":
                    result = firstNumber /100;
                    break;
                case "x^2":
                    result = Math.Pow(firstNumber,2);
                    break;
                case "V2":
                    result = Math.Sqrt(firstNumber);
                    break;
                default:
                    break;
            }

            label1.Text = result.ToString();
        }
    }
}