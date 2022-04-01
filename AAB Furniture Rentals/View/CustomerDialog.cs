using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View
{
   
    public partial class CustomerDialog : Form
    {
        string customerText { get; set; }
        Member editMember;
        public CustomerDialog()
        {
           
            this.customerLabel.Text = "New Customer";
            this.CustomerButton.Text = "Add Customer";
            this.genderComboBox.Items.Add("F");
            this.genderComboBox.Items.Add("M");
        }

        public CustomerDialog(Member currentMember)
        {
            InitializeComponent();
            this.customerLabel.Text = "Edit Customer";
            this.CustomerButton.Text = "Edit Customer";
            
            this.genderComboBox.Items.Add("F");
            this.genderComboBox.Items.Add("M");

            this.firstNameTextBox.Text = currentMember.FirstName;
            this.lastNameTextBox.Text = currentMember.LastName;
            this.genderComboBox.SelectedIndex = this.genderComboBox.FindStringExact(currentMember.Gender.ToString());
            this.firstNameTextBox.Text = currentMember.FirstName;
            this.birthdateBox.Value = currentMember.DateOfBirth;
            this.phoneTextBox.Text = currentMember.PhoneNumber;
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            //Update in database
        }
    }
}
