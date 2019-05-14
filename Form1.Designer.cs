namespace Pis_Big_Project
{
    partial class Form1
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
            this.Big_16_04DataSet = new Pis_Big_Project.Big_16_04DataSet();
            this.Торговий___документBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Торговий___документTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Торговий___документTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Big_16_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Торговий___документBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Торговий___документBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pis_Big_Project.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1023, 484);
            this.reportViewer1.TabIndex = 0;
            // 
            // Big_16_04DataSet
            // 
            this.Big_16_04DataSet.DataSetName = "Big_16_04DataSet";
            this.Big_16_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Торговий___документBindingSource
            // 
            this.Торговий___документBindingSource.DataMember = "Торговий + документ";
            this.Торговий___документBindingSource.DataSource = this.Big_16_04DataSet;
            // 
            // Торговий___документTableAdapter
            // 
            this.Торговий___документTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 484);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Big_16_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Торговий___документBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Торговий___документBindingSource;
        private Big_16_04DataSet Big_16_04DataSet;
        private Big_16_04DataSetTableAdapters.Торговий___документTableAdapter Торговий___документTableAdapter;
    }
}