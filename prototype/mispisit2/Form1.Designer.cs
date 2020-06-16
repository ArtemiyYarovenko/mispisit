namespace mispisit2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналПоступленийИПлатежейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классовыеОрдераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрагентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платёжныеПорученияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыОрдеровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.физическиеЛицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналПоступленийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФизЛицамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.журналПоступленийИПлатежейToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.классовыеОрдераToolStripMenuItem,
            this.контрагентыToolStripMenuItem,
            this.назначенияToolStripMenuItem,
            this.платёжныеПорученияToolStripMenuItem,
            this.типыОрдеровToolStripMenuItem,
            this.физическиеЛицаToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // журналПоступленийИПлатежейToolStripMenuItem
            // 
            this.журналПоступленийИПлатежейToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.журналПоступленийToolStripMenuItem,
            this.поФизЛицамToolStripMenuItem});
            this.журналПоступленийИПлатежейToolStripMenuItem.Name = "журналПоступленийИПлатежейToolStripMenuItem";
            this.журналПоступленийИПлатежейToolStripMenuItem.Size = new System.Drawing.Size(204, 20);
            this.журналПоступленийИПлатежейToolStripMenuItem.Text = "Журнал поступлений и платежей";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.выходToolStripMenuItem.Text = "выход";
            // 
            // классовыеОрдераToolStripMenuItem
            // 
            this.классовыеОрдераToolStripMenuItem.Name = "классовыеОрдераToolStripMenuItem";
            this.классовыеОрдераToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.классовыеОрдераToolStripMenuItem.Text = "Классовые ордера";
            this.классовыеОрдераToolStripMenuItem.Click += new System.EventHandler(this.классовыеОрдераToolStripMenuItem_Click);
            // 
            // контрагентыToolStripMenuItem
            // 
            this.контрагентыToolStripMenuItem.Name = "контрагентыToolStripMenuItem";
            this.контрагентыToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.контрагентыToolStripMenuItem.Text = "Контрагенты";
            this.контрагентыToolStripMenuItem.Click += new System.EventHandler(this.контрагентыToolStripMenuItem_Click);
            // 
            // назначенияToolStripMenuItem
            // 
            this.назначенияToolStripMenuItem.Name = "назначенияToolStripMenuItem";
            this.назначенияToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.назначенияToolStripMenuItem.Text = "Назначения";
            this.назначенияToolStripMenuItem.Click += new System.EventHandler(this.назначенияToolStripMenuItem_Click);
            // 
            // платёжныеПорученияToolStripMenuItem
            // 
            this.платёжныеПорученияToolStripMenuItem.Name = "платёжныеПорученияToolStripMenuItem";
            this.платёжныеПорученияToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.платёжныеПорученияToolStripMenuItem.Text = "Платёжные поручения";
            this.платёжныеПорученияToolStripMenuItem.Click += new System.EventHandler(this.платёжныеПорученияToolStripMenuItem_Click);
            // 
            // типыОрдеровToolStripMenuItem
            // 
            this.типыОрдеровToolStripMenuItem.Name = "типыОрдеровToolStripMenuItem";
            this.типыОрдеровToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.типыОрдеровToolStripMenuItem.Text = "Типы ордеров";
            this.типыОрдеровToolStripMenuItem.Click += new System.EventHandler(this.типыОрдеровToolStripMenuItem_Click);
            // 
            // физическиеЛицаToolStripMenuItem
            // 
            this.физическиеЛицаToolStripMenuItem.Name = "физическиеЛицаToolStripMenuItem";
            this.физическиеЛицаToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.физическиеЛицаToolStripMenuItem.Text = "Физические лица";
            this.физическиеЛицаToolStripMenuItem.Click += new System.EventHandler(this.физическиеЛицаToolStripMenuItem_Click);
            // 
            // журналПоступленийToolStripMenuItem
            // 
            this.журналПоступленийToolStripMenuItem.Name = "журналПоступленийToolStripMenuItem";
            this.журналПоступленийToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.журналПоступленийToolStripMenuItem.Text = "Журнал поступлений";
            this.журналПоступленийToolStripMenuItem.Click += new System.EventHandler(this.журналПоступленийToolStripMenuItem_Click);
            // 
            // поФизЛицамToolStripMenuItem
            // 
            this.поФизЛицамToolStripMenuItem.Name = "поФизЛицамToolStripMenuItem";
            this.поФизЛицамToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.поФизЛицамToolStripMenuItem.Text = "По физ лицам";
            this.поФизЛицамToolStripMenuItem.Click += new System.EventHandler(this.поФизЛицамToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналПоступленийИПлатежейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классовыеОрдераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрагентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назначенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платёжныеПорученияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыОрдеровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem физическиеЛицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналПоступленийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФизЛицамToolStripMenuItem;
    }
}

