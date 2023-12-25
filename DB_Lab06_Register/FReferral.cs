using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Lab06_Register
{
    public partial class FReferral : Form
    {
        public FReferral()
        {
            InitializeComponent();
        }

        private void FReferral_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.REFERRAL_VIEW' table. You can move, or remove it, as needed.
            this.rEFERRAL_VIEWTableAdapter.Fill(this.registrationDataSet.REFERRAL_VIEW);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FNewReferral form = new FNewReferral();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
                this.rEFERRAL_VIEWTableAdapter.Fill(this.registrationDataSet.REFERRAL_VIEW);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int pos = this.rEFERRAL_VIEWBindingSource.Position;
            DataRowView currentRow = (DataRowView)this.rEFERRAL_VIEWBindingSource.Current;
            int referralId = (int) currentRow["REFERRAL_ID"];
            FNewReferral form = new FNewReferral(referralId);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                this.rEFERRAL_VIEWTableAdapter.Fill(this.registrationDataSet.REFERRAL_VIEW);
                this.rEFERRAL_VIEWBindingSource.Position = pos;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FNewTreatment form = new FNewTreatment();
            form.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FTreatment form = new FTreatment();
            form.Show();
        }
    }
}
