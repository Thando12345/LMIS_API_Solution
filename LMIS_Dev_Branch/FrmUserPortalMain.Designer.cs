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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUserPortal
            // 
            lblUserPortal.AutoSize = true;
            lblUserPortal.BackColor = Color.DarkBlue;
            lblUserPortal.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserPortal.ForeColor = Color.White;
            lblUserPortal.Location = new Point(244, 7);
            lblUserPortal.Name = "lblUserPortal";
            lblUserPortal.Size = new Size(233, 46);
            lblUserPortal.TabIndex = 0;
            lblUserPortal.Text = "User Portal";
            lblUserPortal.Click += lblUserPortal_Click;
            // 
            // btnEnrollLearner
            // 
            btnEnrollLearner.BackColor = Color.LightGreen;
            btnEnrollLearner.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnrollLearner.Location = new Point(247, 107);
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
            btnCreateCourse.Location = new Point(247, 186);
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
            btnAddPractitioner.Location = new Point(247, 264);
            btnAddPractitioner.Name = "btnAddPractitioner";
            btnAddPractitioner.Size = new Size(197, 59);
            btnAddPractitioner.TabIndex = 3;
            btnAddPractitioner.Text = "Add Practitioner";
            btnAddPractitioner.UseVisualStyleBackColor = false;
            btnAddPractitioner.Click += btnAddPractitioner_Click;
            // 
            // btnCreateIntervention
            // 
            btnCreateIntervention.BackColor = Color.Orange;
            btnCreateIntervention.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateIntervention.Location = new Point(247, 341);
            btnCreateIntervention.Name = "btnCreateIntervention";
            btnCreateIntervention.Size = new Size(197, 59);
            btnCreateIntervention.TabIndex = 4;
            btnCreateIntervention.Text = "Create Intervention";
            btnCreateIntervention.UseVisualStyleBackColor = false;
            btnCreateIntervention.Click += btnCreateIntervention_Click;
            // 
            // btnGenerateCertificate
            // 
            btnGenerateCertificate.BackColor = Color.Yellow;
            btnGenerateCertificate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateCertificate.Location = new Point(247, 421);
            btnGenerateCertificate.Name = "btnGenerateCertificate";
            btnGenerateCertificate.Size = new Size(197, 59);
            btnGenerateCertificate.TabIndex = 5;
            btnGenerateCertificate.Text = "Generate Certificate";
            btnGenerateCertificate.UseVisualStyleBackColor = false;
            btnGenerateCertificate.Click += btnGenerateCertificate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(lblUserPortal);
            panel1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 71);
            panel1.TabIndex = 6;
            // 
            // FrmUserPortalMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 514);
            Controls.Add(panel1);
            Controls.Add(btnGenerateCertificate);
            Controls.Add(btnCreateIntervention);
            Controls.Add(btnAddPractitioner);
            Controls.Add(btnCreateCourse);
            Controls.Add(btnEnrollLearner);
            Name = "FrmUserPortalMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUserPortalMain";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUserPortal;
        private Button btnEnrollLearner;
        private Button btnCreateCourse;
        private Button btnAddPractitioner;
        private Button btnCreateIntervention;
        private Button btnGenerateCertificate;
        private Panel panel1;
    }
}