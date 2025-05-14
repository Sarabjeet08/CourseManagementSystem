using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem.Model
{
    public class TeacherCourse
    {
        [Key]
        public int TeacherCourseId { get; set; }
        public int TeacherId { get; set; }
        public int CourseId { get; set; }

        // Navigation properties
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

        ////Validation Max 4 courses per teacher
        public static int MaxCoursesPerTeacher { get; set; } = 4;
        public static bool ValidateMaxCoursesPerTeacher(int currentCourseCount)
        {
            return currentCourseCount < MaxCoursesPerTeacher;
        }



    }
}
