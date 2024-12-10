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
    public partial class FrmInterventionsScreen : Form
    {
        public FrmInterventionsScreen()
        {
            InitializeComponent();
        }

        private void dgvCourseDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateIntervention_Click(object sender, EventArgs e)
        {
            FrmCreateInterventionScreen FrmCreateInterventionScreen = new FrmCreateInterventionScreen();
            FrmCreateInterventionScreen.ShowDialog();
        }
    }
}
