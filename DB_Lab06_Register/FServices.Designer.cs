namespace DB_Lab06_Register
{
    partial class FServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FServices));
            this.registrationDataSet = new DB_Lab06_Register.registrationDataSet();
            this.tYPES_OF_SERVICESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tYPES_OF_SERVICESTableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.TYPES_OF_SERVICESTableAdapter();
            this.tableAdapterManager = new DB_Lab06_Register.registrationDataSetTableAdapters.TableAdapterManager();
            this.tYPES_OF_SERVICESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tYPES_OF_SERVICESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tYPES_OF_SERVICESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPES_OF_SERVICESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPES_OF_SERVICESBindingNavigator)).BeginInit();
            this.tYPES_OF_SERVICESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tYPES_OF_SERVICESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "registrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tYPES_OF_SERVICESBindingSource
            // 
            this.tYPES_OF_SERVICESBindingSource.DataMember = "TYPES_OF_SERVICES";
            this.tYPES_OF_SERVICESBindingSource.DataSource = this.registrationDataSet;
            // 
            // tYPES_OF_SERVICESTableAdapter
            // 
            this.tYPES_OF_SERVICESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCTORS_DIRECTORYTableAdapter = null;
            this.tableAdapterManager.EMPLOYEE_DIRECTORYTableAdapter = null;
            this.tableAdapterManager.PATIENT_DIRECTORYTableAdapter = null;
            this.tableAdapterManager.PAYMENT_INVOICETableAdapter = null;
            this.tableAdapterManager.REFERRALTableAdapter = null;
            this.tableAdapterManager.RESULT_TYPESTableAdapter = null;
            this.tableAdapterManager.TREATMENT_OUTCOMESTableAdapter = null;
            this.tableAdapterManager.TYPES_OF_SERVICESTableAdapter = this.tYPES_OF_SERVICESTableAdapter;
            this.tableAdapterManager.UpdateOrder = DB_Lab06_Register.registrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WARDS_DIRECTORYTableAdapter = null;
            // 
            // tYPES_OF_SERVICESBindingNavigator
            // 
            this.tYPES_OF_SERVICESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tYPES_OF_SERVICESBindingNavigator.BindingSource = this.tYPES_OF_SERVICESBindingSource;
            this.tYPES_OF_SERVICESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tYPES_OF_SERVICESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tYPES_OF_SERVICESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tYPES_OF_SERVICESBindingNavigatorSaveItem});
            this.tYPES_OF_SERVICESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tYPES_OF_SERVICESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tYPES_OF_SERVICESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tYPES_OF_SERVICESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tYPES_OF_SERVICESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tYPES_OF_SERVICESBindingNavigator.Name = "tYPES_OF_SERVICESBindingNavigator";
            this.tYPES_OF_SERVICESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tYPES_OF_SERVICESBindingNavigator.Size = new System.Drawing.Size(324, 25);
            this.tYPES_OF_SERVICESBindingNavigator.TabIndex = 0;
            this.tYPES_OF_SERVICESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tYPES_OF_SERVICESBindingNavigatorSaveItem
            // 
            this.tYPES_OF_SERVICESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tYPES_OF_SERVICESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tYPES_OF_SERVICESBindingNavigatorSaveItem.Image")));
            this.tYPES_OF_SERVICESBindingNavigatorSaveItem.Name = "tYPES_OF_SERVICESBindingNavigatorSaveItem";
            this.tYPES_OF_SERVICESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tYPES_OF_SERVICESBindingNavigatorSaveItem.Text = "Save Data";
            this.tYPES_OF_SERVICESBindingNavigatorSaveItem.Click += new System.EventHandler(this.tYPES_OF_SERVICESBindingNavigatorSaveItem_Click);
            // 
            // tYPES_OF_SERVICESDataGridView
            // 
            this.tYPES_OF_SERVICESDataGridView.AutoGenerateColumns = false;
            this.tYPES_OF_SERVICESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tYPES_OF_SERVICESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tYPES_OF_SERVICESDataGridView.DataSource = this.tYPES_OF_SERVICESBindingSource;
            this.tYPES_OF_SERVICESDataGridView.Location = new System.Drawing.Point(0, 28);
            this.tYPES_OF_SERVICESDataGridView.Name = "tYPES_OF_SERVICESDataGridView";
            this.tYPES_OF_SERVICESDataGridView.Size = new System.Drawing.Size(324, 410);
            this.tYPES_OF_SERVICESDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SERVICES_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер услуги";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SERVICES_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование услуги";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // FServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.tYPES_OF_SERVICESDataGridView);
            this.Controls.Add(this.tYPES_OF_SERVICESBindingNavigator);
            this.Name = "FServices";
            this.Text = "FServices";
            this.Load += new System.EventHandler(this.FServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPES_OF_SERVICESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPES_OF_SERVICESBindingNavigator)).EndInit();
            this.tYPES_OF_SERVICESBindingNavigator.ResumeLayout(false);
            this.tYPES_OF_SERVICESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tYPES_OF_SERVICESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private registrationDataSet registrationDataSet;
        private System.Windows.Forms.BindingSource tYPES_OF_SERVICESBindingSource;
        private registrationDataSetTableAdapters.TYPES_OF_SERVICESTableAdapter tYPES_OF_SERVICESTableAdapter;
        private registrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tYPES_OF_SERVICESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tYPES_OF_SERVICESBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tYPES_OF_SERVICESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}