using System;

namespace Sq.Pessoas.Models
{
    public class Pessoa
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Regiao { get; set; }
        public long Pontuacao { get; set; }
    }
}