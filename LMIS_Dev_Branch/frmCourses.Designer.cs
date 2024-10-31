namespace LMIS_Dev_Branch
{
    partial class frmCourses
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
            SuspendLayout();
            // 
            // lblCourseListHeader
            // 
            lblCourseListHeader.AutoSize = true;
            lblCourseListHeader.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourseListHeader.Location = new Point(50, 20);
            lblCourseListHeader.Name = "lblCourseListHeader";
            lblCourseListHeader.Size = new Size(195, 37);
            lblCourseListHeader.TabIndex = 1;
            lblCourseListHeader.Text = "Course List";
            lblCourseListHeader.Click += lblCourseListHeader_Click;
            // 
            // btnNavigation
            // 
            btnNavigation.BackColor = Color.Blue;
            btnNavigation.ForeColor = Color.White;
            btnNavigation.Location = new Point(700, 20);
            btnNavigation.Name = "btnNavigation";
            btnNavigation.Size = new Size(112, 42);
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
            cmbSortingOptions.Size = new Size(182, 33);
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
            // 
            // frmCourses
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 450);
            Controls.Add(btnCreateAccreditedC);
            Controls.Add(lblNonAccreditedPrograms);
            Controls.Add(lblAccreditedLearnership);
            Controls.Add(lblAccreditedSkillsPrograms);
            Controls.Add(cmbSortingOptions);
            Controls.Add(btnNavigation);
            Controls.Add(lblCourseListHeader);
            Name = "frmCourses";
            Text = "frmCourses";
            Load += frmCourses_Load;
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
    }
}