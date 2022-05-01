using AAB_Furniture_Rentals._cs6232_g4DataSetTableAdapters;
using System;

using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View.UserControls
{
    public partial class AdminReportUserControl : UserControl
    {
        public AdminReportUserControl()
        {
            
            InitializeComponent();
            sp_generate_metrics_for_admin_reportTableAdapter.ClearBeforeFill = true;
            this.StartDatePicker.MaxDate = this.EndDatePicker.Value.AddDays(-1);
            this.EndDatePicker.MinDate = this.StartDatePicker.Value.AddDays(1);
           
            this.refreshReport();

        }

        private void refreshReport() {
            try {
                sp_generate_metrics_for_admin_reportTableAdapter.Fill(this._cs6232_g4DataSet.sp_generate_metrics_for_admin_report, this.StartDatePicker.Value, this.EndDatePicker.Value);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Data.SqlClient.SqlException SqlEx) {
                if (SqlEx.Message == "Divide by zero error encountered.") {
                    MessageBox.Show("There are no qualified transactions for the given period. \n Please choose a different date range");

                } else {
                    MessageBox.Show(SqlEx.Message);
                }
                
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendDatesButton_Click(object sender, EventArgs e)
        {
            this.refreshReport();
        }

        private void StartDatePicker_CloseUp(object sender, EventArgs e)
        {

            try
            {  
                this.EndDatePicker.MinDate = this.StartDatePicker.Value.AddDays(1);
            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.Message);
            }
        }

        private void EndDatePicker_CloseUp(object sender, EventArgs e)
        {
            try
            {                                                                                                                                                
                this.StartDatePicker.MaxDate = this.EndDatePicker.Value.AddDays(-1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}





