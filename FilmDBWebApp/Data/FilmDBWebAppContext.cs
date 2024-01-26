using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FilmDBWebApp.Models;

namespace FilmDBWebApp.Data
{
    public class FilmDBWebAppContext : DbContext
    {
        public FilmDBWebAppContext (DbContextOptions<FilmDBWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<FilmDBWebApp.Models.Film> Film { get; set; } = default!;
    }
}
