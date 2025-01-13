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
            dtpStartDate = new DateTimePicker();
            lblStrtDate = new Label();
            lblEndDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblUserFilter = new Label();
            cmbUserFilter = new ComboBox();
            btnSearchLogs = new Button();
            txtSearch = new TextBox();
            button1 = new Button();
            Activity = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // dgvLogs
            // 
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Columns.AddRange(new DataGridViewColumn[] { Activity, User, Date, Time });
            dgvLogs.Location = new Point(50, 251);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 62;
            dgvLogs.Size = new Size(1275, 350);
            dgvLogs.TabIndex = 0;
            dgvLogs.CellContentClick += dgvLogs_CellContentClick;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Location = new Point(50, 83);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 34);
            dtpStartDate.TabIndex = 1;
            // 
            // lblStrtDate
            // 
            lblStrtDate.AutoSize = true;
            lblStrtDate.Location = new Point(50, 46);
            lblStrtDate.Name = "lblStrtDate";
            lblStrtDate.Size = new Size(90, 25);
            lblStrtDate.TabIndex = 2;
            lblStrtDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(548, 46);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(84, 25);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "End Date";
            lblEndDate.Click += lblEndDate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(548, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 34);
            dateTimePicker1.TabIndex = 4;
            // 
            // lblUserFilter
            // 
            lblUserFilter.AutoSize = true;
            lblUserFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserFilter.Location = new Point(50, 132);
            lblUserFilter.Name = "lblUserFilter";
            lblUserFilter.Size = new Size(100, 28);
            lblUserFilter.TabIndex = 5;
            lblUserFilter.Text = "User Filter";
            // 
            // cmbUserFilter
            // 
            cmbUserFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUserFilter.FormattingEnabled = true;
            cmbUserFilter.Location = new Point(50, 172);
            cmbUserFilter.Name = "cmbUserFilter";
            cmbUserFilter.Size = new Size(300, 36);
            cmbUserFilter.TabIndex = 6;
            // 
            // btnSearchLogs
            // 
            btnSearchLogs.BackColor = Color.LightBlue;
            btnSearchLogs.Location = new Point(417, 169);
            btnSearchLogs.Name = "btnSearchLogs";
            btnSearchLogs.Size = new Size(112, 39);
            btnSearchLogs.TabIndex = 7;
            btnSearchLogs.Text = "Search Logs";
            btnSearchLogs.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(548, 174);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 34);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1214, 634);
            button1.Name = "button1";
            button1.Size = new Size(111, 48);
            button1.TabIndex = 10;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Activity
            // 
            Activity.HeaderText = "Activity";
            Activity.MinimumWidth = 8;
            Activity.Name = "Activity";
            Activity.Width = 300;
            // 
            // User
            // 
            User.HeaderText = "User";
            User.MinimumWidth = 8;
            User.Name = "User";
            User.Width = 300;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 300;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 8;
            Time.Name = "Time";
            Time.Width = 300;
            // 
            // FrmViewLogsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 728);
            Controls.Add(button1);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewLogsForm";
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLogs;
        private DateTimePicker dtpStartDate;
        private Label lblStrtDate;
        private Label lblEndDate;
        private DateTimePicker dateTimePicker1;
        private Label lblUserFilter;
        private ComboBox cmbUserFilter;
        private Button btnSearchLogs;
        private TextBox txtSearch;
        private Button button1;
        private DataGridViewTextBoxColumn Activity;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
    }
}