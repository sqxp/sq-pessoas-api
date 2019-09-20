using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Sq.Pessoas.Services.Abstractions;

namespace Sq.Pessoas.Services
{
    public static class Startup
    {
        public static void AddPessoaService(this IServiceCollection services)
        {
            services.TryAddSingleton<IPessoaReadService, PessoaReadService>();
        }
    }
}