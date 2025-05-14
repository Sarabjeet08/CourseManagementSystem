using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagementSystem.DAL;
using CourseManagementSystem.Model;

namespace CourseManagementSystem.BLL
{
    public class CMSServices
    {
        private readonly AppDbContext context = new AppDbContext();

        //Add User for Registration
        public void AddUser(int userId, string username, string password, string role)
        {
            var user = new User();
            user.UserId = userId;
            user.Username = username;
            user.Password = password;
            user.Role = role;

            var existingUser = context.Users.FirstOrDefault(u => u.Username == username);
            if (existingUser != null)
            {
                throw new Exception("Username already exists.");
            }

            context.Users.Add(user);
            context.SaveChanges();
        }

        //Validate User for Login
        public bool ValidateUser(string username, string password)
        {
            var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            return user != null;
        }

        //Get User Role
        public string GetUserRole(string username)
        {
            var user = context.Users.FirstOrDefault(u => u.Username == username);
            return user?.Role;
        }

        //Get All Users
        public List<User> GetAllUsers()
        {
            return context.Users.ToList();
        }

        //Add Course
        public void AddCourse(Course course)
        {
            var existingCourse = context.Courses.FirstOrDefault(c => c.CourseName == course.CourseName);
            if (existingCourse != null)
            {
                throw new Exception("Course name already exists.");
            }

            context.Courses.Add(course);
            context.SaveChanges();
        }

        //Get All Courses
        public List<Course> GetAllCourses()
        {
            return context.Courses.ToList();
        }

        public void UpdateCourse(int courseId, string courseName, string description, int credits, string semester)
        {
            var course = context.Courses.FirstOrDefault(c => c.CourseId == courseId);
            if (course != null)
            {
                course.CourseName = courseName;
                course.Description = description;
                course.Credits = credits;
                course.Semester = semester;
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Course not found.");
            }
        }

        public void DeleteCourse(int courseId)
        {
            var course = context.Courses.FirstOrDefault(c => c.CourseId == courseId);
            if (course != null)
            {
                context.Courses.Remove(course);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Course not found.");
            }
        }

        //Get All Teachers
        public List<Teacher> GetAllTeachers()
        {
            return context.Teachers.ToList();
        }

        //Add Teacher
        public void AddTeacher(Teacher teacher)
        {
            var existingTeacher = context.Teachers.FirstOrDefault(t => t.FirstName == teacher.FirstName && t.LastName == teacher.LastName);
            if (existingTeacher != null)
            {
                throw new Exception("Teacher name already exists.");
            }

            context.Teachers.Add(teacher);
            context.SaveChanges();
        }

        //Update Teacher
        public void UpdateTeacher(int teacherId, string firstName, string lastName, string email, string department)
        {
            var teacher = context.Teachers.FirstOrDefault(t => t.TeacherId == teacherId);
            if (teacher != null)
            {
                teacher.FirstName = firstName;
                teacher.LastName = lastName;
                teacher.Email = email;
                teacher.Department = department;
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Teacher not found.");
            }
        }

        //Delete Teacher
        public void DeleteTeacher(int teacherId)
        {
            var teacher = context.Teachers.FirstOrDefault(t => t.TeacherId == teacherId);
            if (teacher != null)
            {
                context.Teachers.Remove(teacher);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Teacher not found.");
            }
        }

        //Get All Assigned Courses
        public List<TeacherCourse> GetAllAssignedCourse()
        {
            return context.TeacherCourses.ToList();
        }

        //Static Method to get assigned courses by Teacher ID
        public static List<TeacherCourse> GetAssignedCoursesByTeacherId(int teacherId)
        {
            using (var context = new AppDbContext())
            {
                return context.TeacherCourses
                              .Where(tc => tc.TeacherId == teacherId)
                              .ToList();
            }
        }

        //Assign Course to Teacher (with validation)
        public void AssignCourseToTeacher(int teacherId, int courseId)
        {
            var teacher = context.Teachers.FirstOrDefault(t => t.TeacherId == teacherId);
            var course = context.Courses.FirstOrDefault(c => c.CourseId == courseId);

            if (teacher != null && course != null)
            {
                var currentCount = context.TeacherCourses.Count(tc => tc.TeacherId == teacherId);
                if (!TeacherCourse.ValidateMaxCoursesPerTeacher(currentCount))
                {
                    throw new Exception("This teacher is already assigned the maximum number of courses (4).");
                }

                var alreadyAssigned = context.TeacherCourses.Any(tc => tc.TeacherId == teacherId && tc.CourseId == courseId);
                if (alreadyAssigned)
                {
                    throw new Exception("This course is already assigned to this teacher.");
                }

                var teacherCourse = new TeacherCourse
                {
                    TeacherId = teacherId,
                    CourseId = courseId
                };

                context.TeacherCourses.Add(teacherCourse);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Teacher or Course not found.");
            }
        }

        //Unassign Course from Teacher
        public void UnassignCourseFromTeacher(int teacherId, int courseId)
        {
            var teacherCourse = context.TeacherCourses.FirstOrDefault(tc => tc.TeacherId == teacherId && tc.CourseId == courseId);
            if (teacherCourse != null)
            {
                context.TeacherCourses.Remove(teacherCourse);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Teacher-Course assignment not found.");
            }
        }

        //ComboBox Info Fetch
        public Course GetCourseById(int id)
        {
            return context.Courses.FirstOrDefault(c => c.CourseId == id);
        }

        public Teacher GetTeacherById(int id)
        {
            return context.Teachers.FirstOrDefault(t => t.TeacherId == id);
        }
    }
}
