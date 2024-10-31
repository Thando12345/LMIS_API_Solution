namespace LMIS_Dev_Branch
{
    partial class FrmUserPortalMain
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
            lblUserPortal = new Label();
            btnEnrollLearner = new Button();
            btnCreateCourse = new Button();
            btnAddPractitioner = new Button();
            btnCreateIntervention = new Button();
            btnGenerateCertificate = new Button();
            SuspendLayout();
            // 
            // lblUserPortal
            // 
            lblUserPortal.AutoSize = true;
            lblUserPortal.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserPortal.ForeColor = Color.DarkBlue;
            lblUserPortal.Location = new Point(247, 9);
            lblUserPortal.Name = "lblUserPortal";
            lblUserPortal.Size = new Size(233, 46);
            lblUserPortal.TabIndex = 0;
            lblUserPortal.Text = "User Portal";
            // 
            // btnEnrollLearner
            // 
            btnEnrollLearner.BackColor = Color.LightGreen;
            btnEnrollLearner.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnrollLearner.Location = new Point(247, 79);
            btnEnrollLearner.Name = "btnEnrollLearner";
            btnEnrollLearner.Size = new Size(197, 59);
            btnEnrollLearner.TabIndex = 1;
            btnEnrollLearner.Text = "Enroll Learner";
            btnEnrollLearner.UseVisualStyleBackColor = false;
            btnEnrollLearner.Click += btnEnrollLearner_Click;
            // 
            // btnCreateCourse
            // 
            btnCreateCourse.BackColor = Color.Blue;
            btnCreateCourse.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateCourse.Location = new Point(247, 149);
            btnCreateCourse.Name = "btnCreateCourse";
            btnCreateCourse.Size = new Size(197, 59);
            btnCreateCourse.TabIndex = 2;
            btnCreateCourse.Text = "Create Course";
            btnCreateCourse.UseVisualStyleBackColor = false;
            btnCreateCourse.Click += btnCreateCourse_Click;
            // 
            // btnAddPractitioner
            // 
            btnAddPractitioner.BackColor = Color.LightBlue;
            btnAddPractitioner.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPractitioner.Location = new Point(247, 214);
            btnAddPractitioner.Name = "btnAddPractitioner";
            btnAddPractitioner.Size = new Size(197, 59);
            btnAddPractitioner.TabIndex = 3;
            btnAddPractitioner.Text = "Add Practitioner";
            btnAddPractitioner.UseVisualStyleBackColor = false;
            // 
            // btnCreateIntervention
            // 
            btnCreateIntervention.BackColor = Color.Orange;
            btnCreateIntervention.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateIntervention.Location = new Point(247, 285);
            btnCreateIntervention.Name = "btnCreateIntervention";
            btnCreateIntervention.Size = new Size(197, 59);
            btnCreateIntervention.TabIndex = 4;
            btnCreateIntervention.Text = "Create Intervention";
            btnCreateIntervention.UseVisualStyleBackColor = false;
            // 
            // btnGenerateCertificate
            // 
            btnGenerateCertificate.BackColor = Color.Yellow;
            btnGenerateCertificate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateCertificate.Location = new Point(247, 355);
            btnGenerateCertificate.Name = "btnGenerateCertificate";
            btnGenerateCertificate.Size = new Size(197, 59);
            btnGenerateCertificate.TabIndex = 5;
            btnGenerateCertificate.Text = "Generate Certificate";
            btnGenerateCertificate.UseVisualStyleBackColor = false;
            // 
            // FrmUserPortalMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerateCertificate);
            Controls.Add(btnCreateIntervention);
            Controls.Add(btnAddPractitioner);
            Controls.Add(btnCreateCourse);
            Controls.Add(btnEnrollLearner);
            Controls.Add(lblUserPortal);
            Name = "FrmUserPortalMain";
            Text = "FrmUserPortalMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserPortal;
        private Button btnEnrollLearner;
        private Button btnCreateCourse;
        private Button btnAddPractitioner;
        private Button btnCreateIntervention;
        private Button btnGenerateCertificate;
    }
}