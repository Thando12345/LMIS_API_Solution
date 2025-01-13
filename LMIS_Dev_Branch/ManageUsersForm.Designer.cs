namespace LMIS_Dev_Branch
{
    partial class FrmManageUsersForm
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
            dgvUsers = new DataGridView();
            btnCreateUser = new Button();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            label1 = new Label();
            TextBoxColumn = new DataGridViewTextBoxColumn();
            TextBoxColumn2 = new DataGridViewTextBoxColumn();
            ComboBoxColumn = new DataGridViewTextBoxColumn();
            TextBoxColumn3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { TextBoxColumn, TextBoxColumn2, ComboBoxColumn, TextBoxColumn3 });
            dgvUsers.Location = new Point(57, 135);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(1107, 550);
            dgvUsers.TabIndex = 0;
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = Color.LightGreen;
            btnCreateUser.Location = new Point(1185, 135);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(111, 48);
            btnCreateUser.TabIndex = 1;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.LightYellow;
            btnEditUser.Location = new Point(1185, 189);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(111, 48);
            btnEditUser.TabIndex = 2;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.LightCoral;
            btnDeleteUser.Location = new Point(1185, 243);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(111, 48);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1185, 637);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 48);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1346, 93);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumBlue;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(537, 23);
            label1.Name = "label1";
            label1.Size = new Size(261, 43);
            label1.TabIndex = 0;
            label1.Text = "Manage Users";
            // 
            // TextBoxColumn
            // 
            TextBoxColumn.HeaderText = "Username";
            TextBoxColumn.MinimumWidth = 8;
            TextBoxColumn.Name = "TextBoxColumn";
            TextBoxColumn.Width = 260;
            // 
            // TextBoxColumn2
            // 
            TextBoxColumn2.HeaderText = "Email";
            TextBoxColumn2.MinimumWidth = 8;
            TextBoxColumn2.Name = "TextBoxColumn2";
            TextBoxColumn2.Width = 260;
            // 
            // ComboBoxColumn
            // 
            ComboBoxColumn.HeaderText = "Role";
            ComboBoxColumn.MinimumWidth = 8;
            ComboBoxColumn.Name = "ComboBoxColumn";
            ComboBoxColumn.Width = 260;
            // 
            // TextBoxColumn3
            // 
            TextBoxColumn3.HeaderText = "Date Created";
            TextBoxColumn3.MinimumWidth = 8;
            TextBoxColumn3.Name = "TextBoxColumn3";
            TextBoxColumn3.Width = 260;
            // 
            // FrmManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 818);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnEditUser);
            Controls.Add(btnCreateUser);
            Controls.Add(dgvUsers);
            Name = "FrmManageUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsersForm";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsers;
        private Button btnCreateUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private Button btnClose;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn TextBoxColumn;
        private DataGridViewTextBoxColumn TextBoxColumn2;
        private DataGridViewTextBoxColumn ComboBoxColumn;
        private DataGridViewTextBoxColumn TextBoxColumn3;
    }
}