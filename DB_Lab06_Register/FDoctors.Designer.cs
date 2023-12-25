namespace DB_Lab06_Register
{
    partial class FDoctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDoctors));
            this.registrationDataSet = new DB_Lab06_Register.registrationDataSet();
            this.dOCTORS_DIRECTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCTORS_DIRECTORYTableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.DOCTORS_DIRECTORYTableAdapter();
            this.tableAdapterManager = new DB_Lab06_Register.registrationDataSetTableAdapters.TableAdapterManager();
            this.dOCTORS_DIRECTORYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dOCTORS_DIRECTORYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dOCTORS_DIRECTORYDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORS_DIRECTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORS_DIRECTORYBindingNavigator)).BeginInit();
            this.dOCTORS_DIRECTORYBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORS_DIRECTORYDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "registrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCTORS_DIRECTORYBindingSource
            // 
            this.dOCTORS_DIRECTORYBindingSource.DataMember = "DOCTORS_DIRECTORY";
            this.dOCTORS_DIRECTORYBindingSource.DataSource = this.registrationDataSet;
            // 
            // dOCTORS_DIRECTORYTableAdapter
            // 
            this.dOCTORS_DIRECTORYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCTORS_DIRECTORYTableAdapter = this.dOCTORS_DIRECTORYTableAdapter;
            this.tableAdapterManager.EMPLOYEE_DIRECTORYTableAdapter = null;
            this.tableAdapterManager.PATIENT_DIRECTORYTableAdapter = null;
            this.tableAdapterManager.PAYMENT_INVOICETableAdapter = null;
            this.tableAdapterManager.REFERRALTableAdapter = null;
            this.tableAdapterManager.RESULT_TYPESTableAdapter = null;
            this.tableAdapterManager.TREATMENT_OUTCOMESTableAdapter = null;
            this.tableAdapterManager.TYPES_OF_SERVICESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_Lab06_Register.registrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WARDS_DIRECTORYTableAdapter = null;
            // 
            // dOCTORS_DIRECTORYBindingNavigator
            // 
            this.dOCTORS_DIRECTORYBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dOCTORS_DIRECTORYBindingNavigator.BindingSource = this.dOCTORS_DIRECTORYBindingSource;
            this.dOCTORS_DIRECTORYBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dOCTORS_DIRECTORYBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dOCTORS_DIRECTORYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dOCTORS_DIRECTORYBindingNavigatorSaveItem});
            this.dOCTORS_DIRECTORYBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dOCTORS_DIRECTORYBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dOCTORS_DIRECTORYBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dOCTORS_DIRECTORYBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dOCTORS_DIRECTORYBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dOCTORS_DIRECTORYBindingNavigator.Name = "dOCTORS_DIRECTORYBindingNavigator";
            this.dOCTORS_DIRECTORYBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dOCTORS_DIRECTORYBindingNavigator.Size = new System.Drawing.Size(446, 25);
            this.dOCTORS_DIRECTORYBindingNavigator.TabIndex = 0;
            this.dOCTORS_DIRECTORYBindingNavigator.Text = "bindingNavigator1";
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
            // dOCTORS_DIRECTORYBindingNavigatorSaveItem
            // 
            this.dOCTORS_DIRECTORYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dOCTORS_DIRECTORYBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dOCTORS_DIRECTORYBindingNavigatorSaveItem.Image")));
            this.dOCTORS_DIRECTORYBindingNavigatorSaveItem.Name = "dOCTORS_DIRECTORYBindingNavigatorSaveItem";
            this.dOCTORS_DIRECTORYBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dOCTORS_DIRECTORYBindingNavigatorSaveItem.Text = "Save Data";
            this.dOCTORS_DIRECTORYBindingNavigatorSaveItem.Click += new System.EventHandler(this.dOCTORS_DIRECTORYBindingNavigatorSaveItem_Click);
            // 
            // dOCTORS_DIRECTORYDataGridView
            // 
            this.dOCTORS_DIRECTORYDataGridView.AutoGenerateColumns = false;
            this.dOCTORS_DIRECTORYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dOCTORS_DIRECTORYDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dOCTORS_DIRECTORYDataGridView.DataSource = this.dOCTORS_DIRECTORYBindingSource;
            this.dOCTORS_DIRECTORYDataGridView.Location = new System.Drawing.Point(0, 28);
            this.dOCTORS_DIRECTORYDataGridView.Name = "dOCTORS_DIRECTORYDataGridView";
            this.dOCTORS_DIRECTORYDataGridView.Size = new System.Drawing.Size(446, 410);
            this.dOCTORS_DIRECTORYDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DOCTOR_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер доктора";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DOCTOR_FULL_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО доктора";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SPECIALISATION";
            this.dataGridViewTextBoxColumn3.HeaderText = "Специализация";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // FDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.dOCTORS_DIRECTORYDataGridView);
            this.Controls.Add(this.dOCTORS_DIRECTORYBindingNavigator);
            this.Name = "FDoctors";
            this.Text = "FDoctors";
            this.Load += new System.EventHandler(this.FDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORS_DIRECTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORS_DIRECTORYBindingNavigator)).EndInit();
            this.dOCTORS_DIRECTORYBindingNavigator.ResumeLayout(false);
            this.dOCTORS_DIRECTORYBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORS_DIRECTORYDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private registrationDataSet registrationDataSet;
        private System.Windows.Forms.BindingSource dOCTORS_DIRECTORYBindingSource;
        private registrationDataSetTableAdapters.DOCTORS_DIRECTORYTableAdapter dOCTORS_DIRECTORYTableAdapter;
        private registrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dOCTORS_DIRECTORYBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dOCTORS_DIRECTORYBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dOCTORS_DIRECTORYDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}