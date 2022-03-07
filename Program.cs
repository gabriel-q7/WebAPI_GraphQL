using Microsoft.EntityFrameworkCore;
using WebAPI_GraphQL_sln.src.Database;
using WebAPI_GraphQL_sln.src.Database.Repositories;
using WebAPI_GraphQL_sln.src.BusinessRules.Validators;
using WebAPI_GraphQL_sln.src.BusinessRules.Handlers;
using WebAPI_GraphQL_sln.src.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDbContext<TodoContext>(option => option.UseInMemoryDatabase("TodoDatabase"));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    ;

builder.Services
    //Validators
    .AddScoped<ITaskValidator, TaskValidator>()
    
    //Repositories
    .AddScoped<ITaskRepository, TaskRepository>()
    
    //Business rules
    .AddScoped<IUpsertTaskHandler,UpsertTaskHandler>()
    ;

//app.MapGet("/", () => "Hello World!");

var app = builder.Build();

app.MapGraphQL();

app.Run();
