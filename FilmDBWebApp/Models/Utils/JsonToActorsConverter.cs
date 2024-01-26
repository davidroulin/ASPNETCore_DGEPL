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
			List<Actor> actors = new List<Actor>();

			while (reader.Read())
			{
				if (reader.TokenType == JsonTokenType.EndArray)
				{
					break;
				} else
				{
					//string current = reader.GetString();

					//Actor actor1 = new Actor();
					//actor1.FullName = current;

					//Actor actor2 = new Actor { FullName = current };

					//actors.Add(actor);


					//actors.Add(new Actor { FullName = reader.GetString() });


					//string? current = reader.GetString();
					//Actor actor = new Actor { FullName = current ?? "" };
					//actors.Add(actor);

					string? current = reader.GetString();
					Actor actor = new Actor { FullName = current ?? "" };
					actors.Add(actor);

				}
			}

			return actors;


			//Actor actor = new Actor();
			//actor.FullName = "Benoit Poelvoorde";
			//List<Actor> actors = new List<Actor>();
			//actors.Add(actor);
			//return actors;
		}

		public override void Write(Utf8JsonWriter writer, List<Actor> value, JsonSerializerOptions options)
		{
			// TODO
			throw new NotImplementedException();
		}
	
	}
}
