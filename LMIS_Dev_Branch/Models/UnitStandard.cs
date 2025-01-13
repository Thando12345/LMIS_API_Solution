using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMIS_Dev_Branch.Models
{
    public class UnitStandard
    {
        [Key]
        public int UnitStandardId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Id { get; set; } // Unit Standard Code or ID

        public int Credits { get; set; }

        public int NQFLevel { get; set; }

        // Foreign Key
        [ForeignKey("Course")]
        public int CourseId { get; set; }

        // Navigation property
        public Course Course { get; set; }
    }
}
