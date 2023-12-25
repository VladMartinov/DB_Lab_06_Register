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
    public partial class FWards : Form
    {
        public FWards()
        {
            InitializeComponent();
        }

        private void wARDS_DIRECTORYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wARDS_DIRECTORYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registrationDataSet);

        }

        private void FWards_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.WARDS_DIRECTORY' table. You can move, or remove it, as needed.
            this.wARDS_DIRECTORYTableAdapter.Fill(this.registrationDataSet.WARDS_DIRECTORY);

        }
    }
}
