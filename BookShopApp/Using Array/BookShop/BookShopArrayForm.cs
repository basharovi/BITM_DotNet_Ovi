using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class BookShopArrayForm : Form
    {
        public BookShopArrayForm()
        {
            InitializeComponent();
        }

        int index = 1;
        int price;





        private void SaveButton_Click(object sender, EventArgs e)
        {
            string[] customerName = new string[100];
            string[] phoneNo = new string[100];
            string[] address = new string[100];
            string[] order = new string[100];
            string[] quantity = new string[100];
            string[] bill = new string[100];



            customerName[index] = customerNameTextBox.Text;
            phoneNo[index] = phoneNumberTextBox.Text;
            address[index] = addressTextBox.Text;
            order[index] = orderComboBox.Text;
            quantity[index] = quantitiyTextBox.Text;


            if (order[index].Equals("Math"))
            {
                price = 120;

            }
            else if (order[index].Equals("English"))
            {
                price = 100;

            }
            else if (order[index].Equals("Bangla"))
            {
                price = 90;

            }
            else if (order[index].Equals("Art"))
            {
                price = 80;

            }
            bill[index] = (Convert.ToInt32(quantity[index]) * price).ToString();

            richTextBox.SelectedText = ("\n\t     Customer No. [" + index + "] Information \n\t_______________________________\n\n");
            richTextBox.SelectedText = (" Name              :   " + customerName[index] + "\n");
            richTextBox.SelectedText = (" Phone No.       :   " + phoneNo[index] + "\n");
            richTextBox.SelectedText = (" Address           :   " + address[index] + "\n");
            richTextBox.SelectedText = (" Order              :   " + order[index] + "\n");
            richTextBox.SelectedText = (" Quantity         :   " + quantity[index] + "\n");
            richTextBox.SelectedText = (" Total Bill          :   " + bill[index] + " Tk.\n");
            index++;

            customerNameTextBox.Clear();
            phoneNumberTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.ResetText();
            quantitiyTextBox.Clear();
        }
    }
}
