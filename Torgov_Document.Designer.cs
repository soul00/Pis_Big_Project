namespace Pis_Big_Project
{
    partial class Torgov_Document
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label дата_оформленняLabel;
            System.Windows.Forms.Label пІБ_ПредставникаLabel;
            System.Windows.Forms.Label телефон_представникаLabel;
            System.Windows.Forms.Label вид_документуLabel1;
            this.big_16_04DataSet = new Pis_Big_Project.Big_16_04DataSet();
            this.торговий___документBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.торговий___документTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Торговий___документTableAdapter();
            this.tableAdapterManager = new Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager();
            this.торговий___документDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дата_оформленняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.пІБ_ПредставникаTextBox = new System.Windows.Forms.TextBox();
            this.телефон_представникаTextBox = new System.Windows.Forms.TextBox();
            this.вид_документуComboBox = new System.Windows.Forms.ComboBox();
            this.документBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.документTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.ДокументTableAdapter();
            дата_оформленняLabel = new System.Windows.Forms.Label();
            пІБ_ПредставникаLabel = new System.Windows.Forms.Label();
            телефон_представникаLabel = new System.Windows.Forms.Label();
            вид_документуLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговий___документBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговий___документDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // big_16_04DataSet
            // 
            this.big_16_04DataSet.DataSetName = "Big_16_04DataSet";
            this.big_16_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // торговий___документBindingSource
            // 
            this.торговий___документBindingSource.DataMember = "Торговий + документ";
            this.торговий___документBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // торговий___документTableAdapter
            // 
            this.торговий___документTableAdapter.ClearBeforeFill = true;
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
            // торговий___документDataGridView
            // 
            this.торговий___документDataGridView.AutoGenerateColumns = false;
            this.торговий___документDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.торговий___документDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.торговий___документDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.торговий___документDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.торговий___документDataGridView.DataSource = this.торговий___документBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.торговий___документDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.торговий___документDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.торговий___документDataGridView.EnableHeadersVisualStyles = false;
            this.торговий___документDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            this.торговий___документDataGridView.Location = new System.Drawing.Point(0, 127);
            this.торговий___документDataGridView.Name = "торговий___документDataGridView";
            this.торговий___документDataGridView.Size = new System.Drawing.Size(668, 306);
            this.торговий___документDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Вид_документу";
            this.dataGridViewTextBoxColumn1.HeaderText = "Вид_документу";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата_оформлення";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата_оформлення";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 128;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ПІБ_Представника";
            this.dataGridViewTextBoxColumn3.HeaderText = "ПІБ_Представника";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 129;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Телефон_представника";
            this.dataGridViewTextBoxColumn4.HeaderText = "Телефон_представника";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 154;
            // 
            // дата_оформленняLabel
            // 
            дата_оформленняLabel.AutoSize = true;
            дата_оформленняLabel.Location = new System.Drawing.Point(11, 42);
            дата_оформленняLabel.Name = "дата_оформленняLabel";
            дата_оформленняLabel.Size = new System.Drawing.Size(103, 13);
            дата_оформленняLabel.TabIndex = 3;
            дата_оформленняLabel.Text = "Дата оформлення:";
            // 
            // дата_оформленняDateTimePicker
            // 
            this.дата_оформленняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.торговий___документBindingSource, "Дата_оформлення", true));
            this.дата_оформленняDateTimePicker.Location = new System.Drawing.Point(146, 38);
            this.дата_оформленняDateTimePicker.Name = "дата_оформленняDateTimePicker";
            this.дата_оформленняDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_оформленняDateTimePicker.TabIndex = 4;
            // 
            // пІБ_ПредставникаLabel
            // 
            пІБ_ПредставникаLabel.AutoSize = true;
            пІБ_ПредставникаLabel.Location = new System.Drawing.Point(11, 67);
            пІБ_ПредставникаLabel.Name = "пІБ_ПредставникаLabel";
            пІБ_ПредставникаLabel.Size = new System.Drawing.Size(104, 13);
            пІБ_ПредставникаLabel.TabIndex = 5;
            пІБ_ПредставникаLabel.Text = "ПІБ Представника:";
            // 
            // пІБ_ПредставникаTextBox
            // 
            this.пІБ_ПредставникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.торговий___документBindingSource, "ПІБ_Представника", true));
            this.пІБ_ПредставникаTextBox.Location = new System.Drawing.Point(146, 64);
            this.пІБ_ПредставникаTextBox.Name = "пІБ_ПредставникаTextBox";
            this.пІБ_ПредставникаTextBox.Size = new System.Drawing.Size(200, 20);
            this.пІБ_ПредставникаTextBox.TabIndex = 6;
            // 
            // телефон_представникаLabel
            // 
            телефон_представникаLabel.AutoSize = true;
            телефон_представникаLabel.Location = new System.Drawing.Point(11, 93);
            телефон_представникаLabel.Name = "телефон_представникаLabel";
            телефон_представникаLabel.Size = new System.Drawing.Size(129, 13);
            телефон_представникаLabel.TabIndex = 7;
            телефон_представникаLabel.Text = "Телефон представника:";
            // 
            // телефон_представникаTextBox
            // 
            this.телефон_представникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.торговий___документBindingSource, "Телефон_представника", true));
            this.телефон_представникаTextBox.Location = new System.Drawing.Point(146, 90);
            this.телефон_представникаTextBox.Name = "телефон_представникаTextBox";
            this.телефон_представникаTextBox.Size = new System.Drawing.Size(200, 20);
            this.телефон_представникаTextBox.TabIndex = 8;
            // 
            // вид_документуLabel1
            // 
            вид_документуLabel1.AutoSize = true;
            вид_документуLabel1.Location = new System.Drawing.Point(12, 14);
            вид_документуLabel1.Name = "вид_документуLabel1";
            вид_документуLabel1.Size = new System.Drawing.Size(85, 13);
            вид_документуLabel1.TabIndex = 8;
            вид_документуLabel1.Text = "Вид документу:";
            // 
            // вид_документуComboBox
            // 
            this.вид_документуComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.торговий___документBindingSource, "Вид_документу", true));
            this.вид_документуComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.документBindingSource, "Код_документу", true));
            this.вид_документуComboBox.DataSource = this.документBindingSource;
            this.вид_документуComboBox.DisplayMember = "Вид_документу";
            this.вид_документуComboBox.FormattingEnabled = true;
            this.вид_документуComboBox.Location = new System.Drawing.Point(146, 11);
            this.вид_документуComboBox.Name = "вид_документуComboBox";
            this.вид_документуComboBox.Size = new System.Drawing.Size(200, 21);
            this.вид_документуComboBox.TabIndex = 9;
            this.вид_документуComboBox.ValueMember = "Код_документу";
            // 
            // документBindingSource
            // 
            this.документBindingSource.DataMember = "Документ";
            this.документBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // документTableAdapter
            // 
            this.документTableAdapter.ClearBeforeFill = true;
            // 
            // Torgov_Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 433);
            this.Controls.Add(вид_документуLabel1);
            this.Controls.Add(this.вид_документуComboBox);
            this.Controls.Add(дата_оформленняLabel);
            this.Controls.Add(this.дата_оформленняDateTimePicker);
            this.Controls.Add(пІБ_ПредставникаLabel);
            this.Controls.Add(this.пІБ_ПредставникаTextBox);
            this.Controls.Add(телефон_представникаLabel);
            this.Controls.Add(this.телефон_представникаTextBox);
            this.Controls.Add(this.торговий___документDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Torgov_Document";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Документи представників";
            this.Load += new System.EventHandler(this.Torgov_Document_Load);
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговий___документBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговий___документDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Big_16_04DataSet big_16_04DataSet;
        private System.Windows.Forms.BindingSource торговий___документBindingSource;
        private Big_16_04DataSetTableAdapters.Торговий___документTableAdapter торговий___документTableAdapter;
        private Big_16_04DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView торговий___документDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DateTimePicker дата_оформленняDateTimePicker;
        private System.Windows.Forms.TextBox пІБ_ПредставникаTextBox;
        private System.Windows.Forms.TextBox телефон_представникаTextBox;
        private System.Windows.Forms.ComboBox вид_документуComboBox;
        private System.Windows.Forms.BindingSource документBindingSource;
        private Big_16_04DataSetTableAdapters.ДокументTableAdapter документTableAdapter;
    }
}