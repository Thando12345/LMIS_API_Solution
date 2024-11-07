using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                lblAccreditationBody.Visible = true;
                lblAccreditationNumber.Visible = true;
            }
            else
            {
                lblAccreditationBody.Visible = false;
                lblAccreditationNumber.Visible = false;
                lblCertificateInfo.Text = "Certificate Issued: Certificate of Completion";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the details form
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Optional: Show message or action for editing course details
            MessageBox.Show("Edit functionality is not available yet.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblCourseName_Click(object sender, EventArgs e)
        {

        }
    }
}