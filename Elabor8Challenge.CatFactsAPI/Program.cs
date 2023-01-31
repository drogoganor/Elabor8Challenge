using AutoMapper;
using Elabor8Challenge.CatFactsAPI;
using Elabor8Challenge.CatFactsAPI.DTOs;
using Elabor8Challenge.CatFactsAPI.Mapping;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>();
builder.Services.AddAutoMapper(typeof(CatFactsProfile));

var app = builder.Build();

app.MapGet("/facts", async (DataContext db, IMapper map) =>
{
    return new AllCatFactsDto
    {
        All = (await db.CatFacts
            .Include(x => x.User).ThenInclude(x => x.Name)
            .AsNoTracking()
            .Select(x => map.Map<CatFactSummaryDto>(x))
            .ToArrayAsync())
    };
});

app.MapGet("/facts/{id}", async (string id, DataContext db, IMapper map) =>
{
    return map.Map<CatFactDetailDto>(await db.CatFacts
            .Include(x => x.User)
            .AsNoTracking()
            .FirstAsync(x => x.Id == id));
});

app.Run();
