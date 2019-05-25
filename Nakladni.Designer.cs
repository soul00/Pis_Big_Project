namespace Pis_Big_Project
{
    partial class Nakladni
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
            this.big_16_04DataSet = new Pis_Big_Project.Big_16_04DataSet();
            this.зведені_накладніBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.зведені_накладніTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Зведені_накладніTableAdapter();
            this.tableAdapterManager = new Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager();
            this.зведені_ЗамовленняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.зведені_ЗамовленняTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Зведені_ЗамовленняTableAdapter();
            this.зведені_накладніDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зведені_накладніBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зведені_ЗамовленняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зведені_накладніDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // big_16_04DataSet
            // 
            this.big_16_04DataSet.DataSetName = "Big_16_04DataSet";
            this.big_16_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // зведені_накладніBindingSource
            // 
            this.зведені_накладніBindingSource.DataMember = "Зведені_накладні";
            this.зведені_накладніBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // зведені_накладніTableAdapter
            // 
            this.зведені_накладніTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГрафікTableAdapter = null;
            this.tableAdapterManager.ДокументTableAdapter = null;
            this.tableAdapterManager.ЗамовленняTableAdapter = null;
            this.tableAdapterManager.ЗамовникTableAdapter = null;
            this.tableAdapterManager.Накладна_відправленняTableAdapter = null;
            this.tableAdapterManager.Одноразовий_графікTableAdapter = null;
            this.tableAdapterManager.Постійний_графікTableAdapter = null;
            this.tableAdapterManager.Рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Рядок_замовленняTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            this.tableAdapterManager.Торговий_представникTableAdapter = null;
            // 
            // зведені_ЗамовленняBindingSource
            // 
            this.зведені_ЗамовленняBindingSource.DataMember = "Зведені_Замовлення";
            this.зведені_ЗамовленняBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // зведені_ЗамовленняTableAdapter
            // 
            this.зведені_ЗамовленняTableAdapter.ClearBeforeFill = true;
            // 
            // зведені_накладніDataGridView
            // 
            this.зведені_накладніDataGridView.AutoGenerateColumns = false;
            this.зведені_накладніDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.зведені_накладніDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.зведені_накладніDataGridView.DataSource = this.зведені_накладніBindingSource;
            this.зведені_накладніDataGridView.Location = new System.Drawing.Point(12, 12);
            this.зведені_накладніDataGridView.Name = "зведені_накладніDataGridView";
            this.зведені_накладніDataGridView.Size = new System.Drawing.Size(733, 220);
            this.зведені_накладніDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Сума";
            this.dataGridViewTextBoxColumn3.HeaderText = "Сума";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_оформлення";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата_оформлення";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата_відвантаження";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата_відвантаження";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Назва_Підприємства";
            this.dataGridViewTextBoxColumn6.HeaderText = "Назва_Підприємства";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ПІБ_Представника";
            this.dataGridViewTextBoxColumn7.HeaderText = "ПІБ_Представника";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Nakladni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.зведені_накладніDataGridView);
            this.Name = "Nakladni";
            this.Text = "Nakladni";
            this.Load += new System.EventHandler(this.Nakladni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зведені_накладніBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зведені_ЗамовленняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зведені_накладніDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Big_16_04DataSet big_16_04DataSet;
        private System.Windows.Forms.BindingSource зведені_накладніBindingSource;
        private Big_16_04DataSetTableAdapters.Зведені_накладніTableAdapter зведені_накладніTableAdapter;
        private Big_16_04DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource зведені_ЗамовленняBindingSource;
        private Big_16_04DataSetTableAdapters.Зведені_ЗамовленняTableAdapter зведені_ЗамовленняTableAdapter;
        private System.Windows.Forms.DataGridView зведені_накладніDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}