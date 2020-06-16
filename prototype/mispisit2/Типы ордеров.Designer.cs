namespace mispisit2
{
    partial class Типы_ордеров
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Типы_ордеров));
            this.mispisitDataSet = new mispisit2.MispisitDataSet();
            this.типы_ордеровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типы_ордеровTableAdapter = new mispisit2.MispisitDataSetTableAdapters.Типы_ордеровTableAdapter();
            this.tableAdapterManager = new mispisit2.MispisitDataSetTableAdapters.TableAdapterManager();
            this.типы_ордеровBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.типы_ордеровBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.типы_ордеровDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mispisitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_ордеровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_ордеровBindingNavigator)).BeginInit();
            this.типы_ордеровBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типы_ордеровDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mispisitDataSet
            // 
            this.mispisitDataSet.DataSetName = "MispisitDataSet";
            this.mispisitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // типы_ордеровBindingSource
            // 
            this.типы_ордеровBindingSource.DataMember = "Типы ордеров";
            this.типы_ордеровBindingSource.DataSource = this.mispisitDataSet;
            // 
            // типы_ордеровTableAdapter
            // 
            this.типы_ордеровTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Типы_ордеровTableAdapter = this.типы_ордеровTableAdapter;
            this.tableAdapterManager.Физические_лицаTableAdapter = null;
            // 
            // типы_ордеровBindingNavigator
            // 
            this.типы_ордеровBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.типы_ордеровBindingNavigator.BindingSource = this.типы_ордеровBindingSource;
            this.типы_ордеровBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.типы_ордеровBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.типы_ордеровBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.типы_ордеровBindingNavigatorSaveItem});
            this.типы_ордеровBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.типы_ордеровBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.типы_ордеровBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.типы_ордеровBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.типы_ордеровBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.типы_ордеровBindingNavigator.Name = "типы_ордеровBindingNavigator";
            this.типы_ордеровBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.типы_ордеровBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.типы_ордеровBindingNavigator.TabIndex = 0;
            this.типы_ордеровBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // типы_ордеровBindingNavigatorSaveItem
            // 
            this.типы_ордеровBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.типы_ордеровBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("типы_ордеровBindingNavigatorSaveItem.Image")));
            this.типы_ордеровBindingNavigatorSaveItem.Name = "типы_ордеровBindingNavigatorSaveItem";
            this.типы_ордеровBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.типы_ордеровBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.типы_ордеровBindingNavigatorSaveItem.Click += new System.EventHandler(this.типы_ордеровBindingNavigatorSaveItem_Click);
            // 
            // типы_ордеровDataGridView
            // 
            this.типы_ордеровDataGridView.AutoGenerateColumns = false;
            this.типы_ордеровDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.типы_ордеровDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.типы_ордеровDataGridView.DataSource = this.типы_ордеровBindingSource;
            this.типы_ордеровDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.типы_ордеровDataGridView.Location = new System.Drawing.Point(0, 25);
            this.типы_ордеровDataGridView.Name = "типы_ордеровDataGridView";
            this.типы_ордеровDataGridView.Size = new System.Drawing.Size(800, 425);
            this.типы_ордеровDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_типа";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID типа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn2.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Типы_ордеров
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.типы_ордеровDataGridView);
            this.Controls.Add(this.типы_ордеровBindingNavigator);
            this.Name = "Типы_ордеров";
            this.Text = "Типы_ордеров";
            this.Load += new System.EventHandler(this.Типы_ордеров_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mispisitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_ордеровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_ордеровBindingNavigator)).EndInit();
            this.типы_ордеровBindingNavigator.ResumeLayout(false);
            this.типы_ордеровBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типы_ордеровDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MispisitDataSet mispisitDataSet;
        private System.Windows.Forms.BindingSource типы_ордеровBindingSource;
        private MispisitDataSetTableAdapters.Типы_ордеровTableAdapter типы_ордеровTableAdapter;
        private MispisitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator типы_ордеровBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton типы_ордеровBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView типы_ордеровDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}