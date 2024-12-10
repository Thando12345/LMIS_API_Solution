using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LMIS_Dev_Branch.Models;

namespace LMIS_Dev_Branch.Process_Handlers.Database
{
    public class DBContext : DbContext
    {
       // private readonly string _connectionString;

        // Constructor to initialize the connection string from appsettings.json
       // public DBContext(DbContextOptions<DBContext> options) : base(options)
        //{
           // var configuration = new ConfigurationBuilder()
             //   .SetBasePath(Directory.GetCurrentDirectory())
              //  .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
              //  .Build();

          //  _connectionString = configuration.GetConnectionString("DefaultConnection");
       // }

        // EF Core DbSets for entities
        public DbSet<Learner> Learners { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        // OnModelCreating method to configure the model relationships
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // Define primary keys for entities
        //    modelBuilder.Entity<Learner>()
        //        .HasKey(l => l.LearnerId);

        //    modelBuilder.Entity<Enrollment>()
        //        .HasKey(e => e.EnrollmentId);

        //    // Define relationships between Learner and Enrollment
        //    modelBuilder.Entity<Enrollment>()
        //        .HasOne(e => e.Learner)
        //        .WithMany(l => l.Enrollments)
        //        .HasForeignKey(e => e.LearnerId);
        //}
    }
}
