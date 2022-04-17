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
    public partial class CartDialog : Form
    {
        Cart currentCart;
        public CartDialog(Cart theCart)
        {
            InitializeComponent();
            this.currentCart = theCart;
            this.RefreshDataGrid();
        }


        /// <summary>
        /// really cool magical gridhandler that fixes everything
        /// </summary>
        private void RefreshDataGrid() => this.FurnitureDataGridView.DataSource = this.currentCart.FurnitureList;

        private void CheckoutButton_Click(object sender, EventArgs e)
        {

        }

        private void AbandonCartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
