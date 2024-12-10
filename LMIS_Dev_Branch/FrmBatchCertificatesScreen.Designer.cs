namespace LMIS_Dev_Branch
{
    partial class FrmBatchCertificatesScreen
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
            dgvLearnerDetails = new DataGridView();
            LearnerName = new DataGridViewTextBoxColumn();
            LearnerSurname = new DataGridViewTextBoxColumn();
            LearnerID = new DataGridViewTextBoxColumn();
            LearnerCourse = new DataGridViewTextBoxColumn();
            LearnerCheckbox = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            lblBatchCertificates = new Label();
            btnBatchGenerate = new Button();
            chkboxAutoAllocate = new CheckBox();
            chkboxElectronicSignature = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvLearnerDetails).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLearnerDetails
            // 
            dgvLearnerDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLearnerDetails.Columns.AddRange(new DataGridViewColumn[] { LearnerName, LearnerSurname, LearnerID, LearnerCourse, LearnerCheckbox });
            dgvLearnerDetails.Location = new Point(58, 228);
            dgvLearnerDetails.Name = "dgvLearnerDetails";
            dgvLearnerDetails.RowHeadersWidth = 62;
            dgvLearnerDetails.Size = new Size(1023, 189);
            dgvLearnerDetails.TabIndex = 14;
            // 
            // LearnerName
            // 
            LearnerName.HeaderText = "Learner Name";
            LearnerName.MinimumWidth = 8;
            LearnerName.Name = "LearnerName";
            LearnerName.Width = 200;
            // 
            // LearnerSurname
            // 
            LearnerSurname.HeaderText = "Learner Surname";
            LearnerSurname.MinimumWidth = 8;
            LearnerSurname.Name = "LearnerSurname";
            LearnerSurname.Width = 200;
            // 
            // LearnerID
            // 
            LearnerID.HeaderText = "ID";
            LearnerID.MinimumWidth = 8;
            LearnerID.Name = "LearnerID";
            LearnerID.Width = 200;
            // 
            // LearnerCourse
            // 
            LearnerCourse.HeaderText = "Course Name";
            LearnerCourse.MinimumWidth = 8;
            LearnerCourse.Name = "LearnerCourse";
            LearnerCourse.Width = 200;
            // 
            // LearnerCheckbox
            // 
            LearnerCheckbox.HeaderText = "Checkbox ";
            LearnerCheckbox.MinimumWidth = 8;
            LearnerCheckbox.Name = "LearnerCheckbox";
            LearnerCheckbox.Width = 150;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(lblBatchCertificates);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 78);
            panel1.TabIndex = 15;
            // 
            // lblBatchCertificates
            // 
            lblBatchCertificates.AutoSize = true;
            lblBatchCertificates.BackColor = Color.Blue;
            lblBatchCertificates.FlatStyle = FlatStyle.Popup;
            lblBatchCertificates.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatchCertificates.ForeColor = Color.White;
            lblBatchCertificates.Location = new Point(418, 19);
            lblBatchCertificates.Name = "lblBatchCertificates";
            lblBatchCertificates.Size = new Size(293, 37);
            lblBatchCertificates.TabIndex = 6;
            lblBatchCertificates.Text = "Batch Certificates";
            // 
            // btnBatchGenerate
            // 
            btnBatchGenerate.BackColor = Color.Green;
            btnBatchGenerate.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBatchGenerate.ForeColor = Color.White;
            btnBatchGenerate.Location = new Point(58, 457);
            btnBatchGenerate.Name = "btnBatchGenerate";
            btnBatchGenerate.Size = new Size(225, 57);
            btnBatchGenerate.TabIndex = 16;
            btnBatchGenerate.Text = "Generate Certificates";
            btnBatchGenerate.UseVisualStyleBackColor = false;
            // 
            // chkboxAutoAllocate
            // 
            chkboxAutoAllocate.AutoSize = true;
            chkboxAutoAllocate.BackColor = Color.Green;
            chkboxAutoAllocate.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkboxAutoAllocate.ForeColor = Color.White;
            chkboxAutoAllocate.Location = new Point(325, 473);
            chkboxAutoAllocate.Name = "chkboxAutoAllocate";
            chkboxAutoAllocate.Size = new Size(331, 27);
            chkboxAutoAllocate.TabIndex = 17;
            chkboxAutoAllocate.Text = "Auto Allocate Certificate Numbers";
            chkboxAutoAllocate.UseVisualStyleBackColor = false;
            // 
            // chkboxElectronicSignature
            // 
            chkboxElectronicSignature.AutoSize = true;
            chkboxElectronicSignature.BackColor = Color.Green;
            chkboxElectronicSignature.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkboxElectronicSignature.ForeColor = Color.White;
            chkboxElectronicSignature.Location = new Point(704, 473);
            chkboxElectronicSignature.Name = "chkboxElectronicSignature";
            chkboxElectronicSignature.Size = new Size(211, 27);
            chkboxElectronicSignature.TabIndex = 18;
            chkboxElectronicSignature.Text = "Electronic Signature";
            chkboxElectronicSignature.UseVisualStyleBackColor = false;
            chkboxElectronicSignature.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FrmBatchCertificatesScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 660);
            Controls.Add(chkboxElectronicSignature);
            Controls.Add(chkboxAutoAllocate);
            Controls.Add(btnBatchGenerate);
            Controls.Add(panel1);
            Controls.Add(dgvLearnerDetails);
            Name = "FrmBatchCertificatesScreen";
            Text = "FrmBatchCertificatesScreen";
            ((System.ComponentModel.ISupportInitialize)dgvLearnerDetails).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLearnerDetails;
        private Panel panel1;
        private Label lblBatchCertificates;
        private DataGridViewTextBoxColumn LearnerName;
        private DataGridViewTextBoxColumn LearnerSurname;
        private DataGridViewTextBoxColumn LearnerID;
        private DataGridViewTextBoxColumn LearnerCourse;
        private DataGridViewTextBoxColumn LearnerCheckbox;
        private Button btnBatchGenerate;
        private CheckBox chkboxAutoAllocate;
        private CheckBox chkboxElectronicSignature;
    }
}