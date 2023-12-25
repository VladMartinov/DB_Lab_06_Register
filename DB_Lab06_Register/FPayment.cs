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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Lab06_Register
{
    public partial class FPayment : Form
    {
        public FPayment()
        {
            InitializeComponent();
        }

        private void pAYMENT_INVOICEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pAYMENT_INVOICEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registrationDataSet);

        }

        private void FPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.PAYMENT_INVOICE' table. You can move, or remove it, as needed.
            this.pAYMENT_INVOICETableAdapter.Fill(this.registrationDataSet.PAYMENT_INVOICE);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int pos = this.pAYMENT_INVOICEBindingSource.Position;
            DataRowView currentRow = (DataRowView)this.pAYMENT_INVOICEBindingSource.Current;
            int recordId = (int)currentRow["RECORD_ID"];
            int referralId = (int)currentRow["REFERRAL_ID"];

            if (recordId != 0 && referralId != 0)
            {
                string cmdString = "UPDATE PAYMENT_INVOICE SET PAYMENT_INVOICE.PAYMENT_DATE = CONVERT(varchar(10), GETDATE(), 120) WHERE RECORD_ID = @RecordId AND REFERRAL_ID = @ReferralId";
                using (var conn = new SqlConnection(Properties.Settings.Default.registrationConnectionString))
                using (var cmd = new SqlCommand(cmdString, conn))
                {
                    cmd.Parameters.AddWithValue("@RecordId", recordId);
                    cmd.Parameters.AddWithValue("@ReferralId", referralId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                };

                this.pAYMENT_INVOICETableAdapter.Fill(this.registrationDataSet.PAYMENT_INVOICE);
                this.pAYMENT_INVOICEBindingSource.Position = pos;
            }
        }
    }
}
