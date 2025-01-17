using System;
using System.Windows.Forms;

namespace LMIS_Dev_Branch
{
    public partial class FrmCreateCourseForm : Form
    {
        public FrmCreateCourseForm()
        {
            InitializeComponent();

            // Initialize visibility of accreditation fields
            ToggleAccreditationFields(false);

            // Initially set visibility to false
            flowLayoutPanelUnitStandards.Visible = false;
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
            // Log to confirm button click is being triggered
            MessageBox.Show("Add Unit Standard button clicked!", "Action Triggered", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ensure the FlowLayoutPanel is set to visible
            flowLayoutPanelUnitStandards.Visible = true;

            // Log to confirm visibility change
            if (flowLayoutPanelUnitStandards.Visible)
            {
                MessageBox.Show("FlowLayoutPanel is now visible!", "Action Triggered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to make FlowLayoutPanel visible!", "Action Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Bring it to the front (in case it's hidden behind other controls)
            flowLayoutPanelUnitStandards.BringToFront();
        }




        // Event: Save Course Button Click
        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            // Validate and save the course details
            string courseName = txtCourseName.Text.Trim();
            bool isAccredited = lblAccreditationBody.Visible; // Check if accreditation fields are visible

            if (string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please enter the course name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isAccredited)
            {
                string accreditationBody = txtAccreditationBody.Text.Trim();
                string accreditationNumber = txtAccreditationNumber.Text.Trim();

                if (string.IsNullOrEmpty(accreditationBody) || string.IsNullOrEmpty(accreditationNumber))
                {
                    MessageBox.Show("Please enter both Accreditation Body and Accreditation Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Save logic goes here
            MessageBox.Show("Course details saved successfully!", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Additional Events
        private void txtCourseName_TextChanged(object sender, EventArgs e) { }
        private void txtUsNumberInput_TextChanged(object sender, EventArgs e) { }
        private void txtUsCredits_TextChanged(object sender, EventArgs e) { }
        private void txtUsNqfLevel_TextChanged(object sender, EventArgs e) { }
        private void txtAccreditationBody_TextChanged(object sender, EventArgs e) { }
        private void txtAccreditationNumber_TextChanged(object sender, EventArgs e) { }
        private void lblAccreditationToggle_Click(object sender, EventArgs e) { }

        private void flowLayoutPanelUnitStandards_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
