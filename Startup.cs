using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ToDoApi.src.Api;
using ToDoApi.src.BusinessRules.Handlers;
using ToDoApi.src.BusinessRules.Validators;
using ToDoApi.src.Database;
using ToDoApi.src.Database.Repositories;

namespace ToDoApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddDbContext<TodoContext>(option => option.UseInMemoryDatabase("TodoDatabase"));

            services
                .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                ;

            services
                //Validators
                .AddScoped<ITaskValidator, TaskValidator>()
                
                //Repositories
                .AddScoped<ITaskRepository, TaskRepository>()
                
                //Business rules
                .AddScoped<IUpsertTaskHandler,UpsertTaskHandler>()
                .AddScoped<IGetAllTasksHandler, GetAllTasksHandler>()
                .AddScoped<IGetByIdTaskHandler, GetByIdTaskHandler>()
                ;
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });

        }
    }
}
