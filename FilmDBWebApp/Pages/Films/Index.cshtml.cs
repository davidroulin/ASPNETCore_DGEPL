using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FilmDBWebApp.Data;
using FilmDBWebApp.Models;

namespace FilmDBWebApp.Pages.Films
{
    public class IndexModel : PageModel
    {
        private readonly FilmDBWebApp.Data.FilmDBWebAppContext _context;

        public IndexModel(FilmDBWebApp.Data.FilmDBWebAppContext context)
        {
            _context = context;
        }

        public IList<Film> Film { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Film != null)
            {
                Film = await _context.Film.ToListAsync();
            }
        }
    }
}
