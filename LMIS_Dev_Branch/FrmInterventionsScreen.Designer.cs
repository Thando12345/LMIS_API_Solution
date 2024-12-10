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
            ((System.ComponentModel.ISupportInitialize)dgvCourseDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumBlue;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(370, 32);
            label1.Name = "label1";
            label1.Size = new Size(238, 43);
            label1.TabIndex = 0;
            label1.Text = "Interventions";
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
            dgvCourseDetail.Columns.AddRange(new DataGridViewColumn[] { Name_of_Course });
            dgvCourseDetail.Location = new Point(40, 225);
            dgvCourseDetail.Name = "dgvCourseDetail";
            dgvCourseDetail.RowHeadersWidth = 62;
            dgvCourseDetail.Size = new Size(927, 225);
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
            // FrmInterventionsScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 609);
            Controls.Add(dgvCourseDetail);
            Controls.Add(btnSearch);
            Controls.Add(txtInterventionSearch);
            Controls.Add(label1);
            Name = "FrmInterventionsScreen";
            Text = "FrmInterventionsScreen";
            ((System.ComponentModel.ISupportInitialize)dgvCourseDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInterventionSearch;
        private Button btnSearch;
        private DataGridView dgvCourseDetail;
        private DataGridViewTextBoxColumn Name_of_Course;
    }
}