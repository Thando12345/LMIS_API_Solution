using System;
using System.Windows.Forms;

namespace LMIS_Dev_Branch
{
    public partial class Splash : Form
    {
        int startPoint = 0; // Initialize progress value

        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            // Start the timer when the form loads
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment progress
            startPoint += 2;
            lmsprogressBar1.Value = startPoint;

            // Check if progress is complete
            if (lmsprogressBar1.Value == 100)
            {
                // Reset progress and stop timer
                lmsprogressBar1.Value = 0;
                timer1.Stop();

                // Show main user portal form
                FrmUserPortalMain user = new FrmUserPortalMain();
                user.ShowDialog();

                // Hide the splash form
                this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lblLoading_Click(object sender, EventArgs e)
        {

        }
    }
}
