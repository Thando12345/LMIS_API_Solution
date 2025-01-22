

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using LMIS_Dev_Branch.Models;
using System.Data;

namespace LMIS_Dev_Branch
{


    public partial class FrmCreateCourseForm : Form
    {
        private SqlConnection con;
        // private string connectionString;

        public FrmCreateCourseForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-RULM89R\\SQLEXPRESS;Database=LMS_Db;Trusted_Connection=True;TrustServerCertificate=True";

            // Initialize SQL connection for custom queries
            con = new SqlConnection(connectionString);

            // Initialize visibility of accreditation fields
            ToggleAccreditationFields(false);


        }

        // Event: Form Load
        private void FrmCreateCourseForm_Load(object sender, EventArgs e)
        {
            // Any additional initialization logic can be added here

        }


        // Method to bind data to DataGridView (assuming you have one called dgvUnitStandards)

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
            // Validate that a course name is entered
            string courseName = txtCourseName.Text.Trim();
            if (string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please enter a course name before adding unit standards.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourseName.Focus();
                return;
            }

            // Validate Unit Standard Number input
            string usNumber = txtUsNumberInput.Text.Trim();
            if (string.IsNullOrEmpty(usNumber))
            {
                MessageBox.Show("Please enter a valid Unit Standard Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsNumberInput.Focus();
                return;
            }

            try
            {
                // Open the connection
                con.Open();

                // Insert the Unit Standard into the database
                string query = "INSERT INTO UnitStandard (Name, Id, Credits, NQFLevel, CourseId) " +
                               "VALUES (@Name, @Id, @Credits, @NQFLevel, @CourseId)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtUsNameInput.Text.Trim());
                cmd.Parameters.AddWithValue("@Id", usNumber);
                cmd.Parameters.AddWithValue("@Credits", int.Parse(txtUsCredits.Text.Trim()));
                cmd.Parameters.AddWithValue("@NQFLevel", int.Parse(txtUsNqfLevel.Text.Trim()));
                cmd.Parameters.AddWithValue("@CourseId", GetCourseIdByName(courseName)); // Get the CourseId based on the course name

                // Execute the query
                cmd.ExecuteNonQuery();

                // Display success message
                MessageBox.Show("Unit Standard added successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the Unit Standard input fields
                ClearUnitStandardFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the Unit Standard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed
                con.Close();
            }
        }

        private void ClearUnitStandardFields()
        {
            txtUsNumberInput.Clear();
            txtUsNameInput.Clear();
            txtUsId.Clear();
            txtUsCredits.Clear();
            txtUsNqfLevel.Clear();
            txtUsNumberInput.Focus(); // Set focus on the first input field
        }
        private int GetCourseIdByName(string courseName)
        {
            string query = "SELECT CourseId FROM Course WHERE Name = @CourseName";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CourseName", courseName);

            // Execute the query and return the CourseId
            object result = cmd.ExecuteScalar();
            if (result != null && int.TryParse(result.ToString(), out int courseId))
            {
                return courseId;
            }

            // If the course is not found, throw an exception
            throw new Exception("Course not found in the database. Please save the course first.");
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
                !int.TryParse(txtUsNqfLevel.Text, out nqfLevel) ||
                nqfLevel < 1 || nqfLevel > 10 || // Validate NQF level range
                !int.TryParse(txtUsCredits.Text, out credits) ||
                credits <= 0) // Validate credits
            {
                MessageBox.Show("Please provide valid course details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Optional accreditation fields
            string accreditationBody = isAccredited ? txtAccreditationBody.Text.Trim() : null;
            string accreditationNumber = isAccredited ? txtAccreditationNumber.Text.Trim() : null;

            string connectionString = "your_connection_string_here"; // Replace with your connection string

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // SQL query to insert course
                    string query = "INSERT INTO Course (Name, NQFLevel, Credits, IsAccredited, AccreditationBody, AccreditationNumber) " +
                                   "VALUES (@CourseName, @NQFLevel, @Credits, @IsAccredited, @AccreditationBody, @AccreditationNumber)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CourseName", courseName);
                    cmd.Parameters.AddWithValue("@NQFLevel", nqfLevel);
                    cmd.Parameters.AddWithValue("@Credits", credits);
                    cmd.Parameters.AddWithValue("@IsAccredited", isAccredited);
                    cmd.Parameters.AddWithValue("@AccreditationBody", string.IsNullOrEmpty(accreditationBody) ? DBNull.Value : (object)accreditationBody);
                    cmd.Parameters.AddWithValue("@AccreditationNumber", string.IsNullOrEmpty(accreditationNumber) ? DBNull.Value : (object)accreditationNumber);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Course saved successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input fields after saving
                    ClearCourseFields();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        //New Test Case 21-01-2025


        //end test case
    }
}

