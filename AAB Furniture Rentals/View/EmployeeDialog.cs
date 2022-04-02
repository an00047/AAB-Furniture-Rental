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
    public partial class EmployeeDialog : Form
    {

        Employee editEmployee;
        public EmployeeDialog()
        {
            InitializeComponent();
            this.CustomerLabel.Text = "New Customer";
            this.CustomerButton.Text = "Add Customer";
            this.genderComboBox.Items.Add("F");
            this.genderComboBox.Items.Add("M");
        }



        public EmployeeDialog(Employee employeeMember)
        {
            if (employeeMember == null)
            {
                throw new Exception("Member is invalid.");
            }
            InitializeComponent();

            this.editEmployee = employeeMember;
            this.CustomerLabel.Text = "Edit Customer";
            this.CustomerButton.Text = "Edit Customer";

            this.genderComboBox.Items.Add("F");
            this.genderComboBox.Items.Add("M");

            this.firstNameTextBox.Text = this.editEmployee.FirstName;
            this.lastNameTextBox.Text = this.editEmployee.LastName;
            this.genderComboBox.SelectedIndex = this.genderComboBox.FindStringExact(employeeMember.Gender.ToString());
            this.birthdateBox.Value = this.editEmployee.DateOfBirth;
            this.phoneTextBox.Text = this.editEmployee.PhoneNumber;
            this.addressTextBox.Text = this.editEmployee.Address;
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CustomerButton.Text == "Add Customer")
                {
                    this.AddCustomer();
                }
                else
                {
                    this.EditCustomer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private bool ValidateForm()
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
            if (this.phoneTextBox.Text == "")
            {
                this.phoneError.Text = "Phone cannot be empty.";
                error++;
            }

            if (this.cityTextBox.Text == "")
            {
                MessageBox.Show("City cannot be empty");
                // this.CityError.Text = "City cannot be empty.";
                error++;
            }
            if (this.stateTextBox.Text == "")
            {
                MessageBox.Show("City cannot be empty");
                // this.stateError.Text = "City cannot be empty.";
                error++;
            }

            if (this.zipTextBox.Text == "")
            {
                MessageBox.Show("Zip cannot be empty");
               // this.zipError.Text = "Zip cannot be empty.";
                error++;
            }

         
            if (this.userNameTextBox.Text == "")
            {
                MessageBox.Show("User Name cannot be empty");
                //  this.usernameError.Text = "City cannot be empty.";
                error++;
            }





            try
            {
                string[] validNumber = this.phoneTextBox.Text.Split(' ');
                if (this.phoneTextBox.Text.Length != 12)
                {
                    this.phoneError.Text = "Must be in 8 digits long";
                    error++;
                }

                int.Parse(validNumber[0]);
                int.Parse(validNumber[1]);
                int.Parse(validNumber[2]);

            }
            catch (Exception)
            {
                this.phoneError.Text = "Must be in '555 555 5555' format";
                error++;
            }


            return error == 0;

        }
        private void AddEmployee()
        {

            if (this.ValidateForm())
            {
                try
                {
                    Member newMember = new Member();
                    newMember.FirstName = this.firstNameTextBox.Text;
                    newMember.LastName = this.lastNameTextBox.Text;
                    newMember.DateOfBirth = this.birthdateBox.Value;
                    newMember.Gender = Convert.ToChar(this.genderComboBox.SelectedItem);
                    newMember.Address = this.addressTextBox.Text;
                    newMember.PhoneNumber = this.phoneTextBox.Text;
                    MemberController.AddCustomer(newMember);
                    MessageBox.Show("Successfully added customer.");
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }

            }


        }

        private void EditEmployee()
        {
            if (this.ValidateForm())
            {
                try
                {
                    Employee newEmployee = new Employee();
                    newEmployee.EmployeeID = this.editEmployee.EmployeeID;
                    newEmployee.Fname = this.firstNameTextBox.Text;
                    newEmployee.Lname = this.lastNameTextBox.Text;
                    newEmployee.Sex = Convert.ToString(this.genderComboBox.SelectedItem);
                    newEmployee.Dob = this.birthdateBox.Value;
                    newEmployee.Address = this.addressTextBox.Text;
                    newEmployee.City = this.cityTextBox.Text;
                    newEmployee.State = this.stateTextBox.Text;
                    newEmployee.Zip = this.zipTextBox.Text;
                    newEmployee.Phone = this.phoneTextBox.Text;
                    newEmployee.Active = this.activeCheckBox.Checked;
                    newEmployee.Username = this.userNameTextBox.Text;
                    newEmployee.Admin = = this.adminCheckBox.Checked;


                    EmployeeController.EditEmployee(newEmployee);
                    MessageBox.Show("Successfully edited employee.");
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error!");
                }
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
