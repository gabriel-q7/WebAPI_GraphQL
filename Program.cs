var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

//app.MapGet("/", () => "Hello World!");

var app = builder.Build();

app.MapGraphQL();

app.Run();
