namespace DB_Lab06_Register
{
    partial class FPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPayment));
            this.registrationDataSet = new DB_Lab06_Register.registrationDataSet();
            this.pAYMENT_INVOICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAYMENT_INVOICETableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.PAYMENT_INVOICETableAdapter();
            this.tableAdapterManager = new DB_Lab06_Register.registrationDataSetTableAdapters.TableAdapterManager();
            this.pAYMENT_INVOICEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pAYMENT_INVOICEDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERRAL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENT_INVOICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENT_INVOICEBindingNavigator)).BeginInit();
            this.pAYMENT_INVOICEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENT_INVOICEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "registrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAYMENT_INVOICEBindingSource
            // 
            this.pAYMENT_INVOICEBindingSource.DataMember = "PAYMENT_INVOICE";
            this.pAYMENT_INVOICEBindingSource.DataSource = this.registrationDataSet;
            // 
            // pAYMENT_INVOICETableAdapter
            // 
            this.pAYMENT_INVOICETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCTORS_DIRECTORYTableAdapter = null;
            this.tableAdapterManager.EMPLOYEE_DIRECTORYTableAdapter = null;
            this.tableAdapterManager.PATIENT_DIRECTORYTableAdapter = null;
            this.tableAdapterManager.PAYMENT_INVOICETableAdapter = this.pAYMENT_INVOICETableAdapter;
            this.tableAdapterManager.REFERRALTableAdapter = null;
            this.tableAdapterManager.RESULT_TYPESTableAdapter = null;
            this.tableAdapterManager.TREATMENT_OUTCOMESTableAdapter = null;
            this.tableAdapterManager.TYPES_OF_SERVICESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_Lab06_Register.registrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WARDS_DIRECTORYTableAdapter = null;
            // 
            // pAYMENT_INVOICEBindingNavigator
            // 
            this.pAYMENT_INVOICEBindingNavigator.AddNewItem = null;
            this.pAYMENT_INVOICEBindingNavigator.BindingSource = this.pAYMENT_INVOICEBindingSource;
            this.pAYMENT_INVOICEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pAYMENT_INVOICEBindingNavigator.DeleteItem = null;
            this.pAYMENT_INVOICEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pAYMENT_INVOICEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pAYMENT_INVOICEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pAYMENT_INVOICEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pAYMENT_INVOICEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pAYMENT_INVOICEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pAYMENT_INVOICEBindingNavigator.Name = "pAYMENT_INVOICEBindingNavigator";
            this.pAYMENT_INVOICEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pAYMENT_INVOICEBindingNavigator.Size = new System.Drawing.Size(470, 25);
            this.pAYMENT_INVOICEBindingNavigator.TabIndex = 0;
            this.pAYMENT_INVOICEBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pAYMENT_INVOICEDataGridView
            // 
            this.pAYMENT_INVOICEDataGridView.AllowUserToAddRows = false;
            this.pAYMENT_INVOICEDataGridView.AllowUserToDeleteRows = false;
            this.pAYMENT_INVOICEDataGridView.AllowUserToOrderColumns = true;
            this.pAYMENT_INVOICEDataGridView.AutoGenerateColumns = false;
            this.pAYMENT_INVOICEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pAYMENT_INVOICEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.REFERRAL_ID,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pAYMENT_INVOICEDataGridView.DataSource = this.pAYMENT_INVOICEBindingSource;
            this.pAYMENT_INVOICEDataGridView.Location = new System.Drawing.Point(0, 28);
            this.pAYMENT_INVOICEDataGridView.Name = "pAYMENT_INVOICEDataGridView";
            this.pAYMENT_INVOICEDataGridView.ReadOnly = true;
            this.pAYMENT_INVOICEDataGridView.Size = new System.Drawing.Size(470, 275);
            this.pAYMENT_INVOICEDataGridView.TabIndex = 1;
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
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "Оплатить";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RECORD_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер выписки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // REFERRAL_ID
            // 
            this.REFERRAL_ID.DataPropertyName = "REFERRAL_ID";
            this.REFERRAL_ID.HeaderText = "Номер записи";
            this.REFERRAL_ID.Name = "REFERRAL_ID";
            this.REFERRAL_ID.ReadOnly = true;
            this.REFERRAL_ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATE_OF_ISSUE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата выдачи счёта";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PAYMENT_DATE";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата оплаты счёта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // FPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 315);
            this.Controls.Add(this.pAYMENT_INVOICEDataGridView);
            this.Controls.Add(this.pAYMENT_INVOICEBindingNavigator);
            this.Name = "FPayment";
            this.Text = "FPayment";
            this.Load += new System.EventHandler(this.FPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENT_INVOICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENT_INVOICEBindingNavigator)).EndInit();
            this.pAYMENT_INVOICEBindingNavigator.ResumeLayout(false);
            this.pAYMENT_INVOICEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENT_INVOICEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private registrationDataSet registrationDataSet;
        private System.Windows.Forms.BindingSource pAYMENT_INVOICEBindingSource;
        private registrationDataSetTableAdapters.PAYMENT_INVOICETableAdapter pAYMENT_INVOICETableAdapter;
        private registrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pAYMENT_INVOICEBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView pAYMENT_INVOICEDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERRAL_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}