using Elabor8Challenge.CatFactsAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elabor8Challenge.CatFactsAPI.Services
{
    public class CatFactsService
    {
        private readonly DataContext context;

        public CatFactsService(DataContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<CatFact>> GetAllCatFacts()
        {
            return context.CatFacts.AsNoTracking();
        }
    }
}
