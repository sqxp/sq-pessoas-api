using System.Collections.Generic;
using System.Threading.Tasks;
using Sq.Pessoas.Models;

namespace Sq.Pessoas.Services.Abstractions
{
    public interface IPessoaReadService
    {
        Task<List<Pessoa>> ListPessoasAsync();
    }
}