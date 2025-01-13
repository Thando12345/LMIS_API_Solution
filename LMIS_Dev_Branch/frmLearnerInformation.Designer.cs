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
            DatePickerStartDate = new DateTimePicker();
            txtHighestEducation = new TextBox();
            txtLearningProgramme = new TextBox();
            DatePickerEndDate = new DateTimePicker();
            cmbInter = new ComboBox();
            btnEnroll = new Button();
            toolTip2 = new ToolTip(components);
            btnDelete = new Button();
            btnSave = new Button();
            dgvLearnerList = new DataGridView();
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
            txtPostAdrress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmailAddress = new TextBox();
            txtGrantContractNumber = new TextBox();
            txtTrainingProvider = new TextBox();
            textBox3 = new TextBox();
            txtLastSchoolAttended = new TextBox();
            lblStatDate = new Label();
            lblEndDate = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLearnerList).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Blue;
            btnSearch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(286, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 45);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            toolTip1.SetToolTip(btnSearch, "Enter Learner ID or Surname to search.");
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchLearner
            // 
            txtSearchLearner.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchLearner.Location = new Point(55, 23);
            txtSearchLearner.Name = "txtSearchLearner";
            txtSearchLearner.Size = new Size(220, 40);
            txtSearchLearner.TabIndex = 1;
            toolTip1.SetToolTip(txtSearchLearner, "Enter Learner ID or Surname to search.");
            txtSearchLearner.TextChanged += txtSearchLearner_TextChanged;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Enter Learner ID or Surname to search.";
            toolTip1.Popup += toolTip1_Popup;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Location = new Point(538, 328);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Alternate ID";
            textBox1.Size = new Size(1, 30);
            textBox1.TabIndex = 15;
            toolTip1.SetToolTip(textBox1, "For non-RSA citizens, enter an alternate ID.");
            // 
            // chkDeclaration
            // 
            chkDeclaration.AutoSize = true;
            chkDeclaration.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDeclaration.Location = new Point(646, 871);
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
            btnEdit.Location = new Point(1271, 170);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 46);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit ";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnUploadID
            // 
            btnUploadID.BackColor = Color.Teal;
            btnUploadID.ForeColor = Color.White;
            btnUploadID.Location = new Point(182, 858);
            btnUploadID.Name = "btnUploadID";
            btnUploadID.Size = new Size(132, 50);
            btnUploadID.TabIndex = 7;
            btnUploadID.Text = "Upload ID";
            btnUploadID.UseVisualStyleBackColor = false;
            btnUploadID.Click += btnUploadID_Click;
            // 
            // btnUploadQualification
            // 
            btnUploadQualification.BackColor = Color.Teal;
            btnUploadQualification.ForeColor = Color.White;
            btnUploadQualification.Location = new Point(333, 859);
            btnUploadQualification.Name = "btnUploadQualification";
            btnUploadQualification.Size = new Size(220, 50);
            btnUploadQualification.TabIndex = 8;
            btnUploadQualification.Text = "Upload Qualifications";
            btnUploadQualification.UseVisualStyleBackColor = false;
            btnUploadQualification.Click += btnUploadQualification_Click;
            // 
            // txtIdentityNumber
            // 
            txtIdentityNumber.ForeColor = Color.DarkGray;
            txtIdentityNumber.Location = new Point(671, 447);
            txtIdentityNumber.Name = "txtIdentityNumber";
            txtIdentityNumber.PlaceholderText = "Identity Number";
            txtIdentityNumber.Size = new Size(220, 30);
            txtIdentityNumber.TabIndex = 13;
            txtIdentityNumber.TextChanged += txtIdentityNumber_TextChanged;
            // 
            // txtAlternateID
            // 
            txtAlternateID.ForeColor = Color.DarkGray;
            txtAlternateID.Location = new Point(913, 447);
            txtAlternateID.Name = "txtAlternateID";
            txtAlternateID.PlaceholderText = "Alternate ID";
            txtAlternateID.Size = new Size(220, 30);
            txtAlternateID.TabIndex = 14;
            txtAlternateID.TextChanged += txtAlternateID_TextChanged;
            // 
            // DatePickerStartDate
            // 
            DatePickerStartDate.Location = new Point(488, 724);
            DatePickerStartDate.Name = "DatePickerStartDate";
            DatePickerStartDate.Size = new Size(271, 30);
            DatePickerStartDate.TabIndex = 34;
            DatePickerStartDate.ValueChanged += lblStartDate_ValueChanged;
            // 
            // txtHighestEducation
            // 
            txtHighestEducation.ForeColor = Color.DarkGray;
            txtHighestEducation.Location = new Point(55, 775);
            txtHighestEducation.Name = "txtHighestEducation";
            txtHighestEducation.PlaceholderText = "Highest Level of Education Attained";
            txtHighestEducation.Size = new Size(330, 30);
            txtHighestEducation.TabIndex = 36;
            txtHighestEducation.TextChanged += textBox4_TextChanged;
            // 
            // txtLearningProgramme
            // 
            txtLearningProgramme.ForeColor = Color.DarkGray;
            txtLearningProgramme.Location = new Point(55, 726);
            txtLearningProgramme.Name = "txtLearningProgramme";
            txtLearningProgramme.PlaceholderText = "Learning Programme";
            txtLearningProgramme.Size = new Size(275, 30);
            txtLearningProgramme.TabIndex = 39;
            // 
            // DatePickerEndDate
            // 
            DatePickerEndDate.Location = new Point(971, 724);
            DatePickerEndDate.Name = "DatePickerEndDate";
            DatePickerEndDate.Size = new Size(271, 30);
            DatePickerEndDate.TabIndex = 42;
            // 
            // cmbInter
            // 
            cmbInter.ForeColor = Color.DarkGray;
            cmbInter.FormattingEnabled = true;
            cmbInter.Items.AddRange(new object[] { "X", "Y", "Z" });
            cmbInter.Location = new Point(363, 675);
            cmbInter.Name = "cmbInter";
            cmbInter.Size = new Size(220, 31);
            cmbInter.TabIndex = 43;
            cmbInter.Text = " Intervention";
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.Green;
            btnEnroll.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnroll.ForeColor = Color.White;
            btnEnroll.Location = new Point(396, 18);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(110, 45);
            btnEnroll.TabIndex = 2;
            btnEnroll.Text = "Enroll";
            toolTip2.SetToolTip(btnEnroll, "Search for a learner based on ID or Surname.");
            btnEnroll.UseVisualStyleBackColor = false;
            btnEnroll.Click += btnEnroll_Click;
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
            btnDelete.Location = new Point(1271, 118);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 46);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Blue;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(53, 858);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 50);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgvLearnerList
            // 
            dgvLearnerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLearnerList.Location = new Point(55, 118);
            dgvLearnerList.Name = "dgvLearnerList";
            dgvLearnerList.RowHeadersWidth = 62;
            dgvLearnerList.Size = new Size(1210, 276);
            dgvLearnerList.TabIndex = 3;
            dgvLearnerList.CellContentClick += dgvLearnerList_CellContentClick;
            // 
            // txtSurname
            // 
            txtSurname.ForeColor = Color.DarkGray;
            txtSurname.Location = new Point(55, 447);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Surname";
            txtSurname.Size = new Size(275, 30);
            txtSurname.TabIndex = 10;
            txtSurname.TextChanged += txtSurname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-80, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 11;
            label1.Text = "Surname";
            // 
            // txtFullNames
            // 
            txtFullNames.ForeColor = Color.DarkGray;
            txtFullNames.Location = new Point(363, 447);
            txtFullNames.Name = "txtFullNames";
            txtFullNames.PlaceholderText = "Full Names";
            txtFullNames.Size = new Size(275, 30);
            txtFullNames.TabIndex = 12;
            txtFullNames.TextChanged += txtFullNames_TextChanged;
            // 
            // cmbNationality
            // 
            cmbNationality.ForeColor = Color.DarkGray;
            cmbNationality.FormattingEnabled = true;
            cmbNationality.Items.AddRange(new object[] { "South Africa", "Zimbabwe", "Nigeria", "Kenya", "Tanzania", "Uganda", "Ghana", "Ethiopia", "Somalia" });
            cmbNationality.Location = new Point(55, 493);
            cmbNationality.Name = "cmbNationality";
            cmbNationality.Size = new Size(220, 31);
            cmbNationality.TabIndex = 16;
            cmbNationality.Text = "Nationality";
            cmbNationality.SelectedIndexChanged += cmbNationality_SelectedIndexChanged;
            // 
            // cmbHomeLanguage
            // 
            cmbHomeLanguage.ForeColor = Color.DarkGray;
            cmbHomeLanguage.FormattingEnabled = true;
            cmbHomeLanguage.Items.AddRange(new object[] { "Zulu", "Xhosa", "Afrikaans", "English", "Sesotho", "Setswana", "Sepedi (Northern Sotho)", "Tswana", "Venda", "Tsonga", "Ndebele", "South African Sign Language", "Other (specify)" });
            cmbHomeLanguage.Location = new Point(297, 493);
            cmbHomeLanguage.Name = "cmbHomeLanguage";
            cmbHomeLanguage.Size = new Size(220, 31);
            cmbHomeLanguage.TabIndex = 17;
            cmbHomeLanguage.Text = "Home Language";
            cmbHomeLanguage.SelectedIndexChanged += cmbHomeLanguage_SelectedIndexChanged;
            // 
            // txtAge
            // 
            txtAge.ForeColor = Color.DarkGray;
            txtAge.Location = new Point(539, 493);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Age";
            txtAge.Size = new Size(110, 30);
            txtAge.TabIndex = 18;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // cmbGender
            // 
            cmbGender.ForeColor = Color.DarkGray;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other (specify)" });
            cmbGender.Location = new Point(671, 493);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(220, 31);
            cmbGender.TabIndex = 19;
            cmbGender.Text = "Gender";
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // cmbRace
            // 
            cmbRace.ForeColor = Color.DarkGray;
            cmbRace.FormattingEnabled = true;
            cmbRace.Items.AddRange(new object[] { "Male", "Female", "Other (specify)" });
            cmbRace.Location = new Point(913, 493);
            cmbRace.Name = "cmbRace";
            cmbRace.Size = new Size(220, 31);
            cmbRace.TabIndex = 20;
            cmbRace.Text = "Race";
            // 
            // cmbDisabilityStatus
            // 
            cmbDisabilityStatus.ForeColor = Color.DarkGray;
            cmbDisabilityStatus.FormattingEnabled = true;
            cmbDisabilityStatus.Items.AddRange(new object[] { "No Disability", "Visual Impairment", "", "Hearing Impairment", "", "Mobility Impairment", "", "Cognitive Impairment", "", "Mental Health Condition", "", "Chronic Illness", "", "Learning Disability", "", "Speech or Language Impairment", "", "Developmental Disability", "", "Other (specify)" });
            cmbDisabilityStatus.Location = new Point(55, 539);
            cmbDisabilityStatus.Name = "cmbDisabilityStatus";
            cmbDisabilityStatus.Size = new Size(220, 31);
            cmbDisabilityStatus.TabIndex = 21;
            cmbDisabilityStatus.Text = "Disability Status";
            // 
            // cmbEmploymentStatus
            // 
            cmbEmploymentStatus.ForeColor = Color.DarkGray;
            cmbEmploymentStatus.FormattingEnabled = true;
            cmbEmploymentStatus.Items.AddRange(new object[] { "Employed Full-Time", "", "Employed Part-Time", "", "Self-Employed", "", "Unemployed", "", "Student", "", "Retired", "", "Freelance", "", "Contract Worker", "", "Intern", "", "Other (specify)" });
            cmbEmploymentStatus.Location = new Point(297, 539);
            cmbEmploymentStatus.Name = "cmbEmploymentStatus";
            cmbEmploymentStatus.Size = new Size(220, 31);
            cmbEmploymentStatus.TabIndex = 22;
            cmbEmploymentStatus.Text = "Employment Status";
            // 
            // txtOFOCode
            // 
            txtOFOCode.ForeColor = Color.DarkGray;
            txtOFOCode.Location = new Point(539, 539);
            txtOFOCode.Name = "txtOFOCode";
            txtOFOCode.PlaceholderText = " OFO Code";
            txtOFOCode.Size = new Size(220, 30);
            txtOFOCode.TabIndex = 23;
            // 
            // txtCompanyName
            // 
            txtCompanyName.ForeColor = Color.DarkGray;
            txtCompanyName.Location = new Point(781, 539);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.PlaceholderText = "Company Name";
            txtCompanyName.Size = new Size(352, 30);
            txtCompanyName.TabIndex = 24;
            // 
            // txtHomeAddress
            // 
            txtHomeAddress.ForeColor = Color.DarkGray;
            txtHomeAddress.Location = new Point(55, 585);
            txtHomeAddress.Name = "txtHomeAddress";
            txtHomeAddress.PlaceholderText = "Home Address";
            txtHomeAddress.Size = new Size(550, 30);
            txtHomeAddress.TabIndex = 25;
            // 
            // txtPostAdrress
            // 
            txtPostAdrress.ForeColor = Color.DarkGray;
            txtPostAdrress.Location = new Point(627, 585);
            txtPostAdrress.Name = "txtPostAdrress";
            txtPostAdrress.PlaceholderText = "Postal Address";
            txtPostAdrress.Size = new Size(550, 30);
            txtPostAdrress.TabIndex = 26;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.ForeColor = Color.DarkGray;
            txtPhoneNumber.Location = new Point(55, 631);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(220, 30);
            txtPhoneNumber.TabIndex = 27;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.ForeColor = Color.DarkGray;
            txtEmailAddress.Location = new Point(297, 631);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.PlaceholderText = "Email Address";
            txtEmailAddress.Size = new Size(330, 30);
            txtEmailAddress.TabIndex = 28;
            txtEmailAddress.TextChanged += txtEmailAddress_TextChanged;
            // 
            // txtGrantContractNumber
            // 
            txtGrantContractNumber.ForeColor = Color.DarkGray;
            txtGrantContractNumber.Location = new Point(55, 677);
            txtGrantContractNumber.Name = "txtGrantContractNumber";
            txtGrantContractNumber.PlaceholderText = "Discretionary Grant Contract Number (if applicable)";
            txtGrantContractNumber.Size = new Size(275, 30);
            txtGrantContractNumber.TabIndex = 29;
            // 
            // txtTrainingProvider
            // 
            txtTrainingProvider.ForeColor = Color.DarkGray;
            txtTrainingProvider.Location = new Point(671, 677);
            txtTrainingProvider.Name = "txtTrainingProvider";
            txtTrainingProvider.PlaceholderText = "Training Provider Name";
            txtTrainingProvider.Size = new Size(275, 30);
            txtTrainingProvider.TabIndex = 31;
            txtTrainingProvider.TextChanged += txtTrainingProvider_TextChanged;
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.DarkGray;
            textBox3.Location = new Point(538, 462);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Programme Dates";
            textBox3.Size = new Size(1, 30);
            textBox3.TabIndex = 33;
            // 
            // txtLastSchoolAttended
            // 
            txtLastSchoolAttended.ForeColor = Color.DarkGray;
            txtLastSchoolAttended.Location = new Point(429, 775);
            txtLastSchoolAttended.Name = "txtLastSchoolAttended";
            txtLastSchoolAttended.PlaceholderText = "Enter the name of the last school attended. If not a high school, enter the primary school name.";
            txtLastSchoolAttended.Size = new Size(836, 30);
            txtLastSchoolAttended.TabIndex = 37;
            txtLastSchoolAttended.TextChanged += textBox4_TextChanged_1;
            // 
            // lblStatDate
            // 
            lblStatDate.AutoSize = true;
            lblStatDate.Location = new Point(363, 729);
            lblStatDate.Name = "lblStatDate";
            lblStatDate.Size = new Size(101, 23);
            lblStatDate.TabIndex = 40;
            lblStatDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(854, 729);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(92, 23);
            lblEndDate.TabIndex = 41;
            lblEndDate.Text = "End Date";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1271, 861);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 48);
            btnClose.TabIndex = 44;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmLearnerInformation
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 964);
            Controls.Add(btnClose);
            Controls.Add(cmbInter);
            Controls.Add(DatePickerEndDate);
            Controls.Add(lblEndDate);
            Controls.Add(lblStatDate);
            Controls.Add(txtLearningProgramme);
            Controls.Add(txtLastSchoolAttended);
            Controls.Add(txtHighestEducation);
            Controls.Add(chkDeclaration);
            Controls.Add(DatePickerStartDate);
            Controls.Add(textBox3);
            Controls.Add(txtTrainingProvider);
            Controls.Add(txtGrantContractNumber);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtPostAdrress);
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
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmLearnerInformation";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox txtPostAdrress;
        private TextBox txtPhoneNumber;
        private TextBox txtEmailAddress;
        private TextBox txtGrantContractNumber;
        private TextBox txtTrainingProvider;
        private TextBox txtProgrammeDates;
        private TextBox textBox3;
        private DateTimePicker DatePickerStartDate;
        private CheckBox chkDeclaration;
        private TextBox txtHighestEducation;
        private TextBox txtLastSchoolAttended;
        private TextBox txtLearningProgramme;
        private Label lblStatDate;
        private Label lblEndDate;
        private DateTimePicker DatePickerEndDate;
        private ComboBox cmbInter;
        private Button btnClose;
    }
}