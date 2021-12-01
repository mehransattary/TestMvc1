using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMvc1.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Manager> Mangers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Student> Course_student { get; set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Course_Student>().HasKey(sc => new { sc.Students_id ,sc.Course_id });
            //modelBuilder.Entity<Student>().Property(x=>x.FirstName)
            //.HasColumnName("FirstName").HasMaxLength(100).IsRequired().HasColumnType("nvarhar(70)");

            //modelBuilder.Entity<Student>().Property(x => x.FirstName)
            //  .HasColumnName("FirstName").HasMaxLength(100).IsRequired().HasColumnType("nvarhar(70)");
        }


    }
}
