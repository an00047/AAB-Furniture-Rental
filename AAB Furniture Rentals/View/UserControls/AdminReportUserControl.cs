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

            sp_generate_metrics_for_admin_reportTableAdapter.Fill(this._cs6232_g4DataSet.sp_generate_metrics_for_admin_report, this.StartDatePicker.Value, this.EndDatePicker.Value);
            this.reportViewer1.RefreshReport();


        }

        private void SendDatesButton_Click(object sender, EventArgs e)
        {
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report1.rdlc";
            sp_generate_metrics_for_admin_reportTableAdapter.Fill(this._cs6232_g4DataSet.sp_generate_metrics_for_admin_report, this.StartDatePicker.Value, this.EndDatePicker.Value);
            //    sp_generate_metrics_for_admin_reportTableAdapter.GetData(this.StartDatePicker.Value, this.EndDatePicker.Value);
            this.reportViewer1.RefreshReport();
            //var i = 1;
        }

  
    }
}
