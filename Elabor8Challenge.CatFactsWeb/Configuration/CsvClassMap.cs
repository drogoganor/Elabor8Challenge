using CsvHelper.Configuration;
using Elabor8Challenge.CatFactsWeb.Models;

namespace Elabor8Challenge.CatFactsWeb.Configuration
{
    public class CsvClassMap : ClassMap<CatFactCsvModel>
    {
        public CsvClassMap()
        {
            Map(m => m.User).Name("user");
            Map(m => m.TotalVotes).Name("totalVotes");
        }
    }
}
