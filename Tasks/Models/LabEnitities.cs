using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;


namespace Tasks.Models
{
    public class LabEnitities : DbContext
    {
        //public LabEnitities()
        //{

        //}

        public LabEnitities(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new CustomerMap());
            base.OnModelCreating(modelBuilder);
        }
        //public DbSet<Student> Student { get; set; }
        //public DbSet<Department> Department { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.
        //        UseSqlServer("Data Source=.;Initial Catalog=TaskMVC;Integrated Security=True");
        //}
    }
}
