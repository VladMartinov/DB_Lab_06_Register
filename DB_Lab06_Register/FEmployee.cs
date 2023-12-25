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
    public partial class FEmployee : Form
    {
        public FEmployee()
        {
            InitializeComponent();
        }

        private void eMPLOYEE_DIRECTORYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLOYEE_DIRECTORYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registrationDataSet);

        }

        private void FEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.EMPLOYEE_DIRECTORY' table. You can move, or remove it, as needed.
            this.eMPLOYEE_DIRECTORYTableAdapter.Fill(this.registrationDataSet.EMPLOYEE_DIRECTORY);

        }
    }
}
