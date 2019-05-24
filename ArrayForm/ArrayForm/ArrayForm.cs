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

        public ArrayForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            const int size = 10;
            int [] number = new int[size];
            string message = " ";
            number[0] = 11;
            number[2] = 15;
            number[4] = 19;
            number[6] = 30;

            
            int index;

            for ( index = 0; index < number.Length; index++)
            {
                message = message + "Element at index [" + index + "] " + number[index].ToString() + "\n";
                showRichTextBox.Text = message;
            }
            


        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            

            string message = " ";
            number [index] = Convert.ToInt32(addTextBox.Text);
            index++;
          


            

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                message = message + "Element at index [" + index + "] " + number[index].ToString() + "\n";
               
            }
            showRichTextBox.Text = message;
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            //string message = " ";
            //[index] = Convert.ToInt32(addTextBox.Text);
            //index++;
           // int sum;

            for (int index = 0; index < number.Length; index++)
            {
                
                    sum = sum + number[index];


            }
            showRichTextBox.Text = Convert.ToString(sum);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            int[] array2 = new int[10];

            for (int index = 0; index < array2.Length; index++)
            {
                array2[index] = number[index];
                showRichTextBox.Text = Convert.ToString(array2[index]);

            }

            string message = " ";

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + "Element at index [" + index + "] " + number[index].ToString() + "\n";

            }
            showRichTextBox.Text = message;
        }

        private void duplicateButton_Click(object sender, EventArgs e)
        {
            int duplicate = number[0];
            int count = 0;

            for (int index =0; index < number.Length; index ++)
            {
                for (int indexJ =0; indexJ <= index; indexJ++)
                {
                    if (number[indexJ] == duplicate )
                    {
                        count++;
                    }

                }
            }
            showRichTextBox.Text = Convert.ToString(count);
        }

       
    }
    
}
