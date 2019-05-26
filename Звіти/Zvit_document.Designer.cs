namespace Pis_Big_Project.Звіти
{
    partial class Zvit_document
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
            this.Документ_ЗамовникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.big_16_04DataSet = new Pis_Big_Project.Big_16_04DataSet();
            this.документЗамовникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.документ_ЗамовникTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Документ_ЗамовникTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Документ_ЗамовникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документЗамовникBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Документ_ЗамовникBindingSource
            // 
            this.Документ_ЗамовникBindingSource.DataMember = "Документ_Замовник";
            this.Документ_ЗамовникBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // big_16_04DataSet
            // 
            this.big_16_04DataSet.DataSetName = "Big_16_04DataSet";
            this.big_16_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // документЗамовникBindingSource
            // 
            this.документЗамовникBindingSource.DataMember = "Документ_Замовник";
            this.документЗамовникBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // документ_ЗамовникTableAdapter
            // 
            this.документ_ЗамовникTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Document_Zvit";
            reportDataSource1.Value = this.Документ_ЗамовникBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pis_Big_Project.Звіти.zvit_document.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Zvit_document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Zvit_document";
            this.Load += new System.EventHandler(this.Zvit_document_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Документ_ЗамовникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документЗамовникBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Big_16_04DataSet big_16_04DataSet;
        private System.Windows.Forms.BindingSource документЗамовникBindingSource;
        private Big_16_04DataSetTableAdapters.Документ_ЗамовникTableAdapter документ_ЗамовникTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Документ_ЗамовникBindingSource;
    }
}