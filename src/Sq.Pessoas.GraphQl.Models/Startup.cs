using GraphQL.Types;
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
            services.TryAddSingleton<PessoaQuery>();
            services.TryAddSingleton<PessoaType>();
            services.TryAddSingleton<ISchema, PessoaSchema>();
        }
    }
}