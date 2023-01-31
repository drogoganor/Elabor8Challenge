using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elabor8Challenge.CatFactsAPI.Model
{
    public class CatFact
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public bool Used { get; set; }
        public bool Deleted { get; set; }
        public string Source { get; set; }
        public int Upvotes { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public int V { get; set; }
        public virtual FactStatus Status { get; set; }
        public virtual ICollection<User> UserUpvoted { get; set; }

        [NotMapped]
        public virtual User UserSubmitted { get; set; }
    }
}
