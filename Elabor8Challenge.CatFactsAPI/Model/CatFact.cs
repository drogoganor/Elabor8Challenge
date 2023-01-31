using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elabor8Challenge.CatFactsAPI.Model
{
    public class CatFact
    {
        [Key]
        public string Id { get; set; }
        public string Text { get; set; }
        public FactTypeEnum Type { get; set; }
        public bool Used { get; set; }
        public bool Deleted { get; set; }
        public FactSourceEnum Source { get; set; }
        public int Upvotes { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public int V { get; set; }
        public string UserUpvoted { get; set; }

        [ForeignKey("Status")]
        public string StatusId { get; set; }
        public virtual FactStatus Status { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
