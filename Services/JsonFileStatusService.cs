using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

using Microsoft.AspNetCore.Hosting;
using Razor_test1.Models;

namespace Razor_test1.Services
{
    public class JsonFileStatusService
    {



        public JsonFileStatusService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "statuses.json"); }
        }

        public IEnumerable<Status> GetStatuses()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Status[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }


    }

}