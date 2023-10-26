namespace SistemScolarDeInregistrareApp
{
    partial class rapTaxa
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
            this.SistemScolarDataSet3 = new SistemScolarDeInregistrareApp.SistemScolarDataSet3();
            this.rapTaxaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapTaxaTableAdapter = new SistemScolarDeInregistrareApp.SistemScolarDataSet3TableAdapters.rapTaxaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemScolarDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapTaxaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.rapTaxaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemScolarDeInregistrareApp.RapoarteTaxa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SistemScolarDataSet3
            // 
            this.SistemScolarDataSet3.DataSetName = "SistemScolarDataSet3";
            this.SistemScolarDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rapTaxaBindingSource
            // 
            this.rapTaxaBindingSource.DataMember = "rapTaxa";
            this.rapTaxaBindingSource.DataSource = this.SistemScolarDataSet3;
            // 
            // rapTaxaTableAdapter
            // 
            this.rapTaxaTableAdapter.ClearBeforeFill = true;
            // 
            // rapTaxa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rapTaxa";
            this.Text = "rapTaxa";
            this.Load += new System.EventHandler(this.rapTaxa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemScolarDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapTaxaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rapTaxaBindingSource;
        private SistemScolarDataSet3 SistemScolarDataSet3;
        private SistemScolarDataSet3TableAdapters.rapTaxaTableAdapter rapTaxaTableAdapter;
    }
}