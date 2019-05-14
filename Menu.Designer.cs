namespace Pis_Big_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загальніДаніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.накладніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рахункифактуриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замовникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графікиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.торговіПредставникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товариToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукЗамовникаЗаТипомГрафікуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запитЗамовникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замовникиЗЗапитомВід200ТисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.торговіПредставникиТаЇхЗамовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукДокументівЗаДатоюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звітиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zvitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загальніДаніToolStripMenuItem,
            this.запитиToolStripMenuItem,
            this.звітиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // загальніДаніToolStripMenuItem
            // 
            this.загальніДаніToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.документиToolStripMenuItem,
            this.замовникиToolStripMenuItem,
            this.торговіПредставникиToolStripMenuItem,
            this.товариToolStripMenuItem});
            this.загальніДаніToolStripMenuItem.Name = "загальніДаніToolStripMenuItem";
            this.загальніДаніToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.загальніДаніToolStripMenuItem.Text = "Загальні дані";
            // 
            // документиToolStripMenuItem
            // 
            this.документиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.накладніToolStripMenuItem,
            this.замовленняToolStripMenuItem,
            this.рахункифактуриToolStripMenuItem});
            this.документиToolStripMenuItem.Name = "документиToolStripMenuItem";
            this.документиToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.документиToolStripMenuItem.Text = "Документи";
            this.документиToolStripMenuItem.Click += new System.EventHandler(this.ДокументиToolStripMenuItem_Click);
            // 
            // накладніToolStripMenuItem
            // 
            this.накладніToolStripMenuItem.Name = "накладніToolStripMenuItem";
            this.накладніToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.накладніToolStripMenuItem.Text = "Накладні";
            this.накладніToolStripMenuItem.Click += new System.EventHandler(this.НакладніToolStripMenuItem_Click);
            // 
            // замовленняToolStripMenuItem
            // 
            this.замовленняToolStripMenuItem.Name = "замовленняToolStripMenuItem";
            this.замовленняToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.замовленняToolStripMenuItem.Text = "Замовлення";
            this.замовленняToolStripMenuItem.Click += new System.EventHandler(this.ЗамовленняToolStripMenuItem_Click);
            // 
            // рахункифактуриToolStripMenuItem
            // 
            this.рахункифактуриToolStripMenuItem.Name = "рахункифактуриToolStripMenuItem";
            this.рахункифактуриToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.рахункифактуриToolStripMenuItem.Text = "Рахунки-фактури";
            this.рахункифактуриToolStripMenuItem.Click += new System.EventHandler(this.РахункифактуриToolStripMenuItem_Click);
            // 
            // замовникиToolStripMenuItem
            // 
            this.замовникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графікиToolStripMenuItem});
            this.замовникиToolStripMenuItem.Name = "замовникиToolStripMenuItem";
            this.замовникиToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.замовникиToolStripMenuItem.Text = "Замовники";
            this.замовникиToolStripMenuItem.Click += new System.EventHandler(this.ЗамовникиToolStripMenuItem_Click);
            // 
            // графікиToolStripMenuItem
            // 
            this.графікиToolStripMenuItem.Name = "графікиToolStripMenuItem";
            this.графікиToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.графікиToolStripMenuItem.Text = "Графіки відвідувань";
            this.графікиToolStripMenuItem.Click += new System.EventHandler(this.ГрафікиToolStripMenuItem_Click);
            // 
            // торговіПредставникиToolStripMenuItem
            // 
            this.торговіПредставникиToolStripMenuItem.Name = "торговіПредставникиToolStripMenuItem";
            this.торговіПредставникиToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.торговіПредставникиToolStripMenuItem.Text = "Торгові представники";
            this.торговіПредставникиToolStripMenuItem.Click += new System.EventHandler(this.ТорговіПредставникиToolStripMenuItem_Click);
            // 
            // товариToolStripMenuItem
            // 
            this.товариToolStripMenuItem.Name = "товариToolStripMenuItem";
            this.товариToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.товариToolStripMenuItem.Text = "Товари";
            this.товариToolStripMenuItem.Click += new System.EventHandler(this.ТовариToolStripMenuItem_Click);
            // 
            // запитиToolStripMenuItem
            // 
            this.запитиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пошукЗамовникаЗаТипомГрафікуToolStripMenuItem,
            this.запитЗамовникToolStripMenuItem,
            this.замовникиЗЗапитомВід200ТисToolStripMenuItem,
            this.торговіПредставникиТаЇхЗамовленняToolStripMenuItem,
            this.пошукДокументівЗаДатоюToolStripMenuItem});
            this.запитиToolStripMenuItem.Name = "запитиToolStripMenuItem";
            this.запитиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.запитиToolStripMenuItem.Text = "Запити";
            // 
            // пошукЗамовникаЗаТипомГрафікуToolStripMenuItem
            // 
            this.пошукЗамовникаЗаТипомГрафікуToolStripMenuItem.Name = "пошукЗамовникаЗаТипомГрафікуToolStripMenuItem";
            this.пошукЗамовникаЗаТипомГрафікуToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.пошукЗамовникаЗаТипомГрафікуToolStripMenuItem.Text = "Пошук замовників за типом графіку";
            this.пошукЗамовникаЗаТипомГрафікуToolStripMenuItem.Click += new System.EventHandler(this.ПошукЗамовникаЗаТипомГрафікуToolStripMenuItem_Click);
            // 
            // запитЗамовникToolStripMenuItem
            // 
            this.запитЗамовникToolStripMenuItem.Name = "запитЗамовникToolStripMenuItem";
            this.запитЗамовникToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.запитЗамовникToolStripMenuItem.Text = "Замовники та їх документи";
            this.запитЗамовникToolStripMenuItem.Click += new System.EventHandler(this.ЗапитЗамовникToolStripMenuItem_Click);
            // 
            // замовникиЗЗапитомВід200ТисToolStripMenuItem
            // 
            this.замовникиЗЗапитомВід200ТисToolStripMenuItem.Name = "замовникиЗЗапитомВід200ТисToolStripMenuItem";
            this.замовникиЗЗапитомВід200ТисToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.замовникиЗЗапитомВід200ТисToolStripMenuItem.Text = "Замовлення з сумою від 200 тис.";
            this.замовникиЗЗапитомВід200ТисToolStripMenuItem.Click += new System.EventHandler(this.ЗамовникиЗЗапитомВід200ТисToolStripMenuItem_Click);
            // 
            // торговіПредставникиТаЇхЗамовленняToolStripMenuItem
            // 
            this.торговіПредставникиТаЇхЗамовленняToolStripMenuItem.Name = "торговіПредставникиТаЇхЗамовленняToolStripMenuItem";
            this.торговіПредставникиТаЇхЗамовленняToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.торговіПредставникиТаЇхЗамовленняToolStripMenuItem.Text = "Торгові представники та їх замовлення";
            this.торговіПредставникиТаЇхЗамовленняToolStripMenuItem.Click += new System.EventHandler(this.ТорговіПредставникиТаЇхЗамовленняToolStripMenuItem_Click);
            // 
            // пошукДокументівЗаДатоюToolStripMenuItem
            // 
            this.пошукДокументівЗаДатоюToolStripMenuItem.Name = "пошукДокументівЗаДатоюToolStripMenuItem";
            this.пошукДокументівЗаДатоюToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.пошукДокументівЗаДатоюToolStripMenuItem.Text = "Пошук документів за датою";
            this.пошукДокументівЗаДатоюToolStripMenuItem.Click += new System.EventHandler(this.ПошукДокументівЗаДатоюToolStripMenuItem_Click);
            // 
            // звітиToolStripMenuItem
            // 
            this.звітиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zvitToolStripMenuItem});
            this.звітиToolStripMenuItem.Name = "звітиToolStripMenuItem";
            this.звітиToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.звітиToolStripMenuItem.Text = "Звіти";
            // 
            // zvitToolStripMenuItem
            // 
            this.zvitToolStripMenuItem.Name = "zvitToolStripMenuItem";
            this.zvitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zvitToolStripMenuItem.Text = "zvit";
            this.zvitToolStripMenuItem.Click += new System.EventHandler(this.ZvitToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 409);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Меню замовлення";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загальніДаніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem накладніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замовленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рахункифактуриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замовникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem торговіПредставникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товариToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графікиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звітиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукЗамовникаЗаТипомГрафікуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запитЗамовникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замовникиЗЗапитомВід200ТисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem торговіПредставникиТаЇхЗамовленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукДокументівЗаДатоюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zvitToolStripMenuItem;
    }
}

