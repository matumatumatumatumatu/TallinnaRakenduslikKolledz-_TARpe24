using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TallinnaRakenduslikKolledž.Models;
using Microsoft.EntityFrameworkCore;

namespace TallinnaRakenduslikKolledž.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }
        
            public DbSet<Course> Courses { get; set; }
            public DbSet<Enrollment> Enrollments { get; set; }
            public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Department> Departments{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Course>().ToTable("Course");
            modelbuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelbuilder.Entity<Student>().ToTable("Student");
            modelbuilder.Entity<Instructor>().ToTable("Instructor");
            modelbuilder.Entity<CourseAssignment>().ToTable("CourseAssignment");
            modelbuilder.Entity<OfficeAssignment>().ToTable("OfficeAssignment");
            modelbuilder.Entity<Department>().ToTable("Department");

        }

    }
}
