
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMIS_Dev_Branch
{
    public partial class frmLearnerInformation : Form
    {
        public frmLearnerInformation()
        {
            InitializeComponent();


        }



        private void TxtSearchLearner_Leave(object sender, EventArgs e)
        {
            toolTip1.Hide(txtSearchLearner);
        }

        // Initialize and set tooltip properties in the Popup event
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            // Ensure tooltip settings only for txtSearchLearner
            if (e.AssociatedControl == txtSearchLearner)
            {
                toolTip1.ToolTipTitle = "Search Box";
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
                toolTip1.IsBalloon = true;

                // Set tooltip text if not already set
                toolTip1.SetToolTip(txtSearchLearner, "Enter Learner ID or Surname to search.");
            }
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void frmLearnerInformation_Load(object sender, EventArgs e)
        {

        }

        private void btnUploadQualification_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtProgrammeDates_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
