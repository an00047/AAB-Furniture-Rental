using System;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View.Dialogs
{
    /// <summary>
    /// Partial class for the shipping member dialog
    /// </summary>
    public partial class SelectShoppingMemberDialog : Form
    {
        /// <summary>
        /// initialized the component
        /// </summary>
        public SelectShoppingMemberDialog()
        {
            InitializeComponent(); 

        }


        private void closeFromButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
