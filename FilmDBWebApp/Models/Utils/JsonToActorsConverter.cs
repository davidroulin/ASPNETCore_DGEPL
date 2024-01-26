using System.Text.Json;
using System.Text.Json.Serialization;

namespace FilmDBWebApp.Models.Utils
{
	public class JsonToActorsConverter: JsonConverter<List<Actor>>
	{
		// TODO fournit une logique pour passer
		// d'un array de strings Json -> a -> List<Actor>

		public override List<Actor>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			while (reader.Read())
			{
				if (reader.TokenType == JsonTokenType.EndArray)
				{
					break;
				}
			}

			Actor actor = new Actor();
			actor.FullName = "Benoit Poelvoorde";
			List<Actor> actors = new List<Actor>();
			actors.Add(actor);
			return actors;
		}

		public override void Write(Utf8JsonWriter writer, List<Actor> value, JsonSerializerOptions options)
		{
			// TODO
			throw new NotImplementedException();
		}
	
	}
}
