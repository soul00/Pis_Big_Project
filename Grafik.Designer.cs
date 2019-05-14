namespace Pis_Big_Project
{
    partial class Grafik
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
            System.Windows.Forms.Label тип_графікуLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafik));
            this.big_16_04DataSet = new Pis_Big_Project.Big_16_04DataSet();
            this.графікBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.графікTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.ГрафікTableAdapter();
            this.tableAdapterManager = new Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager();
            this.замовникTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.ЗамовникTableAdapter();
            this.одноразовий_графікTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Одноразовий_графікTableAdapter();
            this.постійний_графікTableAdapter = new Pis_Big_Project.Big_16_04DataSetTableAdapters.Постійний_графікTableAdapter();
            this.графікBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.графікBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_ЗамовникаComboBox = new System.Windows.Forms.ComboBox();
            this.замовникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_графікуTextBox = new System.Windows.Forms.TextBox();
            this.одноразовий_графікBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.одноразовий_графікDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.постійний_графікBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.постійний_графікDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            тип_графікуLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.графікBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.графікBindingNavigator)).BeginInit();
            this.графікBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.замовникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.одноразовий_графікBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.одноразовий_графікDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постійний_графікBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постійний_графікDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // тип_графікуLabel
            // 
            тип_графікуLabel.AutoSize = true;
            тип_графікуLabel.Location = new System.Drawing.Point(12, 68);
            тип_графікуLabel.Name = "тип_графікуLabel";
            тип_графікуLabel.Size = new System.Drawing.Size(70, 13);
            тип_графікуLabel.TabIndex = 7;
            тип_графікуLabel.Text = "Тип графіку:";
            // 
            // big_16_04DataSet
            // 
            this.big_16_04DataSet.DataSetName = "Big_16_04DataSet";
            this.big_16_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // графікBindingSource
            // 
            this.графікBindingSource.DataMember = "Графік";
            this.графікBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // графікTableAdapter
            // 
            this.графікTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Pis_Big_Project.Big_16_04DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГрафікTableAdapter = this.графікTableAdapter;
            this.tableAdapterManager.ДокументTableAdapter = null;
            this.tableAdapterManager.ЗамовленняTableAdapter = null;
            this.tableAdapterManager.ЗамовникTableAdapter = this.замовникTableAdapter;
            this.tableAdapterManager.Накладна_відправленняTableAdapter = null;
            this.tableAdapterManager.Одноразовий_графікTableAdapter = this.одноразовий_графікTableAdapter;
            this.tableAdapterManager.Постійний_графікTableAdapter = this.постійний_графікTableAdapter;
            this.tableAdapterManager.Рахунок_фактураTableAdapter = null;
            this.tableAdapterManager.Рядок_замовленняTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            this.tableAdapterManager.Торговий_представникTableAdapter = null;
            // 
            // замовникTableAdapter
            // 
            this.замовникTableAdapter.ClearBeforeFill = true;
            // 
            // одноразовий_графікTableAdapter
            // 
            this.одноразовий_графікTableAdapter.ClearBeforeFill = true;
            // 
            // постійний_графікTableAdapter
            // 
            this.постійний_графікTableAdapter.ClearBeforeFill = true;
            // 
            // графікBindingNavigator
            // 
            this.графікBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.графікBindingNavigator.BindingSource = this.графікBindingSource;
            this.графікBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.графікBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.графікBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.графікBindingNavigatorSaveItem});
            this.графікBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.графікBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.графікBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.графікBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.графікBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.графікBindingNavigator.Name = "графікBindingNavigator";
            this.графікBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.графікBindingNavigator.Size = new System.Drawing.Size(619, 25);
            this.графікBindingNavigator.TabIndex = 0;
            this.графікBindingNavigator.Text = "bindingNavigator1";
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
            // графікBindingNavigatorSaveItem
            // 
            this.графікBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.графікBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("графікBindingNavigatorSaveItem.Image")));
            this.графікBindingNavigatorSaveItem.Name = "графікBindingNavigatorSaveItem";
            this.графікBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.графікBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.графікBindingNavigatorSaveItem.Click += new System.EventHandler(this.ГрафікBindingNavigatorSaveItem_Click);
            // 
            // код_ЗамовникаComboBox
            // 
            this.код_ЗамовникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.графікBindingSource, "Код_Замовника", true));
            this.код_ЗамовникаComboBox.DataSource = this.замовникBindingSource;
            this.код_ЗамовникаComboBox.DisplayMember = "Назва_Підприємства";
            this.код_ЗамовникаComboBox.FormattingEnabled = true;
            this.код_ЗамовникаComboBox.Location = new System.Drawing.Point(113, 38);
            this.код_ЗамовникаComboBox.Name = "код_ЗамовникаComboBox";
            this.код_ЗамовникаComboBox.Size = new System.Drawing.Size(215, 21);
            this.код_ЗамовникаComboBox.TabIndex = 4;
            this.код_ЗамовникаComboBox.ValueMember = "Код_Замовника";
            // 
            // замовникBindingSource
            // 
            this.замовникBindingSource.DataMember = "Замовник";
            this.замовникBindingSource.DataSource = this.big_16_04DataSet;
            // 
            // тип_графікуTextBox
            // 
            this.тип_графікуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.графікBindingSource, "Тип_графіку", true));
            this.тип_графікуTextBox.Location = new System.Drawing.Point(113, 65);
            this.тип_графікуTextBox.Name = "тип_графікуTextBox";
            this.тип_графікуTextBox.Size = new System.Drawing.Size(215, 20);
            this.тип_графікуTextBox.TabIndex = 8;
            // 
            // одноразовий_графікBindingSource
            // 
            this.одноразовий_графікBindingSource.DataMember = "is_a_одноразовий";
            this.одноразовий_графікBindingSource.DataSource = this.графікBindingSource;
            // 
            // одноразовий_графікDataGridView
            // 
            this.одноразовий_графікDataGridView.AutoGenerateColumns = false;
            this.одноразовий_графікDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.одноразовий_графікDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.одноразовий_графікDataGridView.DataSource = this.одноразовий_графікBindingSource;
            this.одноразовий_графікDataGridView.Location = new System.Drawing.Point(18, 106);
            this.одноразовий_графікDataGridView.Name = "одноразовий_графікDataGridView";
            this.одноразовий_графікDataGridView.Size = new System.Drawing.Size(269, 94);
            this.одноразовий_графікDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_Графіку";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_Графіку";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата_відвідування";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата_відвідування";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Час";
            this.dataGridViewTextBoxColumn3.HeaderText = "Час";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // постійний_графікBindingSource
            // 
            this.постійний_графікBindingSource.DataMember = "is_a_постійний";
            this.постійний_графікBindingSource.DataSource = this.графікBindingSource;
            // 
            // постійний_графікDataGridView
            // 
            this.постійний_графікDataGridView.AutoGenerateColumns = false;
            this.постійний_графікDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.постійний_графікDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.постійний_графікDataGridView.DataSource = this.постійний_графікBindingSource;
            this.постійний_графікDataGridView.Location = new System.Drawing.Point(311, 106);
            this.постійний_графікDataGridView.Name = "постійний_графікDataGridView";
            this.постійний_графікDataGridView.Size = new System.Drawing.Size(262, 94);
            this.постійний_графікDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Код_Графіку";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код_Графіку";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Інтервал_відвідувань_днів";
            this.dataGridViewTextBoxColumn5.HeaderText = "Інтервал_відвідувань_днів";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Час";
            this.dataGridViewTextBoxColumn6.HeaderText = "Час";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Замовник";
            // 
            // Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.постійний_графікDataGridView);
            this.Controls.Add(this.одноразовий_графікDataGridView);
            this.Controls.Add(this.код_ЗамовникаComboBox);
            this.Controls.Add(тип_графікуLabel);
            this.Controls.Add(this.тип_графікуTextBox);
            this.Controls.Add(this.графікBindingNavigator);
            this.Name = "Grafik";
            this.Text = "Grafik";
            this.Load += new System.EventHandler(this.Grafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.big_16_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.графікBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.графікBindingNavigator)).EndInit();
            this.графікBindingNavigator.ResumeLayout(false);
            this.графікBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.замовникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.одноразовий_графікBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.одноразовий_графікDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постійний_графікBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постійний_графікDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Big_16_04DataSet big_16_04DataSet;
        private System.Windows.Forms.BindingSource графікBindingSource;
        private Big_16_04DataSetTableAdapters.ГрафікTableAdapter графікTableAdapter;
        private Big_16_04DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator графікBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton графікBindingNavigatorSaveItem;
        private Big_16_04DataSetTableAdapters.Одноразовий_графікTableAdapter одноразовий_графікTableAdapter;
        private System.Windows.Forms.ComboBox код_ЗамовникаComboBox;
        private System.Windows.Forms.TextBox тип_графікуTextBox;
        private System.Windows.Forms.BindingSource одноразовий_графікBindingSource;
        private Big_16_04DataSetTableAdapters.Постійний_графікTableAdapter постійний_графікTableAdapter;
        private System.Windows.Forms.DataGridView одноразовий_графікDataGridView;
        private System.Windows.Forms.BindingSource постійний_графікBindingSource;
        private Big_16_04DataSetTableAdapters.ЗамовникTableAdapter замовникTableAdapter;
        private System.Windows.Forms.DataGridView постійний_графікDataGridView;
        private System.Windows.Forms.BindingSource замовникBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}