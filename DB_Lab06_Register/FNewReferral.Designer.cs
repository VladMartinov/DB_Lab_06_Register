namespace DB_Lab06_Register
{
    partial class FNewReferral
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.eMPLOYEEDIRECTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationDataSet = new DB_Lab06_Register.registrationDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pATIENTDIRECTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dOCTORSDIRECTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.wARDSDIRECTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.tYPESOFSERVICESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENT_DIRECTORYTableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.PATIENT_DIRECTORYTableAdapter();
            this.dOCTORS_DIRECTORYTableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.DOCTORS_DIRECTORYTableAdapter();
            this.tYPES_OF_SERVICESTableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.TYPES_OF_SERVICESTableAdapter();
            this.eMPLOYEE_DIRECTORYTableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.EMPLOYEE_DIRECTORYTableAdapter();
            this.wARDS_DIRECTORYTableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.WARDS_DIRECTORYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDIRECTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTDIRECTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORSDIRECTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wARDSDIRECTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPESOFSERVICESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(198, 153);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 28);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(320, 153);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 28);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пациент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Доктор:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Палата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Услуга:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Сотрудник:";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.eMPLOYEEDIRECTORYBindingSource;
            this.comboBox5.DisplayMember = "FULL_NAME_EMPLOYEE";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(91, 113);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(309, 21);
            this.comboBox5.TabIndex = 7;
            this.comboBox5.ValueMember = "ID_EMPLOYEE";
            // 
            // eMPLOYEEDIRECTORYBindingSource
            // 
            this.eMPLOYEEDIRECTORYBindingSource.DataMember = "EMPLOYEE_DIRECTORY";
            this.eMPLOYEEDIRECTORYBindingSource.DataSource = this.registrationDataSet;
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "registrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pATIENTDIRECTORYBindingSource;
            this.comboBox1.DisplayMember = "FULL_NAME_PATIENT";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "ID_PATIENT";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pATIENTDIRECTORYBindingSource
            // 
            this.pATIENTDIRECTORYBindingSource.DataMember = "PATIENT_DIRECTORY";
            this.pATIENTDIRECTORYBindingSource.DataSource = this.registrationDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.dOCTORSDIRECTORYBindingSource;
            this.comboBox2.DisplayMember = "DOCTOR_FULL_NAME";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(309, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "DOCTOR_ID";
            // 
            // dOCTORSDIRECTORYBindingSource
            // 
            this.dOCTORSDIRECTORYBindingSource.DataMember = "DOCTORS_DIRECTORY";
            this.dOCTORSDIRECTORYBindingSource.DataSource = this.registrationDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.wARDSDIRECTORYBindingSource;
            this.comboBox3.DisplayMember = "WARD_NUMBER";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(91, 64);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(53, 21);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.ValueMember = "WARD_NUMBER";
            // 
            // wARDSDIRECTORYBindingSource
            // 
            this.wARDSDIRECTORYBindingSource.DataMember = "WARDS_DIRECTORY";
            this.wARDSDIRECTORYBindingSource.DataSource = this.registrationDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.tYPESOFSERVICESBindingSource;
            this.comboBox4.DisplayMember = "SERVICES_NAME";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(91, 88);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(164, 21);
            this.comboBox4.TabIndex = 11;
            this.comboBox4.ValueMember = "SERVICES_ID";
            // 
            // tYPESOFSERVICESBindingSource
            // 
            this.tYPESOFSERVICESBindingSource.DataMember = "TYPES_OF_SERVICES";
            this.tYPESOFSERVICESBindingSource.DataSource = this.registrationDataSet;
            // 
            // pATIENT_DIRECTORYTableAdapter
            // 
            this.pATIENT_DIRECTORYTableAdapter.ClearBeforeFill = true;
            // 
            // dOCTORS_DIRECTORYTableAdapter
            // 
            this.dOCTORS_DIRECTORYTableAdapter.ClearBeforeFill = true;
            // 
            // tYPES_OF_SERVICESTableAdapter
            // 
            this.tYPES_OF_SERVICESTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEE_DIRECTORYTableAdapter
            // 
            this.eMPLOYEE_DIRECTORYTableAdapter.ClearBeforeFill = true;
            // 
            // wARDS_DIRECTORYTableAdapter
            // 
            this.wARDS_DIRECTORYTableAdapter.ClearBeforeFill = true;
            // 
            // FNewReferral
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(426, 198);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FNewReferral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNewReferral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FNewReferral_FormClosing);
            this.Load += new System.EventHandler(this.FNewReferral_Load);
            this.Shown += new System.EventHandler(this.FNewReferral_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDIRECTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTDIRECTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORSDIRECTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wARDSDIRECTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPESOFSERVICESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private registrationDataSet registrationDataSet;
        private System.Windows.Forms.BindingSource pATIENTDIRECTORYBindingSource;
        private registrationDataSetTableAdapters.PATIENT_DIRECTORYTableAdapter pATIENT_DIRECTORYTableAdapter;
        private System.Windows.Forms.BindingSource dOCTORSDIRECTORYBindingSource;
        private registrationDataSetTableAdapters.DOCTORS_DIRECTORYTableAdapter dOCTORS_DIRECTORYTableAdapter;
        private System.Windows.Forms.BindingSource tYPESOFSERVICESBindingSource;
        private registrationDataSetTableAdapters.TYPES_OF_SERVICESTableAdapter tYPES_OF_SERVICESTableAdapter;
        private System.Windows.Forms.BindingSource eMPLOYEEDIRECTORYBindingSource;
        private registrationDataSetTableAdapters.EMPLOYEE_DIRECTORYTableAdapter eMPLOYEE_DIRECTORYTableAdapter;
        private System.Windows.Forms.BindingSource wARDSDIRECTORYBindingSource;
        private registrationDataSetTableAdapters.WARDS_DIRECTORYTableAdapter wARDS_DIRECTORYTableAdapter;
    }
}