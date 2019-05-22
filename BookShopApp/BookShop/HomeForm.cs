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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        
        private void SaveButtonClick(object sender, EventArgs e)
        {
            DataTable bookshop = new DataTable();
            bookshop.Columns.Add("\n\t\t\t     Customer Information\n\t\t___________________________________\n\n\n");
            bookshop.Columns.Add(" Name                   :\t" + customerNameTextBox.Text+ "\n\n");
            bookshop.Columns.Add(" Phone No.          :\t" + phoneNumberTextBox.Text+ "\n\n");
            bookshop.Columns.Add(" Address               :\t" + addressTextBox.Text+ "\n\n");
            bookshop.Columns.Add(" Order                   :\t" + orderComboBox.Text+ "\n\n");
            bookshop.Columns.Add(" Quantity             :\t" + quantitiyTextBox.Text+ "\n\n");

            foreach (var dataTable in bookshop.Columns)
            {
                richTextBox.SelectedText = dataTable.ToString();
            }

            customerNameTextBox.Clear();
            phoneNumberTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.ResetText();
            quantitiyTextBox.Clear();
        }

       
    }
}
