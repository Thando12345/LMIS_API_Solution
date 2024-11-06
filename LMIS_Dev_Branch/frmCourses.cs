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
    public partial class frmCourses1 : Form
    {
        public frmCourses1()
        {
            InitializeComponent();
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            // Initialize the DataGridView with sample data
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Set up columns for dgvCourses
            dgvCourses.Columns.Add("CourseName", "Course Name");
            dgvCourses.Columns.Add("CourseType", "Course Type");
            dgvCourses.Columns.Add("Credits", "Credits");
            dgvCourses.Columns.Add("NQFLevel", "NQF Level");

            // Add a checkbox column for Accreditation
            DataGridViewCheckBoxColumn accreditedColumn = new DataGridViewCheckBoxColumn
            {
                Name = "IsAccredited",
                HeaderText = "Accredited",
                Width = 100
            };
            dgvCourses.Columns.Add(accreditedColumn);

            // Add sample data
            dgvCourses.Rows.Add("Computer Science", "Degree", 120, 6, true);
            dgvCourses.Rows.Add("Data Analysis", "Certificate", 30, 5, true);
            dgvCourses.Rows.Add("Web Development", "Diploma", 90, 6, false);

            // Set DataGridView properties
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.ReadOnly = true;
        }

        private void dgvCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is selected
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvCourses.Rows[e.RowIndex];

                // Retrieve course details from the selected row
                string courseName = selectedRow.Cells["CourseName"].Value.ToString();
                string courseType = selectedRow.Cells["CourseType"].Value.ToString();
                int credits = Convert.ToInt32(selectedRow.Cells["Credits"].Value);
                int nqfLevel = Convert.ToInt32(selectedRow.Cells["NQFLevel"].Value);
                bool isAccredited = Convert.ToBoolean(selectedRow.Cells["IsAccredited"].Value);

                // Mock accreditation data
                string accreditationBody = isAccredited ? "Some Accrediting Body" : "";
                string accreditationNumber = isAccredited ? "Accreditation123" : "";

                // Open CourseDetailsForm as a pop-up
                CourseDetailsForm detailsForm = new CourseDetailsForm
                {
                    CourseName = courseName,
                    CourseType = courseType,
                    Credits = credits,
                    NQFLevel = nqfLevel,
                    IsAccredited = isAccredited,
                    AccreditationBody = accreditationBody,
                    AccreditationNumber = accreditationNumber
                };
                detailsForm.ShowDialog();
            }
        }

        private void btnNavigation_Click(object sender, EventArgs e)
        {
            // Code to handle navigation button click
            MessageBox.Show("Navigation button clicked!");
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            CreateCourseForm createCourseForm = new CreateCourseForm();
            createCourseForm.Show();
        }

        private void btnCreateAccreditedC_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateNonAccreditedCourse_Click(object sender, EventArgs e)
        {

        }

        private void lblNonAccreditedPrograms_Click(object sender, EventArgs e)
        {

        }

        private void lblAccreditedLearnership_Click(object sender, EventArgs e)
        {
            // Trigger logic to create an accredited course.
            // For example, show a form to enter accredited course details.
            CreateCourseForm createCourseForm = new CreateCourseForm();
            createCourseForm.chkAccredited.Checked = true; // Set accreditation to true.
            createCourseForm.Show();
        }

        private void lblAccreditedSkillsPrograms_Click(object sender, EventArgs e)
        {

        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCourseType_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNQFLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkIsAccredited_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}