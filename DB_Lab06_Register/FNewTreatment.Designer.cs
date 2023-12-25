namespace DB_Lab06_Register
{
    partial class FNewTreatment
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.registrationDataSet = new DB_Lab06_Register.registrationDataSet();
            this.rEFERRALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEFERRALTableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.REFERRALTableAdapter();
            this.rESULTTYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESULT_TYPESTableAdapter = new DB_Lab06_Register.registrationDataSetTableAdapters.RESULT_TYPESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFERRALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESULTTYPESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.rESULTTYPESBindingSource;
            this.comboBox2.DisplayMember = "RESULT_NAME";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(180, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(222, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.ValueMember = "RESULT_ID";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rEFERRALBindingSource;
            this.comboBox1.DisplayMember = "REFERRAL_ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "REFERRAL_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Стоимость:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Результат:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Номер записи поступления:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(322, 104);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 28);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(200, 104);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 28);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "registrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEFERRALBindingSource
            // 
            this.rEFERRALBindingSource.DataMember = "REFERRAL";
            this.rEFERRALBindingSource.DataSource = this.registrationDataSet;
            // 
            // rEFERRALTableAdapter
            // 
            this.rEFERRALTableAdapter.ClearBeforeFill = true;
            // 
            // rESULTTYPESBindingSource
            // 
            this.rESULTTYPESBindingSource.DataMember = "RESULT_TYPES";
            this.rESULTTYPESBindingSource.DataSource = this.registrationDataSet;
            // 
            // rESULT_TYPESTableAdapter
            // 
            this.rESULT_TYPESTableAdapter.ClearBeforeFill = true;
            // 
            // FNewTreatment
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(439, 146);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "FNewTreatment";
            this.Text = "FNewTreatment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FNewTreatment_FormClosing);
            this.Load += new System.EventHandler(this.FNewTreatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFERRALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESULTTYPESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBox1;
        private registrationDataSet registrationDataSet;
        private System.Windows.Forms.BindingSource rEFERRALBindingSource;
        private registrationDataSetTableAdapters.REFERRALTableAdapter rEFERRALTableAdapter;
        private System.Windows.Forms.BindingSource rESULTTYPESBindingSource;
        private registrationDataSetTableAdapters.RESULT_TYPESTableAdapter rESULT_TYPESTableAdapter;
    }
}