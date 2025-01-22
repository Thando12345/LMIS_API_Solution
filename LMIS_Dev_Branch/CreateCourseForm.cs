

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
            try
            {
                // Validate inputs
                if (!ValidateInputs(out string courseName, out string usNumber, out int credits, out int nqfLevel)) return;

                string connectionString = "Data Source=DESKTOP-RULM89R\\SQLEXPRESS;Database=LMS_Db;Trusted_Connection=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open(); // Ensure the connection is open

                    // Ensure the UnitStandard table exists
                    EnsureUnitStandardTableExists(con);

                    // Get CourseId
                    int courseId = GetCourseIdByName(con, courseName);  // Pass con here as well
                    if (courseId == 0)
                    {
                        ShowValidationError("The specified course does not exist. Please select a valid course.", txtCourseName);
                        return;
                    }

                    // Check for Duplicate Unit Standard
                    if (IsDuplicateUnitStandard(con, usNumber, courseId))  // Pass con here as well
                    {
                        ShowValidationError("A Unit Standard with this number already exists for the selected course.", txtUsNumberInput);
                        return;
                    }

                    // Insert Unit Standard
                    InsertUnitStandard(con, txtUsNameInput.Text.Trim(), usNumber, credits, nqfLevel, courseId);

                    // Success Message
                    MessageBox.Show("Unit Standard added successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input fields
                    ClearUnitStandardFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs(out string courseName, out string usNumber, out int credits, out int nqfLevel)
        {
            courseName = txtCourseName.Text.Trim();
            if (string.IsNullOrEmpty(courseName))
            {
                ShowValidationError("Please enter a course name before adding unit standards.", txtCourseName);
                usNumber = null;
                credits = 0;
                nqfLevel = 0;
                return false;
            }

            usNumber = txtUsNumberInput.Text.Trim();
            if (string.IsNullOrEmpty(usNumber))
            {
                ShowValidationError("Please enter a valid Unit Standard Number.", txtUsNumberInput);
                credits = 0;
                nqfLevel = 0;
                return false;
            }

            if (!int.TryParse(txtUsCredits.Text.Trim(), out credits) || credits <= 0)
            {
                ShowValidationError("Please enter a valid credit value.", txtUsCredits);
                nqfLevel = 0;
                return false;
            }

            if (!int.TryParse(txtUsNqfLevel.Text.Trim(), out nqfLevel) || nqfLevel < 1 || nqfLevel > 10)
            {
                ShowValidationError("Please enter a valid NQF level (1-10).", txtUsNqfLevel);
                return false;
            }

            return true;
        }

        private void ShowValidationError(string message, Control control)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private bool IsDuplicateUnitStandard(SqlConnection con, string usNumber, int courseId)
        {
            string query = "SELECT COUNT(*) FROM UnitStandard WHERE Id = @Id AND CourseId = @CourseId";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Id", usNumber);
                cmd.Parameters.AddWithValue("@CourseId", courseId);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private void EnsureUnitStandardTableExists(SqlConnection con)
        {
            string checkCourseTableQuery = @"
IF OBJECT_ID('[dbo].[Course]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Course]
    (
        [CourseId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary key with auto-incrementing ID
        [Name] VARCHAR(100) NOT NULL, -- Course name (max 100 characters)
        [Credits] INT NOT NULL, -- Course credits
        [NQFLevel] INT NOT NULL, -- NQF Level
        [IsAccredited] BIT NOT NULL, -- Is the course accredited
        [AccreditationBody] VARCHAR(200), -- Accreditation body (max 200 characters)
        [AccreditationNumber] VARCHAR(100) -- Accreditation number (max 100 characters)
    );
END";

            string checkUnitStandardTableQuery = @"
IF OBJECT_ID('[dbo].[UnitStandard]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[UnitStandard]
    (
        [UnitStandardId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary key with auto-incrementing ID
        [Name] VARCHAR(100) NOT NULL, -- Unit standard name (max 100 characters)
        [Id] VARCHAR(50) NOT NULL, -- Unit standard ID or code (max 50 characters)
        [Credits] INT NOT NULL, -- Credits for the unit standard
        [NQFLevel] INT NOT NULL, -- NQF Level for the unit standard
        [CourseId] INT NOT NULL, -- Foreign key to Course table
        CONSTRAINT FK_UnitStandard_Course FOREIGN KEY (CourseId) REFERENCES [dbo].[Course]([CourseId])
    );
    -- Create an index for better join performance
    CREATE NONCLUSTERED INDEX IX_UnitStandard_CourseId ON [dbo].[UnitStandard](CourseId);
END";

            // Execute both queries
            using (SqlCommand cmd = new SqlCommand(checkCourseTableQuery, con))
            {
                cmd.ExecuteNonQuery();
            }

            using (SqlCommand cmd = new SqlCommand(checkUnitStandardTableQuery, con))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void InsertUnitStandard(SqlConnection con, string name, string id, int credits, int nqfLevel, int courseId)
        {
            string insertQuery = "INSERT INTO UnitStandard (Name, Id, Credits, NQFLevel, CourseId) VALUES (@Name, @Id, @Credits, @NQFLevel, @CourseId)";
            using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
            {
                insertCmd.Parameters.AddWithValue("@Name", name);
                insertCmd.Parameters.AddWithValue("@Id", id);
                insertCmd.Parameters.AddWithValue("@Credits", credits);
                insertCmd.Parameters.AddWithValue("@NQFLevel", nqfLevel);
                insertCmd.Parameters.AddWithValue("@CourseId", courseId);
                insertCmd.ExecuteNonQuery();
            }
        }

        private void ClearUnitStandardFields()
        {
            txtUsNameInput.Clear();
            txtUsNumberInput.Clear();
            txtUsCredits.Clear();
            txtUsNqfLevel.Clear();
        }

        // Method to retrieve CourseId by CourseName
        private int GetCourseIdByName(SqlConnection con, string courseName)
        {
            int courseId = 0;
            string query = "SELECT CourseId FROM Course WHERE Name = @Name";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Open the connection if it's not open
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                cmd.Parameters.AddWithValue("@Name", courseName);

                object result = cmd.ExecuteScalar();
                courseId = result != null ? Convert.ToInt32(result) : 0;
            }

            return courseId;
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

            // string connectionString = "DefaultConnection"; // Replace with your connection string
            string connectionString = "Data Source=DESKTOP-RULM89R\\SQLEXPRESS;Database=LMS_Db;Trusted_Connection=True;TrustServerCertificate=True";

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
            //txtCourseName.Clear();
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go to the next step?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmPractitionersViewScreen frmPractitionersViewScreen = new frmPractitionersViewScreen();
                frmPractitionersViewScreen.ShowDialog();
            }
            // If the user clicks 'No', nothing happens, and the form remains open
        }
    }

        //New Test Case 21-01-2025


        //end test case
    }
}

