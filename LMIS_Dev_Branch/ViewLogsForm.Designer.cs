namespace LMIS_Dev_Branch
{
    partial class FrmViewLogsForm
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
            dgvLogs = new DataGridView();
            Activity = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            dtpStartDate = new DateTimePicker();
            lblStrtDate = new Label();
            lblEndDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblUserFilter = new Label();
            cmbUserFilter = new ComboBox();
            btnSearchLogs = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // dgvLogs
            // 
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Columns.AddRange(new DataGridViewColumn[] { Activity, User, Date, Time });
            dgvLogs.Location = new Point(50, 223);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 62;
            dgvLogs.Size = new Size(700, 350);
            dgvLogs.TabIndex = 0;
            dgvLogs.CellContentClick += dgvLogs_CellContentClick;
            // 
            // Activity
            // 
            Activity.HeaderText = "Activity";
            Activity.MinimumWidth = 8;
            Activity.Name = "Activity";
            Activity.Width = 150;
            // 
            // User
            // 
            User.HeaderText = "User";
            User.MinimumWidth = 8;
            User.Name = "User";
            User.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 150;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 8;
            Time.Name = "Time";
            Time.Width = 150;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(50, 58);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 31);
            dtpStartDate.TabIndex = 1;
            // 
            // lblStrtDate
            // 
            lblStrtDate.AutoSize = true;
            lblStrtDate.Location = new Point(50, 21);
            lblStrtDate.Name = "lblStrtDate";
            lblStrtDate.Size = new Size(90, 25);
            lblStrtDate.TabIndex = 2;
            lblStrtDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(548, 21);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(84, 25);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "End Date";
            lblEndDate.Click += lblEndDate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(548, 58);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // lblUserFilter
            // 
            lblUserFilter.AutoSize = true;
            lblUserFilter.Location = new Point(50, 107);
            lblUserFilter.Name = "lblUserFilter";
            lblUserFilter.Size = new Size(90, 25);
            lblUserFilter.TabIndex = 5;
            lblUserFilter.Text = "User Filter";
            // 
            // cmbUserFilter
            // 
            cmbUserFilter.FormattingEnabled = true;
            cmbUserFilter.Location = new Point(50, 147);
            cmbUserFilter.Name = "cmbUserFilter";
            cmbUserFilter.Size = new Size(163, 33);
            cmbUserFilter.TabIndex = 6;
            // 
            // btnSearchLogs
            // 
            btnSearchLogs.BackColor = Color.LightBlue;
            btnSearchLogs.Location = new Point(417, 144);
            btnSearchLogs.Name = "btnSearchLogs";
            btnSearchLogs.Size = new Size(112, 40);
            btnSearchLogs.TabIndex = 7;
            btnSearchLogs.Text = "Search Logs";
            btnSearchLogs.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(548, 149);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 31);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // FrmViewLogsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 616);
            Controls.Add(txtSearch);
            Controls.Add(btnSearchLogs);
            Controls.Add(cmbUserFilter);
            Controls.Add(lblUserFilter);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblEndDate);
            Controls.Add(lblStrtDate);
            Controls.Add(dtpStartDate);
            Controls.Add(dgvLogs);
            Name = "FrmViewLogsForm";
            Text = "ViewLogsForm";
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLogs;
        private DataGridViewTextBoxColumn Activity;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DateTimePicker dtpStartDate;
        private Label lblStrtDate;
        private Label lblEndDate;
        private DateTimePicker dateTimePicker1;
        private Label lblUserFilter;
        private ComboBox cmbUserFilter;
        private Button btnSearchLogs;
        private TextBox txtSearch;
    }
}