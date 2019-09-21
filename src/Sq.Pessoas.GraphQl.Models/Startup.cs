using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Sq.Pessoas.GraphQl.Models.Queries;
using Sq.Pessoas.GraphQl.Models.Types;

namespace Sq.Pessoas.GraphQl.Models
{
    public static class Startup
    {
        public static void AddPessoaGraphQl(this IServiceCollection services)
        {
            services.AddSingleton<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.TryAddSingleton<PessoaQuery>();
            services.TryAddSingleton<PessoaType>();
            services.TryAddSingleton<ISchema, PessoaSchema>();
            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
                options.ExposeExceptions = true;
            });
        }

        public static void UsePessoaGraphQl(this IApplicationBuilder app, string graphQlEndpoint, string graphQlPlaygroundEndpoint)
        {
            app.UseGraphQL<ISchema>(graphQlEndpoint);
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions
            {
                Path = graphQlPlaygroundEndpoint,
                GraphQLEndPoint = graphQlEndpoint
            });            
        }
    }
}