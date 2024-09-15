using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using _1.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var company = new Company
    {
        Name = "Tech Innovators",
        Address = "123 Innovation Way",
        EmployeesCount = 250,
        Industry = "Software Development"
    };

    return Results.Json(company);
});

app.MapGet("/random", () =>
{
    var random = new Random();
    int randomNumber = random.Next(0, 101);
    return Results.Json(new { RandomNumber = randomNumber });
});

app.Run();
