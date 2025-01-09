using System.Data;
using System.Data.SqlClient;


namespace LMIS_Dev_Branch
{
    public partial class frmLearnerInformation : Form
    {
        public frmLearnerInformation()
        {
            InitializeComponent();
            //var db = new DBContext(new DbContextOptions<DBContext>());

        }

        //SqlConnection con = new SqlConnection("@Data Source=DESKTOP-RULM89R\\SQLEXPRESS;Database=LMS_Db;Trusted_Connection=True;TrustServerCertificate=True");
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RULM89R\\SQLEXPRESS;Database=LMS_Db;Trusted_Connection=True;TrustServerCertificate=True");

        public SqlConnection Con { get => con; set => con = value; }

        private void TxtSearchLearner_Leave(object sender, EventArgs e)
        {
            toolTip1.Hide(txtSearchLearner);
        }

        // Initialize and set tooltip properties in the Popup event
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            // Ensure tooltip settings only for txtSearchLearner
            if (e.AssociatedControl == txtSearchLearner)
            {
                toolTip1.ToolTipTitle = "Search Box";
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
                toolTip1.IsBalloon = true;

                // Set tooltip text if not already set
                toolTip1.SetToolTip(txtSearchLearner, "Enter Learner ID or Surname to search.");
            }
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        // Event handler for the Edit button
        private void btnEdit_Click(object sender, EventArgs e)
        {
            HandleEditAction();
        }

