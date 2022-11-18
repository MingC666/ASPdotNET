using System;
using System.Text.Json;
using DotnetWeb.Models;

namespace DotnetWeb.Services
{
	public class JsonFileFoodsService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        public JsonFileFoodsService(IWebHostEnvironment webHostEnvironment)

        {
			WebHostEnvironment = webHostEnvironment;
		}

        private string JsonFileName { get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "foods.json"); } }

        public IEnumerable<Food> GetFoods()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Food[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

    }
}

