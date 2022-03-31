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
        public CustomerDialog(string formType)
        {
            InitializeComponent();
            this.customerLabel.Text = formType + " Customer";
            this.CustomerButton.Text = formType + " Customer";
        }

        private void CustomerDialog_Load(object sender, EventArgs e)
        {

        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
