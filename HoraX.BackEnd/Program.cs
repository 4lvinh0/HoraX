using Microsoft.EntityFrameworkCore;
using HoraX.BackEnd.Data;




var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options 
    => options.UseInMemoryDatabase("Banco para testes"));


var app = builder.Build();





app.MapGet("/", () => "Hello World!");

app.Run();
