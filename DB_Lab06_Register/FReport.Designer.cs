namespace DB_Lab06_Register
{
    partial class FReport
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tYPESOFSERVICESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationDataSet = new DB_Lab06_Register.registrationDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pATIENTDIRECTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.pATIENT_DIRECTORYTableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.PATIENT_DIRECTORYTableAdapter();
            this.tYPES_OF_SERVICESTableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.TYPES_OF_SERVICESTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tYPESOFSERVICESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTDIRECTORYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tYPESOFSERVICESBindingSource;
            this.comboBox2.DisplayMember = "SERVICES_NAME";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(309, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.ValueMember = "SERVICES_NAME";
            // 
            // tYPESOFSERVICESBindingSource
            // 
            this.tYPESOFSERVICESBindingSource.DataMember = "TYPES_OF_SERVICES";
            this.tYPESOFSERVICESBindingSource.DataSource = this.registrationDataSet;
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
            this.comboBox1.Location = new System.Drawing.Point(95, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "FULL_NAME_PATIENT";
            // 
            // pATIENTDIRECTORYBindingSource
            // 
            this.pATIENTDIRECTORYBindingSource.DataMember = "PATIENT_DIRECTORY";
            this.pATIENTDIRECTORYBindingSource.DataSource = this.registrationDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Доктор:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Пациент:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(324, 87);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 28);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(202, 87);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 28);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // pATIENT_DIRECTORYTableAdapter
            // 
            this.pATIENT_DIRECTORYTableAdapter.ClearBeforeFill = true;
            // 
            // tYPES_OF_SERVICESTableAdapter
            // 
            this.tYPES_OF_SERVICESTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(422, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(422, 50);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // FReport
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(449, 129);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FReport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FReport_FormClosing);
            this.Load += new System.EventHandler(this.FReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tYPESOFSERVICESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTDIRECTORYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private registrationDataSet registrationDataSet;
        private System.Windows.Forms.BindingSource pATIENTDIRECTORYBindingSource;
        private registrationDataSetTableAdapters.PATIENT_DIRECTORYTableAdapter pATIENT_DIRECTORYTableAdapter;
        private System.Windows.Forms.BindingSource tYPESOFSERVICESBindingSource;
        private registrationDataSetTableAdapters.TYPES_OF_SERVICESTableAdapter tYPES_OF_SERVICESTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}