using System;
using System.Text.Json.Serialization;

/// <summary>
/// 
/// Exemple
/// 
// {
//	  "title": "102 Dalmatians",
//    "year": 2000,
//    "cast": [
//      "Glenn Close",
//      "Gérard Depardieu",
//      "Alice Evans"
//    ],
//    "genres": [
//      "Comedy",
//      "Family",
//      "Crime"
//    ],
//    "href": "102_Dalmatians",
//    "extract": "102 Dalmatians is a 2000 American crime comedy film directed by Kevin Lima and produced by Edward S. Feldman and Walt Disney Pictures. The sequel to the 1996 film 101 Dalmatians, a live-action remake of the 1961 Disney animated film of the same name, it stars Glenn Close reprising her role as Cruella de Vil as she attempts to steal puppies for her \"grandest\" fur coat yet. Glenn Close and Tim McInnerny were the only two actors from the 1996 film to return for the sequel. The film received generally negative reviews from critics and was unable to achieve the box office success of its predecessor, although the film was nominated for the Academy Award for Best Costume Design.",
//    "thumbnail": "https://upload.wikimedia.org/wikipedia/en/f/fe/102_dalmatians_poster.jpg",
//    "thumbnail_width": 220,
//    "thumbnail_height": 327
//  }
/// 
/// 
/// </summary>

public class Film
{

	public string Title { get; set; }

	[JsonPropertyName("extract")]
	public string Summary { get; set; } // "extract"

	public int Year { get; set; }

	[JsonPropertyName("thumbnail")]
	public string Poster{ get; set; } // "thumbnail"



}
