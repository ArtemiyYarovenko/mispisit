namespace mispisit2
{
    partial class Журнал_поступлений_и_платежей
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Журнал_поступлений_и_платежей));
            this.mispisitDataSet = new mispisit2.MispisitDataSet();
            this.журнал_поступлений_и_платежейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.журнал_поступлений_и_платежейTableAdapter = new mispisit2.MispisitDataSetTableAdapters.Журнал_поступлений_и_платежейTableAdapter();
            this.tableAdapterManager = new mispisit2.MispisitDataSetTableAdapters.TableAdapterManager();
            this.журнал_поступлений_и_платежейBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.журнал_поступлений_и_платежейBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.журнал_поступлений_и_платежейDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mispisitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_поступлений_и_платежейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_поступлений_и_платежейBindingNavigator)).BeginInit();
            this.журнал_поступлений_и_платежейBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_поступлений_и_платежейDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mispisitDataSet
            // 
            this.mispisitDataSet.DataSetName = "MispisitDataSet";
            this.mispisitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // журнал_поступлений_и_платежейBindingSource
            // 
            this.журнал_поступлений_и_платежейBindingSource.DataMember = "Журнал поступлений и платежей";
            this.журнал_поступлений_и_платежейBindingSource.DataSource = this.mispisitDataSet;
            // 
            // журнал_поступлений_и_платежейTableAdapter
            // 
            this.журнал_поступлений_и_платежейTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = mispisit2.MispisitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Журнал_поступлений_и_платежейTableAdapter = this.журнал_поступлений_и_платежейTableAdapter;
            this.tableAdapterManager.Классовые_ордераTableAdapter = null;
            this.tableAdapterManager.КонтрагентыTableAdapter = null;
            this.tableAdapterManager.НазначенияTableAdapter = null;
            this.tableAdapterManager.Платёжные_порученияTableAdapter = null;
            this.tableAdapterManager.Типы_ордеровTableAdapter = null;
            this.tableAdapterManager.Физические_лицаTableAdapter = null;
            // 
            // журнал_поступлений_и_платежейBindingNavigator
            // 
            this.журнал_поступлений_и_платежейBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.журнал_поступлений_и_платежейBindingNavigator.BindingSource = this.журнал_поступлений_и_платежейBindingSource;
            this.журнал_поступлений_и_платежейBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.журнал_поступлений_и_платежейBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.журнал_поступлений_и_платежейBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.журнал_поступлений_и_платежейBindingNavigatorSaveItem});
            this.журнал_поступлений_и_платежейBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.журнал_поступлений_и_платежейBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.журнал_поступлений_и_платежейBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.журнал_поступлений_и_платежейBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.журнал_поступлений_и_платежейBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.журнал_поступлений_и_платежейBindingNavigator.Name = "журнал_поступлений_и_платежейBindingNavigator";
            this.журнал_поступлений_и_платежейBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.журнал_поступлений_и_платежейBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.журнал_поступлений_и_платежейBindingNavigator.TabIndex = 0;
            this.журнал_поступлений_и_платежейBindingNavigator.Text = "bindingNavigator1";
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
            // журнал_поступлений_и_платежейBindingNavigatorSaveItem
            // 
            this.журнал_поступлений_и_платежейBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.журнал_поступлений_и_платежейBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("журнал_поступлений_и_платежейBindingNavigatorSaveItem.Image")));
            this.журнал_поступлений_и_платежейBindingNavigatorSaveItem.Name = "журнал_поступлений_и_платежейBindingNavigatorSaveItem";
            this.журнал_поступлений_и_платежейBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.журнал_поступлений_и_платежейBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.журнал_поступлений_и_платежейBindingNavigatorSaveItem.Click += new System.EventHandler(this.журнал_поступлений_и_платежейBindingNavigatorSaveItem_Click);
            // 
            // журнал_поступлений_и_платежейDataGridView
            // 
            this.журнал_поступлений_и_платежейDataGridView.AutoGenerateColumns = false;
            this.журнал_поступлений_и_платежейDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.журнал_поступлений_и_платежейDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.журнал_поступлений_и_платежейDataGridView.DataSource = this.журнал_поступлений_и_платежейBindingSource;
            this.журнал_поступлений_и_платежейDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.журнал_поступлений_и_платежейDataGridView.Location = new System.Drawing.Point(0, 25);
            this.журнал_поступлений_и_платежейDataGridView.Name = "журнал_поступлений_и_платежейDataGridView";
            this.журнал_поступлений_и_платежейDataGridView.Size = new System.Drawing.Size(800, 425);
            this.журнал_поступлений_и_платежейDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_ПИП";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Поступления Или Платежа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_ордера";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID ордера";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_ПП";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID Платёжного поручения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Журнал_поступлений_и_платежей
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.журнал_поступлений_и_платежейDataGridView);
            this.Controls.Add(this.журнал_поступлений_и_платежейBindingNavigator);
            this.Name = "Журнал_поступлений_и_платежей";
            this.Text = "Журнал_поступлений_и_платежей";
            this.Load += new System.EventHandler(this.Журнал_поступлений_и_платежей_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mispisitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_поступлений_и_платежейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_поступлений_и_платежейBindingNavigator)).EndInit();
            this.журнал_поступлений_и_платежейBindingNavigator.ResumeLayout(false);
            this.журнал_поступлений_и_платежейBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_поступлений_и_платежейDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MispisitDataSet mispisitDataSet;
        private System.Windows.Forms.BindingSource журнал_поступлений_и_платежейBindingSource;
        private MispisitDataSetTableAdapters.Журнал_поступлений_и_платежейTableAdapter журнал_поступлений_и_платежейTableAdapter;
        private MispisitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator журнал_поступлений_и_платежейBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton журнал_поступлений_и_платежейBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView журнал_поступлений_и_платежейDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}