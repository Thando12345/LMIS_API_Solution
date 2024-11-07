namespace LMIS_Dev_Branch
{
    partial class frmLearnerInformation
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
            btnSearch = new Button();
            txtSearchLearner = new TextBox();
            toolTip1 = new ToolTip(components);
            textBox1 = new TextBox();
            chkDeclaration = new CheckBox();
            btnEdit = new Button();
            btnUploadID = new Button();
            btnUploadQualification = new Button();
            txtIdentityNumber = new TextBox();
            txtAlternateID = new TextBox();
            lblStartDate = new DateTimePicker();
            txtHighestEducation = new TextBox();
            txtLearningProgramme = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cmbInter = new ComboBox();
            btnEnroll = new Button();
            toolTip2 = new ToolTip(components);
            btnDelete = new Button();
            btnSave = new Button();
            dgvLearnerList = new DataGridView();
            Learner_surname = new DataGridViewTextBoxColumn();
            Learner_first_name = new DataGridViewTextBoxColumn();
            Learner_ID = new DataGridViewTextBoxColumn();
            Course = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            txtSurname = new TextBox();
            label1 = new Label();
            txtFullNames = new TextBox();
            cmbNationality = new ComboBox();
            cmbHomeLanguage = new ComboBox();
            txtAge = new TextBox();
            cmbGender = new ComboBox();
            cmbRace = new ComboBox();
            cmbDisabilityStatus = new ComboBox();
            cmbEmploymentStatus = new ComboBox();
            txtOFOCode = new TextBox();
            txtCompanyName = new TextBox();
            txtHomeAddress = new TextBox();
            textBox2 = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmailAddress = new TextBox();
            txtGrantContractNumber = new TextBox();
            txtTrainingProvider = new TextBox();
            textBox3 = new TextBox();
            txtLastSchoolAttended = new TextBox();
            lblStatDate = new Label();
            lblEndDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLearnerList).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Blue;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(260, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 36);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            toolTip1.SetToolTip(btnSearch, "Enter Learner ID or Surname to search.");
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchLearner
            // 
            txtSearchLearner.Location = new Point(50, 20);
            txtSearchLearner.Name = "txtSearchLearner";
            txtSearchLearner.Size = new Size(200, 31);
            txtSearchLearner.TabIndex = 1;
            toolTip1.SetToolTip(txtSearchLearner, "Enter Learner ID or Surname to search.");
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Enter Learner ID or Surname to search.";
            toolTip1.Popup += toolTip1_Popup;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Location = new Point(489, 357);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Alternate ID";
            textBox1.Size = new Size(0, 31);
            textBox1.TabIndex = 15;
            toolTip1.SetToolTip(textBox1, "For non-RSA citizens, enter an alternate ID.");
            // 
            // chkDeclaration
            // 
            chkDeclaration.AutoSize = true;
            chkDeclaration.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDeclaration.Location = new Point(610, 827);
            chkDeclaration.Name = "chkDeclaration";
            chkDeclaration.Size = new Size(457, 28);
            chkDeclaration.TabIndex = 35;
            chkDeclaration.Text = "I hereby declare the information above is true and correct.";
            toolTip1.SetToolTip(chkDeclaration, "Check this box to confirm the information is accurate.");
            chkDeclaration.UseVisualStyleBackColor = true;
            chkDeclaration.CheckedChanged += chkDeclaration_CheckedChanged_1;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DeepSkyBlue;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(864, 154);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(80, 35);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit ";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnUploadID
            // 
            btnUploadID.BackColor = Color.Teal;
            btnUploadID.ForeColor = Color.White;
            btnUploadID.Location = new Point(167, 818);
            btnUploadID.Name = "btnUploadID";
            btnUploadID.Size = new Size(120, 42);
            btnUploadID.TabIndex = 7;
            btnUploadID.Text = "Upload ID";
            btnUploadID.UseVisualStyleBackColor = false;
            // 
            // btnUploadQualification
            // 
            btnUploadQualification.BackColor = Color.Teal;
            btnUploadQualification.ForeColor = Color.White;
            btnUploadQualification.Location = new Point(302, 818);
            btnUploadQualification.Name = "btnUploadQualification";
            btnUploadQualification.Size = new Size(200, 42);
            btnUploadQualification.TabIndex = 8;
            btnUploadQualification.Text = "Upload Qualifications";
            btnUploadQualification.UseVisualStyleBackColor = false;
            btnUploadQualification.Click += btnUploadQualification_Click;
            // 
            // txtIdentityNumber
            // 
            txtIdentityNumber.ForeColor = Color.DarkGray;
            txtIdentityNumber.Location = new Point(610, 400);
            txtIdentityNumber.Name = "txtIdentityNumber";
            txtIdentityNumber.PlaceholderText = "Identity Number";
            txtIdentityNumber.Size = new Size(200, 31);
            txtIdentityNumber.TabIndex = 13;
            // 
            // txtAlternateID
            // 
            txtAlternateID.ForeColor = Color.DarkGray;
            txtAlternateID.Location = new Point(830, 400);
            txtAlternateID.Name = "txtAlternateID";
            txtAlternateID.PlaceholderText = "Alternate ID";
            txtAlternateID.Size = new Size(200, 31);
            txtAlternateID.TabIndex = 14;
            txtAlternateID.TextChanged += txtAlternateID_TextChanged;
            // 
            // lblStartDate
            // 
            lblStartDate.Location = new Point(444, 701);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(246, 31);
            lblStartDate.TabIndex = 34;
            lblStartDate.ValueChanged += lblStartDate_ValueChanged;
            // 
            // txtHighestEducation
            // 
            txtHighestEducation.ForeColor = Color.DarkGray;
            txtHighestEducation.Location = new Point(50, 756);
            txtHighestEducation.Name = "txtHighestEducation";
            txtHighestEducation.PlaceholderText = "Highest Level of Education Attained";
            txtHighestEducation.Size = new Size(300, 31);
            txtHighestEducation.TabIndex = 36;
            txtHighestEducation.TextChanged += textBox4_TextChanged;
            // 
            // txtLearningProgramme
            // 
            txtLearningProgramme.ForeColor = Color.DarkGray;
            txtLearningProgramme.Location = new Point(50, 703);
            txtLearningProgramme.Name = "txtLearningProgramme";
            txtLearningProgramme.PlaceholderText = "Learning Programme";
            txtLearningProgramme.Size = new Size(250, 31);
            txtLearningProgramme.TabIndex = 39;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(883, 701);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(246, 31);
            dateTimePicker1.TabIndex = 42;
            // 
            // cmbInter
            // 
            cmbInter.ForeColor = Color.DarkGray;
            cmbInter.FormattingEnabled = true;
            cmbInter.Items.AddRange(new object[] { "X", "Y", "Z" });
            cmbInter.Location = new Point(330, 648);
            cmbInter.Name = "cmbInter";
            cmbInter.Size = new Size(200, 33);
            cmbInter.TabIndex = 43;
            cmbInter.Text = " Intervention";
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.Green;
            btnEnroll.ForeColor = Color.White;
            btnEnroll.Location = new Point(360, 20);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(100, 36);
            btnEnroll.TabIndex = 2;
            btnEnroll.Text = "Enroll";
            toolTip2.SetToolTip(btnEnroll, "Search for a learner based on ID or Surname.");
            btnEnroll.UseVisualStyleBackColor = false;
            // 
            // toolTip2
            // 
            toolTip2.ToolTipTitle = "Search for a learner based on ID or Surname.";
            toolTip2.Popup += toolTip2_Popup;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(864, 195);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Blue;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(50, 818);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 42);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgvLearnerList
            // 
            dgvLearnerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLearnerList.Columns.AddRange(new DataGridViewColumn[] { Learner_surname, Learner_first_name, Learner_ID, Course, Action });
            dgvLearnerList.Location = new Point(50, 70);
            dgvLearnerList.Name = "dgvLearnerList";
            dgvLearnerList.RowHeadersWidth = 62;
            dgvLearnerList.Size = new Size(1100, 300);
            dgvLearnerList.TabIndex = 3;
            // 
            // Learner_surname
            // 
            Learner_surname.HeaderText = "Learner's surname";
            Learner_surname.MinimumWidth = 8;
            Learner_surname.Name = "Learner_surname";
            Learner_surname.Width = 150;
            // 
            // Learner_first_name
            // 
            Learner_first_name.HeaderText = "Learner's first name(s)";
            Learner_first_name.MinimumWidth = 8;
            Learner_first_name.Name = "Learner_first_name";
            Learner_first_name.Width = 150;
            // 
            // Learner_ID
            // 
            Learner_ID.HeaderText = "Learner's ID number";
            Learner_ID.MinimumWidth = 8;
            Learner_ID.Name = "Learner_ID";
            Learner_ID.Width = 150;
            // 
            // Course
            // 
            Course.HeaderText = "Course enrolled by the learner";
            Course.MinimumWidth = 8;
            Course.Name = "Course";
            Course.Width = 150;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 8;
            Action.Name = "Action";
            Action.Width = 150;
            // 
            // txtSurname
            // 
            txtSurname.ForeColor = Color.DarkGray;
            txtSurname.Location = new Point(50, 400);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Surname";
            txtSurname.Size = new Size(250, 31);
            txtSurname.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-73, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 11;
            label1.Text = "Surname";
            // 
            // txtFullNames
            // 
            txtFullNames.ForeColor = Color.DarkGray;
            txtFullNames.Location = new Point(330, 400);
            txtFullNames.Name = "txtFullNames";
            txtFullNames.PlaceholderText = "Full Names";
            txtFullNames.Size = new Size(250, 31);
            txtFullNames.TabIndex = 12;
            // 
            // cmbNationality
            // 
            cmbNationality.ForeColor = Color.DarkGray;
            cmbNationality.FormattingEnabled = true;
            cmbNationality.Items.AddRange(new object[] { "South Africa", "Zimbabwe", "Nigeria", "Kenya", "Tanzania", "Uganda", "Ghana", "Ethiopia", "Somalia" });
            cmbNationality.Location = new Point(50, 450);
            cmbNationality.Name = "cmbNationality";
            cmbNationality.Size = new Size(200, 33);
            cmbNationality.TabIndex = 16;
            cmbNationality.Text = "Nationality";
            // 
            // cmbHomeLanguage
            // 
            cmbHomeLanguage.ForeColor = Color.DarkGray;
            cmbHomeLanguage.FormattingEnabled = true;
            cmbHomeLanguage.Items.AddRange(new object[] { "Zulu", "Xhosa", "Afrikaans", "English", "Sesotho", "Setswana", "Sepedi (Northern Sotho)", "Tswana", "Venda", "Tsonga", "Ndebele", "South African Sign Language", "Other (specify)" });
            cmbHomeLanguage.Location = new Point(270, 450);
            cmbHomeLanguage.Name = "cmbHomeLanguage";
            cmbHomeLanguage.Size = new Size(200, 33);
            cmbHomeLanguage.TabIndex = 17;
            cmbHomeLanguage.Text = "Home Language";
            // 
            // txtAge
            // 
            txtAge.ForeColor = Color.DarkGray;
            txtAge.Location = new Point(490, 450);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Age";
            txtAge.Size = new Size(100, 31);
            txtAge.TabIndex = 18;
            // 
            // cmbGender
            // 
            cmbGender.ForeColor = Color.DarkGray;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other (specify)" });
            cmbGender.Location = new Point(610, 450);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(200, 33);
            cmbGender.TabIndex = 19;
            cmbGender.Text = "Gender";
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // cmbRace
            // 
            cmbRace.ForeColor = Color.DarkGray;
            cmbRace.FormattingEnabled = true;
            cmbRace.Items.AddRange(new object[] { "Male", "Female", "Other (specify)" });
            cmbRace.Location = new Point(830, 450);
            cmbRace.Name = "cmbRace";
            cmbRace.Size = new Size(200, 33);
            cmbRace.TabIndex = 20;
            cmbRace.Text = "Race";
            // 
            // cmbDisabilityStatus
            // 
            cmbDisabilityStatus.ForeColor = Color.DarkGray;
            cmbDisabilityStatus.FormattingEnabled = true;
            cmbDisabilityStatus.Items.AddRange(new object[] { "No Disability", "Visual Impairment", "", "Hearing Impairment", "", "Mobility Impairment", "", "Cognitive Impairment", "", "Mental Health Condition", "", "Chronic Illness", "", "Learning Disability", "", "Speech or Language Impairment", "", "Developmental Disability", "", "Other (specify)" });
            cmbDisabilityStatus.Location = new Point(50, 500);
            cmbDisabilityStatus.Name = "cmbDisabilityStatus";
            cmbDisabilityStatus.Size = new Size(200, 33);
            cmbDisabilityStatus.TabIndex = 21;
            cmbDisabilityStatus.Text = "Disability Status";
            // 
            // cmbEmploymentStatus
            // 
            cmbEmploymentStatus.ForeColor = Color.DarkGray;
            cmbEmploymentStatus.FormattingEnabled = true;
            cmbEmploymentStatus.Items.AddRange(new object[] { "Employed Full-Time", "", "Employed Part-Time", "", "Self-Employed", "", "Unemployed", "", "Student", "", "Retired", "", "Freelance", "", "Contract Worker", "", "Intern", "", "Other (specify)" });
            cmbEmploymentStatus.Location = new Point(270, 500);
            cmbEmploymentStatus.Name = "cmbEmploymentStatus";
            cmbEmploymentStatus.Size = new Size(200, 33);
            cmbEmploymentStatus.TabIndex = 22;
            cmbEmploymentStatus.Text = "Employment Status";
            // 
            // txtOFOCode
            // 
            txtOFOCode.ForeColor = Color.DarkGray;
            txtOFOCode.Location = new Point(490, 500);
            txtOFOCode.Name = "txtOFOCode";
            txtOFOCode.PlaceholderText = " OFO Code";
            txtOFOCode.Size = new Size(200, 31);
            txtOFOCode.TabIndex = 23;
            // 
            // txtCompanyName
            // 
            txtCompanyName.ForeColor = Color.DarkGray;
            txtCompanyName.Location = new Point(710, 500);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.PlaceholderText = "Company Name";
            txtCompanyName.Size = new Size(320, 31);
            txtCompanyName.TabIndex = 24;
            // 
            // txtHomeAddress
            // 
            txtHomeAddress.ForeColor = Color.DarkGray;
            txtHomeAddress.Location = new Point(50, 550);
            txtHomeAddress.Name = "txtHomeAddress";
            txtHomeAddress.PlaceholderText = "Home Address";
            txtHomeAddress.Size = new Size(500, 31);
            txtHomeAddress.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.DarkGray;
            textBox2.Location = new Point(570, 550);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Postal Address";
            textBox2.Size = new Size(500, 31);
            textBox2.TabIndex = 26;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.ForeColor = Color.DarkGray;
            txtPhoneNumber.Location = new Point(50, 600);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(200, 31);
            txtPhoneNumber.TabIndex = 27;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.ForeColor = Color.DarkGray;
            txtEmailAddress.Location = new Point(270, 600);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.PlaceholderText = "Email Address";
            txtEmailAddress.Size = new Size(300, 31);
            txtEmailAddress.TabIndex = 28;
            txtEmailAddress.TextChanged += txtEmailAddress_TextChanged;
            // 
            // txtGrantContractNumber
            // 
            txtGrantContractNumber.ForeColor = Color.DarkGray;
            txtGrantContractNumber.Location = new Point(50, 650);
            txtGrantContractNumber.Name = "txtGrantContractNumber";
            txtGrantContractNumber.PlaceholderText = "Discretionary Grant Contract Number (if applicable)";
            txtGrantContractNumber.Size = new Size(250, 31);
            txtGrantContractNumber.TabIndex = 29;
            // 
            // txtTrainingProvider
            // 
            txtTrainingProvider.ForeColor = Color.DarkGray;
            txtTrainingProvider.Location = new Point(610, 650);
            txtTrainingProvider.Name = "txtTrainingProvider";
            txtTrainingProvider.PlaceholderText = "Training Provider Name";
            txtTrainingProvider.Size = new Size(250, 31);
            txtTrainingProvider.TabIndex = 31;
            txtTrainingProvider.TextChanged += txtTrainingProvider_TextChanged;
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.DarkGray;
            textBox3.Location = new Point(489, 416);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Programme Dates";
            textBox3.Size = new Size(0, 31);
            textBox3.TabIndex = 33;
            // 
            // txtLastSchoolAttended
            // 
            txtLastSchoolAttended.ForeColor = Color.DarkGray;
            txtLastSchoolAttended.Location = new Point(390, 756);
            txtLastSchoolAttended.Name = "txtLastSchoolAttended";
            txtLastSchoolAttended.PlaceholderText = "Enter the name of the last school attended. If not a high school, enter the primary school name.";
            txtLastSchoolAttended.Size = new Size(760, 31);
            txtLastSchoolAttended.TabIndex = 37;
            txtLastSchoolAttended.TextChanged += textBox4_TextChanged_1;
            // 
            // lblStatDate
            // 
            lblStatDate.AutoSize = true;
            lblStatDate.Location = new Point(330, 706);
            lblStatDate.Name = "lblStatDate";
            lblStatDate.Size = new Size(90, 25);
            lblStatDate.TabIndex = 40;
            lblStatDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(776, 707);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(84, 25);
            lblEndDate.TabIndex = 41;
            lblEndDate.Text = "End Date";
            // 
            // frmLearnerInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 885);
            Controls.Add(cmbInter);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblEndDate);
            Controls.Add(lblStatDate);
            Controls.Add(txtLearningProgramme);
            Controls.Add(txtLastSchoolAttended);
            Controls.Add(txtHighestEducation);
            Controls.Add(chkDeclaration);
            Controls.Add(lblStartDate);
            Controls.Add(textBox3);
            Controls.Add(txtTrainingProvider);
            Controls.Add(txtGrantContractNumber);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(textBox2);
            Controls.Add(txtHomeAddress);
            Controls.Add(txtCompanyName);
            Controls.Add(txtOFOCode);
            Controls.Add(cmbEmploymentStatus);
            Controls.Add(cmbDisabilityStatus);
            Controls.Add(cmbRace);
            Controls.Add(cmbGender);
            Controls.Add(txtAge);
            Controls.Add(cmbHomeLanguage);
            Controls.Add(cmbNationality);
            Controls.Add(textBox1);
            Controls.Add(txtAlternateID);
            Controls.Add(txtIdentityNumber);
            Controls.Add(txtFullNames);
            Controls.Add(label1);
            Controls.Add(txtSurname);
            Controls.Add(btnUploadQualification);
            Controls.Add(btnUploadID);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvLearnerList);
            Controls.Add(btnEnroll);
            Controls.Add(txtSearchLearner);
            Controls.Add(btnSearch);
            Name = "frmLearnerInformation";
            Text = "frmLearnerInformation";
            Load += frmLearnerInformation_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLearnerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearchLearner;
        private ToolTip toolTip1;
        private Button btnEnroll;
        private ToolTip toolTip2;
        private DataGridView dgvLearnerList;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Learner_surname;
        private DataGridViewTextBoxColumn Learner_first_name;
        private DataGridViewTextBoxColumn Learner_ID;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn Action;
        private Button btnSave;
        private Button btnUploadID;
        private Button btnUploadQualification;
        private TextBox txtSurname;
        private Label label1;
        private TextBox txtFullNames;
        private TextBox txtIdentityNumber;
        private TextBox txtAlternateID;
        private TextBox textBox1;
        private ComboBox cmbNationality;
        private ComboBox cmbHomeLanguage;
        private TextBox txtAge;
        private ComboBox cmbGender;
        private ComboBox cmbRace;
        private ComboBox cmbDisabilityStatus;
        private ComboBox cmbEmploymentStatus;
        private TextBox txtOFOCode;
        private TextBox txtCompanyName;
        private TextBox txtHomeAddress;
        private TextBox textBox2;
        private TextBox txtPhoneNumber;
        private TextBox txtEmailAddress;
        private TextBox txtGrantContractNumber;
        private TextBox txtTrainingProvider;
        private TextBox txtProgrammeDates;
        private TextBox textBox3;
        private DateTimePicker lblStartDate;
        private CheckBox chkDeclaration;
        private TextBox txtHighestEducation;
        private TextBox txtLastSchoolAttended;
        private TextBox txtLearningProgramme;
        private Label lblStatDate;
        private Label lblEndDate;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbInter;
    }
}