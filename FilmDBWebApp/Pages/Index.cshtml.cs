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

		//public string TitreTest { get; set; }

        //public List<string> tousLesFilms_CoteServeur;
        public List<Film> tousLesFilms_CoteServeur;

		private readonly ILogger<IndexModel> _logger;

		private readonly IWebHostEnvironment _hostingInfo;

		public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment hostingInfo)
		{
			_logger = logger;

			_hostingInfo = hostingInfo;

			////  TODO en dur 4 films pour tester
			//tousLesFilms_CoteServeur = new List<string>()
			//{
			//	"Rocky 14",
			//	"Rambo 12",
			//	"La petite maison dans la prairie",
			//	"Shakespeare in love"
			//};

			//tousLesFilms_CoteServeur = new List<Film>()
			//{
			//	new Film{ Summary = "Super film", Title = "Alien 17", Year = "2021" },
			//	new Film{ Summary = "Film moyen", Title = "La petite sirene, la revanche", Year = "1999" }
			//};



			//TitreTest = "Rocky 12";

			string cheminFichierData = Path.Combine(
				_hostingInfo.WebRootPath,
				"data",
				"movies.json"
			);
			// TODO tester ~
			// TODO WebHostEnvironment

			var pointeurFichierData = System.IO.File.OpenText(cheminFichierData);

			string contenuFichierData = pointeurFichierData.ReadToEnd();

			Film[]? films = JsonSerializer.Deserialize<Film[]>(
				contenuFichierData,
				new JsonSerializerOptions {
					PropertyNameCaseInsensitive = true
				}
			);

			tousLesFilms_CoteServeur = films.ToList();

		}

		public void OnGet()
		{

		}
	}
}
