using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMIS_Dev_Branch
{
    public partial class frmPractitionersViewScreen : Form
    {
        public frmPractitionersViewScreen()
        {
            InitializeComponent();
        }

        private void btnCreatePractitioner_Click(object sender, EventArgs e)
        {
            frmPractitionerCreateEditScreen frmPractitionerCreateEditScreen = new frmPractitionerCreateEditScreen();
            frmPractitionerCreateEditScreen.ShowDialog();
        }
    }
}
