using LMIS_Dev_Branch.Models;
using Microsoft.EntityFrameworkCore;

namespace LMIS_Dev_Branch.Data
{
    public class @null : DbContext
    {
        public @null()
        {
        }

        public @null(DbContextOptions<@null> options) : base(options)
        {
        }
        public DbSet<Learner> Learners { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
