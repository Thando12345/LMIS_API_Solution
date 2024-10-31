namespace LMIS_Dev_Branch
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void lblAdminDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            FrmManageUsersForm FrmManageUsersForm = new FrmManageUsersForm();
            FrmManageUsersForm.ShowDialog();
        }

        private void btnApproveRequests_Click(object sender, EventArgs e)
        {

            FrmApproveRequestsForm FrmApproveRequestsForm = new FrmApproveRequestsForm();
            FrmApproveRequestsForm.ShowDialog();

        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {



            FrmViewLogsForm FrmViewLogsForm = new FrmViewLogsForm();
            FrmViewLogsForm.ShowDialog();


        }

        private void btnManageTemplates_Click(object sender, EventArgs e)
        {


            frmManageTemplatesForm frmManageTemplatesForm = new frmManageTemplatesForm();
            frmManageTemplatesForm.ShowDialog();
        }

        private void LblAdminGeneral_Click(object sender, EventArgs e)
        {
            FrmAdminGeneral frmAdminGeneral    = new FrmAdminGeneral();
            frmAdminGeneral.ShowDialog();
        }
    }
}
