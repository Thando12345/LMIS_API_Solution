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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Get the parent form's client size
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Get the PictureBox size
            int pictureBoxWidth = pictureBox1.Width;
            int pictureBoxHeight = pictureBox1.Height;

            // Calculate the new location to center the PictureBox
            int newX = (formWidth - pictureBoxWidth) / 2;
            int newY = (formHeight - pictureBoxHeight) / 2;

            // Set the PictureBox's location
            pictureBox1.Location = new Point(newX, newY);
        }

    }
}
