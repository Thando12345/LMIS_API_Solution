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
            panel1 = new Panel();
            lblBatchCertificates = new Label();
            btnBatchGenerate = new Button();
            chkboxAutoAllocate = new CheckBox();
            chkboxElectronicSignature = new CheckBox();
            btnClose = new Button();
            LearnerName = new DataGridViewTextBoxColumn();
            LearnerSurname = new DataGridViewTextBoxColumn();
            LearnerID = new DataGridViewTextBoxColumn();
            LearnerCourse = new DataGridViewTextBoxColumn();
            LearnerCheckbox = new DataGridViewTextBoxColumn();
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
            dgvLearnerDetails.Size = new Size(1326, 256);
            dgvLearnerDetails.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(lblBatchCertificates);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1457, 78);
            panel1.TabIndex = 15;
            // 
            // lblBatchCertificates
            // 
            lblBatchCertificates.AutoSize = true;
            lblBatchCertificates.BackColor = Color.Blue;
            lblBatchCertificates.FlatStyle = FlatStyle.Popup;
            lblBatchCertificates.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatchCertificates.ForeColor = Color.White;
            lblBatchCertificates.Location = new Point(620, 19);
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
            btnBatchGenerate.Location = new Point(58, 511);
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
            chkboxAutoAllocate.Location = new Point(325, 527);
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
            chkboxElectronicSignature.Location = new Point(704, 527);
            chkboxElectronicSignature.Name = "chkboxElectronicSignature";
            chkboxElectronicSignature.Size = new Size(211, 27);
            chkboxElectronicSignature.TabIndex = 18;
            chkboxElectronicSignature.Text = "Electronic Signature";
            chkboxElectronicSignature.UseVisualStyleBackColor = false;
            chkboxElectronicSignature.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1273, 520);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 48);
            btnClose.TabIndex = 45;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // LearnerName
            // 
            LearnerName.HeaderText = "Learner Name";
            LearnerName.MinimumWidth = 8;
            LearnerName.Name = "LearnerName";
            LearnerName.Width = 250;
            // 
            // LearnerSurname
            // 
            LearnerSurname.HeaderText = "Learner Surname";
            LearnerSurname.MinimumWidth = 8;
            LearnerSurname.Name = "LearnerSurname";
            LearnerSurname.Width = 250;
            // 
            // LearnerID
            // 
            LearnerID.HeaderText = "ID";
            LearnerID.MinimumWidth = 8;
            LearnerID.Name = "LearnerID";
            LearnerID.Width = 250;
            // 
            // LearnerCourse
            // 
            LearnerCourse.HeaderText = "Course Name";
            LearnerCourse.MinimumWidth = 8;
            LearnerCourse.Name = "LearnerCourse";
            LearnerCourse.Width = 250;
            // 
            // LearnerCheckbox
            // 
            LearnerCheckbox.HeaderText = "Checkbox ";
            LearnerCheckbox.MinimumWidth = 8;
            LearnerCheckbox.Name = "LearnerCheckbox";
            LearnerCheckbox.Width = 250;
            // 
            // FrmBatchCertificatesScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 660);
            Controls.Add(btnClose);
            Controls.Add(chkboxElectronicSignature);
            Controls.Add(chkboxAutoAllocate);
            Controls.Add(btnBatchGenerate);
            Controls.Add(panel1);
            Controls.Add(dgvLearnerDetails);
            Name = "FrmBatchCertificatesScreen";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnBatchGenerate;
        private CheckBox chkboxAutoAllocate;
        private CheckBox chkboxElectronicSignature;
        private Button btnClose;
        private DataGridViewTextBoxColumn LearnerName;
        private DataGridViewTextBoxColumn LearnerSurname;
        private DataGridViewTextBoxColumn LearnerID;
        private DataGridViewTextBoxColumn LearnerCourse;
        private DataGridViewTextBoxColumn LearnerCheckbox;
    }
}