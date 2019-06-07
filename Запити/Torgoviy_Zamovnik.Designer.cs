namespace Pis_Big_Project.Запити
{
    partial class Torgoviy_Zamovnik
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.big_16_04DataSet = new Pis_Big_Project.Big_16_04DataSet();
            this.торговий___ЗамовникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.торговий___ЗамовникTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Торговий___ЗамовникTableAdapter();
            this.tableAdapterManager = new Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.торговий___ЗамовникDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговий___ЗамовникBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.торговий___ЗамовникDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // big_16_04DataSet
            // 
            this.big_16_04DataSet.DataSetName = "Big_16_04DataSet";
            this.big_16_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // торговий___ЗамовникBindingSource
            // 
            this.торговий___ЗамовникBindingSource.DataMember = "Торговий + Замовник";
            this.торговий___ЗамовникBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // торговий___ЗамовникTableAdapter
            // 
            this.торговий___ЗамовникTableAdapter.ClearBeforeFill = true;
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
            this.nameToolStripLabel,
            this.nameToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(902, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // nameToolStripLabel
            // 
            this.nameToolStripLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameToolStripLabel.Name = "nameToolStripLabel";
            this.nameToolStripLabel.Size = new System.Drawing.Size(194, 22);
            this.nameToolStripLabel.Text = "ПІБ Торгового представника";
            // 
            // nameToolStripTextBox
            // 
            this.nameToolStripTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.nameToolStripTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.nameToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameToolStripTextBox.Name = "nameToolStripTextBox";
            this.nameToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fillToolStripButton.ForeColor = System.Drawing.Color.White;
            this.fillToolStripButton.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.fillToolStripButton.Text = "Шукати";
            this.fillToolStripButton.Click += new System.EventHandler(this.FillToolStripButton_Click);
            // 
            // торговий___ЗамовникDataGridView
            // 
            this.торговий___ЗамовникDataGridView.AutoGenerateColumns = false;
            this.торговий___ЗамовникDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.торговий___ЗамовникDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.торговий___ЗамовникDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.торговий___ЗамовникDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.торговий___ЗамовникDataGridView.DataSource = this.торговий___ЗамовникBindingSource;
            this.торговий___ЗамовникDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.торговий___ЗамовникDataGridView.EnableHeadersVisualStyles = false;
            this.торговий___ЗамовникDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            this.торговий___ЗамовникDataGridView.Location = new System.Drawing.Point(0, 25);
            this.торговий___ЗамовникDataGridView.Name = "торговий___ЗамовникDataGridView";
            this.торговий___ЗамовникDataGridView.Size = new System.Drawing.Size(902, 281);
            this.торговий___ЗамовникDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ПІБ_Представника";
            this.dataGridViewTextBoxColumn1.HeaderText = "ПІБ_Представника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 129;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номерні_знаки_авто";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номерні_знаки_авто";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 139;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Телефон_представника";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон_представника";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 154;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Назва_Підприємства";
            this.dataGridViewTextBoxColumn4.HeaderText = "Назва_Підприємства";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 141;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Контактна_особа";
            this.dataGridViewTextBoxColumn5.HeaderText = "Контактна_особа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 121;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn6.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 77;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "E_Mail";
            this.dataGridViewTextBoxColumn7.HeaderText = "E_Mail";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 64;
            // 
            // Torgoviy_Zamovnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 306);
            this.Controls.Add(this.торговий___ЗамовникDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Torgoviy_Zamovnik";
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговий___ЗамовникBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.торговий___ЗамовникDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Big_16_04DataSet big_16_04DataSet;
        private System.Windows.Forms.BindingSource торговий___ЗамовникBindingSource;
        private Big_16_04DataSetTableAdapters.Торговий___ЗамовникTableAdapter торговий___ЗамовникTableAdapter;
        private Big_16_04DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView торговий___ЗамовникDataGridView;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}