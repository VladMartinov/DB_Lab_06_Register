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
    public partial class FTreatment : Form
    {
        public FTreatment()
        {
            InitializeComponent();
        }

        private void FTreatment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.TREATMENT_OUTCOMES_VIEW' table. You can move, or remove it, as needed.
            this.tREATMENT_OUTCOMES_VIEWTableAdapter.Fill(this.registrationDataSet.TREATMENT_OUTCOMES_VIEW);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FPayment form = new FPayment();
            form.Show();
        }
    }
}
