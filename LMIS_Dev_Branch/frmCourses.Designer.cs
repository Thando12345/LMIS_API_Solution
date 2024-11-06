namespace LMIS_Dev_Branch
{
    partial class frmCourses1
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
            lblCourseListHeader = new Label();
            btnNavigation = new Button();
            cmbSortingOptions = new ComboBox();
            lblAccreditedSkillsPrograms = new Label();
            lblAccreditedLearnership = new Label();
            lblNonAccreditedPrograms = new Label();
            btnCreateAccreditedC = new Button();
            dgvCourses = new DataGridView();
            CourseName = new DataGridViewTextBoxColumn();
            CourseType = new DataGridViewTextBoxColumn();
            Credits = new DataGridViewTextBoxColumn();
            NQFLevel = new DataGridViewTextBoxColumn();
            IsAccredited = new DataGridViewTextBoxColumn();
            btnCreateCourse = new Button();
            btnCreateNonAccreditedCourse = new Button();
            txtCourseName = new TextBox();
            txtCourseType = new TextBox();
            textBox1 = new TextBox();
            txtNQFLevel = new TextBox();
            chkIsAccredited = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // lblCourseListHeader
            // 
            lblCourseListHeader.AutoSize = true;
            lblCourseListHeader.BackColor = Color.Orange;
            lblCourseListHeader.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourseListHeader.ForeColor = Color.White;
            lblCourseListHeader.Location = new Point(50, 20);
            lblCourseListHeader.Name = "lblCourseListHeader";
            lblCourseListHeader.Size = new Size(195, 37);
            lblCourseListHeader.TabIndex = 1;
            lblCourseListHeader.Text = "Course List";
            // 
            // btnNavigation
            // 
            btnNavigation.BackColor = Color.Blue;
            btnNavigation.ForeColor = Color.White;
            btnNavigation.Location = new Point(700, 20);
            btnNavigation.Name = "btnNavigation";
            btnNavigation.Size = new Size(117, 42);
            btnNavigation.TabIndex = 2;
            btnNavigation.Text = "Navigate";
            btnNavigation.UseVisualStyleBackColor = false;
            btnNavigation.Click += btnNavigation_Click;
            // 
            // cmbSortingOptions
            // 
            cmbSortingOptions.FormattingEnabled = true;
            cmbSortingOptions.Items.AddRange(new object[] { "Alphabetical", "Date Created", "Most Recent" });
            cmbSortingOptions.Location = new Point(700, 68);
            cmbSortingOptions.Name = "cmbSortingOptions";
            cmbSortingOptions.Size = new Size(182, 35);
            cmbSortingOptions.TabIndex = 3;
            cmbSortingOptions.Text = "Sort by";
            // 
            // lblAccreditedSkillsPrograms
            // 
            lblAccreditedSkillsPrograms.AutoSize = true;
            lblAccreditedSkillsPrograms.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccreditedSkillsPrograms.Location = new Point(50, 120);
            lblAccreditedSkillsPrograms.Name = "lblAccreditedSkillsPrograms";
            lblAccreditedSkillsPrograms.Size = new Size(324, 29);
            lblAccreditedSkillsPrograms.TabIndex = 4;
            lblAccreditedSkillsPrograms.Text = "Accredited Skills Programs";
            // 
            // lblAccreditedLearnership
            // 
            lblAccreditedLearnership.AutoSize = true;
            lblAccreditedLearnership.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccreditedLearnership.Location = new Point(50, 200);
            lblAccreditedLearnership.Name = "lblAccreditedLearnership";
            lblAccreditedLearnership.Size = new Size(280, 29);
            lblAccreditedLearnership.TabIndex = 5;
            lblAccreditedLearnership.Text = "Accredited Learnership";
            // 
            // lblNonAccreditedPrograms
            // 
            lblNonAccreditedPrograms.AutoSize = true;
            lblNonAccreditedPrograms.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNonAccreditedPrograms.Location = new Point(50, 280);
            lblNonAccreditedPrograms.Name = "lblNonAccreditedPrograms";
            lblNonAccreditedPrograms.Size = new Size(191, 29);
            lblNonAccreditedPrograms.TabIndex = 6;
            lblNonAccreditedPrograms.Text = "Non-Accredited";
            // 
            // btnCreateAccreditedC
            // 
            btnCreateAccreditedC.BackColor = Color.Blue;
            btnCreateAccreditedC.ForeColor = Color.White;
            btnCreateAccreditedC.Location = new Point(50, 360);
            btnCreateAccreditedC.Name = "btnCreateAccreditedC";
            btnCreateAccreditedC.Size = new Size(240, 42);
            btnCreateAccreditedC.TabIndex = 7;
            btnCreateAccreditedC.Text = "Create Accredited Course";
            btnCreateAccreditedC.UseVisualStyleBackColor = false;
            btnCreateAccreditedC.Click += btnCreateAccreditedC_Click;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Columns.AddRange(new DataGridViewColumn[] { CourseName, CourseType, Credits, NQFLevel, IsAccredited });
            dgvCourses.Location = new Point(50, 420);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.RowHeadersWidth = 62;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(800, 150);
            dgvCourses.TabIndex = 8;
            // 
            // CourseName
            // 
            CourseName.HeaderText = "Course Name";
            CourseName.MinimumWidth = 8;
            CourseName.Name = "CourseName";
            CourseName.ReadOnly = true;
            // 
            // CourseType
            // 
            CourseType.HeaderText = "Course Type";
            CourseType.MinimumWidth = 8;
            CourseType.Name = "CourseType";
            CourseType.ReadOnly = true;
            // 
            // Credits
            // 
            Credits.HeaderText = "Credits";
            Credits.MinimumWidth = 8;
            Credits.Name = "Credits";
            Credits.ReadOnly = true;
            // 
            // NQFLevel
            // 
            NQFLevel.HeaderText = "NQF Level";
            NQFLevel.MinimumWidth = 8;
            NQFLevel.Name = "NQFLevel";
            NQFLevel.ReadOnly = true;
            // 
            // IsAccredited
            // 
            IsAccredited.HeaderText = "Is Accredited";
            IsAccredited.MinimumWidth = 8;
            IsAccredited.Name = "IsAccredited";
            IsAccredited.ReadOnly = true;
            // 
            // btnCreateCourse
            // 
            btnCreateCourse.BackColor = Color.Blue;
            btnCreateCourse.ForeColor = Color.White;
            btnCreateCourse.Location = new Point(652, 599);
            btnCreateCourse.Name = "btnCreateCourse";
            btnCreateCourse.Size = new Size(198, 38);
            btnCreateCourse.TabIndex = 9;
            btnCreateCourse.Text = "Create New Course";
            btnCreateCourse.UseVisualStyleBackColor = false;
            btnCreateCourse.Click += btnCreateCourse_Click;
            // 
            // btnCreateNonAccreditedCourse
            // 
            btnCreateNonAccreditedCourse.BackColor = Color.Blue;
            btnCreateNonAccreditedCourse.ForeColor = Color.White;
            btnCreateNonAccreditedCourse.Location = new Point(312, 360);
            btnCreateNonAccreditedCourse.Name = "btnCreateNonAccreditedCourse";
            btnCreateNonAccreditedCourse.Size = new Size(271, 42);
            btnCreateNonAccreditedCourse.TabIndex = 10;
            btnCreateNonAccreditedCourse.Text = "Create Non-Accredited Course";
            btnCreateNonAccreditedCourse.UseVisualStyleBackColor = false;
            btnCreateNonAccreditedCourse.Click += btnCreateNonAccreditedCourse_Click;
            // 
            // txtCourseName
            // 
            txtCourseName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourseName.Location = new Point(357, 161);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.PlaceholderText = "Course Name";
            txtCourseName.Size = new Size(200, 35);
            txtCourseName.TabIndex = 11;
            // 
            // txtCourseType
            // 
            txtCourseType.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourseType.Location = new Point(357, 201);
            txtCourseType.Name = "txtCourseType";
            txtCourseType.PlaceholderText = "Course Type";
            txtCourseType.Size = new Size(200, 35);
            txtCourseType.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 31);
            textBox1.TabIndex = 0;
            // 
            // txtNQFLevel
            // 
            txtNQFLevel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNQFLevel.Location = new Point(357, 241);
            txtNQFLevel.Name = "txtNQFLevel";
            txtNQFLevel.PlaceholderText = "NQF Level";
            txtNQFLevel.Size = new Size(200, 35);
            txtNQFLevel.TabIndex = 13;
            // 
            // chkIsAccredited
            // 
            chkIsAccredited.AutoSize = true;
            chkIsAccredited.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkIsAccredited.Location = new Point(357, 281);
            chkIsAccredited.Name = "chkIsAccredited";
            chkIsAccredited.Size = new Size(235, 31);
            chkIsAccredited.TabIndex = 14;
            chkIsAccredited.Text = "Accredited Course";
            chkIsAccredited.UseVisualStyleBackColor = true;
            // 
            // frmCourses1
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(904, 675);
            Controls.Add(chkIsAccredited);
            Controls.Add(txtNQFLevel);
            Controls.Add(txtCourseType);
            Controls.Add(txtCourseName);
            Controls.Add(btnCreateNonAccreditedCourse);
            Controls.Add(btnCreateCourse);
            Controls.Add(dgvCourses);
            Controls.Add(btnCreateAccreditedC);
            Controls.Add(lblNonAccreditedPrograms);
            Controls.Add(lblAccreditedLearnership);
            Controls.Add(lblAccreditedSkillsPrograms);
            Controls.Add(cmbSortingOptions);
            Controls.Add(btnNavigation);
            Controls.Add(lblCourseListHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            Name = "frmCourses1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Management";
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCourseListHeader;
        private Button btnNavigation;
        private ComboBox cmbSortingOptions;
        private Label lblAccreditedSkillsPrograms;
        private Label lblAccreditedLearnership;
        private Label lblNonAccreditedPrograms;
        private Button btnCreateAccreditedC;
        private DataGridView dgvCourses;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn CourseType;
        private DataGridViewTextBoxColumn Credits;
        private DataGridViewTextBoxColumn NQFLevel;
        private DataGridViewTextBoxColumn IsAccredited;
        private Button btnCreateCourse;
        private Button btnCreateNonAccreditedCourse;
        private TextBox txtCourseName;
        private TextBox txtCourseType;
        private TextBox textBox1;
        private TextBox txtNQFLevel;
        private CheckBox chkIsAccredited;
    }
}
