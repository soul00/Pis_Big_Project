namespace Pis_Big_Project
{
    partial class Torg_Predst
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
            System.Windows.Forms.Label пІБ_ПредставникаLabel;
            System.Windows.Forms.Label номерні_знаки_автоLabel;
            System.Windows.Forms.Label телефон_представникаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Torg_Predst));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.big_16_04DataSet = new Pis_Big_Project.Big_16_04DataSet();
            this.торговий_представникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.торговий_представникTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Торговий_представникTableAdapter();
            this.tableAdapterManager = new Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager();
            this.торговий_представникBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.торговий_представникBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.пІБ_ПредставникаTextBox = new System.Windows.Forms.TextBox();
            this.номерні_знаки_автоTextBox = new System.Windows.Forms.TextBox();
            this.телефон_представникаTextBox = new System.Windows.Forms.TextBox();
            this.торговий_представникDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            пІБ_ПредставникаLabel = new System.Windows.Forms.Label();
            номерні_знаки_автоLabel = new System.Windows.Forms.Label();
            телефон_представникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговий_представникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговий_представникBindingNavigator)).BeginInit();
            this.торговий_представникBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.торговий_представникDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // пІБ_ПредставникаLabel
            // 
            пІБ_ПредставникаLabel.AutoSize = true;
            пІБ_ПредставникаLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            пІБ_ПредставникаLabel.Location = new System.Drawing.Point(17, 32);
            пІБ_ПредставникаLabel.Name = "пІБ_ПредставникаLabel";
            пІБ_ПредставникаLabel.Size = new System.Drawing.Size(129, 17);
            пІБ_ПредставникаLabel.TabIndex = 3;
            пІБ_ПредставникаLabel.Text = "ПІБ Представника:";
            // 
            // номерні_знаки_автоLabel
            // 
            номерні_знаки_автоLabel.AutoSize = true;
            номерні_знаки_автоLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номерні_знаки_автоLabel.Location = new System.Drawing.Point(17, 58);
            номерні_знаки_автоLabel.Name = "номерні_знаки_автоLabel";
            номерні_знаки_автоLabel.Size = new System.Drawing.Size(144, 17);
            номерні_знаки_автоLabel.TabIndex = 5;
            номерні_знаки_автоLabel.Text = "Номерні знаки авто:";
            // 
            // телефон_представникаLabel
            // 
            телефон_представникаLabel.AutoSize = true;
            телефон_представникаLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефон_представникаLabel.Location = new System.Drawing.Point(17, 84);
            телефон_представникаLabel.Name = "телефон_представникаLabel";
            телефон_представникаLabel.Size = new System.Drawing.Size(168, 17);
            телефон_представникаLabel.TabIndex = 7;
            телефон_представникаLabel.Text = "Телефон представника:";
            // 
            // big_16_04DataSet
            // 
            this.big_16_04DataSet.DataSetName = "Big_16_04DataSet";
            this.big_16_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // торговий_представникBindingSource
            // 
            this.торговий_представникBindingSource.DataMember = "Торговий_представник";
            this.торговий_представникBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // торговий_представникTableAdapter
            // 
            this.торговий_представникTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Накладна_відправленняTableAdapter = null;
            this.tableAdapterManager.Одноразовий_графікTableAdapter = null;
            this.tableAdapterManager.ПечивоTableAdapter = null;
            this.tableAdapterManager.Постійний_графікTableAdapter = null;
            this.tableAdapterManager.Рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Рядок_замовленняTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            this.tableAdapterManager.Торговий_представникTableAdapter = this.торговий_представникTableAdapter;
            this.tableAdapterManager.ЦукеркиTableAdapter = null;
            this.tableAdapterManager.ШоколадTableAdapter = null;
            // 
            // торговий_представникBindingNavigator
            // 
            this.торговий_представникBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.торговий_представникBindingNavigator.BindingSource = this.торговий_представникBindingSource;
            this.торговий_представникBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.торговий_представникBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.торговий_представникBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.торговий_представникBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.торговий_представникBindingNavigatorSaveItem});
            this.торговий_представникBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.торговий_представникBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.торговий_представникBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.торговий_представникBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.торговий_представникBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.торговий_представникBindingNavigator.Name = "торговий_представникBindingNavigator";
            this.торговий_представникBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.торговий_представникBindingNavigator.Size = new System.Drawing.Size(673, 25);
            this.торговий_представникBindingNavigator.TabIndex = 0;
            this.торговий_представникBindingNavigator.Text = "bindingNavigator1";
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
            // торговий_представникBindingNavigatorSaveItem
            // 
            this.торговий_представникBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.торговий_представникBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("торговий_представникBindingNavigatorSaveItem.Image")));
            this.торговий_представникBindingNavigatorSaveItem.Name = "торговий_представникBindingNavigatorSaveItem";
            this.торговий_представникBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.торговий_представникBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.торговий_представникBindingNavigatorSaveItem.Click += new System.EventHandler(this.Торговий_представникBindingNavigatorSaveItem_Click);
            // 
            // пІБ_ПредставникаTextBox
            // 
            this.пІБ_ПредставникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.торговий_представникBindingSource, "ПІБ_Представника", true));
            this.пІБ_ПредставникаTextBox.Location = new System.Drawing.Point(193, 31);
            this.пІБ_ПредставникаTextBox.Name = "пІБ_ПредставникаTextBox";
            this.пІБ_ПредставникаTextBox.Size = new System.Drawing.Size(210, 20);
            this.пІБ_ПредставникаTextBox.TabIndex = 4;
            // 
            // номерні_знаки_автоTextBox
            // 
            this.номерні_знаки_автоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.торговий_представникBindingSource, "Номерні_знаки_авто", true));
            this.номерні_знаки_автоTextBox.Location = new System.Drawing.Point(193, 57);
            this.номерні_знаки_автоTextBox.Name = "номерні_знаки_автоTextBox";
            this.номерні_знаки_автоTextBox.Size = new System.Drawing.Size(210, 20);
            this.номерні_знаки_автоTextBox.TabIndex = 6;
            // 
            // телефон_представникаTextBox
            // 
            this.телефон_представникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.торговий_представникBindingSource, "Телефон_представника", true));
            this.телефон_представникаTextBox.Location = new System.Drawing.Point(193, 83);
            this.телефон_представникаTextBox.Name = "телефон_представникаTextBox";
            this.телефон_представникаTextBox.Size = new System.Drawing.Size(210, 20);
            this.телефон_представникаTextBox.TabIndex = 8;
            // 
            // торговий_представникDataGridView
            // 
            this.торговий_представникDataGridView.AutoGenerateColumns = false;
            this.торговий_представникDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.торговий_представникDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.торговий_представникDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.торговий_представникDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.торговий_представникDataGridView.DataSource = this.торговий_представникBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.торговий_представникDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.торговий_представникDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.торговий_представникDataGridView.EnableHeadersVisualStyles = false;
            this.торговий_представникDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(161)))));
            this.торговий_представникDataGridView.Location = new System.Drawing.Point(0, 109);
            this.торговий_представникDataGridView.Name = "торговий_представникDataGridView";
            this.торговий_представникDataGridView.Size = new System.Drawing.Size(673, 235);
            this.торговий_представникDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_ТоргПредст";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_ТоргПредст";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ПІБ_Представника";
            this.dataGridViewTextBoxColumn2.HeaderText = "ПІБ_Представника";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 129;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номерні_знаки_авто";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номерні_знаки_авто";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 139;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Телефон_представника";
            this.dataGridViewTextBoxColumn4.HeaderText = "Телефон_представника";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 154;
            // 
            // Torg_Predst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 344);
            this.Controls.Add(this.торговий_представникDataGridView);
            this.Controls.Add(пІБ_ПредставникаLabel);
            this.Controls.Add(this.пІБ_ПредставникаTextBox);
            this.Controls.Add(номерні_знаки_автоLabel);
            this.Controls.Add(this.номерні_знаки_автоTextBox);
            this.Controls.Add(телефон_представникаLabel);
            this.Controls.Add(this.телефон_представникаTextBox);
            this.Controls.Add(this.торговий_представникBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Torg_Predst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Торгові представники";
            this.Load += new System.EventHandler(this.Torg_Predst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговий_представникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговий_представникBindingNavigator)).EndInit();
            this.торговий_представникBindingNavigator.ResumeLayout(false);
            this.торговий_представникBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.торговий_представникDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Big_16_04DataSet big_16_04DataSet;
        private System.Windows.Forms.BindingSource торговий_представникBindingSource;
        private Big_16_04DataSetTableAdapters.Торговий_представникTableAdapter торговий_представникTableAdapter;
        private Big_16_04DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator торговий_представникBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton торговий_представникBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox пІБ_ПредставникаTextBox;
        private System.Windows.Forms.TextBox номерні_знаки_автоTextBox;
        private System.Windows.Forms.TextBox телефон_представникаTextBox;
        private System.Windows.Forms.DataGridView торговий_представникDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}