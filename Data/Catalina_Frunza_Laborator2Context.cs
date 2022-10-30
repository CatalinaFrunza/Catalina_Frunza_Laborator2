using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Catalina_Frunza_Laborator2.Models;

namespace Catalina_Frunza_Laborator2.Data
{
    public class Catalina_Frunza_Laborator2Context : DbContext
    {
        public Catalina_Frunza_Laborator2Context (DbContextOptions<Catalina_Frunza_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Catalina_Frunza_Laborator2.Models.Books> Book { get; set; } = default!;

        public DbSet<Catalina_Frunza_Laborator2.Models.Publisher> Publisher { get; set; }
    }
}
