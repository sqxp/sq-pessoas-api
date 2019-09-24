using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sq.Pessoas.Api.Extensions;
using Sq.Pessoas.GraphQl.Models;
using Sq.Pessoas.Services;

namespace Sq.Pessoas.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSynchronousIO();
            services.AddPessoaService();
            services.AddPessoaGraphQl();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) 
                app.UseDeveloperExceptionPage();
            
            app.UsePessoaGraphQl("/graphql", "/ui/playground");
        }
    }
}