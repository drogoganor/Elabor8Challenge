using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elabor8Challenge.CatFactsAPI.Model
{
    public class Name
    {
        public string Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }

        [NotMapped]
        public virtual User User { get; set; }
    }
}
