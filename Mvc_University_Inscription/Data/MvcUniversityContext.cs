using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mvc_University_Inscription.Models;


namespace Mvc_University_Inscription.Data
{
    public class MvcUniversityContext : DbContext
    {
        public MvcUniversityContext(DbContextOptions<MvcUniversityContext> options) : base(options)
        {
        }

        public DbSet <Course> Courses { get; set; }
        public DbSet <Student> Students { get; set; }
        public DbSet <Teacher> Teachers { get; set; }
        public DbSet <Admin> Admins { get; set; }

    }

}
