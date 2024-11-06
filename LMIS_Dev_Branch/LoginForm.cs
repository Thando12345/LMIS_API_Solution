namespace LMIS_Dev_Branch
{
    public partial class FrmLoginForm : Form
    {
        public FrmLoginForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(LoginForm_Load); // Wire up the Load event
            pictureBox1.Click += new EventHandler(pictureBox1_Click); // Wire up the Click event
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Set the size of the PictureBox
            pictureBox1.Size = new Size(300, 150);

            // Calculate the location to center it
            pictureBox1.Location = new Point(
                (this.ClientSize.Width - pictureBox1.Width) / 2, // Center horizontally
                20 // Distance from the top of the form (you can adjust this value)
            );
        }

        // Click event handler for the PictureBox
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // You can add any functionality you want when the PictureBox is clicked
            MessageBox.Show("PictureBox clicked!");
        }

        private void lblSelectRole_Click(object sender, EventArgs e)
        {

        }

        private void FrmLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//
        }
    }
}
