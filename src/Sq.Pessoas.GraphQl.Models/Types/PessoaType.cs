using GraphQL.Types;
using Sq.Pessoas.Models;

namespace Sq.Pessoas.GraphQl.Models.Types
{
    public class PessoaType : ObjectGraphType<Pessoa>
    {
        public PessoaType()
        {
            Name = "Pessoa";
            Description = "Um pessoa que faz parte de um sistema";
            Field(p => p.Id).Description("Identificador único");
            Field(p => p.Nome).Description("Nome informado");
            Field(p => p.DataNascimento).Description("Data de nascimento informada");
            Field(p => p.Regiao).Description("Região informada");
            Field(p => p.Pontuacao).Description("Pontuacao total");
        }
    }
}