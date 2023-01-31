using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elabor8Challenge.CatFactsAPI.Model
{
    public class Name
    {
        [Key]
        public string Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }
}
