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
            btnClose = new Button();
            btnDelete = new Button();
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
            panel1.Size = new Size(1466, 85);
            panel1.TabIndex = 0;
            // 
            // lblSearchPractitioner
            // 
            lblSearchPractitioner.AutoSize = true;
            lblSearchPractitioner.BackColor = Color.Blue;
            lblSearchPractitioner.FlatStyle = FlatStyle.Flat;
            lblSearchPractitioner.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchPractitioner.ForeColor = Color.White;
            lblSearchPractitioner.Location = new Point(574, 20);
            lblSearchPractitioner.Margin = new Padding(9, 0, 9, 0);
            lblSearchPractitioner.Name = "lblSearchPractitioner";
            lblSearchPractitioner.Size = new Size(338, 41);
            lblSearchPractitioner.TabIndex = 0;
            lblSearchPractitioner.Text = "Search Practitioners";
            lblSearchPractitioner.Click += lblSearchPractitioner_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(826, 110);
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
            btnSearchPractitioner.Location = new Point(1211, 104);
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
            dgvPractitioner.Size = new Size(1275, 225);
            dgvPractitioner.TabIndex = 3;
            // 
            // First_Name
            // 
            First_Name.HeaderText = "First Name";
            First_Name.MinimumWidth = 8;
            First_Name.Name = "First_Name";
            First_Name.Width = 300;
            // 
            // Surname
            // 
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 8;
            Surname.Name = "Surname";
            Surname.Width = 300;
            // 
            // Role
            // 
            Role.HeaderText = " Role ";
            Role.MinimumWidth = 8;
            Role.Name = "Role";
            Role.Width = 300;
            // 
            // Course
            // 
            Course.HeaderText = "Course";
            Course.MinimumWidth = 8;
            Course.Name = "Course";
            Course.Width = 300;
            // 
            // btnEditPractitioner
            // 
            btnEditPractitioner.BackColor = Color.Green;
            btnEditPractitioner.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditPractitioner.ForeColor = Color.White;
            btnEditPractitioner.Location = new Point(1329, 193);
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
            btnCreatePractitioner.Location = new Point(48, 461);
            btnCreatePractitioner.Name = "btnCreatePractitioner";
            btnCreatePractitioner.Size = new Size(269, 59);
            btnCreatePractitioner.TabIndex = 5;
            btnCreatePractitioner.Text = "Create New Practitioner";
            btnCreatePractitioner.UseVisualStyleBackColor = false;
            btnCreatePractitioner.Click += btnCreatePractitioner_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1212, 458);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 62);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1329, 240);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 41);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // frmPractitionersViewScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 599);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnCreatePractitioner);
            Controls.Add(btnEditPractitioner);
            Controls.Add(dgvPractitioner);
            Controls.Add(btnSearchPractitioner);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "frmPractitionersViewScreen";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnClose;
        private Button btnDelete;
    }
}