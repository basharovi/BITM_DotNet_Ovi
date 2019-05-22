using System;
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

        private void ShowInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\t_____Show Your Information!_____\n\n\tFull Name : " + firstNameTextBox.Text+" " +lastNameTextBox.Text + "\n\tFather's Name : " + fathersNameTextBox.Text + "\n\tMother's Name: " + mothersNameTextBox.Text + "\n\tAddress : " + addressTextBox.Text+"\n"); ;
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\t_____Show Your Full Name!_____\n\n\tFull Name : " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n");
        }

        private void ParentsName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\t_____Show Your Parent's Name!_____\n\n\tFather's Name : " +fathersNameTextBox.Text+ "\n\tMother's Name : "+mothersNameTextBox.Text+"\n");
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\t_____Show Your Address!_____\n\n\tAddress : "+addressTextBox.Text+"\n");
        }
    }
}
