
using AAB_Furniture_Rentals.Controller;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View.UserControls
{
    /// <summary>
    /// User control enabling an employee to look up customers
    /// </summary>
    public partial class EmployeeCustomersTabUserControl : UserControl
    {
     
        private Member currentCustomer;
        private List<Member> customerList;
        /// <summary>
        /// constructor method for the Customers user control
        /// </summary>
        public EmployeeCustomersTabUserControl()
        {
            InitializeComponent();
            customerList = new List<Member>();
         
            this.editCustomerButton.Enabled = false;
            this.searchTypeComboBox.Items.Add("--Select Search Type--");
            this.searchTypeComboBox.Items.Add("Customer ID");
            this.searchTypeComboBox.Items.Add("Customer Phone Number");
            this.searchTypeComboBox.Items.Add("Customer First and Last Name");
            this.searchTypeComboBox.SelectedIndex = 0;

        }

        private void NewCustomerButton_Click(object sender, System.EventArgs e)
        {
            Form newCustomerDialog = new CustomerDialog();
            newCustomerDialog.ShowDialog();

        }

        private void EditCustomerButton_Click(object sender, System.EventArgs e)
        {
            
            Form editCustomerDialog = new CustomerDialog(this.currentCustomer);
            DialogResult result = editCustomerDialog.ShowDialog();

        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
           if (this.searchTextBox.Text == "")
            {
                MessageBox.Show("Search cannot be empty!");
            }
            else if (this.searchTypeComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Must specify search type!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.searchTypeComboBox.SelectedIndex == 1)
            {
                this.searchByCustomerID();
            }
            else if (this.searchTypeComboBox.SelectedIndex == 2)
            {
                this.searchByPhoneNumber();
            }
            else if (this.searchTypeComboBox.SelectedIndex == 3)
            {
                this.searchByFirstAndLastName();
            }
        }

    

        private void searchByCustomerID()
        {
            try
            {

                var customerID = int.Parse(this.searchTextBox.Text);
                List<Member> customerList = new List<Member>();
                currentCustomer = MemberController.GetCustomerByID(customerID);
                customerList.Add(currentCustomer);
                this.RefreshDataGrid(customerList);
                this.editCustomerButton.Enabled = true;

            }
            catch (FormatException)
            {
                MessageBox.Show("Customer ID must be a number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void searchByPhoneNumber()
        {
            try
            {
               
                    string[] validNumber = this.searchTextBox.Text.Split(' ');
                    if (this.searchTextBox.Text.Length != 12)
                    {
                    throw new ArgumentException("Must be in 8 digits long!");
                       
                    } else if (validNumber.Length != 3)
                     {
                    throw new ArgumentException("Must be in '555 555 5555' format!");

                     }

                     int.Parse(validNumber[0]);
                    int.Parse(validNumber[1]);
                    int.Parse(validNumber[2]);
                    

                currentCustomer = MemberController.GetCustomerByPhoneNumber(this.searchTextBox.Text);
                List<Member> customerList = new List<Member>();
                customerList.Add(currentCustomer);
                this.RefreshDataGrid(customerList);
                this.editCustomerButton.Enabled = true;

            }
            catch (FormatException)
            {
                MessageBox.Show("Phone number must be a number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    
        private void searchByFirstAndLastName()
        {
            try
            {

                string[] validName = this.searchTextBox.Text.Split(' ');

                string firstName = validName[0];
                string lastName = validName[1];


                if (validName.Length != 2)
                {
                   throw new ArgumentException("Must search first and last name!");

                }

                currentCustomer = MemberController.GetCustomerByFirstAndLastName(firstName, lastName);
                List<Member> customerList = new List<Member>();
                customerList.Add(currentCustomer);
                this.RefreshDataGrid(customerList);
                this.editCustomerButton.Enabled = true;

            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void RefreshDataGrid(List<Member> customerList)
        {   
            
            this.customerDataGridView.DataSource = customerList;
        }

        private void CustomerTextBox_Changed(object sender, EventArgs e)
        {
            this.editCustomerButton.Enabled = false;
          
        }

        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.searchTypeComboBox.SelectedIndex == 0)
            {
                this.searchTypeLabel.Text = "";
                this.searchButton.Hide();
                this.searchTextBox.Hide();
            }
            if (this.searchTypeComboBox.SelectedIndex == 1)
            {
                this.searchTypeLabel.Text = "Customer ID:";
                this.searchButton.Show();
                this.searchTextBox.Show();
            }
            else if (this.searchTypeComboBox.SelectedIndex == 2)
            {
                this.searchTypeLabel.Text = "Phone Number:";
                this.searchButton.Show();
                this.searchTextBox.Show();
            }
            else if (this.searchTypeComboBox.SelectedIndex == 3)
            {
                this.searchTypeLabel.Text = "First and Last Name:";
                this.searchButton.Show();
                this.searchTextBox.Show();
            }
        }
    }
  }
