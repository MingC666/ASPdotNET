using System.Text.Json;
using System.Text.Json.Serialization;

namespace DotnetWeb.Models
{
	public class Food
	{
        public string Name { get; set; }
		public string Price { get; set; }
		public string Ingredients { get; set; }

        

        public override string ToString() => JsonSerializer.Serialize<Food>(this);

		public string Info() =>  $"{Name}: ${Price}; Made of: {Ingredients}.";


    }
}

