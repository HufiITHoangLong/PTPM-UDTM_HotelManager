namespace GUI
{
    partial class FormTK
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Hotel_ManagerDataSet_ThongKe = new GUI.Hotel_ManagerDataSet_ThongKe();
            this.CHITIETHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CHITIETHDTableAdapter = new GUI.Hotel_ManagerDataSet_ThongKeTableAdapters.CHITIETHDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Hotel_ManagerDataSet_ThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHITIETHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CHITIETHDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 537);
            this.reportViewer1.TabIndex = 0;
            // 
            // Hotel_ManagerDataSet_ThongKe
            // 
            this.Hotel_ManagerDataSet_ThongKe.DataSetName = "Hotel_ManagerDataSet_ThongKe";
            this.Hotel_ManagerDataSet_ThongKe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CHITIETHDBindingSource
            // 
            this.CHITIETHDBindingSource.DataMember = "CHITIETHD";
            this.CHITIETHDBindingSource.DataSource = this.Hotel_ManagerDataSet_ThongKe;
            // 
            // CHITIETHDTableAdapter
            // 
            this.CHITIETHDTableAdapter.ClearBeforeFill = true;
            // 
            // FormTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormTK";
            this.Text = "Form Thống kê";
            this.Load += new System.EventHandler(this.FormTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hotel_ManagerDataSet_ThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHITIETHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CHITIETHDBindingSource;
        private Hotel_ManagerDataSet_ThongKe Hotel_ManagerDataSet_ThongKe;
        private Hotel_ManagerDataSet_ThongKeTableAdapters.CHITIETHDTableAdapter CHITIETHDTableAdapter;
    }
}