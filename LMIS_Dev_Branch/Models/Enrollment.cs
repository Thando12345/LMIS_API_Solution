using System;

namespace LMIS_Dev_Branch.Models
{
    public class Enrollment
    {
        // Primary Key
        public int EnrollmentId { get; set; }

        // Foreign Key to Learner
        public int LearnerId { get; set; }

        // Additional Properties
        public DateTime EnrollmentDate { get; set; } = DateTime.Now;
        public string Status { get; set; } // e.g., "Active", "Completed", "Cancelled"

        // Navigation Properties
        public Learner Learner { get; set; } // Reference to the associated Learner
    }
}
