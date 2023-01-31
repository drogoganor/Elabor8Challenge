using CsvHelper;
using CsvHelper.Configuration;
using Elabor8Challenge.CatFactsWeb.Configuration;
using Elabor8Challenge.CatFactsWeb.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Globalization;
using System.IO;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient("CatFacts", httpClient =>
{
    httpClient.BaseAddress = new Uri("https://localhost:7158/");
});

builder.Services.AddScoped<CatFactsService>();

var app = builder.Build();

app.MapGet("/", async (CatFactsService service) =>
{
    var catFacts = await service.GetCatFactsCsv();

    var memoryStream = new MemoryStream();
    var streamWriter = new StreamWriter(memoryStream);
    using (var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
    {
        csv.Context.RegisterClassMap<CsvClassMap>();
        csv.WriteRecords(catFacts);
    }

    return Results.File(memoryStream.ToArray(), "text/csv", "CatFacts.csv");
});

app.Run();
