namespace mispisit2
{
    partial class Классовые_ордера
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Классовые_ордера));
            this.mispisitDataSet = new mispisit2.MispisitDataSet();
            this.классовые_ордераBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.классовые_ордераTableAdapter = new mispisit2.MispisitDataSetTableAdapters.Классовые_ордераTableAdapter();
            this.tableAdapterManager = new mispisit2.MispisitDataSetTableAdapters.TableAdapterManager();
            this.классовые_ордераBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.классовые_ордераBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.классовые_ордераDataGridView = new System.Windows.Forms.DataGridView();
            this.назначенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.контрагентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.физическиеЛицаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типыОрдеровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.назначенияTableAdapter = new mispisit2.MispisitDataSetTableAdapters.НазначенияTableAdapter();
            this.контрагентыTableAdapter = new mispisit2.MispisitDataSetTableAdapters.КонтрагентыTableAdapter();
            this.контрагентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.физические_лицаTableAdapter = new mispisit2.MispisitDataSetTableAdapters.Физические_лицаTableAdapter();
            this.типы_ордеровTableAdapter = new mispisit2.MispisitDataSetTableAdapters.Типы_ордеровTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mispisitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.классовые_ордераBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.классовые_ордераBindingNavigator)).BeginInit();
            this.классовые_ордераBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.классовые_ордераDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.назначенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контрагентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.физическиеЛицаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыОрдеровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контрагентыBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mispisitDataSet
            // 
            this.mispisitDataSet.DataSetName = "MispisitDataSet";
            this.mispisitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // классовые_ордераBindingSource
            // 
            this.классовые_ордераBindingSource.DataMember = "Классовые ордера";
            this.классовые_ордераBindingSource.DataSource = this.mispisitDataSet;
            // 
            // классовые_ордераTableAdapter
            // 
            this.классовые_ордераTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = mispisit2.MispisitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Журнал_поступлений_и_платежейTableAdapter = null;
            this.tableAdapterManager.Классовые_ордераTableAdapter = this.классовые_ордераTableAdapter;
            this.tableAdapterManager.КонтрагентыTableAdapter = null;
            this.tableAdapterManager.НазначенияTableAdapter = null;
            this.tableAdapterManager.Платёжные_порученияTableAdapter = null;
            this.tableAdapterManager.Типы_ордеровTableAdapter = null;
            this.tableAdapterManager.Физические_лицаTableAdapter = null;
            // 
            // классовые_ордераBindingNavigator
            // 
            this.классовые_ордераBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.классовые_ордераBindingNavigator.BindingSource = this.классовые_ордераBindingSource;
            this.классовые_ордераBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.классовые_ордераBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.классовые_ордераBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.классовые_ордераBindingNavigatorSaveItem});
            this.классовые_ордераBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.классовые_ордераBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.классовые_ордераBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.классовые_ордераBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.классовые_ордераBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.классовые_ордераBindingNavigator.Name = "классовые_ордераBindingNavigator";
            this.классовые_ордераBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.классовые_ордераBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.классовые_ордераBindingNavigator.TabIndex = 0;
            this.классовые_ордераBindingNavigator.Text = "bindingNavigator1";
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
            // классовые_ордераBindingNavigatorSaveItem
            // 
            this.классовые_ордераBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.классовые_ордераBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("классовые_ордераBindingNavigatorSaveItem.Image")));
            this.классовые_ордераBindingNavigatorSaveItem.Name = "классовые_ордераBindingNavigatorSaveItem";
            this.классовые_ордераBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.классовые_ордераBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.классовые_ордераBindingNavigatorSaveItem.Click += new System.EventHandler(this.классовые_ордераBindingNavigatorSaveItem_Click);
            // 
            // классовые_ордераDataGridView
            // 
            this.классовые_ордераDataGridView.AutoGenerateColumns = false;
            this.классовые_ордераDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.классовые_ордераDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2});
            this.классовые_ордераDataGridView.DataSource = this.классовые_ордераBindingSource;
            this.классовые_ордераDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.классовые_ордераDataGridView.Location = new System.Drawing.Point(0, 25);
            this.классовые_ордераDataGridView.Name = "классовые_ордераDataGridView";
            this.классовые_ордераDataGridView.Size = new System.Drawing.Size(800, 425);
            this.классовые_ордераDataGridView.TabIndex = 1;
            // 
            // назначенияBindingSource
            // 
            this.назначенияBindingSource.DataMember = "Назначения";
            this.назначенияBindingSource.DataSource = this.mispisitDataSet;
            // 
            // контрагентыBindingSource
            // 
            this.контрагентыBindingSource.DataMember = "Контрагенты";
            this.контрагентыBindingSource.DataSource = this.mispisitDataSet;
            // 
            // физическиеЛицаBindingSource
            // 
            this.физическиеЛицаBindingSource.DataMember = "Физические лица";
            this.физическиеЛицаBindingSource.DataSource = this.mispisitDataSet;
            // 
            // типыОрдеровBindingSource
            // 
            this.типыОрдеровBindingSource.DataMember = "Типы ордеров";
            this.типыОрдеровBindingSource.DataSource = this.mispisitDataSet;
            // 
            // назначенияTableAdapter
            // 
            this.назначенияTableAdapter.ClearBeforeFill = true;
            // 
            // контрагентыTableAdapter
            // 
            this.контрагентыTableAdapter.ClearBeforeFill = true;
            // 
            // контрагентыBindingSource1
            // 
            this.контрагентыBindingSource1.DataMember = "Контрагенты";
            this.контрагентыBindingSource1.DataSource = this.mispisitDataSet;
            // 
            // физические_лицаTableAdapter
            // 
            this.физические_лицаTableAdapter.ClearBeforeFill = true;
            // 
            // типы_ордеровTableAdapter
            // 
            this.типы_ордеровTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_ордера";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID ордера";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Сумма_ордера";
            this.dataGridViewTextBoxColumn3.HeaderText = "Сумма ордера";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_назначения";
            this.dataGridViewTextBoxColumn4.DataSource = this.назначенияBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Описание";
            this.dataGridViewTextBoxColumn4.HeaderText = "Назначение";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "ID_назначения";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_контрагента";
            this.dataGridViewTextBoxColumn5.DataSource = this.контрагентыBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "ОГРНИП";
            this.dataGridViewTextBoxColumn5.HeaderText = "Контрагент";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "ID_контрагента";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_физлица";
            this.dataGridViewTextBoxColumn6.DataSource = this.физическиеЛицаBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "ФИО";
            this.dataGridViewTextBoxColumn6.HeaderText = "Физическое лицо";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "ID_физлица";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тип_ордера";
            this.dataGridViewTextBoxColumn2.DataSource = this.типыОрдеровBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Описание";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип ордера";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID_типа";
            // 
            // Классовые_ордера
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.классовые_ордераDataGridView);
            this.Controls.Add(this.классовые_ордераBindingNavigator);
            this.Name = "Классовые_ордера";
            this.Text = "Классовые_ордера";
            this.Load += new System.EventHandler(this.Классовые_ордера_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mispisitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.классовые_ордераBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.классовые_ордераBindingNavigator)).EndInit();
            this.классовые_ордераBindingNavigator.ResumeLayout(false);
            this.классовые_ордераBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.классовые_ордераDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.назначенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контрагентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.физическиеЛицаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыОрдеровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контрагентыBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MispisitDataSet mispisitDataSet;
        private System.Windows.Forms.BindingSource классовые_ордераBindingSource;
        private MispisitDataSetTableAdapters.Классовые_ордераTableAdapter классовые_ордераTableAdapter;
        private MispisitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator классовые_ордераBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton классовые_ордераBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView классовые_ордераDataGridView;
        private System.Windows.Forms.BindingSource назначенияBindingSource;
        private MispisitDataSetTableAdapters.НазначенияTableAdapter назначенияTableAdapter;
        private System.Windows.Forms.BindingSource контрагентыBindingSource;
        private MispisitDataSetTableAdapters.КонтрагентыTableAdapter контрагентыTableAdapter;
        private System.Windows.Forms.BindingSource контрагентыBindingSource1;
        private System.Windows.Forms.BindingSource физическиеЛицаBindingSource;
        private MispisitDataSetTableAdapters.Физические_лицаTableAdapter физические_лицаTableAdapter;
        private System.Windows.Forms.BindingSource типыОрдеровBindingSource;
        private MispisitDataSetTableAdapters.Типы_ордеровTableAdapter типы_ордеровTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
    }
}