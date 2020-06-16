namespace mispisit2
{
    partial class Физические_лица
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Физические_лица));
            this.mispisitDataSet = new mispisit2.MispisitDataSet();
            this.физические_лицаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.физические_лицаTableAdapter = new mispisit2.MispisitDataSetTableAdapters.Физические_лицаTableAdapter();
            this.tableAdapterManager = new mispisit2.MispisitDataSetTableAdapters.TableAdapterManager();
            this.физические_лицаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.физические_лицаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.физические_лицаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mispisitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.физические_лицаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.физические_лицаBindingNavigator)).BeginInit();
            this.физические_лицаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.физические_лицаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mispisitDataSet
            // 
            this.mispisitDataSet.DataSetName = "MispisitDataSet";
            this.mispisitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // физические_лицаBindingSource
            // 
            this.физические_лицаBindingSource.DataMember = "Физические лица";
            this.физические_лицаBindingSource.DataSource = this.mispisitDataSet;
            // 
            // физические_лицаTableAdapter
            // 
            this.физические_лицаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = mispisit2.MispisitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Журнал_поступлений_и_платежейTableAdapter = null;
            this.tableAdapterManager.Классовые_ордераTableAdapter = null;
            this.tableAdapterManager.КонтрагентыTableAdapter = null;
            this.tableAdapterManager.НазначенияTableAdapter = null;
            this.tableAdapterManager.Платёжные_порученияTableAdapter = null;
            this.tableAdapterManager.Типы_ордеровTableAdapter = null;
            this.tableAdapterManager.Физические_лицаTableAdapter = this.физические_лицаTableAdapter;
            // 
            // физические_лицаBindingNavigator
            // 
            this.физические_лицаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.физические_лицаBindingNavigator.BindingSource = this.физические_лицаBindingSource;
            this.физические_лицаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.физические_лицаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.физические_лицаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.физические_лицаBindingNavigatorSaveItem});
            this.физические_лицаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.физические_лицаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.физические_лицаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.физические_лицаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.физические_лицаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.физические_лицаBindingNavigator.Name = "физические_лицаBindingNavigator";
            this.физические_лицаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.физические_лицаBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.физические_лицаBindingNavigator.TabIndex = 0;
            this.физические_лицаBindingNavigator.Text = "bindingNavigator1";
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
            // физические_лицаBindingNavigatorSaveItem
            // 
            this.физические_лицаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.физические_лицаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("физические_лицаBindingNavigatorSaveItem.Image")));
            this.физические_лицаBindingNavigatorSaveItem.Name = "физические_лицаBindingNavigatorSaveItem";
            this.физические_лицаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.физические_лицаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.физические_лицаBindingNavigatorSaveItem.Click += new System.EventHandler(this.физические_лицаBindingNavigatorSaveItem_Click);
            // 
            // физические_лицаDataGridView
            // 
            this.физические_лицаDataGridView.AutoGenerateColumns = false;
            this.физические_лицаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.физические_лицаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.физические_лицаDataGridView.DataSource = this.физические_лицаBindingSource;
            this.физические_лицаDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.физические_лицаDataGridView.Location = new System.Drawing.Point(0, 25);
            this.физические_лицаDataGridView.Name = "физические_лицаDataGridView";
            this.физические_лицаDataGridView.Size = new System.Drawing.Size(800, 425);
            this.физические_лицаDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_физлица";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID физизческого лица";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Контактный_телефон";
            this.dataGridViewTextBoxColumn3.HeaderText = "Контактный телефон";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Физические_лица
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.физические_лицаDataGridView);
            this.Controls.Add(this.физические_лицаBindingNavigator);
            this.Name = "Физические_лица";
            this.Text = "Физические_лица";
            this.Load += new System.EventHandler(this.Физические_лица_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mispisitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.физические_лицаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.физические_лицаBindingNavigator)).EndInit();
            this.физические_лицаBindingNavigator.ResumeLayout(false);
            this.физические_лицаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.физические_лицаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MispisitDataSet mispisitDataSet;
        private System.Windows.Forms.BindingSource физические_лицаBindingSource;
        private MispisitDataSetTableAdapters.Физические_лицаTableAdapter физические_лицаTableAdapter;
        private MispisitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator физические_лицаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton физические_лицаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView физические_лицаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}