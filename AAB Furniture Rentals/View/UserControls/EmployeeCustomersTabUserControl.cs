
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

        private Member selectedMember;
        private List<Member> customerList;
        /// <summary>
        /// constructor method for the Customers user control
        /// </summary>
        public EmployeeCustomersTabUserControl()
        {
            InitializeComponent();
            this.customerList = new List<Member>();

            this.editCustomerButton.Enabled = false;
            this.SetCurrentMemberButton.Enabled = false;
            this.CustIdRadioBtn.Checked = true;
            if (MemberController.CurrentMember != null)
            {
                this.CustomerIDValue.Text = MemberController.CurrentMember.MemberID.ToString();
                this.CustomerPhoneValue.Text = MemberController.CurrentMember.PhoneNumber.ToString();
                this.CustoemrNameValue.Text = MemberController.CurrentMember.FirstName + " " + MemberController.CurrentMember.LastName;
            }
            else {
                this.CustomerIDValue.Text = "N/A";
                this.CustomerPhoneValue.Text = "--- --- ----";
                this.CustoemrNameValue.Text = "N/A";
            }


        }

        private void NewCustomerButton_Click(object sender, System.EventArgs e)
        {
            Form newCustomerDialog = new CustomerDialog(this);
            DialogResult result = newCustomerDialog.ShowDialog();
            //MEMBER IS SET ON THE DIALOG
            if (result != DialogResult.Cancel)
            {
                this.CustomerIDValue.Text = MemberController.CurrentMember.MemberID.ToString();
                this.CustomerPhoneValue.Text = MemberController.CurrentMember.PhoneNumber.ToString();
                this.CustoemrNameValue.Text = MemberController.CurrentMember.FirstName + " " + MemberController.CurrentMember.LastName;

            }


        }

        private void EditCustomerButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                int customerID = int.Parse(customerDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                Member editCustomer = MemberController.GetCustomerByID(customerID);
                Form editCustomerDialog = new CustomerDialog(editCustomer, this);
                DialogResult result = editCustomerDialog.ShowDialog();
            }
            catch (Exception)
            { MessageBox.Show("Error with customer ID! Please try again.");
            }
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            SetCurrentMemberButton.Enabled = false;
            this.search();
        }

        private void search()
        {

            if (this.searchTextBox.Text == "")
            {
                MessageBox.Show("Search cannot be empty!");
            }
            else if (this.CustIdRadioBtn.Checked == true)
            {
                this.searchByCustomerID();
            }
            else if (this.PhoneRadioBtn.Checked == true)
            {
                this.searchByPhoneNumber();
            }
            else if (this.NameRadioBtn.Checked == true)
            {
                this.searchByFirstAndLastName();
            }
        }

    

        private void searchByCustomerID()
        {
            try
            {

                var customerID = int.Parse(this.searchTextBox.Text);
                this.customerList.Clear();
                customerList = MemberController.GetCustomersByID(customerID);
                this.RefreshDataGrid();
                this.editCustomerButton.Enabled = true;

            }
            catch (FormatException)
            {
                MessageBox.Show("Customer ID must be a number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.customerDataGridView.DataSource = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.customerDataGridView.DataSource = "";

        }
        }

        private void searchByPhoneNumber()
        {
            try
            {
                     this.customerList.Clear();
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

                this.customerList.Clear();
                this.customerList = MemberController.GetCustomersByPhoneNumber(this.searchTextBox.Text);
                this.RefreshDataGrid();
                this.editCustomerButton.Enabled = true;

            }
            catch (FormatException)
            {
                MessageBox.Show("Phone number must be a number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.customerDataGridView.DataSource = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.customerDataGridView.DataSource = "";

            }
        }
    
        private void searchByFirstAndLastName()
        {
            try
            {
                this.customerList.Clear();
                string[] validName = this.searchTextBox.Text.Split(' ');

                string firstName = validName[0];
                string lastName = validName[1];


                if (validName.Length != 2)
                {
                   throw new ArgumentException("Must search first and last name!");

                }
                this.customerList.Clear();
                this.customerList = MemberController.GetCustomersByFirstAndLastName(firstName, lastName);
                this.RefreshDataGrid();
                this.editCustomerButton.Enabled = true;

            }
           catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Must search first and last name!", "Error!");
                this.customerDataGridView.DataSource = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.customerDataGridView.DataSource = "";
            }
        }

       
       private void RefreshDataGrid()
        {
            
            this.customerDataGridView.DataSource = this.customerList;
            this.customerDataGridView.Refresh();
        }

        /// <summary>
        /// Updates/refreshes the data grid
        /// </summary>
        public void UpdateDataGrid()
        {

            this.customerList.Clear();
            this.search();
      
        }


        private void CustomerTextBox_Changed(object sender, EventArgs e)
        {
            this.editCustomerButton.Enabled = false;
          
        }

        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void customerDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.selectedMember = ((Member)this.customerDataGridView.SelectedRows[0].DataBoundItem);
            this.SetCurrentMemberButton.Enabled = true;

        }

        private void SetCurrentMemberButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Curent Shopper set to:" +
                " " + this.selectedMember.FirstName +
                " " + this.selectedMember.LastName + 
                " | Member ID: " + this.selectedMember.MemberID.ToString());


            MemberController.CurrentMember = this.selectedMember;
            this.CustomerIDValue.Text = MemberController.CurrentMember.MemberID.ToString();
            this.CustomerPhoneValue.Text = MemberController.CurrentMember.PhoneNumber.ToString();
            this.CustoemrNameValue.Text = MemberController.CurrentMember.FirstName + " " + MemberController.CurrentMember.LastName;

            this.SetCurrentMemberButton.Enabled = false;
        }

        private void SetLabel(object sender, EventArgs e)
        {
            this.searchTextBox.Clear();
            if (this.CustIdRadioBtn.Checked == true)
            {
                this.searchTypeLabel.Text = "Customer ID:";
                this.searchButton.Show();
                this.searchTextBox.Show();
            }
            else if (this.PhoneRadioBtn.Checked == true)
            {
                this.searchTypeLabel.Text = "Phone Number:";
                this.searchButton.Show();
                this.searchTextBox.Show();
            }
            else if (this.NameRadioBtn.Checked == true)
            {
                this.searchTypeLabel.Text = "First and Last Name:";
                this.searchButton.Show();
                this.searchTextBox.Show();
            }
        }
    }
  }
