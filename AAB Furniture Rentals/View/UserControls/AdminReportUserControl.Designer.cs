
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
            this.spgeneratemetricsforadminreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._cs6232_g4DataSet = new AAB_Furniture_Rentals._cs6232_g4DataSet();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SendDatesButton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_generate_metrics_for_admin_reportTableAdapter = new AAB_Furniture_Rentals._cs6232_g4DataSetTableAdapters.sp_generate_metrics_for_admin_reportTableAdapter();
            this.selectDateGroupBox = new System.Windows.Forms.GroupBox();
            this.currentDatesGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentStartDateLabel = new System.Windows.Forms.Label();
            this.CurrentEndDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spgeneratemetricsforadminreportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet)).BeginInit();
            this.selectDateGroupBox.SuspendLayout();
            this.currentDatesGroupBox.SuspendLayout();
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
            this.StartDatePicker.Location = new System.Drawing.Point(72, 19);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(135, 20);
            this.StartDatePicker.TabIndex = 1;
            this.StartDatePicker.Value = new System.DateTime(2021, 1, 1, 2, 2, 0, 0);
            this.StartDatePicker.CloseUp += new System.EventHandler(this.StartDatePicker_CloseUp);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDatePicker.Location = new System.Drawing.Point(72, 44);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(135, 20);
            this.EndDatePicker.TabIndex = 2;
            this.EndDatePicker.Value = new System.DateTime(2021, 3, 3, 2, 2, 0, 0);
            this.EndDatePicker.CloseUp += new System.EventHandler(this.EndDatePicker_CloseUp);
            // 
            // SendDatesButton
            // 
            this.SendDatesButton.Location = new System.Drawing.Point(213, 19);
            this.SendDatesButton.Name = "SendDatesButton";
            this.SendDatesButton.Size = new System.Drawing.Size(75, 45);
            this.SendDatesButton.TabIndex = 3;
            this.SendDatesButton.Text = "Execute";
            this.SendDatesButton.UseVisualStyleBackColor = true;
            this.SendDatesButton.Click += new System.EventHandler(this.SendDatesButton_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.reportViewer1.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "adminReport";
            reportDataSource1.Value = this.spgeneratemetricsforadminreportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DisplayName = "AAB Furniture Rental Admin Report";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AAB_Furniture_Rentals.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 83);
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
            this.reportViewer1.Size = new System.Drawing.Size(511, 120);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.UseWaitCursor = true;
            this.reportViewer1.WaitControlDisplayAfter = 1;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // sp_generate_metrics_for_admin_reportTableAdapter
            // 
            this.sp_generate_metrics_for_admin_reportTableAdapter.ClearBeforeFill = true;
            // 
            // selectDateGroupBox
            // 
            this.selectDateGroupBox.Controls.Add(this.label2);
            this.selectDateGroupBox.Controls.Add(this.label1);
            this.selectDateGroupBox.Controls.Add(this.EndDatePicker);
            this.selectDateGroupBox.Controls.Add(this.StartDatePicker);
            this.selectDateGroupBox.Controls.Add(this.SendDatesButton);
            this.selectDateGroupBox.Location = new System.Drawing.Point(3, 3);
            this.selectDateGroupBox.Name = "selectDateGroupBox";
            this.selectDateGroupBox.Size = new System.Drawing.Size(298, 74);
            this.selectDateGroupBox.TabIndex = 5;
            this.selectDateGroupBox.TabStop = false;
            this.selectDateGroupBox.Text = "Choose Date of Interest:";
            // 
            // currentDatesGroupBox
            // 
            this.currentDatesGroupBox.Controls.Add(this.CurrentEndDateLabel);
            this.currentDatesGroupBox.Controls.Add(this.CurrentStartDateLabel);
            this.currentDatesGroupBox.Controls.Add(this.label4);
            this.currentDatesGroupBox.Controls.Add(this.label3);
            this.currentDatesGroupBox.Location = new System.Drawing.Point(307, 3);
            this.currentDatesGroupBox.Name = "currentDatesGroupBox";
            this.currentDatesGroupBox.Size = new System.Drawing.Size(209, 74);
            this.currentDatesGroupBox.TabIndex = 7;
            this.currentDatesGroupBox.TabStop = false;
            this.currentDatesGroupBox.Text = "Current Date Range Shown:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Date:";
            // 
            // CurrentStartDateLabel
            // 
            this.CurrentStartDateLabel.AutoSize = true;
            this.CurrentStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStartDateLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CurrentStartDateLabel.Location = new System.Drawing.Point(61, 23);
            this.CurrentStartDateLabel.Name = "CurrentStartDateLabel";
            this.CurrentStartDateLabel.Size = new System.Drawing.Size(17, 17);
            this.CurrentStartDateLabel.TabIndex = 7;
            this.CurrentStartDateLabel.Text = "?";
            // 
            // CurrentEndDateLabel
            // 
            this.CurrentEndDateLabel.AutoSize = true;
            this.CurrentEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentEndDateLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CurrentEndDateLabel.Location = new System.Drawing.Point(61, 48);
            this.CurrentEndDateLabel.Name = "CurrentEndDateLabel";
            this.CurrentEndDateLabel.Size = new System.Drawing.Size(17, 17);
            this.CurrentEndDateLabel.TabIndex = 8;
            this.CurrentEndDateLabel.Text = "?";
            // 
            // AdminReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.currentDatesGroupBox);
            this.Controls.Add(this.selectDateGroupBox);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AdminReportUserControl";
            this.Size = new System.Drawing.Size(525, 215);
            ((System.ComponentModel.ISupportInitialize)(this.spgeneratemetricsforadminreportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet)).EndInit();
            this.selectDateGroupBox.ResumeLayout(false);
            this.selectDateGroupBox.PerformLayout();
            this.currentDatesGroupBox.ResumeLayout(false);
            this.currentDatesGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox selectDateGroupBox;
        private System.Windows.Forms.GroupBox currentDatesGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentEndDateLabel;
        private System.Windows.Forms.Label CurrentStartDateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
