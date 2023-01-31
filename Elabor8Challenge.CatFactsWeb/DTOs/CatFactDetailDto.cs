using System;
using System.Text.Json.Serialization;

namespace Elabor8Challenge.CatFactsWeb.DTOs
{
    public class CatFactDetailDto
    {
        public bool Used { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public bool Deleted { get; set; }
        public string Id { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string User { get; set; }
        public string Text { get; set; }

        [JsonPropertyName("__v")]
        public int V { get; set; }
        public FactStatusDto Status { get; set; }
    }
}
