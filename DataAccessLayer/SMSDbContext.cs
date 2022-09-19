using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SMSDbContext:DbContext
    {
        public SMSDbContext():base("constr")
        {

        }
        public DbSet<College> Colleges { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Student> Students { get; set; }
    }
    
}
