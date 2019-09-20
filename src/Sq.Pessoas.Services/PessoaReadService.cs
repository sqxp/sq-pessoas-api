using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Sq.Pessoas.Models;
using Sq.Pessoas.Services.Abstractions;

namespace Sq.Pessoas.Services
{
    public class PessoaReadService : IPessoaReadService
    {
        private static IEnumerable<Pessoa> ReadFile()
        {
            var location = System.Reflection.Assembly.GetEntryAssembly()?.Location;
            var filePath = Path.Combine(Path.GetDirectoryName(location), "data");
            var file = File.ReadAllLines(filePath);
            foreach (var line in file)
            {
                var data = line.Split(';');
                if (data.Length != 5) continue;
                yield return new Pessoa
                {
                    Id = data[0],
                    Nome = data[1],
                    DataNascimento = DateTime.Parse(data[2]),
                    Regiao = data[3],
                    Pontuacao = long.Parse(data[4])
                };
            }
        }

        public Task<List<Pessoa>> ListPessoasAsync() =>
            Task.Run(() => ReadFile().ToList());
    }
}