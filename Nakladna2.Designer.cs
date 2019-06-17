namespace Pis_Big_Project
{
    partial class Nakladna2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nakladna2));
            System.Windows.Forms.Label дата_відвантаженняLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label1;
            this.big_16_04DataSet = new Pis_Big_Project.Big_16_04DataSet();
            this.накладна_відправленняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.накладна_відправленняTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Накладна_відправленняTableAdapter();
            this.tableAdapterManager = new Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager();
            this.накладна_відправленняBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.накладна_відправленняBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.дата_відвантаженняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.товарDataGridView = new System.Windows.Forms.DataGridView();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.ТоварTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.печатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.кодТоваруDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назватоваруDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вагаоднієїпалетикгDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьтоваруDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цінаоднієїпалетигрнDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.виробниктоваруDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.термінзберіганняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            дата_відвантаженняLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладна_відправленняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладна_відправленняBindingNavigator)).BeginInit();
            this.накладна_відправленняBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // big_16_04DataSet
            // 
            this.big_16_04DataSet.DataSetName = "Big_16_04DataSet";
            this.big_16_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // накладна_відправленняBindingSource
            // 
            this.накладна_відправленняBindingSource.DataMember = "Накладна_відправлення";
            this.накладна_відправленняBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // накладна_відправленняTableAdapter
            // 
            this.накладна_відправленняTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БатончикTableAdapter = null;
            this.tableAdapterManager.БісквітиTableAdapter = null;
            this.tableAdapterManager.ВафліTableAdapter = null;
            this.tableAdapterManager.ГрафікTableAdapter = null;
            this.tableAdapterManager.ДокументTableAdapter = null;
            this.tableAdapterManager.ЗамовленняTableAdapter = null;
            this.tableAdapterManager.ЗамовникTableAdapter = null;
            this.tableAdapterManager.Накладна_відправленняTableAdapter = this.накладна_відправленняTableAdapter;
            this.tableAdapterManager.Нема_ТоваруTableAdapter = null;
            this.tableAdapterManager.Одноразовий_графікTableAdapter = null;
            this.tableAdapterManager.ПечивоTableAdapter = null;
            this.tableAdapterManager.Постійний_графікTableAdapter = null;
            this.tableAdapterManager.Рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Рядок_замовленняTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = this.товарTableAdapter;
            this.tableAdapterManager.Торговий_представникTableAdapter = null;
            this.tableAdapterManager.ЦукеркиTableAdapter = null;
            this.tableAdapterManager.ШоколадTableAdapter = null;
            // 
            // накладна_відправленняBindingNavigator
            // 
            this.накладна_відправленняBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.накладна_відправленняBindingNavigator.BindingSource = this.накладна_відправленняBindingSource;
            this.накладна_відправленняBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.накладна_відправленняBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.накладна_відправленняBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.накладна_відправленняBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.накладна_відправленняBindingNavigatorSaveItem,
            this.печатьToolStripButton});
            this.накладна_відправленняBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.накладна_відправленняBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.накладна_відправленняBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.накладна_відправленняBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.накладна_відправленняBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.накладна_відправленняBindingNavigator.Name = "накладна_відправленняBindingNavigator";
            this.накладна_відправленняBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.накладна_відправленняBindingNavigator.Size = new System.Drawing.Size(660, 25);
            this.накладна_відправленняBindingNavigator.TabIndex = 0;
            this.накладна_відправленняBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // накладна_відправленняBindingNavigatorSaveItem
            // 
            this.накладна_відправленняBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.накладна_відправленняBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("накладна_відправленняBindingNavigatorSaveItem.Image")));
            this.накладна_відправленняBindingNavigatorSaveItem.Name = "накладна_відправленняBindingNavigatorSaveItem";
            this.накладна_відправленняBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.накладна_відправленняBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.накладна_відправленняBindingNavigatorSaveItem.Click += new System.EventHandler(this.Накладна_відправленняBindingNavigatorSaveItem_Click);
            // 
            // дата_відвантаженняLabel
            // 
            дата_відвантаженняLabel.AutoSize = true;
            дата_відвантаженняLabel.Location = new System.Drawing.Point(8, 35);
            дата_відвантаженняLabel.Name = "дата_відвантаженняLabel";
            дата_відвантаженняLabel.Size = new System.Drawing.Size(122, 16);
            дата_відвантаженняLabel.TabIndex = 5;
            дата_відвантаженняLabel.Text = "Дата відвантаження:";
            // 
            // дата_відвантаженняDateTimePicker
            // 
            this.дата_відвантаженняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.накладна_відправленняBindingSource, "Дата_відвантаження", true));
            this.дата_відвантаженняDateTimePicker.Location = new System.Drawing.Point(148, 30);
            this.дата_відвантаженняDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.дата_відвантаженняDateTimePicker.Name = "дата_відвантаженняDateTimePicker";
            this.дата_відвантаженняDateTimePicker.Size = new System.Drawing.Size(233, 21);
            this.дата_відвантаженняDateTimePicker.TabIndex = 6;
            // 
            // товарDataGridView
            // 
            this.товарDataGridView.AutoGenerateColumns = false;
            this.товарDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.товарDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.товарDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.товарDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТоваруDataGridViewTextBoxColumn,
            this.назватоваруDataGridViewTextBoxColumn,
            this.вагаоднієїпалетикгDataGridViewTextBoxColumn,
            this.кількістьтоваруDataGridViewTextBoxColumn,
            this.цінаоднієїпалетигрнDataGridViewTextBoxColumn,
            this.виробниктоваруDataGridViewTextBoxColumn,
            this.термінзберіганняDataGridViewTextBoxColumn});
            this.товарDataGridView.DataSource = this.товарBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.товарDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.товарDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.товарDataGridView.EnableHeadersVisualStyles = false;
            this.товарDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            this.товарDataGridView.Location = new System.Drawing.Point(0, 74);
            this.товарDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.товарDataGridView.Name = "товарDataGridView";
            this.товарDataGridView.Size = new System.Drawing.Size(660, 235);
            this.товарDataGridView.TabIndex = 12;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(391, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 16);
            label1.TabIndex = 13;
            label1.Text = "Замовник:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Чалиф"});
            this.comboBox1.Location = new System.Drawing.Point(469, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // печатьToolStripButton
            // 
            this.печатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.печатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripButton.Image")));
            this.печатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripButton.Name = "печатьToolStripButton";
            this.печатьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.печатьToolStripButton.Text = "&Печать";
            this.печатьToolStripButton.Click += new System.EventHandler(this.ПечатьToolStripButton_Click);
            // 
            // кодТоваруDataGridViewTextBoxColumn
            // 
            this.кодТоваруDataGridViewTextBoxColumn.DataPropertyName = "Код_Товару";
            this.кодТоваруDataGridViewTextBoxColumn.HeaderText = "Код_Товару";
            this.кодТоваруDataGridViewTextBoxColumn.Name = "кодТоваруDataGridViewTextBoxColumn";
            this.кодТоваруDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодТоваруDataGridViewTextBoxColumn.Visible = false;
            // 
            // назватоваруDataGridViewTextBoxColumn
            // 
            this.назватоваруDataGridViewTextBoxColumn.DataPropertyName = "Назва_товару";
            this.назватоваруDataGridViewTextBoxColumn.HeaderText = "Назва_товару";
            this.назватоваруDataGridViewTextBoxColumn.Name = "назватоваруDataGridViewTextBoxColumn";
            // 
            // вагаоднієїпалетикгDataGridViewTextBoxColumn
            // 
            this.вагаоднієїпалетикгDataGridViewTextBoxColumn.DataPropertyName = "Вага_однієї_палети_кг";
            this.вагаоднієїпалетикгDataGridViewTextBoxColumn.HeaderText = "Вага_однієї_палети_кг";
            this.вагаоднієїпалетикгDataGridViewTextBoxColumn.Name = "вагаоднієїпалетикгDataGridViewTextBoxColumn";
            // 
            // кількістьтоваруDataGridViewTextBoxColumn
            // 
            this.кількістьтоваруDataGridViewTextBoxColumn.DataPropertyName = "Кількість_товару";
            this.кількістьтоваруDataGridViewTextBoxColumn.HeaderText = "Кількість_товару";
            this.кількістьтоваруDataGridViewTextBoxColumn.Name = "кількістьтоваруDataGridViewTextBoxColumn";
            // 
            // цінаоднієїпалетигрнDataGridViewTextBoxColumn
            // 
            this.цінаоднієїпалетигрнDataGridViewTextBoxColumn.DataPropertyName = "Ціна_однієї_палети_грн";
            this.цінаоднієїпалетигрнDataGridViewTextBoxColumn.HeaderText = "Ціна_однієї_палети_грн";
            this.цінаоднієїпалетигрнDataGridViewTextBoxColumn.Name = "цінаоднієїпалетигрнDataGridViewTextBoxColumn";
            // 
            // виробниктоваруDataGridViewTextBoxColumn
            // 
            this.виробниктоваруDataGridViewTextBoxColumn.DataPropertyName = "Виробник_товару";
            this.виробниктоваруDataGridViewTextBoxColumn.HeaderText = "Виробник_товару";
            this.виробниктоваруDataGridViewTextBoxColumn.Name = "виробниктоваруDataGridViewTextBoxColumn";
            // 
            // термінзберіганняDataGridViewTextBoxColumn
            // 
            this.термінзберіганняDataGridViewTextBoxColumn.DataPropertyName = "Термін_зберігання";
            this.термінзберіганняDataGridViewTextBoxColumn.HeaderText = "Термін_зберігання";
            this.термінзберіганняDataGridViewTextBoxColumn.Name = "термінзберіганняDataGridViewTextBoxColumn";
            // 
            // Nakladna2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 309);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.товарDataGridView);
            this.Controls.Add(дата_відвантаженняLabel);
            this.Controls.Add(this.дата_відвантаженняDateTimePicker);
            this.Controls.Add(this.накладна_відправленняBindingNavigator);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Nakladna2";
            this.Text = "Накладна відправлення";
            this.Load += new System.EventHandler(this.Nakladna2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладна_відправленняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладна_відправленняBindingNavigator)).EndInit();
            this.накладна_відправленняBindingNavigator.ResumeLayout(false);
            this.накладна_відправленняBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Big_16_04DataSet big_16_04DataSet;
        private System.Windows.Forms.BindingSource накладна_відправленняBindingSource;
        private Big_16_04DataSetTableAdapters.Накладна_відправленняTableAdapter накладна_відправленняTableAdapter;
        private Big_16_04DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator накладна_відправленняBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton накладна_відправленняBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker дата_відвантаженняDateTimePicker;
        private Big_16_04DataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.DataGridView товарDataGridView;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private System.Windows.Forms.ToolStripButton печатьToolStripButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТоваруDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назватоваруDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вагаоднієїпалетикгDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьтоваруDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цінаоднієїпалетигрнDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn виробниктоваруDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn термінзберіганняDataGridViewTextBoxColumn;
    }
}