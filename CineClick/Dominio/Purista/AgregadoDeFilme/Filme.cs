using CineClick.SharedKernel;
using System;

namespace CineClick.Dominio.Puro
{
    public sealed class Filme : RaizDeAgregado
    {

        public  string Nome { get; private set; }
        public  string Sinopse { get; private set; }

        public  DateTime CadastradoEm { get; private set; }

        public  PeriodoDeExibicao PeriodoDeExebicao { get; private set; }
        public  NivelDeClassificacao Classificacao { get; private set; }

  

        public Filme(string nome, string sinopse, PeriodoDeExibicao periodoDeExibicao, NivelDeClassificacao classificacao)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Sinopse = sinopse;
            PeriodoDeExebicao = periodoDeExibicao;
            Classificacao = classificacao;
            CadastradoEm = DateTime.Now;
        }
    }
}