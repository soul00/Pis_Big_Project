namespace Pis_Big_Project
{
    partial class Document
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
            System.Windows.Forms.Label сумаLabel;
            System.Windows.Forms.Label дата_оформленняLabel;
            System.Windows.Forms.Label вид_документуLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.big_16_04DataSet = new Pis_Big_Project.Big_16_04DataSet();
            this.документBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.документTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.ДокументTableAdapter();
            this.tableAdapterManager = new Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager();
            this.замовленняTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.ЗамовленняTableAdapter();
            this.замовникTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.ЗамовникTableAdapter();
            this.накладна_відправленняTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Накладна_відправленняTableAdapter();
            this.рахунок_фактураTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Рахунок_фактураTableAdapter();
            this.рядок_замовленняTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Рядок_замовленняTableAdapter();
            this.торговий_представникTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Торговий_представникTableAdapter();
            this.документBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.документBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_ЗамовникаComboBox = new System.Windows.Forms.ComboBox();
            this.замовникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.код_ТоргПредстComboBox = new System.Windows.Forms.ComboBox();
            this.торговий_представникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сумаTextBox = new System.Windows.Forms.TextBox();
            this.дата_оформленняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.вид_документуComboBox = new System.Windows.Forms.ComboBox();
            this.рядок_замовленняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рядок_замовленняDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.замовленняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.замовленняDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.накладна_відправленняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.накладна_відправленняDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рахунок_фактураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рахунок_фактураDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.ТоварTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            сумаLabel = new System.Windows.Forms.Label();
            дата_оформленняLabel = new System.Windows.Forms.Label();
            вид_документуLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingNavigator)).BeginInit();
            this.документBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.замовникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговий_представникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рядок_замовленняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рядок_замовленняDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовленняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовленняDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладна_відправленняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладна_відправленняDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рахунок_фактураBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рахунок_фактураDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // сумаLabel
            // 
            сумаLabel.AutoSize = true;
            сумаLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            сумаLabel.Location = new System.Drawing.Point(13, 146);
            сумаLabel.Name = "сумаLabel";
            сумаLabel.Size = new System.Drawing.Size(49, 17);
            сумаLabel.TabIndex = 8;
            сумаLabel.Text = "Сума:";
            // 
            // дата_оформленняLabel
            // 
            дата_оформленняLabel.AutoSize = true;
            дата_оформленняLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_оформленняLabel.Location = new System.Drawing.Point(13, 94);
            дата_оформленняLabel.Name = "дата_оформленняLabel";
            дата_оформленняLabel.Size = new System.Drawing.Size(138, 17);
            дата_оформленняLabel.TabIndex = 10;
            дата_оформленняLabel.Text = "Дата оформлення:";
            // 
            // вид_документуLabel
            // 
            вид_документуLabel.AutoSize = true;
            вид_документуLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            вид_документуLabel.Location = new System.Drawing.Point(13, 119);
            вид_документуLabel.Name = "вид_документуLabel";
            вид_документуLabel.Size = new System.Drawing.Size(107, 17);
            вид_документуLabel.TabIndex = 12;
            вид_документуLabel.Text = "Вид документу:";
            // 
            // big_16_04DataSet
            // 
            this.big_16_04DataSet.DataSetName = "Big_16_04DataSet";
            this.big_16_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БатончикTableAdapter = null;
            this.tableAdapterManager.БісквітиTableAdapter = null;
            this.tableAdapterManager.ВафліTableAdapter = null;
            this.tableAdapterManager.ГрафікTableAdapter = null;
            this.tableAdapterManager.ДокументTableAdapter = this.документTableAdapter;
            this.tableAdapterManager.ЗамовленняTableAdapter = this.замовленняTableAdapter;
            this.tableAdapterManager.ЗамовникTableAdapter = this.замовникTableAdapter;
            this.tableAdapterManager.Накладна_відправленняTableAdapter = this.накладна_відправленняTableAdapter;
            this.tableAdapterManager.Одноразовий_графікTableAdapter = null;
            this.tableAdapterManager.ПечивоTableAdapter = null;
            this.tableAdapterManager.Постійний_графікTableAdapter = null;
            this.tableAdapterManager.Рахунок_фактураTableAdapter = this.рахунок_фактураTableAdapter;
            this.tableAdapterManager.Рядок_замовленняTableAdapter = this.рядок_замовленняTableAdapter;
            this.tableAdapterManager.ТоварTableAdapter = null;
            this.tableAdapterManager.Торговий_представникTableAdapter = this.торговий_представникTableAdapter;
            this.tableAdapterManager.ЦукеркиTableAdapter = null;
            this.tableAdapterManager.ШоколадTableAdapter = null;
            // 
            // замовленняTableAdapter
            // 
            this.замовленняTableAdapter.ClearBeforeFill = true;
            // 
            // замовникTableAdapter
            // 
            this.замовникTableAdapter.ClearBeforeFill = true;
            // 
            // накладна_відправленняTableAdapter
            // 
            this.накладна_відправленняTableAdapter.ClearBeforeFill = true;
            // 
            // рахунок_фактураTableAdapter
            // 
            this.рахунок_фактураTableAdapter.ClearBeforeFill = true;
            // 
            // рядок_замовленняTableAdapter
            // 
            this.рядок_замовленняTableAdapter.ClearBeforeFill = true;
            // 
            // торговий_представникTableAdapter
            // 
            this.торговий_представникTableAdapter.ClearBeforeFill = true;
            // 
            // документBindingNavigator
            // 
            this.документBindingNavigator.AddNewItem = this.bindingNavigatorPositionItem;
            this.документBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.документBindingNavigator.BindingSource = this.документBindingSource;
            this.документBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.документBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.документBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.документBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.документBindingNavigatorSaveItem});
            this.документBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.документBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.документBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.документBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.документBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.документBindingNavigator.Name = "документBindingNavigator";
            this.документBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.документBindingNavigator.Size = new System.Drawing.Size(861, 25);
            this.документBindingNavigator.TabIndex = 1;
            this.документBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // документBindingNavigatorSaveItem
            // 
            this.документBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.документBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("документBindingNavigatorSaveItem.Image")));
            this.документBindingNavigatorSaveItem.Name = "документBindingNavigatorSaveItem";
            this.документBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.документBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.документBindingNavigatorSaveItem.Click += new System.EventHandler(this.ДокументBindingNavigatorSaveItem_Click);
            // 
            // код_ЗамовникаComboBox
            // 
            this.код_ЗамовникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.документBindingSource, "Код_Замовника", true));
            this.код_ЗамовникаComboBox.DataSource = this.замовникBindingSource;
            this.код_ЗамовникаComboBox.DisplayMember = "Назва_Підприємства";
            this.код_ЗамовникаComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.код_ЗамовникаComboBox.FormattingEnabled = true;
            this.код_ЗамовникаComboBox.Location = new System.Drawing.Point(170, 37);
            this.код_ЗамовникаComboBox.Name = "код_ЗамовникаComboBox";
            this.код_ЗамовникаComboBox.Size = new System.Drawing.Size(172, 21);
            this.код_ЗамовникаComboBox.TabIndex = 5;
            this.код_ЗамовникаComboBox.ValueMember = "Код_Замовника";
            // 
            // замовникBindingSource
            // 
            this.замовникBindingSource.DataMember = "Замовник";
            this.замовникBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // код_ТоргПредстComboBox
            // 
            this.код_ТоргПредстComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.документBindingSource, "Код_ТоргПредст", true));
            this.код_ТоргПредстComboBox.DataSource = this.торговий_представникBindingSource;
            this.код_ТоргПредстComboBox.DisplayMember = "ПІБ_Представника";
            this.код_ТоргПредстComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.код_ТоргПредстComboBox.FormattingEnabled = true;
            this.код_ТоргПредстComboBox.Location = new System.Drawing.Point(170, 64);
            this.код_ТоргПредстComboBox.Name = "код_ТоргПредстComboBox";
            this.код_ТоргПредстComboBox.Size = new System.Drawing.Size(172, 21);
            this.код_ТоргПредстComboBox.TabIndex = 7;
            this.код_ТоргПредстComboBox.ValueMember = "Код_ТоргПредст";
            // 
            // торговий_представникBindingSource
            // 
            this.торговий_представникBindingSource.DataMember = "Торговий_представник";
            this.торговий_представникBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // сумаTextBox
            // 
            this.сумаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.документBindingSource, "Сума", true));
            this.сумаTextBox.Location = new System.Drawing.Point(170, 145);
            this.сумаTextBox.Name = "сумаTextBox";
            this.сумаTextBox.Size = new System.Drawing.Size(172, 20);
            this.сумаTextBox.TabIndex = 9;
            // 
            // дата_оформленняDateTimePicker
            // 
            this.дата_оформленняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.документBindingSource, "Дата_оформлення", true));
            this.дата_оформленняDateTimePicker.Location = new System.Drawing.Point(170, 92);
            this.дата_оформленняDateTimePicker.Name = "дата_оформленняDateTimePicker";
            this.дата_оформленняDateTimePicker.Size = new System.Drawing.Size(172, 20);
            this.дата_оформленняDateTimePicker.TabIndex = 11;
            // 
            // вид_документуComboBox
            // 
            this.вид_документуComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.документBindingSource, "Вид_документу", true));
            this.вид_документуComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.вид_документуComboBox.FormattingEnabled = true;
            this.вид_документуComboBox.Items.AddRange(new object[] {
            "Накладна",
            "Замовлення",
            "Рахунок-фактура"});
            this.вид_документуComboBox.Location = new System.Drawing.Point(170, 118);
            this.вид_документуComboBox.Name = "вид_документуComboBox";
            this.вид_документуComboBox.Size = new System.Drawing.Size(172, 21);
            this.вид_документуComboBox.TabIndex = 13;
            // 
            // рядок_замовленняBindingSource
            // 
            this.рядок_замовленняBindingSource.DataMember = "R_24";
            this.рядок_замовленняBindingSource.DataSource = this.документBindingSource;
            // 
            // рядок_замовленняDataGridView
            // 
            this.рядок_замовленняDataGridView.AutoGenerateColumns = false;
            this.рядок_замовленняDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.рядок_замовленняDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.рядок_замовленняDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.рядок_замовленняDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.рядок_замовленняDataGridView.DataSource = this.рядок_замовленняBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.рядок_замовленняDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.рядок_замовленняDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.рядок_замовленняDataGridView.EnableHeadersVisualStyles = false;
            this.рядок_замовленняDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            this.рядок_замовленняDataGridView.Location = new System.Drawing.Point(549, 25);
            this.рядок_замовленняDataGridView.Name = "рядок_замовленняDataGridView";
            this.рядок_замовленняDataGridView.Size = new System.Drawing.Size(312, 379);
            this.рядок_замовленняDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_Рядка";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_Рядка";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код_Товару";
            this.dataGridViewTextBoxColumn2.DataSource = this.товарBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Назва_товару";
            this.dataGridViewTextBoxColumn2.HeaderText = "Назва товару";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Код_Товару";
            this.dataGridViewTextBoxColumn2.Width = 101;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Кількість_палет";
            this.dataGridViewTextBoxColumn3.HeaderText = "Кількість_палет";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 113;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Код_документу";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код_документу";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // замовленняBindingSource
            // 
            this.замовленняBindingSource.DataMember = "FK__Замовленн__Код_д__1CF15040";
            this.замовленняBindingSource.DataSource = this.документBindingSource;
            // 
            // замовленняDataGridView
            // 
            this.замовленняDataGridView.AutoGenerateColumns = false;
            this.замовленняDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.замовленняDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.замовленняDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.замовленняDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.замовленняDataGridView.DataSource = this.замовленняBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.замовленняDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.замовленняDataGridView.EnableHeadersVisualStyles = false;
            this.замовленняDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            this.замовленняDataGridView.Location = new System.Drawing.Point(358, 25);
            this.замовленняDataGridView.Name = "замовленняDataGridView";
            this.замовленняDataGridView.Size = new System.Drawing.Size(185, 72);
            this.замовленняDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код_Замовлення";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код_Замовлення";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код_документу";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код_документу";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Статус";
            this.dataGridViewTextBoxColumn7.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 66;
            // 
            // накладна_відправленняBindingSource
            // 
            this.накладна_відправленняBindingSource.DataMember = "FK__Накладна___Код_д__1A14E395";
            this.накладна_відправленняBindingSource.DataSource = this.документBindingSource;
            // 
            // накладна_відправленняDataGridView
            // 
            this.накладна_відправленняDataGridView.AutoGenerateColumns = false;
            this.накладна_відправленняDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.накладна_відправленняDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.накладна_відправленняDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.накладна_відправленняDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.накладна_відправленняDataGridView.DataSource = this.накладна_відправленняBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.накладна_відправленняDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.накладна_відправленняDataGridView.EnableHeadersVisualStyles = false;
            this.накладна_відправленняDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            this.накладна_відправленняDataGridView.Location = new System.Drawing.Point(358, 103);
            this.накладна_відправленняDataGridView.Name = "накладна_відправленняDataGridView";
            this.накладна_відправленняDataGridView.Size = new System.Drawing.Size(185, 79);
            this.накладна_відправленняDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Код_Накладної";
            this.dataGridViewTextBoxColumn8.HeaderText = "Код_Накладної";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Код_документу";
            this.dataGridViewTextBoxColumn9.HeaderText = "Код документу";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Дата_відвантаження";
            this.dataGridViewTextBoxColumn10.HeaderText = "Дата відвантаження";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 136;
            // 
            // рахунок_фактураBindingSource
            // 
            this.рахунок_фактураBindingSource.DataMember = "FK__Рахунок_ф__Код_д__173876EA";
            this.рахунок_фактураBindingSource.DataSource = this.документBindingSource;
            // 
            // рахунок_фактураDataGridView
            // 
            this.рахунок_фактураDataGridView.AutoGenerateColumns = false;
            this.рахунок_фактураDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.рахунок_фактураDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.рахунок_фактураDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.рахунок_фактураDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.рахунок_фактураDataGridView.DataSource = this.рахунок_фактураBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.рахунок_фактураDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.рахунок_фактураDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.рахунок_фактураDataGridView.EnableHeadersVisualStyles = false;
            this.рахунок_фактураDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            this.рахунок_фактураDataGridView.Location = new System.Drawing.Point(0, 188);
            this.рахунок_фактураDataGridView.Name = "рахунок_фактураDataGridView";
            this.рахунок_фактураDataGridView.Size = new System.Drawing.Size(549, 216);
            this.рахунок_фактураDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Код_рахунку";
            this.dataGridViewTextBoxColumn11.HeaderText = "Код_рахунку";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Код_документу";
            this.dataGridViewTextBoxColumn12.HeaderText = "Код_документу";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Сумарна_вартість";
            this.dataGridViewTextBoxColumn13.HeaderText = "Сумарна вартість";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 121;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Термін_Дії_до";
            this.dataGridViewTextBoxColumn14.HeaderText = "Термін дії до";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 96;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Підстава";
            this.dataGridViewTextBoxColumn15.HeaderText = "Підстава";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 77;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Підприємство:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Торговий представник";
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.рахунок_фактураDataGridView);
            this.Controls.Add(this.накладна_відправленняDataGridView);
            this.Controls.Add(this.замовленняDataGridView);
            this.Controls.Add(this.рядок_замовленняDataGridView);
            this.Controls.Add(this.вид_документуComboBox);
            this.Controls.Add(this.код_ЗамовникаComboBox);
            this.Controls.Add(this.код_ТоргПредстComboBox);
            this.Controls.Add(сумаLabel);
            this.Controls.Add(this.сумаTextBox);
            this.Controls.Add(дата_оформленняLabel);
            this.Controls.Add(this.дата_оформленняDateTimePicker);
            this.Controls.Add(вид_документуLabel);
            this.Controls.Add(this.документBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Document";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Документ";
            this.Load += new System.EventHandler(this.Document_Load);
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingNavigator)).EndInit();
            this.документBindingNavigator.ResumeLayout(false);
            this.документBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.замовникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговий_представникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рядок_замовленняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рядок_замовленняDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовленняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовленняDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладна_відправленняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладна_відправленняDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рахунок_фактураBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рахунок_фактураDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Big_16_04DataSet big_16_04DataSet;
        private System.Windows.Forms.BindingSource документBindingSource;
        private Big_16_04DataSetTableAdapters.ДокументTableAdapter документTableAdapter;
        private Big_16_04DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator документBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton документBindingNavigatorSaveItem;
        private Big_16_04DataSetTableAdapters.Рядок_замовленняTableAdapter рядок_замовленняTableAdapter;
        private System.Windows.Forms.ComboBox код_ЗамовникаComboBox;
        private System.Windows.Forms.ComboBox код_ТоргПредстComboBox;
        private System.Windows.Forms.TextBox сумаTextBox;
        private System.Windows.Forms.DateTimePicker дата_оформленняDateTimePicker;
        private System.Windows.Forms.ComboBox вид_документуComboBox;
        private System.Windows.Forms.BindingSource рядок_замовленняBindingSource;
        private Big_16_04DataSetTableAdapters.ЗамовленняTableAdapter замовленняTableAdapter;
        private System.Windows.Forms.DataGridView рядок_замовленняDataGridView;
        private System.Windows.Forms.BindingSource замовленняBindingSource;
        private Big_16_04DataSetTableAdapters.Накладна_відправленняTableAdapter накладна_відправленняTableAdapter;
        private System.Windows.Forms.DataGridView замовленняDataGridView;
        private System.Windows.Forms.BindingSource накладна_відправленняBindingSource;
        private Big_16_04DataSetTableAdapters.Рахунок_фактураTableAdapter рахунок_фактураTableAdapter;
        private System.Windows.Forms.DataGridView накладна_відправленняDataGridView;
        private System.Windows.Forms.BindingSource рахунок_фактураBindingSource;
        private System.Windows.Forms.DataGridView рахунок_фактураDataGridView;
        private Big_16_04DataSetTableAdapters.ЗамовникTableAdapter замовникTableAdapter;
        private System.Windows.Forms.BindingSource замовникBindingSource;
        private Big_16_04DataSetTableAdapters.Торговий_представникTableAdapter торговий_представникTableAdapter;
        private System.Windows.Forms.BindingSource торговий_представникBindingSource;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private Big_16_04DataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}