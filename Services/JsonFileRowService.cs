
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;


using Microsoft.AspNetCore.Hosting;
using Razor_test1.Models;

namespace Razor_test1.Services
{
    public class JsonFileRowService
    {
 

    
        public JsonFileRowService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "rows.json"); }
        }

        public IEnumerable<Row> GetRows()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Row[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

      
    }

}