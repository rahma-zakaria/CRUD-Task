using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;


namespace Tasks.Models
{
    public class LabEnitities : DbContext
    {
        //public LabEnitities()
        //{

        //}

        public LabEnitities(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.
        //        UseSqlServer("Data Source=.;Initial Catalog=TaskMVC;Integrated Security=True");
        //}
    }
}
