using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListForm
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        List<string> names = new List<string>();
        List<int> numbers = new List<int>();
        
        private void AddButton_Click(object sender, EventArgs e)
        {
           

            numbers.Add(Convert.ToInt32(numberTextBox.Text));
            names.Add(stringTextBox.Text);

            


            string message = "";

            message = "ForEach\n\n";

            int index = 0;
            foreach (int number in numbers)
            {
                message = message + names[index]+ " " + number + "\n";
                index++;
            }

            showRichTextBox.Text = message;

        }
    }
}
