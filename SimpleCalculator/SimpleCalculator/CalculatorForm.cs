using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumerTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result1 = firstNumber + secondNumber;
            string result2 = Convert.ToString(result1);
           
            DataTable calculator  = new DataTable();
            calculator.Columns.Add(""+result2+"");
            

            foreach (var dataTable in calculator.Columns)
            {
                resultRichTextBox.SelectedText = dataTable.ToString();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            firstNumerTextBox.Clear();
            secondNumberTextBox.Clear();
            resultRichTextBox.Clear();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumerTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result1 = firstNumber - secondNumber;
            string result2 = Convert.ToString(result1);

            DataTable calculator = new DataTable();
            calculator.Columns.Add("" + result2 + "");


            foreach (var dataTable in calculator.Columns)
            {
                resultRichTextBox.SelectedText = dataTable.ToString();
            }
        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumerTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result1 = firstNumber * secondNumber;
            string result2 = Convert.ToString(result1);

            DataTable calculator = new DataTable();
            calculator.Columns.Add("" + result2 + "");


            foreach (var dataTable in calculator.Columns)
            {
                resultRichTextBox.SelectedText = dataTable.ToString();
            }
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumerTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result1 = firstNumber / secondNumber;
            string result2 = Convert.ToString(result1);

            DataTable calculator = new DataTable();
            calculator.Columns.Add("" + result2 + "");


            foreach (var dataTable in calculator.Columns)
            {
                resultRichTextBox.SelectedText = dataTable.ToString();
            }
        }
    }
}
