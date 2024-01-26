using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using FilmDBWebApp.Models;

namespace FilmDBWebApp.Pages
{
	public class IndexModel : PageModel
	{

		private readonly ILogger<IndexModel> _logger;

		public List<Film> tousLesFilms_CoteServeur = new List<Film>();

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;

		}

		public void OnGet()
		{

		}
	}
}
