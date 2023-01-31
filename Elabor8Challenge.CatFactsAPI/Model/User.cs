using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elabor8Challenge.CatFactsAPI.Model
{
    public class User
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("Name")]
        public string NameId { get; set; }
        public virtual Name Name { get; set; }
    }
}
