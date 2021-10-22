using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Razor_test1.Models
{
    public class Row
    {
        [JsonPropertyName("Time_Windows")]
        public string Time { get; set; }

        [JsonPropertyName("1m")]
        public string one_m { get; set; } // Decimal originally
        [JsonPropertyName("5m")]
        public string five_m { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Row>(this);
        
    }
}
