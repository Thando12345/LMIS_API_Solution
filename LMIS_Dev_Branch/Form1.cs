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
    }
}
