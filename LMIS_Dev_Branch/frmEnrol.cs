using LMIS_Dev_Branch.Models;
using LMIS_Dev_Branch.Process_Handler.Course_Handlers;

namespace LMIS_Dev_Branch
{
    public partial class frmEnrol : Form
    {
        public frmEnrol()
        {
            InitializeComponent();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxCourseCode_SelectedIndexChanged(object sender, EventArgs e)
        {
           Course course = new GetCourseByIdHandler(cbxCourseCode.Text).Course;  
        }
    }
}
