namespace Pis_Big_Project
{
    partial class Zapyt_Zamov_Grafik
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
            this.запит_замовник___ГрафікBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запит_замовник___ГрафікTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Запит_замовник___ГрафікTableAdapter();
            this.tableAdapterManager = new Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.typeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.typeToolStripTextBox = new System.Windows.Forms.ToolStripComboBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.запит_замовник___ГрафікDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запит_замовник___ГрафікBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.запит_замовник___ГрафікDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // big_16_04DataSet
            // 
            this.big_16_04DataSet.DataSetName = "Big_16_04DataSet";
            this.big_16_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // запит_замовник___ГрафікBindingSource
            // 
            this.запит_замовник___ГрафікBindingSource.DataMember = "Запит замовник + Графік";
            this.запит_замовник___ГрафікBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // запит_замовник___ГрафікTableAdapter
            // 
            this.запит_замовник___ГрафікTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БатончикTableAdapter = null;
            this.tableAdapterManager.БісквітиTableAdapter = null;
            this.tableAdapterManager.ВафліTableAdapter = null;
            this.tableAdapterManager.ГрафікTableAdapter = null;
            this.tableAdapterManager.ДокументTableAdapter = null;
            this.tableAdapterManager.ЗамовленняTableAdapter = null;
            this.tableAdapterManager.ЗамовникTableAdapter = null;
            this.tableAdapterManager.Накладна_відправленняTableAdapter = null;
            this.tableAdapterManager.Одноразовий_графікTableAdapter = null;
            this.tableAdapterManager.ПечивоTableAdapter = null;
            this.tableAdapterManager.Постійний_графікTableAdapter = null;
            this.tableAdapterManager.Рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Рядок_замовленняTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            this.tableAdapterManager.Торговий_представникTableAdapter = null;
            this.tableAdapterManager.ЦукеркиTableAdapter = null;
            this.tableAdapterManager.ШоколадTableAdapter = null;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripLabel,
            this.typeToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(602, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // typeToolStripLabel
            // 
            this.typeToolStripLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.typeToolStripLabel.Name = "typeToolStripLabel";
            this.typeToolStripLabel.Size = new System.Drawing.Size(133, 22);
            this.typeToolStripLabel.Text = "Введіть тип графіку";
            this.typeToolStripLabel.Click += new System.EventHandler(this.TypeToolStripLabel_Click);
            // 
            // typeToolStripTextBox
            // 
            this.typeToolStripTextBox.Items.AddRange(new object[] {
            "Одноразовий",
            "Постійний"});
            this.typeToolStripTextBox.Name = "typeToolStripTextBox";
            this.typeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(54, 22);
            this.fillToolStripButton.Text = "пошук";
            this.fillToolStripButton.Click += new System.EventHandler(this.FillToolStripButton_Click);
            // 
            // запит_замовник___ГрафікDataGridView
            // 
            this.запит_замовник___ГрафікDataGridView.AutoGenerateColumns = false;
            this.запит_замовник___ГрафікDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.запит_замовник___ГрафікDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.запит_замовник___ГрафікDataGridView.DataSource = this.запит_замовник___ГрафікBindingSource;
            this.запит_замовник___ГрафікDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.запит_замовник___ГрафікDataGridView.Location = new System.Drawing.Point(0, 25);
            this.запит_замовник___ГрафікDataGridView.Name = "запит_замовник___ГрафікDataGridView";
            this.запит_замовник___ГрафікDataGridView.Size = new System.Drawing.Size(602, 256);
            this.запит_замовник___ГрафікDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Назва_Підприємства";
            this.dataGridViewTextBoxColumn1.HeaderText = "Назва_Підприємства";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn2.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Контактна_особа";
            this.dataGridViewTextBoxColumn3.HeaderText = "Контактна_особа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Тип_графіку";
            this.dataGridViewTextBoxColumn4.HeaderText = "Тип_графіку";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Zapyt_Zamov_Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 281);
            this.Controls.Add(this.запит_замовник___ГрафікDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Zapyt_Zamov_Grafik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Запит за типом графіку";
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запит_замовник___ГрафікBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.запит_замовник___ГрафікDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Big_16_04DataSet big_16_04DataSet;
        private System.Windows.Forms.BindingSource запит_замовник___ГрафікBindingSource;
        private Big_16_04DataSetTableAdapters.Запит_замовник___ГрафікTableAdapter запит_замовник___ГрафікTableAdapter;
        private Big_16_04DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel typeToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView запит_замовник___ГрафікDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripComboBox typeToolStripTextBox;
    }
}