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
    public partial class FrmUserPortalMain : Form
    {
        public FrmUserPortalMain()
        {
            InitializeComponent();
        }

        private void btnEnrollLearner_Click(object sender, EventArgs e)
        {
            frmLearnerInformation frmLearnerInformation = new frmLearnerInformation();
            frmLearnerInformation.ShowDialog();
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            frmCourses1 frmCourses1 = new frmCourses1();
            frmCourses1.ShowDialog();
        }
    }
}
