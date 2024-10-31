namespace LMIS_Dev_Branch
{
    partial class FrmApproveRequestsForm
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
            dgvApprovalRequests = new DataGridView();
            Request_ID = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            Request_Type = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            chkApproveRequest = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            btnApprove = new Button();
            btnReject = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvApprovalRequests).BeginInit();
            SuspendLayout();
            // 
            // dgvApprovalRequests
            // 
            dgvApprovalRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApprovalRequests.Columns.AddRange(new DataGridViewColumn[] { Request_ID, User, Request_Type, Date, Status });
            dgvApprovalRequests.Location = new Point(50, 100);
            dgvApprovalRequests.Name = "dgvApprovalRequests";
            dgvApprovalRequests.RowHeadersWidth = 62;
            dgvApprovalRequests.Size = new Size(830, 400);
            dgvApprovalRequests.TabIndex = 0;
            dgvApprovalRequests.CellContentClick += dgvApprovalRequests_CellContentClick;
            // 
            // Request_ID
            // 
            Request_ID.HeaderText = "Request ID";
            Request_ID.MinimumWidth = 8;
            Request_ID.Name = "Request_ID";
            Request_ID.Width = 150;
            // 
            // User
            // 
            User.HeaderText = "User";
            User.MinimumWidth = 8;
            User.Name = "User";
            User.Width = 150;
            // 
            // Request_Type
            // 
            Request_Type.HeaderText = "Request Type";
            Request_Type.MinimumWidth = 8;
            Request_Type.Name = "Request_Type";
            Request_Type.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // chkApproveRequest
            // 
            chkApproveRequest.AutoSize = true;
            chkApproveRequest.Location = new Point(114, 207);
            chkApproveRequest.Name = "chkApproveRequest";
            chkApproveRequest.Size = new Size(124, 29);
            chkApproveRequest.TabIndex = 1;
            chkApproveRequest.Text = "Request ID";
            chkApproveRequest.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(263, 207);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(73, 29);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "User";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(401, 207);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(143, 29);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Request Type";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(566, 207);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(75, 29);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Date";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(719, 207);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(81, 29);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "Satus";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.LightGreen;
            btnApprove.Location = new Point(566, 46);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(111, 48);
            btnApprove.TabIndex = 6;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.LightCoral;
            btnReject.Location = new Point(706, 46);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(111, 48);
            btnReject.TabIndex = 7;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            // 
            // FrmApproveRequestsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 572);
            Controls.Add(btnReject);
            Controls.Add(btnApprove);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(chkApproveRequest);
            Controls.Add(dgvApprovalRequests);
            Name = "FrmApproveRequestsForm";
            Text = "ApproveRequestsForm";
            ((System.ComponentModel.ISupportInitialize)dgvApprovalRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvApprovalRequests;
        private DataGridViewTextBoxColumn Request_ID;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Request_Type;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Status;
        private CheckBox chkApproveRequest;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Button btnApprove;
        private Button btnReject;
    }
}