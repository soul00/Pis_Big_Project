namespace Pis_Big_Project
{
    partial class Waffles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.big_16_04DataSet = new Pis_Big_Project.Big_16_04DataSet();
            this.вафліBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вафліTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.ВафліTableAdapter();
            this.tableAdapterManager = new Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager();
            this.вафліDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вафліBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вафліDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // big_16_04DataSet
            // 
            this.big_16_04DataSet.DataSetName = "Big_16_04DataSet";
            this.big_16_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вафліBindingSource
            // 
            this.вафліBindingSource.DataMember = "Вафлі";
            this.вафліBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // вафліTableAdapter
            // 
            this.вафліTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БатончикTableAdapter = null;
            this.tableAdapterManager.БісквітиTableAdapter = null;
            this.tableAdapterManager.ВафліTableAdapter = this.вафліTableAdapter;
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
            // вафліDataGridView
            // 
            this.вафліDataGridView.AutoGenerateColumns = false;
            this.вафліDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.вафліDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.вафліDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.вафліDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.вафліDataGridView.DataSource = this.вафліBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.вафліDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.вафліDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.вафліDataGridView.EnableHeadersVisualStyles = false;
            this.вафліDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            this.вафліDataGridView.Location = new System.Drawing.Point(0, 0);
            this.вафліDataGridView.Name = "вафліDataGridView";
            this.вафліDataGridView.Size = new System.Drawing.Size(817, 272);
            this.вафліDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Назва_товару";
            this.dataGridViewTextBoxColumn1.HeaderText = "Назва_товару";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 104;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Вага_однієї_палети_кг";
            this.dataGridViewTextBoxColumn2.HeaderText = "Вага_однієї_палети_кг";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 149;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Кількість_товару";
            this.dataGridViewTextBoxColumn3.HeaderText = "Кількість_товару";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 118;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ціна_однієї_палети_грн";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ціна_однієї_палети_грн";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 153;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Виробник_товару";
            this.dataGridViewTextBoxColumn5.HeaderText = "Виробник_товару";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 121;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Термін_зберігання";
            this.dataGridViewTextBoxColumn6.HeaderText = "Термін_зберігання";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 128;
            // 
            // Waffles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 272);
            this.Controls.Add(this.вафліDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Waffles";
            this.Text = "Вафлі";
            this.Load += new System.EventHandler(this.Waffles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вафліBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вафліDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Big_16_04DataSet big_16_04DataSet;
        private System.Windows.Forms.BindingSource вафліBindingSource;
        private Big_16_04DataSetTableAdapters.ВафліTableAdapter вафліTableAdapter;
        private Big_16_04DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView вафліDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}