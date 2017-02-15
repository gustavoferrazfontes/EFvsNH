using CineClick.SharedKernel;
using System;

namespace CineClick.Dominio.NHibernate
{
    public class Filme : RaizDeAgregado
    {

        public virtual string Nome { get; protected set; }
        public virtual string Sinopse { get; protected set; }

        public virtual DateTime CadastradoEm { get; protected set; }

        public virtual PeriodoDeExibicao PeriodoDeExebicao { get; protected set; }
        public virtual NivelDeClassificacao Classificacao { get; protected set; }

        protected Filme()
        {

        }


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