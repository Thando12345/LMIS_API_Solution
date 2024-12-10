namespace LMIS_Dev_Branch
{
    partial class FrmCreateInterventionScreen
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
            lblCreateIntervention = new Label();
            lblCourseName = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            lblDates = new Label();
            lblFunder = new Label();
            cmbFunderDropdown = new ComboBox();
            lblFacilitator = new Label();
            cmbFacilitatorDropdown = new ComboBox();
            lblAssessor = new Label();
            cmbAssessorDropdown = new ComboBox();
            lblModerator = new Label();
            cmbModeratorDropdown = new ComboBox();
            btnLinkLearners = new Button();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCreateIntervention
            // 
            lblCreateIntervention.AutoSize = true;
            lblCreateIntervention.BackColor = Color.DarkBlue;
            lblCreateIntervention.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateIntervention.ForeColor = Color.White;
            lblCreateIntervention.Location = new Point(220, 25);
            lblCreateIntervention.Name = "lblCreateIntervention";
            lblCreateIntervention.Size = new Size(342, 43);
            lblCreateIntervention.TabIndex = 0;
            lblCreateIntervention.Text = "Create Intervention";
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCourseName.Location = new Point(40, 140);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(130, 23);
            lblCourseName.TabIndex = 1;
            lblCourseName.Text = "Course Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(220, 140);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter course name";
            textBox1.Size = new Size(342, 33);
            textBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(220, 207);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(342, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(lblCreateIntervention);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 90);
            panel1.TabIndex = 4;
            // 
            // lblDates
            // 
            lblDates.AutoSize = true;
            lblDates.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDates.Location = new Point(40, 207);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(62, 23);
            lblDates.TabIndex = 5;
            lblDates.Text = "Dates";
            // 
            // lblFunder
            // 
            lblFunder.AutoSize = true;
            lblFunder.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFunder.Location = new Point(40, 282);
            lblFunder.Name = "lblFunder";
            lblFunder.Size = new Size(71, 23);
            lblFunder.TabIndex = 6;
            lblFunder.Text = "Funder";
            // 
            // cmbFunderDropdown
            // 
            cmbFunderDropdown.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFunderDropdown.FormattingEnabled = true;
            cmbFunderDropdown.Location = new Point(220, 272);
            cmbFunderDropdown.Name = "cmbFunderDropdown";
            cmbFunderDropdown.Size = new Size(342, 33);
            cmbFunderDropdown.TabIndex = 7;
            // 
            // lblFacilitator
            // 
            lblFacilitator.AutoSize = true;
            lblFacilitator.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFacilitator.Location = new Point(40, 350);
            lblFacilitator.Name = "lblFacilitator";
            lblFacilitator.Size = new Size(96, 23);
            lblFacilitator.TabIndex = 8;
            lblFacilitator.Text = "Facilitator";
            // 
            // cmbFacilitatorDropdown
            // 
            cmbFacilitatorDropdown.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFacilitatorDropdown.FormattingEnabled = true;
            cmbFacilitatorDropdown.Location = new Point(220, 346);
            cmbFacilitatorDropdown.Name = "cmbFacilitatorDropdown";
            cmbFacilitatorDropdown.Size = new Size(342, 33);
            cmbFacilitatorDropdown.TabIndex = 9;
            // 
            // lblAssessor
            // 
            lblAssessor.AutoSize = true;
            lblAssessor.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAssessor.Location = new Point(40, 421);
            lblAssessor.Name = "lblAssessor";
            lblAssessor.Size = new Size(92, 23);
            lblAssessor.TabIndex = 10;
            lblAssessor.Text = "Assessor";
            // 
            // cmbAssessorDropdown
            // 
            cmbAssessorDropdown.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAssessorDropdown.FormattingEnabled = true;
            cmbAssessorDropdown.Location = new Point(220, 411);
            cmbAssessorDropdown.Name = "cmbAssessorDropdown";
            cmbAssessorDropdown.Size = new Size(342, 33);
            cmbAssessorDropdown.TabIndex = 11;
            // 
            // lblModerator
            // 
            lblModerator.AutoSize = true;
            lblModerator.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModerator.Location = new Point(40, 492);
            lblModerator.Name = "lblModerator";
            lblModerator.Size = new Size(102, 23);
            lblModerator.TabIndex = 12;
            lblModerator.Text = "Moderator";
            lblModerator.Click += label1_Click;
            // 
            // cmbModeratorDropdown
            // 
            cmbModeratorDropdown.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbModeratorDropdown.FormattingEnabled = true;
            cmbModeratorDropdown.Location = new Point(220, 488);
            cmbModeratorDropdown.Name = "cmbModeratorDropdown";
            cmbModeratorDropdown.Size = new Size(342, 33);
            cmbModeratorDropdown.TabIndex = 13;
            // 
            // btnLinkLearners
            // 
            btnLinkLearners.BackColor = Color.Blue;
            btnLinkLearners.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLinkLearners.ForeColor = Color.White;
            btnLinkLearners.Location = new Point(40, 540);
            btnLinkLearners.Name = "btnLinkLearners";
            btnLinkLearners.Size = new Size(50, 50);
            btnLinkLearners.TabIndex = 14;
            btnLinkLearners.Text = "+";
            toolTip1.SetToolTip(btnLinkLearners, "Add learner by ID");
            btnLinkLearners.UseVisualStyleBackColor = false;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(413, 580);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 15;
            button1.Text = " ";
            toolTip1.SetToolTip(button1, "Add learner by ID");
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmCreateInterventionScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 783);
            Controls.Add(button1);
            Controls.Add(btnLinkLearners);
            Controls.Add(cmbModeratorDropdown);
            Controls.Add(lblModerator);
            Controls.Add(cmbAssessorDropdown);
            Controls.Add(lblAssessor);
            Controls.Add(cmbFacilitatorDropdown);
            Controls.Add(lblFacilitator);
            Controls.Add(cmbFunderDropdown);
            Controls.Add(lblFunder);
            Controls.Add(lblDates);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(lblCourseName);
            Name = "FrmCreateInterventionScreen";
            Text = "FrmCreateInterventionScreen";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreateIntervention;
        private Label lblCourseName;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Label lblDates;
        private Label lblFunder;
        private ComboBox cmbFunderDropdown;
        private Label lblFacilitator;
        private ComboBox cmbFacilitatorDropdown;
        private Label lblAssessor;
        private ComboBox cmbAssessorDropdown;
        private Label lblModerator;
        private ComboBox cmbModeratorDropdown;
        private Button btnLinkLearners;
        private ToolTip toolTip1;
        private Button button1;
    }
}