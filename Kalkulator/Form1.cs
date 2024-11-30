using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Restricts user input in the textbox to numbers and specific operators
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // List of allowed characters for mathematical expressions
            List<char> allowedChars = new List<char> { '.','(', ')', '-', '+', '/', '*','^' };

            // Block characters that are not digits, control keys, or allowed operators
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !allowedChars.Contains(e.KeyChar))
            {
                e.Handled = true;
            }

            // Block spaces in the textbox
            if (e.KeyChar == ' ') 
            {
                e.Handled = true;  
            }
        }

        // Handles key presses like Enter or "=" for evaluating expressions
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Oemplus)
            {
                // Call the Counting method to evaluate the expression
                Counting();
            }
        }

        // Adds the number "3" to the textbox when button3 is clicked
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        // Adds the number "1" to the textbox when button1 is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        // Adds the "+" operator to the textbox if the last character is not another operator
        private void button15_Click(object sender, EventArgs e)
        {
            List<char> allowedChars = new List<char> { '.', '(', ')', '-', '+', '/', '*', '^' };
            if (textBox1.Text.Length > 0 && !allowedChars.Contains(textBox1.Text[textBox1.Text.Length - 1]))
            {
                textBox1.Text += "+";
            }
        }

        // Adds the number "0" to the textbox when button b0 is clicked
        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        // Removes the last character from the textbox
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        // Adds the number "7" to the textbox
        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        // Checks if adding a dot is valid based on the current expression
        private bool CheckDots()
        {
            string text = textBox1.Text;
            char[] operators = new char[] { '(', ')', '-', '+', '/', '*', '^' };

            // Splits the text by operators and gets the last part
            string[] parts = text.Split(operators, StringSplitOptions.RemoveEmptyEntries);
            string lastPart = parts[parts.Length - 1];

            // Return false if the last part already contains a dot
            if (lastPart.Contains("."))
                return false;
            else
                return true;
        }

        // Adds a dot (.) to the textbox if it is valid
        private void bDot_Click(object sender, EventArgs e)
        {
            List<char> allowedChars = new List<char> { '.', '(', ')', '-', '+', '√', '/', '*', '^' };
            if (textBox1.Text.Length > 0 && !allowedChars.Contains(textBox1.Text[textBox1.Text.Length - 1]) && CheckDots())
            {
                textBox1.Text += ".";
            }
        }

        // Adds number 2 to the textbox
        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }


        // Adds number 4 to the textbox
        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        // Adds number 5 to the textbox
        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        // Adds number 6 to the textbox
        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        // Adds number 8 to the textbox
        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        // Adds number 9 to the textbox
        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        // Adds the square root (√) symbol to the textbox if it is valid
        private void button18_Click(object sender, EventArgs e)
        {
            List<char> allowedChars = new List<char> { '.', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            if (textBox1.Text.Length == 0 || !allowedChars.Contains(textBox1.Text[textBox1.Text.Length - 1]))
            {
                textBox1.Text += "√";
            }
        }

        //Not working
       /* private void button13_Click(object sender, EventArgs e)
        {
            List<char> allowedChars = new List<char> { '.', '(', ')', '-', '+', '/', '*', '^' };
            if (textBox1.Text.Length > 0 && !allowedChars.Contains(textBox1.Text[textBox1.Text.Length - 1]))
            {
                textBox1.Text += "^";
            }
        }
       */


        private void button17_Click(object sender, EventArgs e)
        {
            List<char> allowedChars = new List<char> { '.', '(', ')', '-', '+', '/', '*', '^' };
            if (textBox1.Text.Length > 0 && !allowedChars.Contains(textBox1.Text[textBox1.Text.Length - 1]))
            {
                textBox1.Text += "/";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            List<char> allowedChars = new List<char> { '.', '(', '-', '+', '/', '*', '^' };
            if (textBox1.Text.Length > 0 && !allowedChars.Contains(textBox1.Text[textBox1.Text.Length - 1]))
            {
                textBox1.Text += "*";
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            List<char> allowedChars = new List<char> { '.', '(', ')', '-', '+', '/', '*', '^' };
            if (textBox1.Text.Length > 0 && !allowedChars.Contains(textBox1.Text[textBox1.Text.Length - 1]))
            {
                textBox1.Text += "-";
            }
        }

        private void bNawiasZ_Click(object sender, EventArgs e)
        {
            List<char> allowedChars = new List<char> { '.', '(', '-', '+', '√', '/', '*', '^' };
            if (textBox1.Text.Length > 0 && !allowedChars.Contains(textBox1.Text[textBox1.Text.Length - 1]))
            {
                textBox1.Text += ")";
            }
        }

        private void bNawiasO_Click(object sender, EventArgs e)
        {
            List<char> allowedChars = new List<char> { ')', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', };
            if (textBox1.Text.Length == 0 || !allowedChars.Contains(textBox1.Text[textBox1.Text.Length - 1]))
            {
                textBox1.Text += "(";
            }
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        // Handles evaluation of square roots in the expression
        private string HandleSquareRoots(string expression)
        {
            // Finds and replaces all square root symbols with their numerical values
            while (expression.Contains("√"))
            {
                int index = expression.IndexOf("√");
                int endIndex = index + 1;

                while (endIndex < expression.Length && (char.IsDigit(expression[endIndex]) || expression[endIndex] == '.'))
                {
                    endIndex++;
                }

                string number = expression.Substring(index + 1, endIndex - index - 1);
                double sqrtValue = Math.Sqrt(Convert.ToDouble(number));
                expression = expression.Replace("√" + number, sqrtValue.ToString());
            }

            return expression;
        }

        // Evaluates mathematical expressions
        private double EvaluateExpression(string expression)
        {
            if (expression.Contains("√"))
            {
                expression = HandleSquareRoots(expression);
            }

            // Replace "^" with "**" for compatibility
            expression = expression.Replace("^", "**");

            try
            {
                System.Data.DataTable table = new System.Data.DataTable();
                object result = table.Compute(expression, "");
                return Convert.ToDouble(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Błąd w składni wyrażenia: {expression}", ex);
            }
        }

        // <IMPORTANT> Main calculation method, evaluates the expression and updates the textbox
        private void Counting()
        {
            string input = textBox1.Text;
            double result = EvaluateExpression(input);
            textBox1.Text = "";
            textBox1.Text = result.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Counting();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {

        }
    }
}
