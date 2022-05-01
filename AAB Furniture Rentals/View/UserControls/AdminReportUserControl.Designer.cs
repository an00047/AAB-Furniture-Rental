
namespace AAB_Furniture_Rentals.View.UserControls
{
    partial class AdminReportUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SendDatesButton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._cs6232_g4DataSet = new AAB_Furniture_Rentals._cs6232_g4DataSet();
            this.spgeneratemetricsforadminreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_generate_metrics_for_admin_reportTableAdapter = new AAB_Furniture_Rentals._cs6232_g4DataSetTableAdapters.sp_generate_metrics_for_admin_reportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgeneratemetricsforadminreportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(138, 11);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDatePicker.TabIndex = 1;
            this.StartDatePicker.Value = new System.DateTime(2021, 1, 1, 2, 2, 0, 0);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(138, 37);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 2;
            this.EndDatePicker.Value = new System.DateTime(2021, 3, 3, 2, 2, 0, 0);
            // 
            // SendDatesButton
            // 
            this.SendDatesButton.Location = new System.Drawing.Point(344, 34);
            this.SendDatesButton.Name = "SendDatesButton";
            this.SendDatesButton.Size = new System.Drawing.Size(75, 23);
            this.SendDatesButton.TabIndex = 3;
            this.SendDatesButton.Text = "Execute";
            this.SendDatesButton.UseVisualStyleBackColor = true;
            this.SendDatesButton.Click += new System.EventHandler(this.SendDatesButton_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "adminReport";
            reportDataSource1.Value = this.spgeneratemetricsforadminreportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AAB_Furniture_Rentals.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(35, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 145);
            this.reportViewer1.TabIndex = 4;
            // 
            // _cs6232_g4DataSet
            // 
            this._cs6232_g4DataSet.DataSetName = "_cs6232_g4DataSet";
            this._cs6232_g4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spgeneratemetricsforadminreportBindingSource
            // 
            this.spgeneratemetricsforadminreportBindingSource.DataMember = "sp_generate_metrics_for_admin_report";
            this.spgeneratemetricsforadminreportBindingSource.DataSource = this._cs6232_g4DataSet;
            // 
            // sp_generate_metrics_for_admin_reportTableAdapter
            // 
            this.sp_generate_metrics_for_admin_reportTableAdapter.ClearBeforeFill = true;
            // 
            // AdminReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.SendDatesButton);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Name = "AdminReportUserControl";
            this.Size = new System.Drawing.Size(466, 261);
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgeneratemetricsforadminreportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Button SendDatesButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spgeneratemetricsforadminreportBindingSource;
        private _cs6232_g4DataSet _cs6232_g4DataSet;
        private _cs6232_g4DataSetTableAdapters.sp_generate_metrics_for_admin_reportTableAdapter sp_generate_metrics_for_admin_reportTableAdapter;
    }
}
