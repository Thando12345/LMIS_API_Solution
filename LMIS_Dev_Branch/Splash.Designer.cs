namespace LMIS_Dev_Branch
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            lmsprogressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblLoading = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lmsprogressBar1
            // 
            lmsprogressBar1.Location = new Point(94, 193);
            lmsprogressBar1.Name = "lmsprogressBar1";
            lmsprogressBar1.Size = new Size(580, 21);
            lmsprogressBar1.TabIndex = 0;
            lmsprogressBar1.Click += progressBar1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(247, 110);
            label1.Name = "label1";
            label1.Size = new Size(315, 71);
            label1.TabIndex = 2;
            label1.Text = "Networx ";
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Font = new Font("Century Schoolbook", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoading.Location = new Point(12, 261);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(113, 27);
            lblLoading.TabIndex = 3;
            lblLoading.Text = "Loading...";
            lblLoading.Click += lblLoading_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(531, 120);
            label3.Name = "label3";
            label3.Size = new Size(143, 59);
            label3.TabIndex = 4;
            label3.Text = "LMS";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 304);
            Controls.Add(label3);
            Controls.Add(lblLoading);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lmsprogressBar1);
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar lmsprogressBar1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblLoading;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}