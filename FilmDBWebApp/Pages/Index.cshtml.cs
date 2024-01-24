using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FilmDBWebApp.Pages
{
	public class IndexModel : PageModel
	{

		public string TitreTest { get; set; }

        public List<string> tousLesFilms_CoteServeur;

        private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;

			////  TODO en dur 4 films pour tester
			tousLesFilms_CoteServeur = new List<string>()
			{
				"Rocky 14",
				"Rambo 12",
				"La petite maison dans la prairie",
				"Shakespeare in love"
			};

			TitreTest = "Rocky 12";

        }

		public void OnGet()
		{

		}
	}
}
