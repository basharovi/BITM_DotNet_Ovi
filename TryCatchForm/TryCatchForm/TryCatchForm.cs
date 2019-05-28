using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatchForm
{
    public partial class CustomerInfoForm : Form
    {
        List<string> users = new List<string>();
        List<string> names = new List<string>();
        List<int> ages = new List<int>();


        public CustomerInfoForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {

            try
            {
                string user;
                string name;
                int age;
                userLabel.Text = "";

                user = userTextBox.Text;
                if (String.IsNullOrEmpty(userTextBox.Text))
                {
                    MessageBox.Show("User Field can not be Empty");
                    return;
                }

                if (UserExist(user))
                {
                    userLabel.Text = "User " + user + " Already Exist!!";
                    return;
                }

                if (String.IsNullOrEmpty(ageTextBox.Text))
                {
                    MessageBox.Show("Age Field can not be Empty");
                    return;
                }

                 user = userTextBox.Text;
                 name = nameTextBox.Text;
                 age = Convert.ToInt32(ageTextBox.Text);

                users.Add(user);
                names.Add(user);
                ages.Add(age);

                 

                displayRichTextBox.Text = Display();
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private string Display()
        {
            string message = "";
            message = "SL\tUser\tName\tAge\n";

            for (int index =0; index < users.Count; index++)
            {
                message = message + (index+1) + "\t" + users[index] + "\t" + names[index] + "\t" + ages[index]+ "\n";
            }


            return message;
        }

        private bool UserExist(string user)
        {
            bool isExist = false;

            foreach(string userCheck in users)
            {
                if (userCheck == user)
                    isExist = true;
            }

            return isExist;
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ageTextBox.Text, "  ^ [0-9]"))
            {
                ageTextBox.Text = "";
            }
        }

        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
