
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spgeneratemetricsforadminreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._cs6232_g4DataSet = new AAB_Furniture_Rentals._cs6232_g4DataSet();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SendDatesButton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_generate_metrics_for_admin_reportTableAdapter = new AAB_Furniture_Rentals._cs6232_g4DataSetTableAdapters.sp_generate_metrics_for_admin_reportTableAdapter();
            this.startDateGroupBox = new System.Windows.Forms.GroupBox();
            this.endDateGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.spgeneratemetricsforadminreportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet)).BeginInit();
            this.startDateGroupBox.SuspendLayout();
            this.endDateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // spgeneratemetricsforadminreportBindingSource
            // 
            this.spgeneratemetricsforadminreportBindingSource.DataMember = "sp_generate_metrics_for_admin_report";
            this.spgeneratemetricsforadminreportBindingSource.DataSource = this._cs6232_g4DataSet;
            // 
            // _cs6232_g4DataSet
            // 
            this._cs6232_g4DataSet.DataSetName = "_cs6232_g4DataSet";
            this._cs6232_g4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatePicker.Location = new System.Drawing.Point(6, 19);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(147, 20);
            this.StartDatePicker.TabIndex = 1;
            this.StartDatePicker.Value = new System.DateTime(2021, 1, 1, 2, 2, 0, 0);
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDatePicker.Location = new System.Drawing.Point(6, 19);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(150, 20);
            this.EndDatePicker.TabIndex = 2;
            this.EndDatePicker.Value = new System.DateTime(2021, 3, 3, 2, 2, 0, 0);
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // SendDatesButton
            // 
            this.SendDatesButton.Location = new System.Drawing.Point(335, 16);
            this.SendDatesButton.Name = "SendDatesButton";
            this.SendDatesButton.Size = new System.Drawing.Size(75, 23);
            this.SendDatesButton.TabIndex = 3;
            this.SendDatesButton.Text = "Execute";
            this.SendDatesButton.UseVisualStyleBackColor = true;
            this.SendDatesButton.Click += new System.EventHandler(this.SendDatesButton_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.IsDocumentMapWidthFixed = true;
            reportDataSource3.Name = "adminReport";
            reportDataSource3.Value = this.spgeneratemetricsforadminreportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DisplayName = "LOcalReportDisplayName";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AAB_Furniture_Rentals.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(511, 151);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.UseWaitCursor = true;
            this.reportViewer1.WaitControlDisplayAfter = 1;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // sp_generate_metrics_for_admin_reportTableAdapter
            // 
            this.sp_generate_metrics_for_admin_reportTableAdapter.ClearBeforeFill = true;
            // 
            // startDateGroupBox
            // 
            this.startDateGroupBox.Controls.Add(this.StartDatePicker);
            this.startDateGroupBox.Location = new System.Drawing.Point(3, 3);
            this.startDateGroupBox.Name = "startDateGroupBox";
            this.startDateGroupBox.Size = new System.Drawing.Size(160, 43);
            this.startDateGroupBox.TabIndex = 5;
            this.startDateGroupBox.TabStop = false;
            this.startDateGroupBox.Text = "Start Date:";
            // 
            // endDateGroupBox
            // 
            this.endDateGroupBox.Controls.Add(this.EndDatePicker);
            this.endDateGroupBox.Location = new System.Drawing.Point(169, 3);
            this.endDateGroupBox.Name = "endDateGroupBox";
            this.endDateGroupBox.Size = new System.Drawing.Size(160, 43);
            this.endDateGroupBox.TabIndex = 6;
            this.endDateGroupBox.TabStop = false;
            this.endDateGroupBox.Text = "End Date: ";
            // 
            // AdminReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endDateGroupBox);
            this.Controls.Add(this.startDateGroupBox);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.SendDatesButton);
            this.Name = "AdminReportUserControl";
            this.Size = new System.Drawing.Size(525, 215);
            ((System.ComponentModel.ISupportInitialize)(this.spgeneratemetricsforadminreportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet)).EndInit();
            this.startDateGroupBox.ResumeLayout(false);
            this.endDateGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Button SendDatesButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spgeneratemetricsforadminreportBindingSource;
        private _cs6232_g4DataSet _cs6232_g4DataSet;
        private _cs6232_g4DataSetTableAdapters.sp_generate_metrics_for_admin_reportTableAdapter sp_generate_metrics_for_admin_reportTableAdapter;
        private System.Windows.Forms.GroupBox startDateGroupBox;
        private System.Windows.Forms.GroupBox endDateGroupBox;
    }
}
