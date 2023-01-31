using Elabor8Challenge.CatFactsWeb.DTOs;
using Elabor8Challenge.CatFactsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Elabor8Challenge.CatFactsWeb.Services
{
    public class CatFactsService
    {
        private readonly HttpClient httpClient;

        public CatFactsService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.httpClient.BaseAddress = new Uri("https://localhost:7158/");
        }

        private async Task<AllCatFactsDto> GetCatFactsSummary() =>
            await httpClient.GetFromJsonAsync<AllCatFactsDto>("/facts");

        private async Task<CatFactDetailDto> GetCatFactDetail(string id) =>
            await httpClient.GetFromJsonAsync<CatFactDetailDto>($"/facts/{id}");

        public async Task<IEnumerable<CatFactCsvModel>> GetCatFactsCsv()
        {
            var catFactsSummary = await GetCatFactsSummary();
            return from fact in catFactsSummary.All
                   group fact by fact.User.Id into grouped
                   let groupUser = grouped.First().User.Name
                   select new CatFactCsvModel
                   {
                       User = $"{groupUser.First} {groupUser.Last}",
                       TotalVotes = grouped.Sum(x => x.Upvotes)
                   } into summed orderby summed.TotalVotes descending
                   select summed;
        }
    }
}
