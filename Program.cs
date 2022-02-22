using Microsoft.EntityFrameworkCore;
using src.Database;
using src.Database.Repositories;
using src.BusinessRules.Validators;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDbContext<TodoContext>(option => option.UseInMemoryDatabase("TodoDatabase"));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

builder.Services
    //Validators
    .AddScoped<ITaskValidator, TaskValidator>()
    //Repositories
    .AddScoped<ITaskRepository, TaskRepository>();

//app.MapGet("/", () => "Hello World!");

var app = builder.Build();

app.MapGraphQL();

app.Run();
