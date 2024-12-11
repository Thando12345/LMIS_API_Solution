using Microsoft.EntityFrameworkCore;
using LMIS_Dev_Branch.Models;

namespace LMIS_Dev_Branch.Process_Handlers.Database
{
    public class DBContext : DbContext
    {
        // Constructor to initialize the DbContext with options
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        // EF Core DbSets for entities
        public DbSet<Learner> Learners { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        // Configure the model relationships using OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define primary keys for entities
            modelBuilder.Entity<Learner>()
                .HasKey(l => l.LearnerId);

            modelBuilder.Entity<Enrollment>()
                .HasKey(e => e.EnrollmentId);

            // Define relationships between Learner and Enrollment
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Learner)
                .WithMany(l => l.Enrollments)
                .HasForeignKey(e => e.LearnerId);
        }
    }
}
