namespace LMIS_Dev_Branch
{
    partial class FrmCreateCourseForm
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblCourseName = new Label();
            txtCourseName = new TextBox();
            dgvUnitStandards = new DataGridView();
            lblUsNumber = new Label();
            txtUsNumberInput = new TextBox();
            lblUsName = new Label();
            txtUsNameInput = new TextBox();
            lblUsId = new Label();
            txtUsId = new TextBox();
            lblUsCredits = new Label();
            txtUsCredits = new TextBox();
            lblUsNqfLevel = new Label();
            txtUsNqfLevel = new TextBox();
            btnAddUnitStandard = new Button();
            btnCancelUnitStandard = new Button();
            lblAccreditationToggle = new Label();
            btnAccreditationYes = new Button();
            button1 = new Button();
            lblAccreditationBody = new Label();
            txtAccreditationBody = new TextBox();
            lblAccreditationNumber = new Label();
            txtAccreditationNumber = new TextBox();
            btnSaveCourse = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            lblAdminApprovalNote = new Label();
            tooltipAddUnitStandard = new ToolTip(components);
            toolTipCancelUnitStandard = new ToolTip(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUnitStandards).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Blue;
            lblTitle.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(239, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(291, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Course";
            lblTitle.Click += lblTitle_Click_1;
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCourseName.Location = new Point(50, 93);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(159, 27);
            lblCourseName.TabIndex = 1;
            lblCourseName.Text = "Course Name";
            // 
            // txtCourseName
            // 
            txtCourseName.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourseName.Location = new Point(250, 93);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(291, 30);
            txtCourseName.TabIndex = 2;
            // 
            // dgvUnitStandards
            // 
            dgvUnitStandards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnitStandards.Location = new Point(50, 156);
            dgvUnitStandards.Name = "dgvUnitStandards";
            dgvUnitStandards.RowHeadersWidth = 62;
            dgvUnitStandards.Size = new Size(713, 570);
            dgvUnitStandards.TabIndex = 3;
            // 
            // lblUsNumber
            // 
            lblUsNumber.AutoSize = true;
            lblUsNumber.BackColor = Color.DarkGray;
            lblUsNumber.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsNumber.Location = new Point(59, 169);
            lblUsNumber.Name = "lblUsNumber";
            lblUsNumber.Size = new Size(61, 27);
            lblUsNumber.TabIndex = 4;
            lblUsNumber.Text = "Us #";
            // 
            // txtUsNumberInput
            // 
            txtUsNumberInput.Location = new Point(126, 167);
            txtUsNumberInput.Name = "txtUsNumberInput";
            txtUsNumberInput.Size = new Size(193, 31);
            txtUsNumberInput.TabIndex = 5;
            // 
            // lblUsName
            // 
            lblUsName.AutoSize = true;
            lblUsName.BackColor = Color.DarkGray;
            lblUsName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsName.Location = new Point(337, 169);
            lblUsName.Name = "lblUsName";
            lblUsName.Size = new Size(111, 27);
            lblUsName.TabIndex = 6;
            lblUsName.Text = "Us Name";
            // 
            // txtUsNameInput
            // 
            txtUsNameInput.Location = new Point(468, 169);
            txtUsNameInput.Name = "txtUsNameInput";
            txtUsNameInput.Size = new Size(193, 31);
            txtUsNameInput.TabIndex = 7;
            // 
            // lblUsId
            // 
            lblUsId.AutoSize = true;
            lblUsId.BackColor = Color.DarkGray;
            lblUsId.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsId.Location = new Point(59, 219);
            lblUsId.Name = "lblUsId";
            lblUsId.Size = new Size(35, 27);
            lblUsId.TabIndex = 8;
            lblUsId.Text = "ID";
            // 
            // txtUsId
            // 
            txtUsId.Location = new Point(126, 215);
            txtUsId.Name = "txtUsId";
            txtUsId.Size = new Size(193, 31);
            txtUsId.TabIndex = 9;
            // 
            // lblUsCredits
            // 
            lblUsCredits.AutoSize = true;
            lblUsCredits.BackColor = Color.DarkGray;
            lblUsCredits.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsCredits.Location = new Point(337, 219);
            lblUsCredits.Name = "lblUsCredits";
            lblUsCredits.Size = new Size(88, 27);
            lblUsCredits.TabIndex = 10;
            lblUsCredits.Text = "Credits";
            // 
            // txtUsCredits
            // 
            txtUsCredits.Location = new Point(468, 219);
            txtUsCredits.Name = "txtUsCredits";
            txtUsCredits.Size = new Size(193, 31);
            txtUsCredits.TabIndex = 11;
            // 
            // lblUsNqfLevel
            // 
            lblUsNqfLevel.AutoSize = true;
            lblUsNqfLevel.BackColor = Color.DarkGray;
            lblUsNqfLevel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsNqfLevel.Location = new Point(59, 269);
            lblUsNqfLevel.Name = "lblUsNqfLevel";
            lblUsNqfLevel.Size = new Size(126, 27);
            lblUsNqfLevel.TabIndex = 12;
            lblUsNqfLevel.Text = "NQF Level";
            // 
            // txtUsNqfLevel
            // 
            txtUsNqfLevel.Location = new Point(208, 269);
            txtUsNqfLevel.Name = "txtUsNqfLevel";
            txtUsNqfLevel.Size = new Size(193, 31);
            txtUsNqfLevel.TabIndex = 13;
            // 
            // btnAddUnitStandard
            // 
            btnAddUnitStandard.BackColor = Color.Green;
            btnAddUnitStandard.ForeColor = Color.White;
            btnAddUnitStandard.Location = new Point(677, 269);
            btnAddUnitStandard.Name = "btnAddUnitStandard";
            btnAddUnitStandard.Size = new Size(82, 34);
            btnAddUnitStandard.TabIndex = 14;
            btnAddUnitStandard.Text = "+";
            tooltipAddUnitStandard.SetToolTip(btnAddUnitStandard, "Click to add a new unit standard row");
            btnAddUnitStandard.UseVisualStyleBackColor = false;
            // 
            // btnCancelUnitStandard
            // 
            btnCancelUnitStandard.BackColor = Color.Red;
            btnCancelUnitStandard.ForeColor = Color.White;
            btnCancelUnitStandard.Location = new Point(677, 319);
            btnCancelUnitStandard.Name = "btnCancelUnitStandard";
            btnCancelUnitStandard.Size = new Size(82, 34);
            btnCancelUnitStandard.TabIndex = 15;
            btnCancelUnitStandard.Text = "Cancel";
            toolTipCancelUnitStandard.SetToolTip(btnCancelUnitStandard, "Click to remove this unit standard row");
            btnCancelUnitStandard.UseVisualStyleBackColor = false;
            // 
            // lblAccreditationToggle
            // 
            lblAccreditationToggle.AutoSize = true;
            lblAccreditationToggle.BackColor = Color.DarkGray;
            lblAccreditationToggle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccreditationToggle.Location = new Point(59, 334);
            lblAccreditationToggle.Name = "lblAccreditationToggle";
            lblAccreditationToggle.Size = new Size(287, 27);
            lblAccreditationToggle.TabIndex = 16;
            lblAccreditationToggle.Text = "Is the Course Accredited?";
            // 
            // btnAccreditationYes
            // 
            btnAccreditationYes.BackColor = Color.Blue;
            btnAccreditationYes.ForeColor = Color.White;
            btnAccreditationYes.ImageAlign = ContentAlignment.BottomRight;
            btnAccreditationYes.Location = new Point(375, 334);
            btnAccreditationYes.Name = "btnAccreditationYes";
            btnAccreditationYes.Size = new Size(82, 34);
            btnAccreditationYes.TabIndex = 17;
            btnAccreditationYes.Text = "Yes";
            btnAccreditationYes.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.BottomRight;
            button1.Location = new Point(463, 334);
            button1.Name = "button1";
            button1.Size = new Size(82, 34);
            button1.TabIndex = 18;
            button1.Text = "No";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblAccreditationBody
            // 
            lblAccreditationBody.AutoSize = true;
            lblAccreditationBody.BackColor = Color.DarkGray;
            lblAccreditationBody.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccreditationBody.Location = new Point(208, 389);
            lblAccreditationBody.Name = "lblAccreditationBody";
            lblAccreditationBody.Size = new Size(212, 27);
            lblAccreditationBody.TabIndex = 19;
            lblAccreditationBody.Text = "Accreditation Body";
            // 
            // txtAccreditationBody
            // 
            txtAccreditationBody.Location = new Point(468, 389);
            txtAccreditationBody.Name = "txtAccreditationBody";
            txtAccreditationBody.Size = new Size(193, 31);
            txtAccreditationBody.TabIndex = 20;
            // 
            // lblAccreditationNumber
            // 
            lblAccreditationNumber.AutoSize = true;
            lblAccreditationNumber.BackColor = Color.DarkGray;
            lblAccreditationNumber.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccreditationNumber.Location = new Point(208, 439);
            lblAccreditationNumber.Name = "lblAccreditationNumber";
            lblAccreditationNumber.Size = new Size(243, 27);
            lblAccreditationNumber.TabIndex = 21;
            lblAccreditationNumber.Text = "Accreditation Number";
            // 
            // txtAccreditationNumber
            // 
            txtAccreditationNumber.Location = new Point(468, 439);
            txtAccreditationNumber.Name = "txtAccreditationNumber";
            txtAccreditationNumber.Size = new Size(193, 31);
            txtAccreditationNumber.TabIndex = 22;
            // 
            // btnSaveCourse
            // 
            btnSaveCourse.BackColor = Color.Blue;
            btnSaveCourse.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveCourse.ForeColor = Color.White;
            btnSaveCourse.Location = new Point(360, 510);
            btnSaveCourse.Name = "btnSaveCourse";
            btnSaveCourse.Size = new Size(82, 40);
            btnSaveCourse.TabIndex = 23;
            btnSaveCourse.Text = "Save";
            btnSaveCourse.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.LightGray;
            btnPrevious.ForeColor = Color.White;
            btnPrevious.ImageAlign = ContentAlignment.BottomRight;
            btnPrevious.Location = new Point(59, 570);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(111, 34);
            btnPrevious.TabIndex = 24;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightGray;
            btnNext.ForeColor = Color.White;
            btnNext.ImageAlign = ContentAlignment.BottomRight;
            btnNext.Location = new Point(648, 570);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(111, 34);
            btnNext.TabIndex = 25;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // lblAdminApprovalNote
            // 
            lblAdminApprovalNote.AutoSize = true;
            lblAdminApprovalNote.BackColor = Color.Red;
            lblAdminApprovalNote.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminApprovalNote.Location = new Point(95, 650);
            lblAdminApprovalNote.Name = "lblAdminApprovalNote";
            lblAdminApprovalNote.Size = new Size(630, 27);
            lblAdminApprovalNote.TabIndex = 26;
            lblAdminApprovalNote.Text = "NB: Admin must approve when the user creates a course.";
            // 
            // tooltipAddUnitStandard
            // 
            tooltipAddUnitStandard.Popup += tooltipAddUnitStandard_Popup;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 66);
            panel1.TabIndex = 27;
            // 
            // FrmCreateCourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 755);
            Controls.Add(panel1);
            Controls.Add(lblAdminApprovalNote);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnSaveCourse);
            Controls.Add(txtAccreditationNumber);
            Controls.Add(lblAccreditationNumber);
            Controls.Add(txtAccreditationBody);
            Controls.Add(lblAccreditationBody);
            Controls.Add(button1);
            Controls.Add(btnAccreditationYes);
            Controls.Add(lblAccreditationToggle);
            Controls.Add(btnCancelUnitStandard);
            Controls.Add(btnAddUnitStandard);
            Controls.Add(txtUsNqfLevel);
            Controls.Add(lblUsNqfLevel);
            Controls.Add(txtUsCredits);
            Controls.Add(lblUsCredits);
            Controls.Add(txtUsId);
            Controls.Add(lblUsId);
            Controls.Add(txtUsNameInput);
            Controls.Add(lblUsName);
            Controls.Add(txtUsNumberInput);
            Controls.Add(lblUsNumber);
            Controls.Add(dgvUnitStandards);
            Controls.Add(txtCourseName);
            Controls.Add(lblCourseName);
            Name = "FrmCreateCourseForm";
            Text = "CreateCourseForm";
            ((System.ComponentModel.ISupportInitialize)dgvUnitStandards).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCourseName;
        private TextBox txtCourseName;
        private DataGridView dgvUnitStandards;
        private Label lblUsNumber;
        private TextBox txtUsNumberInput;
        private Label lblUsName;
        private TextBox txtUsNameInput;
        private Label lblUsId;
        private TextBox txtUsId;
        private Label lblUsCredits;
        private TextBox txtUsCredits;
        private Label lblUsNqfLevel;
        private TextBox txtUsNqfLevel;
        private Button btnAddUnitStandard;
        private Button btnCancelUnitStandard;
        private Label lblAccreditationToggle;
        private Button btnAccreditationYes;
        private Button button1;
        private Label lblAccreditationBody;
        private TextBox txtAccreditationBody;
        private Label lblAccreditationNumber;
        private TextBox txtAccreditationNumber;
        private Button btnSaveCourse;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblAdminApprovalNote;
        private ToolTip tooltipAddUnitStandard;
        private ToolTip toolTipCancelUnitStandard;
        private Panel panel1;
    }
}