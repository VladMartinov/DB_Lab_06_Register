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
    public partial class FServices : Form
    {
        public FServices()
        {
            InitializeComponent();
        }

        private void tYPES_OF_SERVICESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tYPES_OF_SERVICESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registrationDataSet);

        }

        private void FServices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.TYPES_OF_SERVICES' table. You can move, or remove it, as needed.
            this.tYPES_OF_SERVICESTableAdapter.Fill(this.registrationDataSet.TYPES_OF_SERVICES);

        }
    }
}
