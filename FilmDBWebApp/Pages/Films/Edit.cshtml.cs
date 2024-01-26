using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilmDBWebApp.Data;
using FilmDBWebApp.Models;

namespace FilmDBWebApp.Pages.Films
{
    public class EditModel : PageModel
    {
        private readonly FilmDBWebApp.Data.FilmDBWebAppContext _context;

        public EditModel(FilmDBWebApp.Data.FilmDBWebAppContext context)
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

            var film =  await _context.Film.FirstOrDefaultAsync(m => m.ID == id);
            if (film == null)
            {
                return NotFound();
            }
            Film = film;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Film).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmExists(Film.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FilmExists(int id)
        {
          return (_context.Film?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
