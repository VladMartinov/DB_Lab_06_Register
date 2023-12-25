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
    public partial class FReport : Form
    {
        public string patientId = "";
        public string serviceId = "";

        public bool isPatient = false;
        public bool isService = false;

        public FReport()
        {
            InitializeComponent();
        }

        private void FReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.TYPES_OF_SERVICES' table. You can move, or remove it, as needed.
            this.tYPES_OF_SERVICESTableAdapter.Fill(this.registrationDataSet.TYPES_OF_SERVICES);
            // TODO: This line of code loads data into the 'registrationDataSet.PATIENT_DIRECTORY' table. You can move, or remove it, as needed.
            this.pATIENT_DIRECTORYTableAdapter.Fill(this.registrationDataSet.PATIENT_DIRECTORY);

        }

        private void FReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                isPatient = checkBox1.Checked;
                isService = checkBox2.Checked;

                patientId = comboBox1.SelectedValue.ToString();
                serviceId = comboBox2.SelectedValue.ToString();
            }
        }
    }
}
