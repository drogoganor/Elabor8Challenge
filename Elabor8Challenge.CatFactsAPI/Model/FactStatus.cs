using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Elabor8Challenge.CatFactsAPI.Model
{
    public class FactStatus
    {
        [Key]
        public string Id { get; set; }
        public bool Verified { get; set; }
        public int SentCount { get; set; }
    }
}
