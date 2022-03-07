using Microsoft.EntityFrameworkCore;
using WebAPI_GraphQL_sln.src.Database;
using WebAPI_GraphQL_sln.src.Database.Repositories;
using WebAPI_GraphQL_sln.src.BusinessRules.Validators;

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
