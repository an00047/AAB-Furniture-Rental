using AAB_Furniture_Rentals.Controller;
using AAB_Furniture_Rentals.Model;
using AAB_Furniture_Rentals.View.UserControls;
using System;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View
{
   /// <summary>
   /// A dialog form for editing or adding a new customer.
   /// </summary>
    public partial class CustomerDialog : Form
    {

        EmployeeCustomersTabUserControl currentUserControl;
        Member editMember;
        /// <summary>
        /// Constructor for the CustomerDialog. Assumes a new customer is being added. 
        /// A
        /// </summary>
        public CustomerDialog(EmployeeCustomersTabUserControl currentEmployeeUserControl)
        {
            InitializeComponent();
            if (currentEmployeeUserControl == null)
            {
                throw new ArgumentException("Error with employee tab!");
            }
            this.currentUserControl = currentEmployeeUserControl;
            this.CustomerLabel.Text = "New Customer";
            this.CustomerButton.Text = "Add Customer";
            this.genderComboBox.Items.Add("F");
            this.genderComboBox.Items.Add("M");
        }

        /// <summary>
        /// Overloaded constructor for editing a customer. 
        /// Takes customer to be edited and pre-fills out form with information.
        /// </summary>
        /// <param name="currentMember"></param>
        public CustomerDialog(Member currentMember, EmployeeCustomersTabUserControl currentEmployeeUserControl)
        {
            if (currentMember == null)
            {
                throw new Exception("Member is invalid.");
            }
            if (currentEmployeeUserControl == null)
            {
                throw new ArgumentException("Error with employee tab!");
            }
            InitializeComponent();
            this.currentUserControl = currentEmployeeUserControl;
            this.editMember = currentMember;
            this.CustomerLabel.Text = "Edit Customer";
            this.CustomerButton.Text = "Edit Customer";
            
            this.genderComboBox.Items.Add("F");
            this.genderComboBox.Items.Add("M");

            this.firstNameTextBox.Text = this.editMember.FirstName;
            this.lastNameTextBox.Text = this.editMember.LastName;
            this.genderComboBox.SelectedIndex = this.genderComboBox.FindStringExact(currentMember.Gender.ToString());
            this.birthdateBox.Value = this.editMember.DateOfBirth;
            this.phoneTextBox.Text = this.editMember.PhoneNumber;
            this.addressTextBox.Text = this.editMember.Address;
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
            catch(Exception ex)
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
            if(this.phoneTextBox.Text == "")
            {
                this.phoneError.Text = "Phone cannot be empty.";
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
        private void AddCustomer()
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
                    this.currentUserControl.UpdateDataGrid();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }
                
            }
         
          
        }

        private void EditCustomer()
        {
            if (this.ValidateForm())
            {
                try
                {
                    Member newMember = new Member();
                    newMember.MemberID = this.editMember.MemberID;
                    newMember.FirstName = this.firstNameTextBox.Text;
                    newMember.LastName = this.lastNameTextBox.Text;
                    newMember.DateOfBirth = this.birthdateBox.Value;
                    newMember.Gender = Convert.ToChar(this.genderComboBox.SelectedItem);
                    newMember.Address = this.addressTextBox.Text;
                    newMember.PhoneNumber = this.phoneTextBox.Text;
                    MemberController.EditCustomer(newMember);
                    MessageBox.Show("Successfully edited customer.");
                    this.currentUserControl.UpdateDataGrid();
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
