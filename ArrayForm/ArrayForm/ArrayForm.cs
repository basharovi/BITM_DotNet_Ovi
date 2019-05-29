using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayForm
{
    public partial class ArrayForm : Form
    {
        const int size = 10;
        int[] number = new int[size];
        int index;
        int sum=0;
        int i = 0;

        public ArrayForm()
        {
            InitializeComponent();
        }

        private string Show()
        {
            string message = "";

            for (index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + "Element at index  [" + index + "]  =  " + number[index].ToString() + "\n";

            }
            return  message;

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            
            showRichTextBox.Text = Show();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            
            string message = " ";
            if (String.IsNullOrEmpty(addTextBox.Text))
            {
                MessageBox.Show("Add Field cant be Empty");
                return;
            }
            number [i] = Convert.ToInt32(addTextBox.Text);
            
          
            showRichTextBox.Text = message +  Show();
            i++;
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "";
            message = "Input Value\n\n";
            message = message + Show();

            message = message + "Reverse Value\n\n";

            for (int index = size - 1; index >= 0; index--)
            {
                if (number[index] != 0)
                    message = message + "Element at index [" + index + "] " + number[index].ToString() + "\n";

            }
            showRichTextBox.Text = message;


        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            

            for (int index = 0; index < number.Length; index++)
            {
                
                    sum = sum + number[index];


            }
            showRichTextBox.Text = Show() + "Sum = " + Convert.ToString(sum);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            int[] copyArray = new int[size];

            for (int index = 0; index < copyArray.Length; index++)
            {
                copyArray[index] = number[index];
               

            }
            string message = " ";

            for (int index = 0; index < copyArray.Length; index++)
            {
                if (copyArray[index] != 0)
                    message = message + "Element at index  [" + index + "]  =  " + copyArray[index].ToString() + "\n";

            }

            showRichTextBox.Text = message;
        }

        private void duplicateButton_Click(object sender, EventArgs e)
        {
            
            int count = 0;

            for (int indexI = 0; indexI < number.Length; indexI ++)
            {
                for (int indexJ = indexI + 1; indexJ < number.Length; indexJ++)
                {
                    if (number[indexI] == number[indexJ])
                    {
                        count++;
                    }
                        
                }
                
            }
            showRichTextBox.Text = Convert.ToString(count);
        }

       
    }
    
}
