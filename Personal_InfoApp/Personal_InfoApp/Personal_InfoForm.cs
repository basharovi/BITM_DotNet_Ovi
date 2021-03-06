﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_InfoApp
{
    public partial class Personal_InfoForm : Form
    {
        public Personal_InfoForm()
        {
            InitializeComponent();
        }
        string firstName, lastName, fullName, fathersName, mothersName, address;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstName = firstNameTextBox.Text;
                lastName = lastNameTextBox.Text;
                fullName = firstName + " " + lastName;
                fathersName = fathersNameTextBox.Text;
                mothersName = mothersNameTextBox.Text;
                
                address = addressTextBox.Text;

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                fathersNameTextBox.Text = "";
                mothersNameTextBox.Text = "";
                addressTextBox.Text = "";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\t_____Show Your Information!_____\n\n\tFull Name : " +fullName+  "\n\tFather's Name : " + fathersName+ "\n\tMother's Name: " + mothersName + "\n\tAddress : " +address+"\n"); ;
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\t_____Show Your Full Name!_____\n\n\tFull Name : " + fullName+ "\n");
        }

        private void ParentsName_Click(object sender, EventArgs e)
        {
           MessageBox.Show("\n\t_____Show Your Parent's Name!_____\n\n\tFather's Name : " +fathersName+ "\n\tMother's Name : "+mothersName+"\n");
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\t_____Show Your Address!_____\n\n\tAddress : "+address+"\n");
            

        }

       
    }
}
