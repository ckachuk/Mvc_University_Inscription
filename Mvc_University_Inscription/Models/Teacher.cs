using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Mvc_University_Inscription.Models
{
    public class Teacher
    {
        [Key]
        public int Id_Teacher { get; set; }

        [Required]
        public string First_Name_Teacher { get; set; }

        [Required]
        public string Last_Name_Teacher { get; set; }

        [Required]
        public int DNI { get; set; }


        public bool Active { get; set; }

        public List<Course> Course { get; set; } = new List<Course>();

    }
}
