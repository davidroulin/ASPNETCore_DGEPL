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
    public class DeleteModel : PageModel
    {
        private readonly FilmDBWebApp.Data.FilmDBWebAppContext _context;

        public DeleteModel(FilmDBWebApp.Data.FilmDBWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Film Film { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Film == null)
            {
                return NotFound();
            }

            var film = await _context.Film.FirstOrDefaultAsync(m => m.ID == id);

            if (film == null)
            {
                return NotFound();
            }
            else 
            {
                Film = film;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Film == null)
            {
                return NotFound();
            }
            var film = await _context.Film.FindAsync(id);

            if (film != null)
            {
                Film = film;
                _context.Film.Remove(Film);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
