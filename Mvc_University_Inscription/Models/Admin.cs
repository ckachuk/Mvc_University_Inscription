using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mvc_University_Inscription.Models
{
    public class Admin
    {
        [Key]
        public int Id_Admin { get; set; }

        public string User_Name { get; set; }

        public string Password { get; set; }


    }
}
