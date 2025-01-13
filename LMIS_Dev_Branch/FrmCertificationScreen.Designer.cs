namespace LMIS_Dev_Branch
{
    partial class FrmCertificationScreen
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
            panel1 = new Panel();
            lblCertification = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvCertification = new DataGridView();
            Course_Name = new DataGridViewTextBoxColumn();
            CourseDates = new DataGridViewTextBoxColumn();
            Funder = new DataGridViewTextBoxColumn();
            Facilitator = new DataGridViewTextBoxColumn();
            Assessor = new DataGridViewTextBoxColumn();
            Moderator = new DataGridViewTextBoxColumn();
            Competent = new DataGridViewTextBoxColumn();
            btnGenerateCertificate = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCertification).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(lblCertification);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1594, 78);
            panel1.TabIndex = 8;
            // 
            // lblCertification
            // 
            lblCertification.AutoSize = true;
            lblCertification.BackColor = Color.Blue;
            lblCertification.FlatStyle = FlatStyle.Popup;
            lblCertification.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCertification.ForeColor = Color.White;
            lblCertification.Location = new Point(714, 20);
            lblCertification.Name = "lblCertification";
            lblCertification.Size = new Size(208, 37);
            lblCertification.TabIndex = 6;
            lblCertification.Text = "Certification";
            lblCertification.Click += lblCertification_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(60, 120);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(356, 25);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search by ID or Course Intervention";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(60, 165);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter Learner ID or Course Name";
            txtSearch.Size = new Size(356, 33);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Blue;
            btnSearch.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(441, 148);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 50);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvCertification
            // 
            dgvCertification.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCertification.Columns.AddRange(new DataGridViewColumn[] { Course_Name, CourseDates, Funder, Facilitator, Assessor, Moderator, Competent });
            dgvCertification.Location = new Point(60, 254);
            dgvCertification.Name = "dgvCertification";
            dgvCertification.RowHeadersWidth = 62;
            dgvCertification.Size = new Size(1476, 248);
            dgvCertification.TabIndex = 12;
            // 
            // Course_Name
            // 
            Course_Name.HeaderText = "Course Name";
            Course_Name.MinimumWidth = 8;
            Course_Name.Name = "Course_Name";
            Course_Name.Width = 200;
            // 
            // CourseDates
            // 
            CourseDates.HeaderText = "Date";
            CourseDates.MinimumWidth = 8;
            CourseDates.Name = "CourseDates";
            CourseDates.Width = 200;
            // 
            // Funder
            // 
            Funder.HeaderText = "Funder";
            Funder.MinimumWidth = 8;
            Funder.Name = "Funder";
            Funder.Width = 200;
            // 
            // Facilitator
            // 
            Facilitator.HeaderText = "Facilitator";
            Facilitator.MinimumWidth = 8;
            Facilitator.Name = "Facilitator";
            Facilitator.Width = 200;
            // 
            // Assessor
            // 
            Assessor.HeaderText = "Assessor";
            Assessor.MinimumWidth = 8;
            Assessor.Name = "Assessor";
            Assessor.Width = 200;
            // 
            // Moderator
            // 
            Moderator.HeaderText = "Moderator";
            Moderator.MinimumWidth = 8;
            Moderator.Name = "Moderator";
            Moderator.Width = 200;
            // 
            // Competent
            // 
            Competent.HeaderText = "Competent";
            Competent.MinimumWidth = 8;
            Competent.Name = "Competent";
            Competent.Width = 200;
            // 
            // btnGenerateCertificate
            // 
            btnGenerateCertificate.BackColor = Color.Green;
            btnGenerateCertificate.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateCertificate.ForeColor = Color.White;
            btnGenerateCertificate.Location = new Point(60, 539);
            btnGenerateCertificate.Name = "btnGenerateCertificate";
            btnGenerateCertificate.Size = new Size(226, 50);
            btnGenerateCertificate.TabIndex = 14;
            btnGenerateCertificate.Text = "Generate Certificate";
            btnGenerateCertificate.UseVisualStyleBackColor = false;
            btnGenerateCertificate.Click += btnGenerateCertificate_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1425, 539);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 48);
            btnClose.TabIndex = 46;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FrmCertificationScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1599, 642);
            Controls.Add(btnClose);
            Controls.Add(btnGenerateCertificate);
            Controls.Add(dgvCertification);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(panel1);
            Name = "FrmCertificationScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCertificationScreen";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCertification).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblCertification;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvCertification;
        private Button btn;
        private Button btnGenerateCertificate;
        private DataGridViewTextBoxColumn Course_Name;
        private DataGridViewTextBoxColumn CourseDates;
        private DataGridViewTextBoxColumn Funder;
        private DataGridViewTextBoxColumn Facilitator;
        private DataGridViewTextBoxColumn Assessor;
        private DataGridViewTextBoxColumn Moderator;
        private DataGridViewTextBoxColumn Competent;
        private Button btnClose;
    }
}