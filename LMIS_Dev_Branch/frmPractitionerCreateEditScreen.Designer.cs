 namespace LMIS_Dev_Branch
{
    partial class frmPractitionerCreateEditScreen
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
            lblName = new Label();
            txtPractitionerName = new TextBox();
            lblSurname = new Label();
            txtPractitionerSurname = new TextBox();
            lblIDNumber = new Label();
            txtIdNumber = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            dgvPractitionerRole = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            Role_Name = new DataGridViewTextBoxColumn();
            Selected = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewTextBoxColumn();
            btnAddRole = new Button();
            btnSavePractitioner = new Button();
            btnCancelPractitioner = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPractitionerRole).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(50, 157);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 27);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtPractitionerName
            // 
            txtPractitionerName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPractitionerName.Location = new Point(184, 157);
            txtPractitionerName.Name = "txtPractitionerName";
            txtPractitionerName.PlaceholderText = "Enter practitioner's first name";
            txtPractitionerName.Size = new Size(364, 35);
            txtPractitionerName.TabIndex = 1;
            txtPractitionerName.TextChanged += txtPractitionerName_TextChanged;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSurname.Location = new Point(50, 227);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(110, 27);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Surname";
            // 
            // txtPractitionerSurname
            // 
            txtPractitionerSurname.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPractitionerSurname.Location = new Point(184, 227);
            txtPractitionerSurname.Name = "txtPractitionerSurname";
            txtPractitionerSurname.PlaceholderText = "Enter practitioner's surname";
            txtPractitionerSurname.Size = new Size(364, 35);
            txtPractitionerSurname.TabIndex = 3;
            // 
            // lblIDNumber
            // 
            lblIDNumber.AutoSize = true;
            lblIDNumber.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDNumber.Location = new Point(50, 297);
            lblIDNumber.Name = "lblIDNumber";
            lblIDNumber.Size = new Size(128, 27);
            lblIDNumber.TabIndex = 4;
            lblIDNumber.Text = "ID Number";
            // 
            // txtIdNumber
            // 
            txtIdNumber.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdNumber.Location = new Point(184, 293);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.PlaceholderText = "Enter practitioner's ID (Optional)";
            txtIdNumber.Size = new Size(364, 35);
            txtIdNumber.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(365, 21);
            label1.Name = "label1";
            label1.Size = new Size(401, 37);
            label1.TabIndex = 6;
            label1.Text = "Practitioner Management";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 78);
            panel1.TabIndex = 7;
            // 
            // dgvPractitionerRole
            // 
            dgvPractitionerRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPractitionerRole.Columns.AddRange(new DataGridViewColumn[] { Role_Name, Selected, Actions });
            dgvPractitionerRole.Location = new Point(50, 351);
            dgvPractitionerRole.Name = "dgvPractitionerRole";
            dgvPractitionerRole.RowHeadersWidth = 62;
            dgvPractitionerRole.Size = new Size(1050, 225);
            dgvPractitionerRole.TabIndex = 8;
            dgvPractitionerRole.CellContentClick += dgvPractitionerRole_CellContentClick;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Blue;
            btnEdit.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(437, 387);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(60, 34);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit ";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(506, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Role_Name
            // 
            Role_Name.HeaderText = "Role Name";
            Role_Name.MinimumWidth = 8;
            Role_Name.Name = "Role_Name";
            Role_Name.Width = 150;
            // 
            // Selected
            // 
            Selected.HeaderText = "Selected";
            Selected.MinimumWidth = 8;
            Selected.Name = "Selected";
            Selected.Width = 150;
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.MinimumWidth = 10;
            Actions.Name = "Actions";
            Actions.Width = 200;
            // 
            // btnAddRole
            // 
            btnAddRole.BackColor = Color.Blue;
            btnAddRole.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRole.ForeColor = Color.White;
            btnAddRole.Location = new Point(50, 604);
            btnAddRole.Name = "btnAddRole";
            btnAddRole.Size = new Size(129, 34);
            btnAddRole.TabIndex = 11;
            btnAddRole.Text = "Add Role";
            btnAddRole.UseVisualStyleBackColor = false;
            // 
            // btnSavePractitioner
            // 
            btnSavePractitioner.BackColor = Color.Green;
            btnSavePractitioner.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSavePractitioner.ForeColor = Color.White;
            btnSavePractitioner.Location = new Point(203, 604);
            btnSavePractitioner.Name = "btnSavePractitioner";
            btnSavePractitioner.Size = new Size(129, 34);
            btnSavePractitioner.TabIndex = 12;
            btnSavePractitioner.Text = "Save";
            btnSavePractitioner.UseVisualStyleBackColor = false;
            // 
            // btnCancelPractitioner
            // 
            btnCancelPractitioner.BackColor = Color.Red;
            btnCancelPractitioner.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelPractitioner.ForeColor = Color.White;
            btnCancelPractitioner.Location = new Point(1009, 604);
            btnCancelPractitioner.Name = "btnCancelPractitioner";
            btnCancelPractitioner.Size = new Size(91, 34);
            btnCancelPractitioner.TabIndex = 13;
            btnCancelPractitioner.Text = "Cancel";
            btnCancelPractitioner.UseVisualStyleBackColor = false;
            // 
            // frmPractitionerCreateEditScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 737);
            Controls.Add(btnCancelPractitioner);
            Controls.Add(btnSavePractitioner);
            Controls.Add(btnAddRole);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvPractitionerRole);
            Controls.Add(panel1);
            Controls.Add(txtIdNumber);
            Controls.Add(lblIDNumber);
            Controls.Add(txtPractitionerSurname);
            Controls.Add(lblSurname);
            Controls.Add(txtPractitionerName);
            Controls.Add(lblName);
            Name = "frmPractitionerCreateEditScreen";
            Text = " ";
            Load += frmPractitionerCreateEditScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPractitionerRole).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtPractitionerName;
        private Label lblSurname;
        private TextBox txtPractitionerSurname;
        private Label lblIDNumber;
        private TextBox txtIdNumber;
        private Label label1;
        private Panel panel1;
        private DataGridView dgvPractitionerRole;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Role_Name;
        private DataGridViewTextBoxColumn Selected;
        private DataGridViewTextBoxColumn Actions;
        private Button btnAddRole;
        private Button btnSavePractitioner;
        private Button btnCancelPractitioner;
    }
}