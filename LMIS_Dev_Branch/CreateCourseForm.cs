using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;
using LMIS_Dev_Branch.Models;

namespace LMIS_Dev_Branch
{


    public partial class FrmCreateCourseForm : Form
    {
        private DBContext _context;

        public FrmCreateCourseForm()
        {
            InitializeComponent();

            // Load configuration from appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Retrieve the connection string
            string connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Connection string 'DefaultConnection' not found in appsettings.json.");
            }

            // Initialize database context
            var options = new DbContextOptionsBuilder<DBContext>()
                .UseSqlServer(connectionString)
                .Options;

            _context = new DBContext(options);

            // Initialize visibility of accreditation fields
            ToggleAccreditationFields(false);


        }

        // Event: Form Load
        private void FrmCreateCourseForm_Load(object sender, EventArgs e)
        {
            // Any additional initialization logic can be added here
        }

        // Logic to toggle accreditation fields visibility
        private void ToggleAccreditationFields(bool isVisible)
        {
            lblAccreditationBody.Visible = isVisible;
            txtAccreditationBody.Visible = isVisible;
            lblAccreditationNumber.Visible = isVisible;
            txtAccreditationNumber.Visible = isVisible;
        }


        //test case


        //end
        // Event: Accreditation Yes Button Click
        private void btnAccreditationYes_Click(object sender, EventArgs e)
        {
            // Set accreditation fields to visible
            ToggleAccreditationFields(true);
            MessageBox.Show("Accreditation confirmed: Yes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event: Accreditation No Button Click
        private void btnAccreditationNo_Click(object sender, EventArgs e)
        {
            // Set accreditation fields to hidden
            ToggleAccreditationFields(false);
            MessageBox.Show("Accreditation confirmed: No", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Event: Add Unit Standard Button Click
        private void btnAddUnitStandard_Click(object sender, EventArgs e)
        {
            // Clear the input fields
            txtUsNumberInput.Clear();
            txtUsNameInput.Clear();
            txtUsId.Clear();
            txtUsCredits.Clear();
            txtUsNqfLevel.Clear();

            // Set focus on each field in sequence
            txtUsNumberInput.Focus();
            txtUsNameInput.Focus();
            txtUsId.Focus();
            txtUsCredits.Focus();
            txtUsNqfLevel.Focus();
        }




        // Event: Save Course Button Click
        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            // Validate and save the course details
            string courseName = txtCourseName.Text.Trim();
            int nqfLevel, credits;
            bool isAccredited = lblAccreditationToggle.Visible; // Check if accreditation fields are visible

            // Validate input
            if (string.IsNullOrEmpty(courseName) ||
                !int.TryParse(txtUsNqfLevel.Text, out nqfLevel) || // Validate NQF level
                !int.TryParse(txtUsCredits.Text, out credits)) // Validate credits
            {
                MessageBox.Show("Please provide valid course details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Optional accreditation fields
            string accreditationBody = isAccredited ? txtAccreditationBody.Text.Trim() : null;
            string accreditationNumber = isAccredited ? txtAccreditationNumber.Text.Trim() : null;

            // Create a new Course object
            var course = new Course
            {
                Name = courseName,
                NQFLevel = nqfLevel,
                Credits = credits,
                IsAccredited = isAccredited,
                AccreditationBody = accreditationBody,
                AccreditationNumber = accreditationNumber
            };

            try
            {
                // Save the course to the database
                _context.Courses.Add(course);
                _context.SaveChanges(); // Commits the changes to the database

                // Display confirmation message
                MessageBox.Show("Course saved successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear input fields after saving
                ClearCourseFields();
            }
            catch (Exception ex)
            {
                // Handle any errors during the save operation
                MessageBox.Show("An error occurred while saving the course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearCourseFields()
        {
            txtCourseName.Clear();
            txtUsNqfLevel.Clear();
            txtUsCredits.Clear();
            txtAccreditationBody.Clear();
            txtAccreditationNumber.Clear();
        }



        // Event: Cancel Unit Standard Button Click
        private void btnCancelUnitStandard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event: Close Button Click
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //new test case
        // Dispose database context

        //end
        // Additional Events
        private void txtCourseName_TextChanged(object sender, EventArgs e) { }
        private void txtUsNumberInput_TextChanged(object sender, EventArgs e) { }
        private void txtUsCredits_TextChanged(object sender, EventArgs e) { }
        private void txtUsNqfLevel_TextChanged(object sender, EventArgs e) { }
        private void txtAccreditationBody_TextChanged(object sender, EventArgs e) { }
        private void txtAccreditationNumber_TextChanged(object sender, EventArgs e) { }
        private void lblAccreditationToggle_Click(object sender, EventArgs e) { }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Prompt the user with a confirmation question before closing the form
            DialogResult result = MessageBox.Show("Are you sure you want to go to the previous step?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the current form (this will close the current form and go back to the previous form if any)
                this.Close();
            }
            // If the user clicks 'No', nothing happens, and the form remains open
        }

        private void dgvUnitStandards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //New Test Case 20-01-2025



        //end test case
    }
}
