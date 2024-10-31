namespace LMIS_Dev_Branch
{
    partial class FrmAdminGeneral
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
            lblAdminScreenTitle = new Label();
            lblUserRolesSection = new Label();
            dgvUserRoles = new DataGridView();
            Role_Name = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewTextBoxColumn();
            btnEditRole = new Button();
            lblAdminActionsSection = new Label();
            btnCreateUsers = new Button();
            btnLoadTemplates = new Button();
            btnViewLogs = new Button();
            btnAuthorizeCertificates = new Button();
            btnAuthorizeCourses = new Button();
            btnCreateUserRole = new Button();
            lblAccreditationInfo = new Label();
            dgvAccreditationList = new DataGridView();
            AccreditationBody = new DataGridViewTextBoxColumn();
            AccreditationNumber = new DataGridViewTextBoxColumn();
            Manage = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnLoadAccreditationTemplates = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUserRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccreditationList).BeginInit();
            SuspendLayout();
            // 
            // lblAdminScreenTitle
            // 
            lblAdminScreenTitle.AutoSize = true;
            lblAdminScreenTitle.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminScreenTitle.ForeColor = Color.Blue;
            lblAdminScreenTitle.Location = new Point(412, 9);
            lblAdminScreenTitle.Name = "lblAdminScreenTitle";
            lblAdminScreenTitle.Size = new Size(363, 56);
            lblAdminScreenTitle.TabIndex = 0;
            lblAdminScreenTitle.Text = "Admin General";
            // 
            // lblUserRolesSection
            // 
            lblUserRolesSection.AutoSize = true;
            lblUserRolesSection.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserRolesSection.ForeColor = Color.Orange;
            lblUserRolesSection.Location = new Point(50, 80);
            lblUserRolesSection.Name = "lblUserRolesSection";
            lblUserRolesSection.Size = new Size(291, 29);
            lblUserRolesSection.TabIndex = 1;
            lblUserRolesSection.Text = "User Roles Management";
            // 
            // dgvUserRoles
            // 
            dgvUserRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserRoles.Columns.AddRange(new DataGridViewColumn[] { Role_Name, Description, Actions });
            dgvUserRoles.Location = new Point(50, 120);
            dgvUserRoles.Name = "dgvUserRoles";
            dgvUserRoles.RowHeadersWidth = 62;
            dgvUserRoles.Size = new Size(678, 225);
            dgvUserRoles.TabIndex = 2;
            // 
            // Role_Name
            // 
            Role_Name.HeaderText = "Role Name";
            Role_Name.MinimumWidth = 8;
            Role_Name.Name = "Role_Name";
            Role_Name.Width = 150;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.Width = 150;
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.MinimumWidth = 8;
            Actions.Name = "Actions";
            Actions.Width = 150;
            // 
            // btnEditRole
            // 
            btnEditRole.BackColor = Color.Teal;
            btnEditRole.Location = new Point(567, 151);
            btnEditRole.Name = "btnEditRole";
            btnEditRole.Size = new Size(112, 40);
            btnEditRole.TabIndex = 3;
            btnEditRole.Text = "Edit";
            btnEditRole.UseVisualStyleBackColor = false;
            btnEditRole.Click += btnEditRole_Click;
            // 
            // lblAdminActionsSection
            // 
            lblAdminActionsSection.AutoSize = true;
            lblAdminActionsSection.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminActionsSection.ForeColor = Color.YellowGreen;
            lblAdminActionsSection.Location = new Point(50, 361);
            lblAdminActionsSection.Name = "lblAdminActionsSection";
            lblAdminActionsSection.Size = new Size(182, 29);
            lblAdminActionsSection.TabIndex = 4;
            lblAdminActionsSection.Text = "Admin Actions";
            // 
            // btnCreateUsers
            // 
            btnCreateUsers.BackColor = Color.Teal;
            btnCreateUsers.Location = new Point(50, 400);
            btnCreateUsers.Name = "btnCreateUsers";
            btnCreateUsers.Size = new Size(180, 48);
            btnCreateUsers.TabIndex = 5;
            btnCreateUsers.Text = "Create Users";
            btnCreateUsers.UseVisualStyleBackColor = false;
            // 
            // btnLoadTemplates
            // 
            btnLoadTemplates.BackColor = Color.Blue;
            btnLoadTemplates.Location = new Point(250, 400);
            btnLoadTemplates.Name = "btnLoadTemplates";
            btnLoadTemplates.Size = new Size(180, 48);
            btnLoadTemplates.TabIndex = 6;
            btnLoadTemplates.Text = "Load All Templates";
            btnLoadTemplates.UseVisualStyleBackColor = false;
            // 
            // btnViewLogs
            // 
            btnViewLogs.BackColor = Color.Orange;
            btnViewLogs.Location = new Point(450, 400);
            btnViewLogs.Name = "btnViewLogs";
            btnViewLogs.Size = new Size(180, 48);
            btnViewLogs.TabIndex = 7;
            btnViewLogs.Text = "View Logs";
            btnViewLogs.UseVisualStyleBackColor = false;
            // 
            // btnAuthorizeCertificates
            // 
            btnAuthorizeCertificates.BackColor = Color.Blue;
            btnAuthorizeCertificates.Location = new Point(650, 400);
            btnAuthorizeCertificates.Name = "btnAuthorizeCertificates";
            btnAuthorizeCertificates.Size = new Size(190, 48);
            btnAuthorizeCertificates.TabIndex = 8;
            btnAuthorizeCertificates.Text = "Authorize Certificates";
            btnAuthorizeCertificates.UseVisualStyleBackColor = false;
            btnAuthorizeCertificates.Click += btnAuthorizeCertificates_Click;
            // 
            // btnAuthorizeCourses
            // 
            btnAuthorizeCourses.BackColor = Color.Green;
            btnAuthorizeCourses.Location = new Point(850, 400);
            btnAuthorizeCourses.Name = "btnAuthorizeCourses";
            btnAuthorizeCourses.Size = new Size(190, 48);
            btnAuthorizeCourses.TabIndex = 9;
            btnAuthorizeCourses.Text = "Authorize Courses\n";
            btnAuthorizeCourses.UseVisualStyleBackColor = false;
            // 
            // btnCreateUserRole
            // 
            btnCreateUserRole.BackColor = Color.Green;
            btnCreateUserRole.Location = new Point(50, 470);
            btnCreateUserRole.Name = "btnCreateUserRole";
            btnCreateUserRole.Size = new Size(190, 48);
            btnCreateUserRole.TabIndex = 10;
            btnCreateUserRole.Text = "Create User Role";
            btnCreateUserRole.UseVisualStyleBackColor = false;
            // 
            // lblAccreditationInfo
            // 
            lblAccreditationInfo.AutoSize = true;
            lblAccreditationInfo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccreditationInfo.ForeColor = Color.Orange;
            lblAccreditationInfo.Location = new Point(50, 540);
            lblAccreditationInfo.Name = "lblAccreditationInfo";
            lblAccreditationInfo.Size = new Size(306, 29);
            lblAccreditationInfo.TabIndex = 11;
            lblAccreditationInfo.Text = "Accreditation Information";
            // 
            // dgvAccreditationList
            // 
            dgvAccreditationList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccreditationList.Columns.AddRange(new DataGridViewColumn[] { AccreditationBody, AccreditationNumber, Manage });
            dgvAccreditationList.Location = new Point(50, 580);
            dgvAccreditationList.Name = "dgvAccreditationList";
            dgvAccreditationList.RowHeadersWidth = 62;
            dgvAccreditationList.Size = new Size(660, 150);
            dgvAccreditationList.TabIndex = 12;
            dgvAccreditationList.CellContentClick += dgvAccreditationList_CellContentClick;
            // 
            // AccreditationBody
            // 
            AccreditationBody.HeaderText = " Accreditation Body";
            AccreditationBody.MinimumWidth = 8;
            AccreditationBody.Name = "AccreditationBody";
            AccreditationBody.Width = 150;
            // 
            // AccreditationNumber
            // 
            AccreditationNumber.HeaderText = "Accreditation No.";
            AccreditationNumber.MinimumWidth = 8;
            AccreditationNumber.Name = "AccreditationNumber";
            AccreditationNumber.Width = 150;
            // 
            // Manage
            // 
            Manage.HeaderText = "Manage";
            Manage.MinimumWidth = 8;
            Manage.Name = "Manage";
            Manage.Width = 150;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Teal;
            btnEdit.Location = new Point(567, 660);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 40);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += button1_Click;
            // 
            // btnLoadAccreditationTemplates
            // 
            btnLoadAccreditationTemplates.BackColor = Color.Blue;
            btnLoadAccreditationTemplates.Location = new Point(50, 750);
            btnLoadAccreditationTemplates.Name = "btnLoadAccreditationTemplates";
            btnLoadAccreditationTemplates.Size = new Size(262, 48);
            btnLoadAccreditationTemplates.TabIndex = 14;
            btnLoadAccreditationTemplates.Text = "Load Accreditation Templates\n";
            btnLoadAccreditationTemplates.UseVisualStyleBackColor = false;
            // 
            // FrmAdminGeneral
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 881);
            Controls.Add(btnLoadAccreditationTemplates);
            Controls.Add(btnEdit);
            Controls.Add(dgvAccreditationList);
            Controls.Add(lblAccreditationInfo);
            Controls.Add(btnCreateUserRole);
            Controls.Add(btnAuthorizeCourses);
            Controls.Add(btnAuthorizeCertificates);
            Controls.Add(btnViewLogs);
            Controls.Add(btnLoadTemplates);
            Controls.Add(btnCreateUsers);
            Controls.Add(lblAdminActionsSection);
            Controls.Add(btnEditRole);
            Controls.Add(dgvUserRoles);
            Controls.Add(lblUserRolesSection);
            Controls.Add(lblAdminScreenTitle);
            ForeColor = Color.White;
            Name = "FrmAdminGeneral";
            Text = "FrmAdminGeneral";
            Load += FrmAdminGeneral_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUserRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccreditationList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminScreenTitle;
        private Label lblUserRolesSection;
        private DataGridView dgvUserRoles;
        private DataGridViewTextBoxColumn Role_Name;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Actions;
        private Button btnEditRole;
        private Label lblAdminActionsSection;
        private Button btnCreateUsers;
        private Button btnLoadTemplates;
        private Button btnViewLogs;
        private Button btnAuthorizeCertificates;
        private Button btnAuthorizeCourses;
        private Button btnCreateUserRole;
        private Label lblAccreditationInfo;
        private DataGridView dgvAccreditationList;
        private DataGridViewTextBoxColumn AccreditationBody;
        private DataGridViewTextBoxColumn AccreditationNumber;
        private DataGridViewTextBoxColumn Manage;
        private Button btnEdit;
        private Button btnLoadAccreditationTemplates;
    }
}