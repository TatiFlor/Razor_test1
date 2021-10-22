using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Razor_test1.Models
{
    public class Param
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Param>(this);
    }
}
