﻿using AAB_Furniture_Rentals.Controller;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View
{
    /// <summary>
    /// 
    /// a dialog of employee data
    /// </summary>
    public partial class EmployeeDialog : Form
    {



        Employee editEmployee;
        /// <summary>
        /// employee dialog constrictor
        /// </summary>
        public EmployeeDialog()
        {
            InitializeComponent();


            this.CustomerLabel.Text = "New Employee";
            this.EmployeeButton.Text = "Add Employee";
            this.birthdateBox.MaxDate = DateTime.Now;
            this.genderComboBox.Items.Add("F");
            this.genderComboBox.Items.Add("M");

            clearErrorMessages();

            try
            {

                List<State> stateList = StateController.GetAllStates();
                stateList.Insert(0, new State(0, "", "-Select-"));
                this.StateComboBox.DataSource = stateList;
                this.StateComboBox.DisplayMember = "StateName";
                this.StateComboBox.ValueMember = "StateID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// other constructer
        /// </summary>
        /// <param name="theEmployee"></param>
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

            List<State> stateList = StateController.GetAllStates();
            stateList.Insert(0, new State(0, "", "-Select-"));
            this.StateComboBox.DataSource = stateList;
            this.StateComboBox.DisplayMember = "StateName";
            this.StateComboBox.ValueMember = "StateID";


            this.firstNameTextBox.Text = theEmployee.Fname;
            this.lastNameTextBox.Text = theEmployee.Lname;
            this.genderComboBox.SelectedItem = theEmployee.Sex;
            this.birthdateBox.Value = theEmployee.Dob;
            this.addressTextBox.Text = theEmployee.Address;
            this.cityTextBox.Text = theEmployee.City;
            this.StateComboBox.SelectedValue = theEmployee.State;
            this.zipTextBox.Text = theEmployee.Zip;
            this.phoneTextBox.Text = theEmployee.Phone;
            this.activeCheckBox.Checked = theEmployee.Active;
            this.userNameTextBox.Text = theEmployee.Username;
            this.adminCheckBox.Checked = theEmployee.Admin;


            
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
            this.StateComboBox.Enabled = false;
            this.zipTextBox.Enabled = false;
            this.phoneTextBox.Enabled = false;
            this.activeCheckBox.Enabled = false;
            this.userNameTextBox.Enabled = false;
            this.adminCheckBox.Enabled = false;
            this.passwordTextBox.Enabled = false;
        }

        private void SetEditable()
        {

            this.firstNameTextBox.Enabled = true;
            this.lastNameTextBox.Enabled = true;
            this.genderComboBox.Enabled = true;
            this.birthdateBox.Enabled = true;
            this.addressTextBox.Enabled = true;
            this.cityTextBox.Enabled = true;
            this.StateComboBox.Enabled = true;
            this.zipTextBox.Enabled = true;
            this.phoneTextBox.Enabled = true;
            this.activeCheckBox.Enabled = true;
            this.userNameTextBox.Enabled = true;
            this.adminCheckBox.Enabled = true;
            this.passwordTextBox.Enabled = true;
            this.userNameTextBox.Enabled = true;
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
                this.phoneError2.Text = "Phone cannot be empty.";
                error++;
            }

            if (this.cityTextBox.Text == "")
            {
                this.cityError.Text = "City cannot be empty.";

                error++;
            }
            if (this.StateComboBox.SelectedItem == null || this.genderComboBox.SelectedIndex < 0)
            {
                this.stateError.Text = "State selection is invalid.";
                error++;
            }

            if (this.zipTextBox.Text == ""  )
            {
                this.zipError.Text = "zip cannot be empty.";

                error++;
            }


            if (this.userNameTextBox.Text == "")
            {
                this.userNameError.Text = "userName cannot be empty.";
                error++;
            }


            if (this.passwordTextBox.Text == "" && this.EmployeeButton.Text == "Add Employee")
            {
                this.passwordError.Text = "Password cannot be empty.";
                error++;
            }




            try
            {
                string[] validNumber = this.phoneTextBox.Text.Split(' ');
                if (this.phoneTextBox.Text.Length != 12)
                {
                    this.phoneError2.Text = "Must be in 10 digits long";
                    error++;
                }

                int.Parse(validNumber[0]);
                int.Parse(validNumber[1]);
                int.Parse(validNumber[2]);

            }
            catch (Exception)
            {
                this.phoneError2.Text = "Must be in '555 555 5555' format";
                error++;
            }

            try
            {
                string validNumber = this.zipTextBox.Text;
                if (this.zipTextBox.Text.Length != 5)
                {
                    this.zipError.Text = "Must be in 5 digits long";
                    error++;
                }

                int.Parse(validNumber);

            }
            catch (Exception)
            {
                this.zipError.Text = "Zip must be all numbers";
                error++;
            }

            return error == 0;

        }

        private void clearErrorMessages()
        {
            this.phoneError2.Text = "";
            this.firstNameError.Text = "";
            this.lastNameError.Text = "";
            this.birthdateError.Text = "";
            this.genderError.Text = "";
            this.addressError.Text = "";

            this.cityError.Text = "";
            this.stateError.Text = "";
            this.zipError.Text = "";
            this.userNameError.Text = "";
            this.passwordError.Text = "";
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
                    newEmployee.State = Convert.ToInt32(this.StateComboBox.SelectedValue);
                    newEmployee.Zip = this.zipTextBox.Text;
                    newEmployee.Phone = this.phoneTextBox.Text;
                    newEmployee.Active = this.activeCheckBox.Checked;
                    newEmployee.Admin = this.adminCheckBox.Checked;
                    newEmployee.Username = this.userNameTextBox.Text;

                    
                    

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
                newEmployee.State = Convert.ToInt32(this.StateComboBox.SelectedValue);
                newEmployee.Zip = this.zipTextBox.Text;
                newEmployee.Phone = this.phoneTextBox.Text;
                newEmployee.Active = this.activeCheckBox.Checked;
                newEmployee.Username = this.userNameTextBox.Text;
                newEmployee.Admin = this.adminCheckBox.Checked;


                EmployeeController.SaveEmployee(newEmployee);
                EmployeeController.UpdateUsernameAndPassword(newEmployee.Username, this.passwordTextBox.Text, editEmployee.Username);
                MessageBox.Show("Successfully edited employee.");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!");
            }


        }

        private void AddUser() {

            string username = this.userNameTextBox.Text;
            string password = this.passwordTextBox.Text;

            EmployeeController.AddUser(username, password);


        }

        private void TextChanged_Event(object sender, EventArgs e)
        {
            this.clearErrorMessages();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.EmployeeButton.Text == "Add Employee")
                {
                    if (ValidateForm())
                    {
                        this.AddUser();
                        this.AddEmployee();
                    }
                }
                else if (this.EmployeeButton.Text == "Edit Employee")
                {
                    this.SetEditable();
                    this.ee.Text = "";
                    this.EmployeeButton.Text = "Save Employee";

                }
                else if (this.EmployeeButton.Text == "Save Employee")
                {
                    if (this.ValidateForm())
                    {
                        this.ee.Text = "";
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

        private void cancelButton_Click_2(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

       
    
      
    }
}
