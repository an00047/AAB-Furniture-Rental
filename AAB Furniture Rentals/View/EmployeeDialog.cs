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
            this.CustomerLabel.Text = "New Employee";
            this.EmployeeButton.Text = "Add Employee";
            this.genderComboBox.Items.Add("F");
            this.genderComboBox.Items.Add("M");
        
        }

       

        public EmployeeDialog(Employee theEmployee)
        {
            if (theEmployee == null)
            {
                throw new Exception("Employee is invalid.");
            }
            InitializeComponent();

            this.editEmployee = theEmployee;
            this.CustomerLabel.Text = "Edit Employee";
            this.EmployeeButton.Text = "Edit Employee";

            this.genderComboBox.Items.Add("F");
            this.genderComboBox.Items.Add("M");

            
            this.firstNameTextBox.Text = theEmployee.Fname;
            this.lastNameTextBox.Text = theEmployee.Lname;
            this.genderComboBox.SelectedItem = theEmployee.Sex;
            this.birthdateBox.Value = theEmployee.Dob;
            this.addressTextBox.Text = theEmployee.Address;
            this.cityTextBox.Text = theEmployee.City;
            this.stateTextBox.Text = theEmployee.State;
           this.zipTextBox.Text = theEmployee.Zip;
           this.phoneTextBox.Text = theEmployee.Phone;
           this.activeCheckBox.Checked = theEmployee.Active;
           this.userNameTextBox.Text = theEmployee.Username;
           this.adminCheckBox.Checked = theEmployee.Admin;


            this.passwordTextBox.Enabled = false;
            this.SetViewOnly();
        }

        private void SetViewOnly()
        {

            this.firstNameTextBox.Enabled = false;
            this.lastNameTextBox.Enabled = false;
            this.genderComboBox.Enabled = false;
            this.birthdateBox.Enabled = false;
            this.addressTextBox.Enabled = false;
            this.cityTextBox.Enabled = false;
            this.stateTextBox.Enabled = false;
            this.zipTextBox.Enabled = false;
            this.phoneTextBox.Enabled = false;
            this.activeCheckBox.Enabled = false;
            this.userNameTextBox.Enabled = false;
            this.adminCheckBox.Enabled = false;
        }

        private void SetEditable()
        {

            this.firstNameTextBox.Enabled = true;
            this.lastNameTextBox.Enabled = true;
            this.genderComboBox.Enabled = true;
            this.birthdateBox.Enabled = true;
            this.addressTextBox.Enabled = true;
            this.cityTextBox.Enabled = true;
            this.stateTextBox.Enabled = true;
            this.zipTextBox.Enabled = true;
            this.phoneTextBox.Enabled = true;
            this.activeCheckBox.Enabled = true;
            this.userNameTextBox.Enabled = true;
            this.adminCheckBox.Enabled = true;
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
                    Employee newEmployee = new Employee();
                    
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
                    newEmployee.Admin = this.adminCheckBox.Checked;


                    EmployeeController.AddNewEmployee(newEmployee);
                    MessageBox.Show("Successfully added employee.");
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }

            }


        }

        private void SaveEmployee()
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
                    newEmployee.Admin = this.adminCheckBox.Checked;


                    EmployeeController.SaveEmployee(newEmployee);
                    MessageBox.Show("Successfully edited employee.");
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error!");
                }
         

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void EmployeeButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                if (this.EmployeeButton.Text == "Add Employee")
                {
                    this.AddUser();
                    this.AddEmployee();
                }
                else if (this.EmployeeButton.Text == "Edit Employee") {
                    this.SetEditable();
                    this.passwordTextBox.Enabled = false;
                    this.userNameTextBox.Enabled = false;
                    this.EmployeeButton.Text = "Save Employee";
                }
                else if (this.EmployeeButton.Text == "Save Employee")
                {
                    if (this.ValidateForm())
                    {
                        this.SaveEmployee();
                        this.SetViewOnly();
                        this.EmployeeButton.Text = "Edit Employee";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void AddUser() {

            string username = this.userNameTextBox.Text;
            string password = this.passwordTextBox.Text;

            EmployeeController.AddUser(username, password);
         

        }
    }
}
