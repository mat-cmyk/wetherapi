using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddHttpClient();



var app = builder.Build();







app.MapGet("/", () => "Hello TODO!");





app.MapGet("/externaldata", async (IHttpClientFactory httpClientFactory) =>
{
    var client = httpClientFactory.CreateClient();
    var response = await client.GetFromJsonAsync<object>("https://historical-forecast-api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&start_date=2024-12-12&end_date=2024-12-25&daily=temperature_2m_max");
    return response is not null ? Results.Ok(response) : Results.StatusCode(500);
});

app.Run();