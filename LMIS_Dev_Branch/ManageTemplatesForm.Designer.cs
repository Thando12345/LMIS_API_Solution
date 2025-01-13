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
            btnClose = new Button();
            Template_Name = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Last_Updated = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTemplates).BeginInit();
            msfrmManageTemplatesForm.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTemplates
            // 
            dgvTemplates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTemplates.Columns.AddRange(new DataGridViewColumn[] { Template_Name, Type, Last_Updated });
            dgvTemplates.Location = new Point(72, 142);
            dgvTemplates.Name = "dgvTemplates";
            dgvTemplates.RowHeadersWidth = 62;
            dgvTemplates.Size = new Size(1149, 400);
            dgvTemplates.TabIndex = 0;
            // 
            // btnAddTemplate
            // 
            btnAddTemplate.BackColor = Color.LightGreen;
            btnAddTemplate.Location = new Point(1237, 142);
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
            btnEditTemplate.Location = new Point(1237, 196);
            btnEditTemplate.Name = "btnEditTemplate";
            btnEditTemplate.Size = new Size(147, 48);
            btnEditTemplate.TabIndex = 2;
            btnEditTemplate.Text = "Edit Template";
            btnEditTemplate.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTemplate
            // 
            btnDeleteTemplate.BackColor = Color.LightCoral;
            btnDeleteTemplate.Location = new Point(1237, 246);
            btnDeleteTemplate.Name = "btnDeleteTemplate";
            btnDeleteTemplate.Size = new Size(147, 48);
            btnDeleteTemplate.TabIndex = 3;
            btnDeleteTemplate.Text = "Delete Template";
            btnDeleteTemplate.UseVisualStyleBackColor = false;
            // 
            // cmbTemplateType
            // 
            cmbTemplateType.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTemplateType.FormattingEnabled = true;
            cmbTemplateType.Items.AddRange(new object[] { "Certificate", "Report" });
            cmbTemplateType.Location = new Point(72, 86);
            cmbTemplateType.Name = "cmbTemplateType";
            cmbTemplateType.Size = new Size(289, 33);
            cmbTemplateType.TabIndex = 4;
            cmbTemplateType.Text = "Select Template Type";
            // 
            // msfrmManageTemplatesForm
            // 
            msfrmManageTemplatesForm.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msfrmManageTemplatesForm.ImageScalingSize = new Size(24, 24);
            msfrmManageTemplatesForm.Items.AddRange(new ToolStripItem[] { coursesToolStripMenuItem, studentsToolStripMenuItem, enrollmentsToolStripMenuItem });
            msfrmManageTemplatesForm.Location = new Point(0, 0);
            msfrmManageTemplatesForm.Name = "msfrmManageTemplatesForm";
            msfrmManageTemplatesForm.Padding = new Padding(9, 3, 0, 3);
            msfrmManageTemplatesForm.Size = new Size(1406, 33);
            msfrmManageTemplatesForm.TabIndex = 5;
            msfrmManageTemplatesForm.Text = "menuStrip1";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCourseToolStripMenuItem, searchCoursesToolStripMenuItem });
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(99, 27);
            coursesToolStripMenuItem.Text = "Courses";
            // 
            // addCourseToolStripMenuItem
            // 
            addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            addCourseToolStripMenuItem.Size = new Size(270, 34);
            addCourseToolStripMenuItem.Text = "Add Course";
            // 
            // searchCoursesToolStripMenuItem
            // 
            searchCoursesToolStripMenuItem.Name = "searchCoursesToolStripMenuItem";
            searchCoursesToolStripMenuItem.Size = new Size(270, 34);
            searchCoursesToolStripMenuItem.Text = "Search Courses";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerStudentToolStripMenuItem, findStudentsToolStripMenuItem });
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(103, 27);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // registerStudentToolStripMenuItem
            // 
            registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            registerStudentToolStripMenuItem.Size = new Size(257, 34);
            registerStudentToolStripMenuItem.Text = "Register Student";
            // 
            // findStudentsToolStripMenuItem
            // 
            findStudentsToolStripMenuItem.Name = "findStudentsToolStripMenuItem";
            findStudentsToolStripMenuItem.Size = new Size(257, 34);
            findStudentsToolStripMenuItem.Text = "Find Students";
            // 
            // enrollmentsToolStripMenuItem
            // 
            enrollmentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enrollStudentToolStripMenuItem, viewEnrollmentsToolStripMenuItem });
            enrollmentsToolStripMenuItem.Name = "enrollmentsToolStripMenuItem";
            enrollmentsToolStripMenuItem.Size = new Size(128, 27);
            enrollmentsToolStripMenuItem.Text = "Enrollments";
            // 
            // enrollStudentToolStripMenuItem
            // 
            enrollStudentToolStripMenuItem.Name = "enrollStudentToolStripMenuItem";
            enrollStudentToolStripMenuItem.Size = new Size(270, 34);
            enrollStudentToolStripMenuItem.Text = "Enroll Student";
            // 
            // viewEnrollmentsToolStripMenuItem
            // 
            viewEnrollmentsToolStripMenuItem.Name = "viewEnrollmentsToolStripMenuItem";
            viewEnrollmentsToolStripMenuItem.Size = new Size(270, 34);
            viewEnrollmentsToolStripMenuItem.Text = "View Enrollments";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1237, 494);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 48);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Template_Name
            // 
            Template_Name.HeaderText = "Template Name";
            Template_Name.MinimumWidth = 8;
            Template_Name.Name = "Template_Name";
            Template_Name.Width = 360;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 8;
            Type.Name = "Type";
            Type.Width = 360;
            // 
            // Last_Updated
            // 
            Last_Updated.HeaderText = "Last Updated";
            Last_Updated.MinimumWidth = 8;
            Last_Updated.Name = "Last_Updated";
            Last_Updated.Width = 360;
            // 
            // frmManageTemplatesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 582);
            Controls.Add(btnClose);
            Controls.Add(msfrmManageTemplatesForm);
            Controls.Add(cmbTemplateType);
            Controls.Add(btnDeleteTemplate);
            Controls.Add(btnEditTemplate);
            Controls.Add(btnAddTemplate);
            Controls.Add(dgvTemplates);
            Name = "frmManageTemplatesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageTemplatesForm";
            ((System.ComponentModel.ISupportInitialize)dgvTemplates).EndInit();
            msfrmManageTemplatesForm.ResumeLayout(false);
            msfrmManageTemplatesForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTemplates;
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
        private Button btnClose;
        private DataGridViewTextBoxColumn Template_Name;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Last_Updated;
    }
}