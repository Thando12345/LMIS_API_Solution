using System;

namespace LMIS_Dev_Branch.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; } // Primary Key
        public int LearnerId { get; set; } // Foreign Key to Learner
        public int CourseId { get; set; } // Foreign Key to Course

        public DateTime EnrollmentDate { get; set; } = DateTime.Now; // Enrollment date
        public string Status { get; set; } // Status of the enrollment

        // Navigation properties
        public Learner Learner { get; set; }
        public Course Course { get; set; }
    }
}
