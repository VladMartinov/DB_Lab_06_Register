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
    public partial class FNewReferral : Form
    {
        private int referralId = 0;

        public FNewReferral()
        {
            InitializeComponent();
        }

        public FNewReferral(int referralId)
        {
            InitializeComponent();
            this.referralId = referralId;
        }

        private void FNewReferral_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.WARDS_DIRECTORY' table. You can move, or remove it, as needed.
            this.wARDS_DIRECTORYTableAdapter.Fill(this.registrationDataSet.WARDS_DIRECTORY);
            // TODO: This line of code loads data into the 'registrationDataSet.EMPLOYEE_DIRECTORY' table. You can move, or remove it, as needed.
            this.eMPLOYEE_DIRECTORYTableAdapter.Fill(this.registrationDataSet.EMPLOYEE_DIRECTORY);
            // TODO: This line of code loads data into the 'registrationDataSet.TYPES_OF_SERVICES' table. You can move, or remove it, as needed.
            this.tYPES_OF_SERVICESTableAdapter.Fill(this.registrationDataSet.TYPES_OF_SERVICES);
            // TODO: This line of code loads data into the 'registrationDataSet.DOCTORS_DIRECTORY' table. You can move, or remove it, as needed.
            this.dOCTORS_DIRECTORYTableAdapter.Fill(this.registrationDataSet.DOCTORS_DIRECTORY);
            // TODO: This line of code loads data into the 'registrationDataSet.PATIENT_DIRECTORY' table. You can move, or remove it, as needed.
            this.pATIENT_DIRECTORYTableAdapter.Fill(this.registrationDataSet.PATIENT_DIRECTORY);

            if (referralId == 0) return;

            string cmdStr = "SELECT ID_PATIENT, DOCTOR_ID, WARD_NUMBER, SERVICES_ID, ID_EMPLOYEE FROM REFERRAL WHERE REFERRAL_ID = @ReferralId";
            using (var conn = new SqlConnection(Properties.Settings.Default.registrationConnectionString))
            using (var cmd = new SqlCommand(cmdStr, conn))
            {
                cmd.Parameters.AddWithValue("@ReferralId", referralId);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                comboBox1.SelectedValue = reader.GetInt32(0);
                comboBox2.SelectedValue = reader.GetInt32(1);
                comboBox3.SelectedValue = reader.GetInt32(2);
                comboBox4.SelectedValue = reader.GetInt32(3);
                comboBox5.SelectedValue = reader.GetInt32(4);

                reader.Close();
                conn.Close();
            };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.wARDS_DIRECTORYTableAdapter.FillBySec(this.registrationDataSet.WARDS_DIRECTORY, (int)comboBox1.SelectedValue);
        }

        private void FNewReferral_Shown(object sender, EventArgs e)
        {
            this.wARDS_DIRECTORYTableAdapter.FillBySec(this.registrationDataSet.WARDS_DIRECTORY, (int)comboBox1.SelectedValue);
        }

        private void FNewReferral_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK) 
            {
                using (var conn = new SqlConnection(Properties.Settings.Default.registrationConnectionString))
                using (var cmd = new SqlCommand("AddPatientAdmissionById", conn) { CommandType = CommandType.StoredProcedure })
                {
                    if (referralId > 0)
                    {
                        cmd.CommandText = "UpdateReferral";
                        cmd.Parameters.AddWithValue("@ReferralId", referralId);
                    }

                    cmd.Parameters.AddWithValue("@PatientId", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@DoctorId", comboBox2.SelectedValue);
                    cmd.Parameters.AddWithValue("@WardNumber", comboBox3.SelectedValue);
                    cmd.Parameters.AddWithValue("@ServiceId", comboBox4.SelectedValue);
                    cmd.Parameters.AddWithValue("@EmployeeId", comboBox5.SelectedValue);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                };
            }
        }
    }
}
