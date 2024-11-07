namespace LMIS_Dev_Branch
{
    partial class CourseDetailsForm
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
            lblPopUpTitle = new Label();
            btnCloseX = new Button();
            lblCourseName = new Button();
            lblCourseType = new Button();
            lblCredits = new Button();
            lblNQFLevel = new Button();
            lblAccreditationBody = new Button();
            lblAccreditationNumber = new Button();
            button1 = new Button();
            lblCertificateInfo = new Button();
            btnClose = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // lblPopUpTitle
            // 
            lblPopUpTitle.Anchor = AnchorStyles.None;
            lblPopUpTitle.AutoSize = true;
            lblPopUpTitle.BackColor = Color.Blue;
            lblPopUpTitle.FlatStyle = FlatStyle.Popup;
            lblPopUpTitle.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPopUpTitle.ImageAlign = ContentAlignment.TopLeft;
            lblPopUpTitle.Location = new Point(187, 10);
            lblPopUpTitle.Name = "lblPopUpTitle";
            lblPopUpTitle.Size = new Size(211, 33);
            lblPopUpTitle.TabIndex = 0;
            lblPopUpTitle.Text = "Course Details";
            // 
            // btnCloseX
            // 
            btnCloseX.BackColor = Color.Red;
            btnCloseX.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseX.Location = new Point(567, 10);
            btnCloseX.Name = "btnCloseX";
            btnCloseX.Size = new Size(28, 33);
            btnCloseX.TabIndex = 1;
            btnCloseX.Text = "X";
            btnCloseX.UseVisualStyleBackColor = false;
            // 
            // lblCourseName
            // 
            lblCourseName.BackColor = Color.White;
            lblCourseName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCourseName.Location = new Point(12, 73);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(400, 38);
            lblCourseName.TabIndex = 2;
            lblCourseName.Text = "Displays course name";
            lblCourseName.UseVisualStyleBackColor = false;
            lblCourseName.Click += lblCourseName_Click;
            // 
            // lblCourseType
            // 
            lblCourseType.BackColor = Color.White;
            lblCourseType.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCourseType.Location = new Point(12, 131);
            lblCourseType.Name = "lblCourseType";
            lblCourseType.Size = new Size(488, 38);
            lblCourseType.TabIndex = 3;
            lblCourseType.Text = "Course Type: Accredited/Non-Accredited";
            lblCourseType.UseVisualStyleBackColor = false;
            // 
            // lblCredits
            // 
            lblCredits.BackColor = Color.White;
            lblCredits.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCredits.Location = new Point(12, 195);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(400, 38);
            lblCredits.TabIndex = 4;
            lblCredits.Text = "Credits: [number of credits]";
            lblCredits.UseVisualStyleBackColor = false;
            // 
            // lblNQFLevel
            // 
            lblNQFLevel.BackColor = Color.White;
            lblNQFLevel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNQFLevel.Location = new Point(12, 259);
            lblNQFLevel.Name = "lblNQFLevel";
            lblNQFLevel.Size = new Size(400, 38);
            lblNQFLevel.TabIndex = 5;
            lblNQFLevel.Text = "NQF Level: [NQF level]";
            lblNQFLevel.UseVisualStyleBackColor = false;
            // 
            // lblAccreditationBody
            // 
            lblAccreditationBody.BackColor = Color.White;
            lblAccreditationBody.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccreditationBody.Location = new Point(12, 318);
            lblAccreditationBody.Name = "lblAccreditationBody";
            lblAccreditationBody.Size = new Size(400, 38);
            lblAccreditationBody.TabIndex = 6;
            lblAccreditationBody.Text = "Accreditation Body: [if accredited]";
            lblAccreditationBody.UseVisualStyleBackColor = false;
            // 
            // lblAccreditationNumber
            // 
            lblAccreditationNumber.BackColor = Color.White;
            lblAccreditationNumber.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccreditationNumber.Location = new Point(11, 383);
            lblAccreditationNumber.Name = "lblAccreditationNumber";
            lblAccreditationNumber.Size = new Size(410, 38);
            lblAccreditationNumber.TabIndex = 7;
            lblAccreditationNumber.Text = "Accreditation Number: [if accredited]";
            lblAccreditationNumber.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 448);
            button1.Name = "button1";
            button1.Size = new Size(410, 38);
            button1.TabIndex = 8;
            button1.Text = "Accreditation Number: [if accredited]";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblCertificateInfo
            // 
            lblCertificateInfo.BackColor = Color.White;
            lblCertificateInfo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCertificateInfo.Location = new Point(12, 509);
            lblCertificateInfo.Name = "lblCertificateInfo";
            lblCertificateInfo.Size = new Size(399, 38);
            lblCertificateInfo.TabIndex = 9;
            lblCertificateInfo.Text = "Certificate Issued: [type]";
            lblCertificateInfo.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(462, 568);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 35);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Blue;
            btnEdit.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(316, 568);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 35);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit Course";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // CourseDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 667);
            Controls.Add(btnEdit);
            Controls.Add(btnClose);
            Controls.Add(lblCertificateInfo);
            Controls.Add(button1);
            Controls.Add(lblAccreditationNumber);
            Controls.Add(lblAccreditationBody);
            Controls.Add(lblNQFLevel);
            Controls.Add(lblCredits);
            Controls.Add(lblCourseType);
            Controls.Add(lblCourseName);
            Controls.Add(btnCloseX);
            Controls.Add(lblPopUpTitle);
            MaximizeBox = false;
            Name = "CourseDetailsForm";
            ShowInTaskbar = false;
            Text = "CourseDetailsForm";
            Load += CourseDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPopUpTitle;
        private Button btnCloseX;
        private Button lblCourseName;
        private Button lblCourseType;
        private Button lblCredits;
        private Button lblNQFLevel;
        private Button lblAccreditationBody;
        private Button lblAccreditationNumber;
        private Button button1;
        private Button lblCertificateInfo;
        private Button btnClose;
        private Button btnEdit;
    }
}