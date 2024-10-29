namespace LMIS_Dev_Branch
{
    partial class frmAdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblAdminDashboard = new Label();
            btnManageUsers = new Button();
            btnManageTemplates = new Button();
            btnViewLogs = new Button();
            btnApproveRequests = new Button();
            dgvUsers = new DataGridView();
            cmbTemplates = new ComboBox();
            lblSelectTemplate = new Label();
            mstFrmAdminDashboard = new MenuStrip();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            addCourseToolStripMenuItem = new ToolStripMenuItem();
            searchCoursesToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            registerStudentToolStripMenuItem = new ToolStripMenuItem();
            findStudentsToolStripMenuItem = new ToolStripMenuItem();
            enrollmentsToolStripMenuItem = new ToolStripMenuItem();
            enrollStudentToolStripMenuItem = new ToolStripMenuItem();
            viewEnrollmentsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            mstFrmAdminDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // lblAdminDashboard
            // 
            lblAdminDashboard.Anchor = AnchorStyles.None;
            lblAdminDashboard.AutoSize = true;
            lblAdminDashboard.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminDashboard.ForeColor = Color.DodgerBlue;
            lblAdminDashboard.Location = new Point(329, 59);
            lblAdminDashboard.Name = "lblAdminDashboard";
            lblAdminDashboard.Size = new Size(365, 54);
            lblAdminDashboard.TabIndex = 0;
            lblAdminDashboard.Text = "Admin Dashboard";
            lblAdminDashboard.Click += lblAdminDashboard_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.BackColor = Color.LightGreen;
            btnManageUsers.Location = new Point(50, 177);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(197, 59);
            btnManageUsers.TabIndex = 1;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = false;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnManageTemplates
            // 
            btnManageTemplates.BackColor = Color.LightYellow;
            btnManageTemplates.Location = new Point(50, 252);
            btnManageTemplates.Name = "btnManageTemplates";
            btnManageTemplates.Size = new Size(197, 59);
            btnManageTemplates.TabIndex = 2;
            btnManageTemplates.Text = "Manage Templates";
            btnManageTemplates.UseVisualStyleBackColor = false;
            btnManageTemplates.Click += btnManageTemplates_Click;
            // 
            // btnViewLogs
            // 
            btnViewLogs.BackColor = Color.LightBlue;
            btnViewLogs.Location = new Point(50, 320);
            btnViewLogs.Name = "btnViewLogs";
            btnViewLogs.Size = new Size(197, 59);
            btnViewLogs.TabIndex = 3;
            btnViewLogs.Text = "View Logs";
            btnViewLogs.UseVisualStyleBackColor = false;
            btnViewLogs.Click += btnViewLogs_Click;
            // 
            // btnApproveRequests
            // 
            btnApproveRequests.BackColor = Color.LightCoral;
            btnApproveRequests.Location = new Point(50, 394);
            btnApproveRequests.Name = "btnApproveRequests";
            btnApproveRequests.Size = new Size(197, 59);
            btnApproveRequests.TabIndex = 4;
            btnApproveRequests.Text = "Approve Requests";
            btnApproveRequests.UseVisualStyleBackColor = false;
            btnApproveRequests.Click += btnApproveRequests_Click;
            // 
            // dgvUsers
            // 
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(329, 177);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(550, 400);
            dgvUsers.TabIndex = 5;
            // 
            // cmbTemplates
            // 
            cmbTemplates.FormattingEnabled = true;
            cmbTemplates.Items.AddRange(new object[] { "Service SETA (SETA Accreditation No. 2301)", "ETDP SETA (ETDP-1021)", "TETA (TETA 08-156)", "HWSETA (Health and Welfare SETA)", "LGSETA (LGSETA Accreditation No. LG925P)", "CATHSETA (CATHSETA Accreditation No. 1618)" });
            cmbTemplates.Location = new Point(329, 598);
            cmbTemplates.Name = "cmbTemplates";
            cmbTemplates.Size = new Size(550, 33);
            cmbTemplates.TabIndex = 6;
            // 
            // lblSelectTemplate
            // 
            lblSelectTemplate.AutoSize = true;
            lblSelectTemplate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectTemplate.Location = new Point(50, 598);
            lblSelectTemplate.Name = "lblSelectTemplate";
            lblSelectTemplate.Size = new Size(241, 28);
            lblSelectTemplate.TabIndex = 7;
            lblSelectTemplate.Text = "Select Certificate Template";
            // 
            // mstFrmAdminDashboard
            // 
            mstFrmAdminDashboard.ImageScalingSize = new Size(24, 24);
            mstFrmAdminDashboard.Items.AddRange(new ToolStripItem[] { coursesToolStripMenuItem, studentsToolStripMenuItem, enrollmentsToolStripMenuItem });
            mstFrmAdminDashboard.Location = new Point(0, 0);
            mstFrmAdminDashboard.Name = "mstFrmAdminDashboard";
            mstFrmAdminDashboard.Padding = new Padding(9, 3, 0, 3);
            mstFrmAdminDashboard.Size = new Size(1131, 35);
            mstFrmAdminDashboard.TabIndex = 8;
            mstFrmAdminDashboard.Text = "menuStrip1";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCourseToolStripMenuItem, searchCoursesToolStripMenuItem });
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(91, 29);
            coursesToolStripMenuItem.Text = "Courses";
            // 
            // addCourseToolStripMenuItem
            // 
            addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            addCourseToolStripMenuItem.Size = new Size(234, 34);
            addCourseToolStripMenuItem.Text = "Add Course";
            // 
            // searchCoursesToolStripMenuItem
            // 
            searchCoursesToolStripMenuItem.Name = "searchCoursesToolStripMenuItem";
            searchCoursesToolStripMenuItem.Size = new Size(234, 34);
            searchCoursesToolStripMenuItem.Text = "Search Courses";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerStudentToolStripMenuItem, findStudentsToolStripMenuItem });
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(97, 29);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // registerStudentToolStripMenuItem
            // 
            registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            registerStudentToolStripMenuItem.Size = new Size(243, 34);
            registerStudentToolStripMenuItem.Text = "Register Student";
            // 
            // findStudentsToolStripMenuItem
            // 
            findStudentsToolStripMenuItem.Name = "findStudentsToolStripMenuItem";
            findStudentsToolStripMenuItem.Size = new Size(243, 34);
            findStudentsToolStripMenuItem.Text = "Find Students";
            // 
            // enrollmentsToolStripMenuItem
            // 
            enrollmentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enrollStudentToolStripMenuItem, viewEnrollmentsToolStripMenuItem });
            enrollmentsToolStripMenuItem.Name = "enrollmentsToolStripMenuItem";
            enrollmentsToolStripMenuItem.Size = new Size(121, 29);
            enrollmentsToolStripMenuItem.Text = "Enrollments";
            // 
            // enrollStudentToolStripMenuItem
            // 
            enrollStudentToolStripMenuItem.Name = "enrollStudentToolStripMenuItem";
            enrollStudentToolStripMenuItem.Size = new Size(249, 34);
            enrollStudentToolStripMenuItem.Text = "Enroll Student";
            // 
            // viewEnrollmentsToolStripMenuItem
            // 
            viewEnrollmentsToolStripMenuItem.Name = "viewEnrollmentsToolStripMenuItem";
            viewEnrollmentsToolStripMenuItem.Size = new Size(249, 34);
            viewEnrollmentsToolStripMenuItem.Text = "View Enrollments";
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 672);
            Controls.Add(mstFrmAdminDashboard);
            Controls.Add(lblSelectTemplate);
            Controls.Add(cmbTemplates);
            Controls.Add(dgvUsers);
            Controls.Add(btnApproveRequests);
            Controls.Add(btnViewLogs);
            Controls.Add(btnManageTemplates);
            Controls.Add(btnManageUsers);
            Controls.Add(lblAdminDashboard);
            Name = "frmAdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            mstFrmAdminDashboard.ResumeLayout(false);
            mstFrmAdminDashboard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminDashboard;
        private Button btnManageUsers;
        private Button btnManageTemplates;
        private Button btnViewLogs;
        private Button btnApproveRequests;
        private DataGridView dgvUsers;
        private ComboBox cmbTemplates;
        private Label lblSelectTemplate;
        private MenuStrip mstFrmAdminDashboard;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem addCourseToolStripMenuItem;
        private ToolStripMenuItem searchCoursesToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem registerStudentToolStripMenuItem;
        private ToolStripMenuItem findStudentsToolStripMenuItem;
        private ToolStripMenuItem enrollmentsToolStripMenuItem;
        private ToolStripMenuItem enrollStudentToolStripMenuItem;
        private ToolStripMenuItem viewEnrollmentsToolStripMenuItem;
    }
}