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
    public partial class BookShopListForm : Form
    {
        int index=0;
        List<string> customerNames = new List<string>();
        List<string> phoneNumbers = new List<string>();
        List<string> address = new List<string>();
        List<string> orders = new List<string>();
        List<string> quantities = new List<string>();
        List<string> bills = new List<string>();
        int price = 1;
        

        public BookShopListForm()
        {
            InitializeComponent();
        }

        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            customerNames.Add(customerNameTextBox.Text);
            phoneNumbers.Add(phoneNumberTextBox.Text);
            address.Add(addressTextBox.Text);
            orders.Add(orderComboBox.Text);
            if (String.IsNullOrEmpty(quantitiyTextBox.Text))
            {
                MessageBox.Show("Quantity box can not be Empty");
                return;
            }
            quantities.Add(quantitiyTextBox.Text);
            
            if (orders[index].Equals("Math-120"))
            {
                price = 120;

            }
            else if (orders[index].Equals("English-100"))
            {
                price = 100;

            }
            else if (orders[index].Equals("Bangla-90"))
            {
                price = 90;

            }
            else if (orders[index].Equals("Art-80"))
            {
                price = 80;

            }
            
            bills.Add((Convert.ToString(Convert.ToInt32(quantities[index]) * price)));
            
            index++;

            richTextBox.SelectedText = ("\n\t     Customer No. [" + index + "] Information \n\t_______________________________\n\n");
            index--;
            richTextBox.SelectedText = (" Name              :   " + customerNames[index] + "\n");
            richTextBox.SelectedText = (" Phone No.       :   " + phoneNumbers[index] + "\n");
            richTextBox.SelectedText = (" Address           :   " + address[index] + "\n");
            richTextBox.SelectedText = (" Order              :   " + orders[index] + "\n");
            richTextBox.SelectedText = (" Quantity         :   " + quantities[index] + "\n");
            richTextBox.SelectedText = (" Total Bill          :   " + bills[index] + " Tk.\n");
            index++;

            customerNameTextBox.Clear();
            phoneNumberTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.ResetText();
            quantitiyTextBox.Clear();
        }
    }
}
