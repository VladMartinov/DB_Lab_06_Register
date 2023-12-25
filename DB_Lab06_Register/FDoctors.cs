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
    public partial class FDoctors : Form
    {
        public FDoctors()
        {
            InitializeComponent();
        }

        private void dOCTORS_DIRECTORYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dOCTORS_DIRECTORYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registrationDataSet);

        }

        private void FDoctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.DOCTORS_DIRECTORY' table. You can move, or remove it, as needed.
            this.dOCTORS_DIRECTORYTableAdapter.Fill(this.registrationDataSet.DOCTORS_DIRECTORY);

        }
    }
}
