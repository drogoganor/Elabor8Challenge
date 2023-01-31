using System.Text.Json.Serialization;

namespace Elabor8Challenge.CatFactsAPI.DTOs
{
    public class CatFactSummaryDto
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public UserDto User { get; set; }
        public int Upvotes { get; set; }
        public string UserUpvoted { get; set; }
    }
}
