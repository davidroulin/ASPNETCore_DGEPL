using System;

namespace FilmDBWebApp.Models
{

	public class Film
	{

		// const ou readonly ?
		// lire par ex. ce tres bon article : https://www.bytehide.com/blog/const-vs-readonly-in-c-explanation-in-3-minutes
		public const int max_length_summary = 150;

		public string Title { get; set; }

		public string Summary { get; set; } // "extract"

		public string TruncatedSummary {
			get {
				return (Summary?.Substring(0, Math.Min(max_length_summary, Summary.Length)) ?? "(no resume)")
					+ (Summary?.Length > max_length_summary ? "..." : "" ?? "");
			}
		}

		public int Year { get; set; }

		public string Poster { get; set; } // "thumbnail"

		//public List<Actor> Actors { get; set; }

		//public List<string> Genres { get; set; }

	}

}
