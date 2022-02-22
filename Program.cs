using Microsoft.EntityFrameworkCore;
using src.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

builder.Services
    .AddDbContext<TodoContext>(option => option.UseInMemoryDatabase("TodoDatabase"));

//app.MapGet("/", () => "Hello World!");

var app = builder.Build();

app.MapGraphQL();

app.Run();
