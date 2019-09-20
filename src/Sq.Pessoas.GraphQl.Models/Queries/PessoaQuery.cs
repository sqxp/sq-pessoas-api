using GraphQL.Types;
using Sq.Pessoas.GraphQl.Models.Types;
using Sq.Pessoas.Services.Abstractions;

namespace Sq.Pessoas.GraphQl.Models.Queries
{
    public class PessoaQuery : ObjectGraphType<object>
    {
        public PessoaQuery(IPessoaReadService service)
        {
            Name = "Query";
            Field<ListGraphType<PessoaType>>(
                "Pessoas",
                resolve: context => service.ListPessoasAsync()
            );
        }
    }
}