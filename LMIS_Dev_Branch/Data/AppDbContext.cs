using Microsoft.EntityFrameworkCore;
using LMIS_Dev_Branch.Models;

namespace LMIS_Dev_Branch.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Learner> Learners { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships
            modelBuilder.Entity<Learner>()
                .HasKey(l => l.LearnerId);

            modelBuilder.Entity<Enrollment>()
                .HasKey(e => e.EnrollmentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Learner)
                .WithMany(l => l.Enrollments)
                .HasForeignKey(e => e.LearnerId);

            // Optional: Define Course relationship if available
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId);
        }
    }
}