        // Handles the logic for editing a learner's details
        private void HandleEditAction()
        {
            try
            {
                if (IsRowSelected())
                {
                    string learnerID = GetSelectedLearnerID();
                    if (!string.IsNullOrEmpty(learnerID))
                    {
                        InitiateEditProcess(learnerID);
                    }
                }
                else
                {
                    ShowWarningMessage("Please select a row to edit.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"An error occurred during editing: {ex.Message}");
            }
        }

        // Checks if a row is selected in the DataGridView
        private bool IsRowSelected()
        {
            return dgvLearnerList.SelectedRows.Count > 0;
        }

        // Retrieves the Learner ID from the selected row
        private string GetSelectedLearnerID()
        {
            DataGridViewRow selectedRow = dgvLearnerList.SelectedRows[0];
            return selectedRow.Cells["Learner_ID"].Value?.ToString();
        }

        // Initiates the edit process for the selected learner
        private void InitiateEditProcess(string learnerID)
        {
            MessageBox.Show($"Edit feature for Learner ID: {learnerID} initiated.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Open a form or enable text boxes to allow editing based on learnerID
            // Example: OpenEditForm(learnerID);
        }

        // Displays a warning message
        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Displays an error message
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmLearnerInformation_Load(object sender, EventArgs e)
        {

            //add data bind

            BindData();

        }
        private void BindData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-RULM89R\\SQLEXPRESS;Database=LMS_Db;Trusted_Connection=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string query = "SELECT Surname AS Learner_Surname, FullNames AS Learner_First_Name, IdentityNumber AS Learner_ID, LearningProgramme AS Course FROM LearnerEnrTbl";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvLearnerList.DataSource = dt;

                            // Set column headers and widths
                            dgvLearnerList.Columns["Learner_Surname"].HeaderText = "Learner Surname";
                            dgvLearnerList.Columns["Learner_Surname"].Width = 285; // Increase width
                            dgvLearnerList.Columns["Learner_First_Name"].HeaderText = "Learner First Name";
                            dgvLearnerList.Columns["Learner_First_Name"].Width = 285; // Increase width
                            dgvLearnerList.Columns["Learner_ID"].HeaderText = "Learner ID";
                            dgvLearnerList.Columns["Learner_ID"].Width = 285; // Increase width
                            dgvLearnerList.Columns["Course"].HeaderText = "Course";
                            dgvLearnerList.Columns["Course"].Width = 285; // Increase width
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUploadQualification_Click(object sender, EventArgs e)
        {
            // Open a file dialog to allow the user to select a qualification document
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Qualification Document",
                Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = openFileDialog.FileName;
                btnUploadQualification.Text = filePath; // Display the file path in the button or another UI element

                // Save the file to the server and store its path in the database
                string serverFilePath = SaveFileToServer(filePath);

                if (!string.IsNullOrEmpty(serverFilePath))
                {
                    // Save the file path to the database
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-RULM89R\\SQLEXPRESS;Database=LMS_Db;Trusted_Connection=True;TrustServerCertificate=True"))
                    {
                        try
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO LearnerEnrTbl(QualificationDocumentPath) VALUES (@QualificationDocumentPath)", con))
                            {
                                // Add the file path as a parameter
                                cmd.Parameters.AddWithValue("@QualificationDocumentPath", serverFilePath);

                                // Execute the query
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Qualification document uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }

                    // Optionally, refresh the data grid or UI to reflect the change
                    BindData();
                }
                else
                {
                    MessageBox.Show("Failed to upload the file to the server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to save the uploaded file to the server
        private string SaveFileToServer(string filePath)
        {
            try
            {
                // Generate a new file name (e.g., by using a timestamp or a GUID)
                string fileName = Path.GetFileName(filePath);
                string serverPath = Path.Combine(@"C:\UploadedDocuments\", fileName);

                // Save the file to the server
                File.Copy(filePath, serverPath);

                // Return the server path where the file is stored
                return serverPath;
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                Console.WriteLine($"Error saving file to server: {ex.Message}");
                return null;
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLearnerList.SelectedRows.Count > 0)
                {
                    // Get selected row data
                    DataGridViewRow selectedRow = dgvLearnerList.SelectedRows[0];
                    string learnerID = selectedRow.Cells["IdentityNumber"]?.Value?.ToString();

                    if (string.IsNullOrEmpty(learnerID))
                    {
                        MessageBox.Show("The selected learner does not have a valid IdentityNumber.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Confirm deletion
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete Learner with ID: {learnerID}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-RULM89R\\SQLEXPRESS;Database=LMS_Db;Trusted_Connection=True;TrustServerCertificate=True"))
                        {
                            con.Open();
                            string query = "DELETE FROM LearnerEnrTbl WHERE IdentityNumber = @LearnerID";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@LearnerID", learnerID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Learner deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Refresh DataGridView
                                    BindData();
                                }
                                else
                                {
                                    MessageBox.Show("No learner found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during deletion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProgrammeDates_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkDeclaration_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkDeclaration_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTrainingProvider_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlternateID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-RULM89R\\SQLEXPRESS;Database=LMS_Db;Trusted_Connection=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string query = @"INSERT INTO LearnerEnrTbl (Surname, FullNames, IdentityNumber, AlternateID, Nationality, HomeLanguage, Age, Gender, Race, DisabilityStatus, EmploymentStatus, OFOCode, CompanyName, HomeAddress, PostAddress, PhoneNumber, EmailAddress, GrantContractNumber, Internship, TrainingProvider, LearningProgramme, StartDate, EndDate, HighestEducation, LastSchoolAttended, Declaration, IdentityDocumentPath, QualificationDocumentPath)
                            VALUES (@Surname, @FullNames, @IdentityNumber, @AlternateID, @Nationality, @HomeLanguage, @Age, @Gender, @Race, @DisabilityStatus, @EmploymentStatus, @OFOCode, @CompanyName, @HomeAddress, @PostAddress, @PhoneNumber, @EmailAddress, @GrantContractNumber, @Internship, @TrainingProvider, @LearningProgramme, @StartDate, @EndDate, @HighestEducation, @LastSchoolAttended, @Declaration, @IdentityDocumentPath, @QualificationDocumentPath)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                        cmd.Parameters.AddWithValue("@FullNames", txtFullNames.Text);
                        cmd.Parameters.AddWithValue("@IdentityNumber", txtIdentityNumber.Text);
                        cmd.Parameters.AddWithValue("@AlternateID", txtAlternateID.Text);
                        cmd.Parameters.AddWithValue("@Nationality", cmbNationality.Text);
                        cmd.Parameters.AddWithValue("@HomeLanguage", cmbHomeLanguage.Text);
                        cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@Race", cmbRace.Text);
                        cmd.Parameters.AddWithValue("@DisabilityStatus", cmbDisabilityStatus.Text);
                        cmd.Parameters.AddWithValue("@EmploymentStatus", cmbEmploymentStatus.Text);
                        cmd.Parameters.AddWithValue("@OFOCode", txtOFOCode.Text);
                        cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
                        cmd.Parameters.AddWithValue("@HomeAddress", txtHomeAddress.Text);
                        cmd.Parameters.AddWithValue("@PostAddress", txtPostAdrress.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text);
                        cmd.Parameters.AddWithValue("@GrantContractNumber", txtGrantContractNumber.Text);
                        cmd.Parameters.AddWithValue("@Internship", cmbInter.Text);
                        cmd.Parameters.AddWithValue("@TrainingProvider", txtTrainingProvider.Text);
                        cmd.Parameters.AddWithValue("@LearningProgramme", txtLearningProgramme.Text);
                        cmd.Parameters.AddWithValue("@StartDate", DateTime.Parse(DatePickerStartDate.Text));
                        cmd.Parameters.AddWithValue("@EndDate", DateTime.Parse(DatePickerEndDate.Text));
                        cmd.Parameters.AddWithValue("@HighestEducation", txtHighestEducation.Text);
                        cmd.Parameters.AddWithValue("@LastSchoolAttended", txtLastSchoolAttended.Text);
                        cmd.Parameters.AddWithValue("@Declaration", chkDeclaration.Checked);
                        cmd.Parameters.AddWithValue("@IdentityDocumentPath", btnUploadID.Text);
                        cmd.Parameters.AddWithValue("@QualificationDocumentPath", btnUploadQualification.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Learner information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchLearner_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {

        }

        private void dgvLearnerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure the row index is valid
            {
                DataGridViewRow row = dgvLearnerList.Rows[e.RowIndex];

                // Retrieve cell values from the clicked row
                string learnerID = row.Cells["Learner_ID"].Value.ToString();
                string learnerName = row.Cells["Learner_First_Name"].Value.ToString();
                string learnerSurname = row.Cells["Learner_Surname"].Value.ToString();
                string course = row.Cells["Course"].Value.ToString();

                // You can use these values to display more information or perform other actions
                MessageBox.Show($"Learner ID: {learnerID}\nName: {learnerName} {learnerSurname}\nCourse: {course}", "Learner Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullNames_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdentityNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbHomeLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUploadID_Click(object sender, EventArgs e)
        {
            // Open a file dialog to allow the user to select an identity document
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Identity Document",
                Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = openFileDialog.FileName;
                btnUploadID.Text = filePath; // Display the file path in the button or another UI element

                // Read the file as a byte array
                byte[] fileData = File.ReadAllBytes(filePath);

                // Save the file data to the database
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-RULM89R\\SQLEXPRESS;Database=LMS_Db;Trusted_Connection=True;TrustServerCertificate=True"))
                {
                    try
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO LearnerEnrTbl(IdentityDocumentPath, FileData) VALUES (@IdentityDocumentPath, @FileData)", con))
                        {
                            // Add the file path as a parameter
                            cmd.Parameters.AddWithValue("@IdentityDocumentPath", filePath);

                            // Add the file data as a parameter
                            cmd.Parameters.Add("@IdentityDocumentPath", SqlDbType.VarBinary).Value = fileData;

                            // Execute the query
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Identity document uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }

                // Optionally, refresh the data grid or UI to reflect the change
                BindData();
            }
        }



    }
}
