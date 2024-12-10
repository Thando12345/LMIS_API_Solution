namespace LMIS_Dev_Branch
{
    partial class frmPractitionersViewScreen
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
            panel1 = new Panel();
            lblSearchPractitioner = new Label();
            textBox1 = new TextBox();
            btnSearchPractitioner = new Button();
            dgvPractitioner = new DataGridView();
            First_Name = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Course = new DataGridViewTextBoxColumn();
            btnEditPractitioner = new Button();
            btnCreatePractitioner = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPractitioner).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(lblSearchPractitioner);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 85);
            panel1.TabIndex = 0;
            // 
            // lblSearchPractitioner
            // 
            lblSearchPractitioner.AutoSize = true;
            lblSearchPractitioner.BackColor = Color.Blue;
            lblSearchPractitioner.FlatStyle = FlatStyle.Flat;
            lblSearchPractitioner.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchPractitioner.ForeColor = Color.White;
            lblSearchPractitioner.Location = new Point(379, 26);
            lblSearchPractitioner.Margin = new Padding(9, 0, 9, 0);
            lblSearchPractitioner.Name = "lblSearchPractitioner";
            lblSearchPractitioner.Size = new Size(338, 41);
            lblSearchPractitioner.TabIndex = 0;
            lblSearchPractitioner.Text = "Search Practitioners";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(654, 103);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Name, Surname, Role, or Course";
            textBox1.Size = new Size(364, 35);
            textBox1.TabIndex = 1;
            // 
            // btnSearchPractitioner
            // 
            btnSearchPractitioner.BackColor = Color.Blue;
            btnSearchPractitioner.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchPractitioner.ForeColor = Color.White;
            btnSearchPractitioner.Location = new Point(1045, 103);
            btnSearchPractitioner.Name = "btnSearchPractitioner";
            btnSearchPractitioner.Size = new Size(112, 41);
            btnSearchPractitioner.TabIndex = 2;
            btnSearchPractitioner.Text = "Search";
            btnSearchPractitioner.UseVisualStyleBackColor = false;
            // 
            // dgvPractitioner
            // 
            dgvPractitioner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPractitioner.Columns.AddRange(new DataGridViewColumn[] { First_Name, Surname, Role, Course });
            dgvPractitioner.Location = new Point(48, 193);
            dgvPractitioner.Name = "dgvPractitioner";
            dgvPractitioner.RowHeadersWidth = 62;
            dgvPractitioner.Size = new Size(1109, 225);
            dgvPractitioner.TabIndex = 3;
            // 
            // First_Name
            // 
            First_Name.HeaderText = "First Name";
            First_Name.MinimumWidth = 8;
            First_Name.Name = "First_Name";
            First_Name.Width = 150;
            // 
            // Surname
            // 
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 8;
            Surname.Name = "Surname";
            Surname.Width = 150;
            // 
            // Role
            // 
            Role.HeaderText = " Role ";
            Role.MinimumWidth = 8;
            Role.Name = "Role";
            Role.Width = 150;
            // 
            // Course
            // 
            Course.HeaderText = "Course";
            Course.MinimumWidth = 8;
            Course.Name = "Course";
            Course.Width = 150;
            // 
            // btnEditPractitioner
            // 
            btnEditPractitioner.BackColor = Color.Green;
            btnEditPractitioner.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditPractitioner.ForeColor = Color.White;
            btnEditPractitioner.Location = new Point(717, 219);
            btnEditPractitioner.Name = "btnEditPractitioner";
            btnEditPractitioner.Size = new Size(81, 41);
            btnEditPractitioner.TabIndex = 4;
            btnEditPractitioner.Text = "Edit";
            btnEditPractitioner.UseVisualStyleBackColor = false;
            // 
            // btnCreatePractitioner
            // 
            btnCreatePractitioner.BackColor = Color.DarkBlue;
            btnCreatePractitioner.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreatePractitioner.ForeColor = Color.White;
            btnCreatePractitioner.Location = new Point(888, 455);
            btnCreatePractitioner.Name = "btnCreatePractitioner";
            btnCreatePractitioner.Size = new Size(269, 45);
            btnCreatePractitioner.TabIndex = 5;
            btnCreatePractitioner.Text = "Create New Practitioner";
            btnCreatePractitioner.UseVisualStyleBackColor = false;
            btnCreatePractitioner.Click += btnCreatePractitioner_Click;
            // 
            // frmPractitionersViewScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 599);
            Controls.Add(btnCreatePractitioner);
            Controls.Add(btnEditPractitioner);
            Controls.Add(dgvPractitioner);
            Controls.Add(btnSearchPractitioner);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "frmPractitionersViewScreen";
            Text = "Practitioners View Screen";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPractitioner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSearchPractitioner;
        private TextBox textBox1;
        private Button btnSearchPractitioner;
        private DataGridView dgvPractitioner;
        private Button btnEditPractitioner;
        private Button btnCreatePractitioner;
        private DataGridViewTextBoxColumn First_Name;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Course;
    }
}