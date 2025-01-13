using LMIS_Dev_Branch.Models;
using Microsoft.EntityFrameworkCore;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options) { }

    public DbSet<Course> Courses { get; set; }
    public DbSet<UnitStandard> UnitStandards { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>()
            .HasMany(c => c.UnitStandards)
            .WithOne(us => us.Course)
            .HasForeignKey(us => us.CourseId);

        base.OnModelCreating(modelBuilder);
    }
}
