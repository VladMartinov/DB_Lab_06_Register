namespace DB_Lab06_Register
{
    partial class FTreatment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTreatment));
            this.registrationDataSet = new DB_Lab06_Register.registrationDataSet();
            this.tREATMENT_OUTCOMES_VIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tREATMENT_OUTCOMES_VIEWTableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.TREATMENT_OUTCOMES_VIEWTableAdapter();
            this.tableAdapterManager = new DB_Lab06_Register.registrationDataSetTableAdapters.TableAdapterManager();
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tREATMENT_OUTCOMES_VIEWDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TREATMENT_END_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tREATMENT_OUTCOMES_VIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tREATMENT_OUTCOMES_VIEWBindingNavigator)).BeginInit();
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tREATMENT_OUTCOMES_VIEWDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "registrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tREATMENT_OUTCOMES_VIEWBindingSource
            // 
            this.tREATMENT_OUTCOMES_VIEWBindingSource.DataMember = "TREATMENT_OUTCOMES_VIEW";
            this.tREATMENT_OUTCOMES_VIEWBindingSource.DataSource = this.registrationDataSet;
            // 
            // tREATMENT_OUTCOMES_VIEWTableAdapter
            // 
            this.tREATMENT_OUTCOMES_VIEWTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DOCTORS_DIRECTORYTableAdapter = null;
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
            // tREATMENT_OUTCOMES_VIEWBindingNavigator
            // 
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.AddNewItem = null;
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.BindingSource = this.tREATMENT_OUTCOMES_VIEWBindingSource;
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.DeleteItem = null;
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1,
            this.toolStripLabel1});
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.Name = "tREATMENT_OUTCOMES_VIEWBindingNavigator";
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.TabIndex = 0;
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tREATMENT_OUTCOMES_VIEWDataGridView
            // 
            this.tREATMENT_OUTCOMES_VIEWDataGridView.AllowUserToAddRows = false;
            this.tREATMENT_OUTCOMES_VIEWDataGridView.AllowUserToDeleteRows = false;
            this.tREATMENT_OUTCOMES_VIEWDataGridView.AllowUserToOrderColumns = true;
            this.tREATMENT_OUTCOMES_VIEWDataGridView.AutoGenerateColumns = false;
            this.tREATMENT_OUTCOMES_VIEWDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tREATMENT_OUTCOMES_VIEWDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.TREATMENT_END_DATE,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tREATMENT_OUTCOMES_VIEWDataGridView.DataSource = this.tREATMENT_OUTCOMES_VIEWBindingSource;
            this.tREATMENT_OUTCOMES_VIEWDataGridView.Location = new System.Drawing.Point(0, 28);
            this.tREATMENT_OUTCOMES_VIEWDataGridView.Name = "tREATMENT_OUTCOMES_VIEWDataGridView";
            this.tREATMENT_OUTCOMES_VIEWDataGridView.ReadOnly = true;
            this.tREATMENT_OUTCOMES_VIEWDataGridView.Size = new System.Drawing.Size(800, 410);
            this.tREATMENT_OUTCOMES_VIEWDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RECORD_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер выписки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FULL_NAME_PATIENT";
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО пациента";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FULL_NAME_EMPLOYEE";
            this.dataGridViewTextBoxColumn4.HeaderText = "ФИО сотрудника";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DOCTOR_FULL_NAME";
            this.dataGridViewTextBoxColumn5.HeaderText = "ФИО доктора";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SERVICES_NAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "Услуга";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "WARD_NUMBER";
            this.dataGridViewTextBoxColumn7.HeaderText = "Номер палаты";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DATE_OF_TICKET";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата записи";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // TREATMENT_END_DATE
            // 
            this.TREATMENT_END_DATE.DataPropertyName = "TREATMENT_END_DATE";
            this.TREATMENT_END_DATE.HeaderText = "Дата выписки";
            this.TREATMENT_END_DATE.Name = "TREATMENT_END_DATE";
            this.TREATMENT_END_DATE.ReadOnly = true;
            this.TREATMENT_END_DATE.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RESULT_NAME";
            this.dataGridViewTextBoxColumn9.HeaderText = "Результат";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "COST_OF_TREATMENT";
            this.dataGridViewTextBoxColumn10.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 75;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(96, 22);
            this.toolStripLabel1.Text = "Платные услуги";
            // 
            // FTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tREATMENT_OUTCOMES_VIEWDataGridView);
            this.Controls.Add(this.tREATMENT_OUTCOMES_VIEWBindingNavigator);
            this.Name = "FTreatment";
            this.Text = "FTreatment";
            this.Load += new System.EventHandler(this.FTreatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tREATMENT_OUTCOMES_VIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tREATMENT_OUTCOMES_VIEWBindingNavigator)).EndInit();
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.ResumeLayout(false);
            this.tREATMENT_OUTCOMES_VIEWBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tREATMENT_OUTCOMES_VIEWDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private registrationDataSet registrationDataSet;
        private System.Windows.Forms.BindingSource tREATMENT_OUTCOMES_VIEWBindingSource;
        private registrationDataSetTableAdapters.TREATMENT_OUTCOMES_VIEWTableAdapter tREATMENT_OUTCOMES_VIEWTableAdapter;
        private registrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tREATMENT_OUTCOMES_VIEWBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView tREATMENT_OUTCOMES_VIEWDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn TREATMENT_END_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}