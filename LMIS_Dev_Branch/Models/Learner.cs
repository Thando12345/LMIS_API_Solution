using System;
using System.Collections.Generic;

namespace LMIS_Dev_Branch.Models
{
    public class Learner
    {
        public int LearnerId { get; set; } // Primary Key
        public string Surname { get; set; }
        public string FullNames { get; set; }
        public string IdentityNumber { get; set; }
        public string AlternateID { get; set; }
        public string Nationality { get; set; }
        public string HomeLanguage { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string DisabilityStatus { get; set; }
        public string EmploymentStatus { get; set; }
        public string OFOCode { get; set; }
        public string CompanyName { get; set; }
        public string HomeAddress { get; set; }
        public string PostAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string GrantContractNumber { get; set; }
        public string Internship { get; set; }
        public string TrainingProvider { get; set; }
        public string LearningProgramme { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string HighestEducation { get; set; }
        public string LastSchoolAttended { get; set; }
        public bool Declaration { get; set; }
        public string IdentityDocumentPath { get; set; }
        public string QualificationDocumentPath { get; set; }

        // Navigation property for enrollments
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
