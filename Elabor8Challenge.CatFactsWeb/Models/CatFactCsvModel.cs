using System.Text.Json.Serialization;

namespace Elabor8Challenge.CatFactsWeb.Models
{
    public class CatFactCsvModel
    {
        [JsonPropertyName("user")]
        public string User { get; set; }

        [JsonPropertyName("totalVotes")]
        public int TotalVotes { get; set; }
    }
}
