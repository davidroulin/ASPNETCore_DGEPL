using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FilmDBWebApp.Pages
{
	public class IndexModel : PageModel
	{

		//public string TitreTest { get; set; }

        //public List<string> tousLesFilms_CoteServeur;
        public List<Film> tousLesFilms_CoteServeur;

		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;

			////  TODO en dur 4 films pour tester
			//tousLesFilms_CoteServeur = new List<string>()
			//{
			//	"Rocky 14",
			//	"Rambo 12",
			//	"La petite maison dans la prairie",
			//	"Shakespeare in love"
			//};

			tousLesFilms_CoteServeur = new List<Film>()
			{
				new Film{ Summary = "Super film", Title = "Alien 17", Year = "2021" },
				new Film{ Summary = "Film moyen", Title = "La petite sirene, la revanche", Year = "1999" }
			};


			//TitreTest = "Rocky 12";

        }

		public void OnGet()
		{

		}
	}
}
