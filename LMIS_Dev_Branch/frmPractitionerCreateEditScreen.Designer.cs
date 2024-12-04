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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(50, 157);
            lblName.Name = "lblName";
            lblName.Size = new Size(70, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtPractitionerName
            // 
            txtPractitionerName.Location = new Point(172, 157);
            txtPractitionerName.Name = "txtPractitionerName";
            txtPractitionerName.PlaceholderText = "Enter practitioner's first name";
            txtPractitionerName.Size = new Size(300, 31);
            txtPractitionerName.TabIndex = 1;
            txtPractitionerName.TextChanged += txtPractitionerName_TextChanged;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSurname.Location = new Point(50, 227);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(98, 25);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Surname";
            // 
            // txtPractitionerSurname
            // 
            txtPractitionerSurname.Location = new Point(172, 227);
            txtPractitionerSurname.Name = "txtPractitionerSurname";
            txtPractitionerSurname.PlaceholderText = "Enter practitioner's surname";
            txtPractitionerSurname.Size = new Size(300, 31);
            txtPractitionerSurname.TabIndex = 3;
            // 
            // lblIDNumber
            // 
            lblIDNumber.AutoSize = true;
            lblIDNumber.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDNumber.Location = new Point(50, 297);
            lblIDNumber.Name = "lblIDNumber";
            lblIDNumber.Size = new Size(116, 25);
            lblIDNumber.TabIndex = 4;
            lblIDNumber.Text = "ID Number";
            // 
            // txtIdNumber
            // 
            txtIdNumber.Location = new Point(172, 291);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.PlaceholderText = "Enter practitioner's ID (Optional)";
            txtIdNumber.Size = new Size(300, 31);
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
            // frmPractitionerCreateEditScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 567);
            Controls.Add(panel1);
            Controls.Add(txtIdNumber);
            Controls.Add(lblIDNumber);
            Controls.Add(txtPractitionerSurname);
            Controls.Add(lblSurname);
            Controls.Add(txtPractitionerName);
            Controls.Add(lblName);
            Name = "frmPractitionerCreateEditScreen";
            Text = " Practitioner Create Edit Screen";
            Load += frmPractitionerCreateEditScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}