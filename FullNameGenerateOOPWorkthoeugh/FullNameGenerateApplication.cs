using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullNameGenerateOOPWorkthoeugh
{

    public partial class FullNameGenerateApplication : Form
    {
        private Person aPerson;
        public FullNameGenerateApplication()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            aPerson = new Person();

            aPerson.FirstName = firstNameTextBox.Text;
            aPerson.MiddleName = middleNameTextBox.Text;
            aPerson.LastName = lastNameTextBox.Text;

            firstNameTextBox.Text = "";
            middleNameTextBox.Text = "";
            lastNameTextBox.Text = "";

            fullNameTextBox.Text = aPerson.GetFullName();
            reverseNameTextBox.Text = aPerson.GetFullReverseName();
        }
    }
}
