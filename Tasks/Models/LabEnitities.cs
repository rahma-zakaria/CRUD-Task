using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;


namespace Tasks.Models
{
    public class LabEnitities : DbContext
    {
        public LabEnitities(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
