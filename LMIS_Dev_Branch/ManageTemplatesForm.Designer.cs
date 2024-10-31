namespace LMIS_Dev_Branch
{
    partial class frmManageTemplatesForm
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
            dgvTemplates = new DataGridView();
            Template_Name = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Last_Updated = new DataGridViewTextBoxColumn();
            btnAddTemplate = new Button();
            btnEditTemplate = new Button();
            btnDeleteTemplate = new Button();
            cmbTemplateType = new ComboBox();
            msfrmManageTemplatesForm = new MenuStrip();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            addCourseToolStripMenuItem = new ToolStripMenuItem();
            searchCoursesToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            registerStudentToolStripMenuItem = new ToolStripMenuItem();
            findStudentsToolStripMenuItem = new ToolStripMenuItem();
            enrollmentsToolStripMenuItem = new ToolStripMenuItem();
            enrollStudentToolStripMenuItem = new ToolStripMenuItem();
            viewEnrollmentsToolStripMenuItem = new ToolStripMenuItem();
            adminDashboardToolStripMenuItem = new ToolStripMenuItem();
            openDashboardToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvTemplates).BeginInit();
            msfrmManageTemplatesForm.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTemplates
            // 
            dgvTemplates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTemplates.Columns.AddRange(new DataGridViewColumn[] { Template_Name, Type, Last_Updated });
            dgvTemplates.Location = new Point(50, 100);
            dgvTemplates.Name = "dgvTemplates";
            dgvTemplates.RowHeadersWidth = 62;
            dgvTemplates.Size = new Size(550, 400);
            dgvTemplates.TabIndex = 0;
            // 
            // Template_Name
            // 
            Template_Name.HeaderText = "Template Name";
            Template_Name.MinimumWidth = 8;
            Template_Name.Name = "Template_Name";
            Template_Name.Width = 150;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 8;
            Type.Name = "Type";
            Type.Width = 150;
            // 
            // Last_Updated
            // 
            Last_Updated.HeaderText = "Last Updated";
            Last_Updated.MinimumWidth = 8;
            Last_Updated.Name = "Last_Updated";
            Last_Updated.Width = 150;
            // 
            // btnAddTemplate
            // 
            btnAddTemplate.BackColor = Color.LightGreen;
            btnAddTemplate.Location = new Point(620, 100);
            btnAddTemplate.Name = "btnAddTemplate";
            btnAddTemplate.Size = new Size(147, 48);
            btnAddTemplate.TabIndex = 1;
            btnAddTemplate.Text = "Add Template";
            btnAddTemplate.UseVisualStyleBackColor = false;
            btnAddTemplate.Click += btnAddTemplate_Click;
            // 
            // btnEditTemplate
            // 
            btnEditTemplate.BackColor = Color.LightYellow;
            btnEditTemplate.Location = new Point(620, 154);
            btnEditTemplate.Name = "btnEditTemplate";
            btnEditTemplate.Size = new Size(147, 48);
            btnEditTemplate.TabIndex = 2;
            btnEditTemplate.Text = "Edit Template";
            btnEditTemplate.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTemplate
            // 
            btnDeleteTemplate.BackColor = Color.LightCoral;
            btnDeleteTemplate.Location = new Point(620, 204);
            btnDeleteTemplate.Name = "btnDeleteTemplate";
            btnDeleteTemplate.Size = new Size(147, 48);
            btnDeleteTemplate.TabIndex = 3;
            btnDeleteTemplate.Text = "Delete Template";
            btnDeleteTemplate.UseVisualStyleBackColor = false;
            // 
            // cmbTemplateType
            // 
            cmbTemplateType.FormattingEnabled = true;
            cmbTemplateType.Items.AddRange(new object[] { "Certificate", "Report" });
            cmbTemplateType.Location = new Point(50, 50);
            cmbTemplateType.Name = "cmbTemplateType";
            cmbTemplateType.Size = new Size(195, 33);
            cmbTemplateType.TabIndex = 4;
            cmbTemplateType.Text = "Select Template Type";
            // 
            // msfrmManageTemplatesForm
            // 
            msfrmManageTemplatesForm.ImageScalingSize = new Size(24, 24);
            msfrmManageTemplatesForm.Items.AddRange(new ToolStripItem[] { coursesToolStripMenuItem, studentsToolStripMenuItem, enrollmentsToolStripMenuItem, adminDashboardToolStripMenuItem });
            msfrmManageTemplatesForm.Location = new Point(0, 0);
            msfrmManageTemplatesForm.Name = "msfrmManageTemplatesForm";
            msfrmManageTemplatesForm.Padding = new Padding(9, 3, 0, 3);
            msfrmManageTemplatesForm.Size = new Size(1141, 35);
            msfrmManageTemplatesForm.TabIndex = 5;
            msfrmManageTemplatesForm.Text = "menuStrip1";
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
            // adminDashboardToolStripMenuItem
            // 
            adminDashboardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openDashboardToolStripMenuItem });
            adminDashboardToolStripMenuItem.Name = "adminDashboardToolStripMenuItem";
            adminDashboardToolStripMenuItem.Size = new Size(174, 29);
            adminDashboardToolStripMenuItem.Text = "Admin Dashboard";
            // 
            // openDashboardToolStripMenuItem
            // 
            openDashboardToolStripMenuItem.Name = "openDashboardToolStripMenuItem";
            openDashboardToolStripMenuItem.Size = new Size(251, 34);
            openDashboardToolStripMenuItem.Text = "Open Dashboard";
            // 
            // frmManageTemplatesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 557);
            Controls.Add(msfrmManageTemplatesForm);
            Controls.Add(cmbTemplateType);
            Controls.Add(btnDeleteTemplate);
            Controls.Add(btnEditTemplate);
            Controls.Add(btnAddTemplate);
            Controls.Add(dgvTemplates);
            Name = "frmManageTemplatesForm";
            Text = "ManageTemplatesForm";
            ((System.ComponentModel.ISupportInitialize)dgvTemplates).EndInit();
            msfrmManageTemplatesForm.ResumeLayout(false);
            msfrmManageTemplatesForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTemplates;
        private DataGridViewTextBoxColumn Template_Name;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Last_Updated;
        private Button btnAddTemplate;
        private Button btnEditTemplate;
        private Button btnDeleteTemplate;
        private ComboBox cmbTemplateType;
        private MenuStrip msfrmManageTemplatesForm;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem addCourseToolStripMenuItem;
        private ToolStripMenuItem searchCoursesToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem registerStudentToolStripMenuItem;
        private ToolStripMenuItem findStudentsToolStripMenuItem;
        private ToolStripMenuItem enrollmentsToolStripMenuItem;
        private ToolStripMenuItem enrollStudentToolStripMenuItem;
        private ToolStripMenuItem viewEnrollmentsToolStripMenuItem;
        private ToolStripMenuItem adminDashboardToolStripMenuItem;
        private ToolStripMenuItem openDashboardToolStripMenuItem;
    }
}