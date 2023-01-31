using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elabor8Challenge.CatFactsAPI.Model
{
    public class User
    {
        public string Id { get; set; }
        public virtual Name Name { get; set; }
        public virtual ICollection<CatFact> UpvotedCatFacts { get; set; }

        [NotMapped]
        public virtual ICollection<CatFact> SubmittedCatFacts { get; set; }
    }
}
