using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mvc_University_Inscription.Models
{
    public class Course
    {
        [Key]
        public int Id_Course { get; set; }

        [Required]
        public string Name_Course { get; set; }

        [Required]
        public DateTime Schedule { get; set; }

        [Required]
        public int Max_Quota { get; set; }


        public Teacher Teacher { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();

        public Course()
        {

        }

    }
}
