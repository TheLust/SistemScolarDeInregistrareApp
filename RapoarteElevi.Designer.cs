namespace SistemScolarDeInregistrareApp
{
    partial class RapoarteElevi
    {/// <summary>
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
            this.SistemScolarDataSet1 = new SistemScolarDeInregistrareApp.SistemScolarDataSet1();
            this.rapEleviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapEleviTableAdapter = new SistemScolarDeInregistrareApp.SistemScolarDataSet1TableAdapters.rapEleviTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemScolarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapEleviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rapEleviBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemScolarDeInregistrareApp.RapoarteElevi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1545, 496);
            this.reportViewer1.TabIndex = 0;
            // 
            // SistemScolarDataSet1
            // 
            this.SistemScolarDataSet1.DataSetName = "SistemScolarDataSet1";
            this.SistemScolarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rapEleviBindingSource
            // 
            this.rapEleviBindingSource.DataMember = "rapElevi";
            this.rapEleviBindingSource.DataSource = this.SistemScolarDataSet1;
            // 
            // rapEleviTableAdapter
            // 
            this.rapEleviTableAdapter.ClearBeforeFill = true;
            // 
            // RapoarteElevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 496);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RapoarteElevi";
            this.Text = "RapoarteElevi";
            this.Load += new System.EventHandler(this.RapoarteElevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemScolarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapEleviBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rapEleviBindingSource;
        private SistemScolarDataSet1 SistemScolarDataSet1;
        private SistemScolarDataSet1TableAdapters.rapEleviTableAdapter rapEleviTableAdapter;
    }
}