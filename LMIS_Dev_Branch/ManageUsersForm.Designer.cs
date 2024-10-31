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
            TextBoxColumn = new DataGridViewTextBoxColumn();
            TextBoxColumn2 = new DataGridViewTextBoxColumn();
            ComboBoxColumn = new DataGridViewTextBoxColumn();
            TextBoxColumn3 = new DataGridViewTextBoxColumn();
            btnCreateUser = new Button();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { TextBoxColumn, TextBoxColumn2, ComboBoxColumn, TextBoxColumn3 });
            dgvUsers.Location = new Point(50, 50);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(674, 400);
            dgvUsers.TabIndex = 0;
            // 
            // TextBoxColumn
            // 
            TextBoxColumn.HeaderText = "Username";
            TextBoxColumn.MinimumWidth = 8;
            TextBoxColumn.Name = "TextBoxColumn";
            TextBoxColumn.Width = 150;
            // 
            // TextBoxColumn2
            // 
            TextBoxColumn2.HeaderText = "Email";
            TextBoxColumn2.MinimumWidth = 8;
            TextBoxColumn2.Name = "TextBoxColumn2";
            TextBoxColumn2.Width = 150;
            // 
            // ComboBoxColumn
            // 
            ComboBoxColumn.HeaderText = "Role";
            ComboBoxColumn.MinimumWidth = 8;
            ComboBoxColumn.Name = "ComboBoxColumn";
            ComboBoxColumn.Width = 150;
            // 
            // TextBoxColumn3
            // 
            TextBoxColumn3.HeaderText = "Date Created";
            TextBoxColumn3.MinimumWidth = 8;
            TextBoxColumn3.Name = "TextBoxColumn3";
            TextBoxColumn3.Width = 150;
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = Color.LightGreen;
            btnCreateUser.Location = new Point(730, 50);
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
            btnEditUser.Location = new Point(730, 104);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(111, 48);
            btnEditUser.TabIndex = 2;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.LightCoral;
            btnDeleteUser.Location = new Point(730, 158);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(111, 48);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // FrmManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 552);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnEditUser);
            Controls.Add(btnCreateUser);
            Controls.Add(dgvUsers);
            Name = "FrmManageUsersForm";
            Text = "ManageUsersForm";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn TextBoxColumn;
        private DataGridViewTextBoxColumn TextBoxColumn2;
        private DataGridViewTextBoxColumn ComboBoxColumn;
        private DataGridViewTextBoxColumn TextBoxColumn3;
        private Button btnCreateUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
    }
}