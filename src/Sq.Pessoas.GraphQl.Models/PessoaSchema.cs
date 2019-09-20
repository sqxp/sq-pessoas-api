using GraphQL;
using GraphQL.Types;
using Sq.Pessoas.GraphQl.Models.Queries;

namespace Sq.Pessoas.GraphQl.Models
{
    public class PessoaSchema : Schema
    {
        public PessoaSchema(IDependencyResolver dependencyResolver)
            : base(dependencyResolver)
        {
            Query = dependencyResolver.Resolve<PessoaQuery>();
        }
    }
}