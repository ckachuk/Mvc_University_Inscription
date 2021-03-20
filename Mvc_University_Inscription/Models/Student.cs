using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mvc_University_Inscription.Models
{
    public class Student
    {

        [Key]
        public int id_Student { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string DNI { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();


    }
}
