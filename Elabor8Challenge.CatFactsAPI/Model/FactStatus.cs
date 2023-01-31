using System.Collections.Generic;

namespace Elabor8Challenge.CatFactsAPI.Model
{
    public class FactStatus
    {
        public string Id { get; set; }
        public bool Verified { get; set; }
        public int SentCount { get; set; }
        public virtual ICollection<CatFact> Facts { get; set; }
    }
}
