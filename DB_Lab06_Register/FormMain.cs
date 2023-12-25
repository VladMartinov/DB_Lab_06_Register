using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab06_Register
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void пациентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPatients form = new FPatients();
            form.Show();
        }

        private void доктораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDoctors form = new FDoctors();
            form.Show();
        }

        private void типыУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FServices form = new FServices();
            form.Show();
        }

        private void палатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FWards form = new FWards();
            form.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FEmployee form = new FEmployee();
            form.Show();
        } 

        private void направленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FReferral form = new FReferral();
            form.Show();
        }

        private void отчет1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report1 = new FastReport.Report();
            report1.Load("ReportSecondTwo.frx");
            report1.Show();
        }

        private void отчет2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report1 = new FastReport.Report();
            report1.Load("ReportSecondOne.frx");
            report1.Show();
        }

        private void отчет3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report1 = new FastReport.Report();
            report1.Load("ReportSecondThree.frx");

            FReport form = new FReport();
            form.ShowDialog();

            string patientName = "";
            string resultName = "";

            if (form.DialogResult == DialogResult.OK)
            {
                if (form.isPatient) patientName = form.patientId;
                if (form.isService) resultName = form.serviceId;
            }

            report1.SetParameterValue("FULL_NAME_PATIENT", patientName);
            report1.SetParameterValue("SERVICES_NAME", resultName);

            report1.Prepare();
            report1.Show();
        }
    }
}
