namespace LMIS_Dev_Branch
{
    partial class FrmInterventionsScreen
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
            label1 = new Label();
            txtInterventionSearch = new TextBox();
            btnSearch = new Button();
            dgvCourseDetail = new DataGridView();
            Name_of_Course = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Funder = new DataGridViewTextBoxColumn();
            Facilitator = new DataGridViewTextBoxColumn();
            Assessor = new DataGridViewTextBoxColumn();
            Moderator = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnDelete = new Button();
            btnCreateIntervention = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCourseDetail).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumBlue;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(445, 28);
            label1.Name = "label1";
            label1.Size = new Size(238, 43);
            label1.TabIndex = 0;
            label1.Text = "Interventions";
            label1.Click += label1_Click;
            // 
            // txtInterventionSearch
            // 
            txtInterventionSearch.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInterventionSearch.Location = new Point(40, 139);
            txtInterventionSearch.Name = "txtInterventionSearch";
            txtInterventionSearch.PlaceholderText = "Search for an intervention or learner";
            txtInterventionSearch.Size = new Size(363, 33);
            txtInterventionSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Blue;
            btnSearch.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(430, 135);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 40);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvCourseDetail
            // 
            dgvCourseDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourseDetail.Columns.AddRange(new DataGridViewColumn[] { Name_of_Course, Date, Funder, Facilitator, Assessor, Moderator, Actions });
            dgvCourseDetail.Location = new Point(12, 225);
            dgvCourseDetail.Name = "dgvCourseDetail";
            dgvCourseDetail.RowHeadersWidth = 62;
            dgvCourseDetail.Size = new Size(1136, 225);
            dgvCourseDetail.TabIndex = 4;
            dgvCourseDetail.CellContentClick += dgvCourseDetail_CellContentClick;
            // 
            // Name_of_Course
            // 
            Name_of_Course.HeaderText = "Course Name ";
            Name_of_Course.MinimumWidth = 8;
            Name_of_Course.Name = "Name_of_Course";
            Name_of_Course.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 150;
            // 
            // Funder
            // 
            Funder.HeaderText = "Funder";
            Funder.MinimumWidth = 8;
            Funder.Name = "Funder";
            Funder.Width = 150;
            // 
            // Facilitator
            // 
            Facilitator.HeaderText = "Facilitator";
            Facilitator.MinimumWidth = 8;
            Facilitator.Name = "Facilitator";
            Facilitator.Width = 150;
            // 
            // Assessor
            // 
            Assessor.HeaderText = "Assessor";
            Assessor.MinimumWidth = 8;
            Assessor.Name = "Assessor";
            Assessor.Width = 150;
            // 
            // Moderator
            // 
            Moderator.HeaderText = "Moderator";
            Moderator.MinimumWidth = 8;
            Moderator.Name = "Moderator";
            Moderator.Width = 150;
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.MinimumWidth = 8;
            Actions.Name = "Actions";
            Actions.Width = 170;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Green;
            btnEdit.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(981, 286);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(60, 35);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1058, 286);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCreateIntervention
            // 
            btnCreateIntervention.BackColor = Color.Green;
            btnCreateIntervention.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateIntervention.ForeColor = Color.White;
            btnCreateIntervention.Location = new Point(948, 470);
            btnCreateIntervention.Name = "btnCreateIntervention";
            btnCreateIntervention.Size = new Size(200, 50);
            btnCreateIntervention.TabIndex = 7;
            btnCreateIntervention.Text = "Create Intervention";
            btnCreateIntervention.UseVisualStyleBackColor = false;
            btnCreateIntervention.Click += btnCreateIntervention_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 95);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // FrmInterventionsScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 609);
            Controls.Add(panel1);
            Controls.Add(btnCreateIntervention);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvCourseDetail);
            Controls.Add(btnSearch);
            Controls.Add(txtInterventionSearch);
            Name = "FrmInterventionsScreen";
            Text = "FrmInterventionsScreen";
            ((System.ComponentModel.ISupportInitialize)dgvCourseDetail).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInterventionSearch;
        private Button btnSearch;
        private DataGridView dgvCourseDetail;
        private Button btnEdit;
        private DataGridViewTextBoxColumn Name_of_Course;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Funder;
        private DataGridViewTextBoxColumn Facilitator;
        private DataGridViewTextBoxColumn Assessor;
        private DataGridViewTextBoxColumn Moderator;
        private DataGridViewTextBoxColumn Actions;
        private Button btnDelete;
        private Button btnCreateIntervention;
        private Panel panel1;
    }
}