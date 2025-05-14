using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required] // Unique username
        public string Username { get; set; }

        [Required] 
        public string Password { get; set; }
        [Required]
        public string Role { get; set; } // e.g., "Admin", "Teacher"



    }
}
