using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab06_Register
{
    public partial class FNewTreatment : Form
    {
        public FNewTreatment()
        {
            InitializeComponent();
        }

        private void FNewTreatment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.RESULT_TYPES' table. You can move, or remove it, as needed.
            this.rESULT_TYPESTableAdapter.Fill(this.registrationDataSet.RESULT_TYPES);
            // TODO: This line of code loads data into the 'registrationDataSet.REFERRAL' table. You can move, or remove it, as needed.
            this.rEFERRALTableAdapter.FillBySec(this.registrationDataSet.REFERRAL);
        }

        private void FNewTreatment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                int cost;
                if (!int.TryParse(textBox1.Text, out cost))
                    cost = 0;
                
                using (var conn = new SqlConnection(Properties.Settings.Default.registrationConnectionString))
                using (var cmd = new SqlCommand("DischargeThePatient", conn) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.AddWithValue("@ReferralId", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@ResultId", comboBox2.SelectedValue);
                    cmd.Parameters.AddWithValue("@Cost", cost);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                };
            }
        }
    }
}
