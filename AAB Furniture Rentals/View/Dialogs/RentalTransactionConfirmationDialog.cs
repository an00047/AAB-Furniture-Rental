
using AAB_Furniture_Rentals.Controller;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View.Dialogs
{

  
    public partial class RentalTransactionConfirmationDialog : Form
    {
        
        public RentalTransactionConfirmationDialog()
        {
            
            InitializeComponent();
            ClearFields();
            PopulateFields();
            FurnitureController.CurrentCart = null;     
        }

        private void CloseConfirmationPage_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ClearFields() {
            this.TransactionIDValue.Text = "";
            this.MemberNameValue.Text = "";
            this.MemberIDValue.Text = "";
            this.PhoneNumValue.Text = "";
            this.CartTotalValue.Text = "";
            this.DailyFineRate.Text = "";
            this.ReturnDateValue.Text = "";
            

        }

        private void PopulateFields()
        {
            this.TransactionIDValue.Text = FurnitureController.CurrentCart.rentalTransactionID.ToString();
            this.MemberNameValue.Text = MemberController.CurrentMember.FirstName + " " + MemberController.CurrentMember.LastName;
            this.MemberIDValue.Text = MemberController.CurrentMember.MemberID.ToString();
            this.PhoneNumValue.Text = MemberController.CurrentMember.PhoneNumber;
            this.CartTotalValue.Text = FurnitureController.CurrentCart.CartTotalCost.ToString();
            this.DailyFineRate.Text = FurnitureController.CurrentCart.CalculateDailyFineRate().ToString();
            this.ReturnDateValue.Text = FurnitureController.CurrentCart.ScheduledDueDate.ToString("D");
          

        }

    }
    
}
