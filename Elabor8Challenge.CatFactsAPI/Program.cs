using Elabor8Challenge.CatFactsAPI;
using Elabor8Challenge.CatFactsAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<CatFactsService>();

var app = builder.Build();

app.MapGet("/", async (DataContext db) =>
    await db.CatFacts.ToListAsync());

app.Run();
