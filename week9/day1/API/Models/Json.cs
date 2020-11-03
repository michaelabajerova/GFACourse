using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.Models
{
    public class Json
    {
        [JsonProperty("until")]
        public int? Until { get; set; }

        [JsonProperty("what")]
        public string What { get; set; }

        [JsonProperty("numbers")]
        public int[] Numbers { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }
    }
}
