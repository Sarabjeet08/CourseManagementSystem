using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagementSystem.Model;

namespace CourseManagementSystem.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("CMSdb")
        {
          
        }
        //create DataSet and Tables
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }
     
    }
}
