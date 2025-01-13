using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LMIS_Dev_Branch.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; } // Example: "Accredited" or "Non-Accredited"

        public int Credits { get; set; }

        public int NQFLevel { get; set; }

        public bool IsAccredited { get; set; }

        [MaxLength(200)]
        public string AccreditationBody { get; set; }

        [MaxLength(100)]
        public string AccreditationNumber { get; set; }

        // Navigation property
        public ICollection<UnitStandard> UnitStandards { get; set; }
    }
}
