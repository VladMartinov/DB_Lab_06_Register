namespace DB_Lab06_Register
{
    partial class FPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPatients));
            this.registrationDataSet = new DB_Lab06_Register.registrationDataSet();
            this.pATIENT_DIRECTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENT_DIRECTORYTableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.PATIENT_DIRECTORYTableAdapter();
            this.tableAdapterManager = new DB_Lab06_Register.registrationDataSetTableAdapters.TableAdapterManager();
            this.pATIENT_DIRECTORYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pATIENT_DIRECTORYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pATIENT_DIRECTORYDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENT_DIRECTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENT_DIRECTORYBindingNavigator)).BeginInit();
            this.pATIENT_DIRECTORYBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENT_DIRECTORYDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "registrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pATIENT_DIRECTORYBindingSource
            // 
            this.pATIENT_DIRECTORYBindingSource.DataMember = "PATIENT_DIRECTORY";
            this.pATIENT_DIRECTORYBindingSource.DataSource = this.registrationDataSet;
            // 
            // pATIENT_DIRECTORYTableAdapter
            // 
            this.pATIENT_DIRECTORYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCTORS_DIRECTORYTableAdapter = null;
            this.tableAdapterManager.EMPLOYEE_DIRECTORYTableAdapter = null;
            this.tableAdapterManager.PATIENT_DIRECTORYTableAdapter = this.pATIENT_DIRECTORYTableAdapter;
            this.tableAdapterManager.PAYMENT_INVOICETableAdapter = null;
            this.tableAdapterManager.REFERRALTableAdapter = null;
            this.tableAdapterManager.RESULT_TYPESTableAdapter = null;
            this.tableAdapterManager.TREATMENT_OUTCOMESTableAdapter = null;
            this.tableAdapterManager.TYPES_OF_SERVICESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_Lab06_Register.registrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WARDS_DIRECTORYTableAdapter = null;
            // 
            // pATIENT_DIRECTORYBindingNavigator
            // 
            this.pATIENT_DIRECTORYBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pATIENT_DIRECTORYBindingNavigator.BindingSource = this.pATIENT_DIRECTORYBindingSource;
            this.pATIENT_DIRECTORYBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pATIENT_DIRECTORYBindingNavigator.DeleteItem = null;
            this.pATIENT_DIRECTORYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pATIENT_DIRECTORYBindingNavigatorSaveItem});
            this.pATIENT_DIRECTORYBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pATIENT_DIRECTORYBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pATIENT_DIRECTORYBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pATIENT_DIRECTORYBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pATIENT_DIRECTORYBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pATIENT_DIRECTORYBindingNavigator.Name = "pATIENT_DIRECTORYBindingNavigator";
            this.pATIENT_DIRECTORYBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pATIENT_DIRECTORYBindingNavigator.Size = new System.Drawing.Size(695, 25);
            this.pATIENT_DIRECTORYBindingNavigator.TabIndex = 0;
            this.pATIENT_DIRECTORYBindingNavigator.Text = "bindingNavigator1";
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
            // pATIENT_DIRECTORYBindingNavigatorSaveItem
            // 
            this.pATIENT_DIRECTORYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pATIENT_DIRECTORYBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pATIENT_DIRECTORYBindingNavigatorSaveItem.Image")));
            this.pATIENT_DIRECTORYBindingNavigatorSaveItem.Name = "pATIENT_DIRECTORYBindingNavigatorSaveItem";
            this.pATIENT_DIRECTORYBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pATIENT_DIRECTORYBindingNavigatorSaveItem.Text = "Save Data";
            this.pATIENT_DIRECTORYBindingNavigatorSaveItem.Click += new System.EventHandler(this.pATIENT_DIRECTORYBindingNavigatorSaveItem_Click);
            // 
            // pATIENT_DIRECTORYDataGridView
            // 
            this.pATIENT_DIRECTORYDataGridView.AutoGenerateColumns = false;
            this.pATIENT_DIRECTORYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pATIENT_DIRECTORYDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pATIENT_DIRECTORYDataGridView.DataSource = this.pATIENT_DIRECTORYBindingSource;
            this.pATIENT_DIRECTORYDataGridView.Location = new System.Drawing.Point(0, 28);
            this.pATIENT_DIRECTORYDataGridView.Name = "pATIENT_DIRECTORYDataGridView";
            this.pATIENT_DIRECTORYDataGridView.Size = new System.Drawing.Size(695, 410);
            this.pATIENT_DIRECTORYDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PATIENT";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер пациента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FULL_NAME_PATIENT";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GENDER";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DATE_OF_BIRTH";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CONTACTS";
            this.dataGridViewTextBoxColumn5.HeaderText = "Контакты";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ADRESS";
            this.dataGridViewTextBoxColumn6.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // FPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.pATIENT_DIRECTORYDataGridView);
            this.Controls.Add(this.pATIENT_DIRECTORYBindingNavigator);
            this.Name = "FPatients";
            this.Text = "FPatients";
            this.Load += new System.EventHandler(this.FPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENT_DIRECTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENT_DIRECTORYBindingNavigator)).EndInit();
            this.pATIENT_DIRECTORYBindingNavigator.ResumeLayout(false);
            this.pATIENT_DIRECTORYBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENT_DIRECTORYDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private registrationDataSet registrationDataSet;
        private System.Windows.Forms.BindingSource pATIENT_DIRECTORYBindingSource;
        private registrationDataSetTableAdapters.PATIENT_DIRECTORYTableAdapter pATIENT_DIRECTORYTableAdapter;
        private registrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pATIENT_DIRECTORYBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pATIENT_DIRECTORYBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pATIENT_DIRECTORYDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}