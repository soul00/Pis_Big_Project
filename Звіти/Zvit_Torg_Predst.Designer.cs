namespace Pis_Big_Project.Звіти
{
    partial class Zvit_Torg_Predst
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
            this.торговийпредставникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.big_16_04DataSet = new Pis_Big_Project.Big_16_04DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.торговий_представникTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Торговий_представникTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.торговийпредставникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // торговийпредставникBindingSource
            // 
            this.торговийпредставникBindingSource.DataMember = "Торговий_представник";
            this.торговийпредставникBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // big_16_04DataSet
            // 
            this.big_16_04DataSet.DataSetName = "Big_16_04DataSet";
            this.big_16_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.торговийпредставникBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pis_Big_Project.Звіти.Zvit_torg_predst.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // торговий_представникTableAdapter
            // 
            this.торговий_представникTableAdapter.ClearBeforeFill = true;
            // 
            // Zvit_Torg_Predst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Zvit_Torg_Predst";
            this.Load += new System.EventHandler(this.Zvit_Torg_Predst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.торговийпредставникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Big_16_04DataSet big_16_04DataSet;
        private System.Windows.Forms.BindingSource торговийпредставникBindingSource;
        private Big_16_04DataSetTableAdapters.Торговий_представникTableAdapter торговий_представникTableAdapter;
    }
}