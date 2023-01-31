using System.Text.Json.Serialization;

namespace Elabor8Challenge.CatFactsWeb.DTOs
{
    public class UserDto
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }
        public NameDto Name { get; set; }
    }
}
