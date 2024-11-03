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
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            // Initialize the DataGridView with some sample data for demonstration purposes
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Set up columns for dgvCourses
            dgvCourses.Columns.Add("CourseName", "Course Name");
            dgvCourses.Columns.Add("CourseType", "Course Type");
            dgvCourses.Columns.Add("Credits", "Credits");
            dgvCourses.Columns.Add("NQFLevel", "NQF Level");

            // Adding a checkbox column for Accreditation
            DataGridViewCheckBoxColumn accreditedColumn = new DataGridViewCheckBoxColumn
            {
                Name = "IsAccredited",
                HeaderText = "Accredited",
                Width = 100
            };
            dgvCourses.Columns.Add(accreditedColumn);

            // Sample data
            dgvCourses.Rows.Add("Computer Science", "Degree", 120, 6, true);
            dgvCourses.Rows.Add("Data Analysis", "Certificate", 30, 5, true);
            dgvCourses.Rows.Add("Web Development", "Diploma", 90, 6, false);

            // Set other properties of DataGridView
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.ReadOnly = true;
        }

        private void dgvCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvCourses.Rows[e.RowIndex];
                string courseName = selectedRow.Cells["CourseName"].Value.ToString();
                string courseType = selectedRow.Cells["CourseType"].Value.ToString();
                int credits = Convert.ToInt32(selectedRow.Cells["Credits"].Value);
                int nqfLevel = Convert.ToInt32(selectedRow.Cells["NQFLevel"].Value);
                bool isAccredited = Convert.ToBoolean(selectedRow.Cells["IsAccredited"].Value);

                // Mock accreditation data
                string accreditationBody = isAccredited ? "Some Accrediting Body" : "";
                string accreditationNumber = isAccredited ? "Accreditation123" : "";

                // Open FrmCourseDetails as a pop-up
                FrmCourseDetails detailsForm = new FrmCourseDetails(courseName, courseType, credits, nqfLevel, isAccredited, accreditationBody, accreditationNumber);
                detailsForm.ShowDialog();
            }
        }


        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                MessageBox.Show($"You clicked on cell [{e.RowIndex}, {e.ColumnIndex}]");
            }
        }

        private void ShowCourseDetails(string courseName, string courseType, int credits, int nqfLevel, bool isAccredited)
        {
            // Display course details in a message box or open a new form with detailed info
            string message = $"Course Name: {courseName}\nCourse Type: {courseType}\nCredits: {credits}\nNQF Level: {nqfLevel}\nAccredited: {isAccredited}";
            MessageBox.Show(message, "Course Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblCourseListHeader_Click(object sender, EventArgs e)
        {
            // Code for any action when lblCourseListHeader is clicked, if needed
        }

        private void btnNavigation_Click(object sender, EventArgs e)
        {
            // Code to handle navigation button click, if needed
            MessageBox.Show("Navigation button clicked!");
        }
    }
}
