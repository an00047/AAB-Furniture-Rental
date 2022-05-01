using AAB_Furniture_Rentals._cs6232_g4DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View.UserControls
{
    public partial class AdminReportUserControl : UserControl
    {
        public AdminReportUserControl()
        {
            InitializeComponent();

         

        }

        private void SendDatesButton_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report1.rdlc";
                sp_generate_metrics_for_admin_reportTableAdapter.GetData(this.StartDatePicker.Value, this.EndDatePicker.Value);
            this.reportViewer1.RefreshReport();
            var i = 1;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
