using System;
using System.Collections.Generic;

namespace LMIS_Dev_Branch.Models
{
    public class Course : IModel
    {
        public string CourseID { get; set; } // Unique identifier for the course
        public string CourseDescription { get; set; } // Detailed description of the course
        public DateTime StartDate { get; set; } // Start date of the course
        public DateTime EndDate { get; set; } // End date of the course
        public int DurationInMonths { get; set; } // Duration of the course in months

        // Navigation property for enrollments
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
