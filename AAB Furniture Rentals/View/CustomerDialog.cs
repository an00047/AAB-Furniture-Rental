using AAB_Furniture_Rentals.Controller;
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

        MemberController localMemberController;
        Member editMember;
        public CustomerDialog()
        {
            InitializeComponent();
            localMemberController = new MemberController();
            this.CustomerLabel.Text = "New Customer";
            this.CustomerButton.Text = "Add Customer";
            this.genderComboBox.Items.Add("F");
            this.genderComboBox.Items.Add("M");

            this.editMember = new Member();
           

        }

        public CustomerDialog(Member currentMember)
        {
            InitializeComponent();
            localMemberController = new MemberController();
            this.editMember = currentMember;
            this.CustomerLabel.Text = "Edit Customer";
            this.CustomerButton.Text = "Edit Customer";
            
            this.genderComboBox.Items.Add("F");
            this.genderComboBox.Items.Add("M");

            this.firstNameTextBox.Text = currentMember.FirstName;
            this.lastNameTextBox.Text = currentMember.LastName;
            this.genderComboBox.SelectedIndex = this.genderComboBox.FindStringExact(currentMember.Gender.ToString());
            this.birthdateBox.Value = currentMember.DateOfBirth;
            this.phoneTextBox.Text = currentMember.PhoneNumber;
            this.addressTextBox.Text = currentMember.Address;
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CustomerButton.Text == "Add Customer")
                {
                    this.addCustomer();
                }
                else
                {
                    this.editCustomer();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private bool validateForm()
        {
            int error = 0;
            if (this.firstNameTextBox.Text == "")
            {
                this.firstNameError.Text = "First name cannot be empty.";
                error++;
            }
            if (this.lastNameTextBox.Text == "")
            {
                this.lastNameError.Text = "Last name cannot be empty.";
                error++;
            }
             if (this.birthdateBox.Value > DateTime.Now || this.birthdateBox.Value == null)
            {
                this.birthdateError.Text = "Birthdate is invalid.";
                error++;
            }
            if (this.genderComboBox.SelectedItem == null || this.genderComboBox.SelectedIndex > 2 || this.genderComboBox.SelectedIndex < 0)
            {
                this.genderError.Text = "Gender selection is invalid.";
                error++;
            }
            if (this.addressTextBox.Text == "")
            {
                this.addressError.Text = "Address cannot be empty.";
                error++;
            }
            if(this.phoneTextBox.Text == "")
            {
                this.phoneError.Text = "Phone cannot be empty.";
                error++;
            }

            return error == 0;
            
        }
        private void addCustomer()
        {

            if (this.validateForm())
            {
                Member newMember = new Member();
                newMember.FirstName = this.firstNameTextBox.Text;
                newMember.LastName = this.lastNameTextBox.Text;
                newMember.DateOfBirth = this.birthdateBox.Value;
                newMember.Gender = Convert.ToChar(this.genderComboBox.SelectedItem);
                newMember.Address = this.addressTextBox.Text;
                newMember.PhoneNumber = this.phoneTextBox.Text;
                this.localMemberController.AddCustomer(newMember);
                MessageBox.Show("Successfully added customer.");
                DialogResult = DialogResult.OK;
                
            }
         
          
        }

        private void editCustomer()
        {
            if (this.validateForm())
            {
                Member newMember = new Member();
                newMember.MemberID = this.editMember.MemberID;
                newMember.FirstName = this.firstNameTextBox.Text;
                newMember.LastName = this.lastNameTextBox.Text;
                newMember.DateOfBirth = this.birthdateBox.Value;
                newMember.Gender = Convert.ToChar(this.genderComboBox.SelectedItem);
                newMember.Address = this.addressTextBox.Text;
                newMember.PhoneNumber = this.phoneTextBox.Text;
                this.localMemberController.EditCustomer(newMember);
                MessageBox.Show("Successfully edited customer.");
                DialogResult = DialogResult.OK;
                
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
