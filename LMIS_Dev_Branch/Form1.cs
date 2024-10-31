using LMIS_Dev_Branch.Properties;

namespace LMIS_Dev_Branch
{
    public partial class frmLMIS : Form
    {
        public frmLMIS()
        {
            InitializeComponent();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCourse frmAddCourse = new FrmAddCourse();
            frmAddCourse.ShowDialog();
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStudent frmAddStudent = new FrmAddStudent();
            frmAddStudent.ShowDialog();
        }

        private void enrollStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnrol frmEnrol = new frmEnrol();
            frmEnrol.ShowDialog();
        }

        private void adminDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminDashboard frmAdminDashboard = new frmAdminDashboard();
            frmAdminDashboard.ShowDialog();
        }

        private void openDashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUserPortalMain FrmUserPortalMain = new FrmUserPortalMain();
            FrmUserPortalMain.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoginForm frmLoginForm = new FrmLoginForm();
            frmLoginForm.ShowDialog();
        }
    }
}
