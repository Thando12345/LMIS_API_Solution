namespace LMIS_Dev_Branch
{
    partial class frmLMIS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            openDashboardToolStripMenuItem1 = new ToolStripMenuItem();
            loginPageToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { coursesToolStripMenuItem, studentsToolStripMenuItem, enrollmentsToolStripMenuItem, adminDashboardToolStripMenuItem, toolStripMenuItem1, loginPageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1634, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCourseToolStripMenuItem, searchCoursesToolStripMenuItem });
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(93, 25);
            coursesToolStripMenuItem.Text = "Courses";
            coursesToolStripMenuItem.Click += coursesToolStripMenuItem_Click;
            // 
            // addCourseToolStripMenuItem
            // 
            addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            addCourseToolStripMenuItem.Size = new Size(239, 34);
            addCourseToolStripMenuItem.Text = "Add Course";
            addCourseToolStripMenuItem.Click += addCourseToolStripMenuItem_Click;
            // 
            // searchCoursesToolStripMenuItem
            // 
            searchCoursesToolStripMenuItem.Name = "searchCoursesToolStripMenuItem";
            searchCoursesToolStripMenuItem.Size = new Size(239, 34);
            searchCoursesToolStripMenuItem.Text = "Search Courses";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerStudentToolStripMenuItem, findStudentsToolStripMenuItem });
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(97, 25);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // registerStudentToolStripMenuItem
            // 
            registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            registerStudentToolStripMenuItem.Size = new Size(244, 34);
            registerStudentToolStripMenuItem.Text = "Register Student";
            registerStudentToolStripMenuItem.Click += registerStudentToolStripMenuItem_Click;
            // 
            // findStudentsToolStripMenuItem
            // 
            findStudentsToolStripMenuItem.Name = "findStudentsToolStripMenuItem";
            findStudentsToolStripMenuItem.Size = new Size(244, 34);
            findStudentsToolStripMenuItem.Text = "Find Students";
            // 
            // enrollmentsToolStripMenuItem
            // 
            enrollmentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enrollStudentToolStripMenuItem, viewEnrollmentsToolStripMenuItem });
            enrollmentsToolStripMenuItem.Name = "enrollmentsToolStripMenuItem";
            enrollmentsToolStripMenuItem.Size = new Size(120, 25);
            enrollmentsToolStripMenuItem.Text = "Enrollments";
            // 
            // enrollStudentToolStripMenuItem
            // 
            enrollStudentToolStripMenuItem.Name = "enrollStudentToolStripMenuItem";
            enrollStudentToolStripMenuItem.Size = new Size(247, 34);
            enrollStudentToolStripMenuItem.Text = "Enroll Student";
            enrollStudentToolStripMenuItem.Click += enrollStudentToolStripMenuItem_Click;
            // 
            // viewEnrollmentsToolStripMenuItem
            // 
            viewEnrollmentsToolStripMenuItem.Name = "viewEnrollmentsToolStripMenuItem";
            viewEnrollmentsToolStripMenuItem.Size = new Size(247, 34);
            viewEnrollmentsToolStripMenuItem.Text = "View Enrollments";
            // 
            // adminDashboardToolStripMenuItem
            // 
            adminDashboardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openDashboardToolStripMenuItem });
            adminDashboardToolStripMenuItem.Name = "adminDashboardToolStripMenuItem";
            adminDashboardToolStripMenuItem.Size = new Size(127, 25);
            adminDashboardToolStripMenuItem.Text = "Admin Portal";
            adminDashboardToolStripMenuItem.Click += adminDashboardToolStripMenuItem_Click;
            // 
            // openDashboardToolStripMenuItem
            // 
            openDashboardToolStripMenuItem.Name = "openDashboardToolStripMenuItem";
            openDashboardToolStripMenuItem.Size = new Size(247, 34);
            openDashboardToolStripMenuItem.Text = "Open Dashboard";
            openDashboardToolStripMenuItem.Click += openDashboardToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { openDashboardToolStripMenuItem1 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(116, 25);
            toolStripMenuItem1.Text = "User Portal";
            // 
            // openDashboardToolStripMenuItem1
            // 
            openDashboardToolStripMenuItem1.Name = "openDashboardToolStripMenuItem1";
            openDashboardToolStripMenuItem1.Size = new Size(247, 34);
            openDashboardToolStripMenuItem1.Text = "Open Dashboard";
            openDashboardToolStripMenuItem1.Click += openDashboardToolStripMenuItem1_Click;
            // 
            // loginPageToolStripMenuItem
            // 
            loginPageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem });
            loginPageToolStripMenuItem.Name = "loginPageToolStripMenuItem";
            loginPageToolStripMenuItem.Size = new Size(117, 25);
            loginPageToolStripMenuItem.Text = "Login Page";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(154, 34);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.tet;
            pictureBox1.Location = new Point(106, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1024, 800);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmLMIS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 638);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLMIS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LMS";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem enrollmentsToolStripMenuItem;
        private ToolStripMenuItem addCourseToolStripMenuItem;
        private ToolStripMenuItem registerStudentToolStripMenuItem;
        private ToolStripMenuItem findStudentsToolStripMenuItem;
        private ToolStripMenuItem searchCoursesToolStripMenuItem;
        private ToolStripMenuItem enrollStudentToolStripMenuItem;
        private ToolStripMenuItem viewEnrollmentsToolStripMenuItem;
        private ToolStripMenuItem adminDashboardToolStripMenuItem;
        private ToolStripMenuItem openDashboardToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem openDashboardToolStripMenuItem1;
        private ToolStripMenuItem loginPageToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
