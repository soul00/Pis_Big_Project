namespace Pis_Big_Project.Звіти
{
    partial class Zvit_Tovary
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
            this.big_16_04DataSet = new Pis_Big_Project.Big_16_04DataSet();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.ТоварTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.товарBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pis_Big_Project.Звіти.Zvit_tovar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(944, 329);
            this.reportViewer1.TabIndex = 0;
            // 
            // big_16_04DataSet
            // 
            this.big_16_04DataSet.DataSetName = "Big_16_04DataSet";
            this.big_16_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // Zvit_Tovary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 329);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Zvit_Tovary";
            this.Text = "Zvit_Tovary";
            this.Load += new System.EventHandler(this.Zvit_Tovary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Big_16_04DataSet big_16_04DataSet;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private Big_16_04DataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
    }
}