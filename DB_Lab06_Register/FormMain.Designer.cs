namespace DB_Lab06_Register
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пациентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доктораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыУслугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.палатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.направленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчет1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчет2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчет3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report1 = new FastReport.Report();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пациентыToolStripMenuItem,
            this.доктораToolStripMenuItem,
            this.типыУслугToolStripMenuItem,
            this.палатыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.направленияToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пациентыToolStripMenuItem
            // 
            this.пациентыToolStripMenuItem.Name = "пациентыToolStripMenuItem";
            this.пациентыToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.пациентыToolStripMenuItem.Text = "Пациенты";
            this.пациентыToolStripMenuItem.Click += new System.EventHandler(this.пациентыToolStripMenuItem_Click);
            // 
            // доктораToolStripMenuItem
            // 
            this.доктораToolStripMenuItem.Name = "доктораToolStripMenuItem";
            this.доктораToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.доктораToolStripMenuItem.Text = "Доктора";
            this.доктораToolStripMenuItem.Click += new System.EventHandler(this.доктораToolStripMenuItem_Click);
            // 
            // типыУслугToolStripMenuItem
            // 
            this.типыУслугToolStripMenuItem.Name = "типыУслугToolStripMenuItem";
            this.типыУслугToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.типыУслугToolStripMenuItem.Text = "Типы услуг";
            this.типыУслугToolStripMenuItem.Click += new System.EventHandler(this.типыУслугToolStripMenuItem_Click);
            // 
            // палатыToolStripMenuItem
            // 
            this.палатыToolStripMenuItem.Name = "палатыToolStripMenuItem";
            this.палатыToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.палатыToolStripMenuItem.Text = "Палаты";
            this.палатыToolStripMenuItem.Click += new System.EventHandler(this.палатыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // направленияToolStripMenuItem
            // 
            this.направленияToolStripMenuItem.Name = "направленияToolStripMenuItem";
            this.направленияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.направленияToolStripMenuItem.Text = "Направления";
            this.направленияToolStripMenuItem.Click += new System.EventHandler(this.направленияToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчет1ToolStripMenuItem,
            this.отчет2ToolStripMenuItem,
            this.отчет3ToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // отчет1ToolStripMenuItem
            // 
            this.отчет1ToolStripMenuItem.Name = "отчет1ToolStripMenuItem";
            this.отчет1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отчет1ToolStripMenuItem.Text = "Отчет №1";
            this.отчет1ToolStripMenuItem.Click += new System.EventHandler(this.отчет1ToolStripMenuItem_Click);
            // 
            // отчет2ToolStripMenuItem
            // 
            this.отчет2ToolStripMenuItem.Name = "отчет2ToolStripMenuItem";
            this.отчет2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отчет2ToolStripMenuItem.Text = "Отчет №2";
            this.отчет2ToolStripMenuItem.Click += new System.EventHandler(this.отчет2ToolStripMenuItem_Click);
            // 
            // отчет3ToolStripMenuItem
            // 
            this.отчет3ToolStripMenuItem.Name = "отчет3ToolStripMenuItem";
            this.отчет3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отчет3ToolStripMenuItem.Text = "Отчет №3";
            this.отчет3ToolStripMenuItem.Click += new System.EventHandler(this.отчет3ToolStripMenuItem_Click);
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.Tag = null;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 149);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пациентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доктораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыУслугToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem палатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem направленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчет1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчет2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчет3ToolStripMenuItem;
        private FastReport.Report report1;
    }
}

