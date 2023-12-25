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
    public partial class FPatients : Form
    {
        public FPatients()
        {
            InitializeComponent();
        }

        private void pATIENT_DIRECTORYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pATIENT_DIRECTORYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registrationDataSet);

        }

        private void FPatients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.PATIENT_DIRECTORY' table. You can move, or remove it, as needed.
            this.pATIENT_DIRECTORYTableAdapter.Fill(this.registrationDataSet.PATIENT_DIRECTORY);

        }
    }
}
