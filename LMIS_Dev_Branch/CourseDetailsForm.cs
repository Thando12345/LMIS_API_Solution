using System;
using System.Windows.Forms;

namespace LMIS_Dev_Branch
{
    public partial class CourseDetailsForm : Form
    {
        // Properties to receive course data
        public string CourseName { get; set; }
        public string CourseType { get; set; }
        public int Credits { get; set; }
        public int NQFLevel { get; set; }
        public string AccreditationBody { get; set; }
        public string AccreditationNumber { get; set; }
        public bool IsAccredited { get; set; }

        public CourseDetailsForm()
        {
            InitializeComponent();
        }

        private void CourseDetailsForm_Load(object sender, EventArgs e)
        {
            // Populate labels with course details
            lblCourseName.Text = $"Course Name: {CourseName}";
            lblCourseType.Text = $"Course Type: {CourseType}";
            lblCredits.Text = $"Credits: {Credits}";
            lblNQFLevel.Text = $"NQF Level: {NQFLevel}";

            // Display accreditation information if the course is accredited
            if (IsAccredited)
            {
                lblAccreditationBody.Text = $"Accreditation Body: {AccreditationBody}";
                lblAccreditationNumber.Text = $"Accreditation Number: {AccreditationNumber}";
                lblCertificateInfo.Text = "Certificate Issued: Certificate of Competence";

                // Make accreditation details visible if the course is accredited
                lblAccreditationBody.Visible = true;
                lblAccreditationNumber.Visible = true;
            }
            else
            {
                // Hide accreditation details and display completion certificate for non-accredited courses
                lblAccreditationBody.Visible = false;
                lblAccreditationNumber.Visible = false;
                lblCertificateInfo.Text = "Certificate Issued: Certificate of Completion";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the course details form
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Placeholder for editing course details (if you plan to implement editing functionality)
            MessageBox.Show("Edit functionality is not available yet.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblCourseName_Click(object sender, EventArgs e)
        {
            // Placeholder for clicking course name (if you want to add additional functionality)
        }
    }
}
