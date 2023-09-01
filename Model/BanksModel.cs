using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Model
{
    public class BanksModel
    {
        [JsonPropertyName("ispb")]
        public string Ispb;
         [JsonPropertyName("name")]
        public string Name { get; set; }
         [JsonPropertyName("code")]
        public int Code { get; set; }
         [JsonPropertyName("fullname")]
        public string FullName { get; set; }
    }
}