using CineClick.SharedKernel;
using System;

namespace CineClick.Dominio.NHibernate.AgregadoDeProgramacao
{
    public class Sessao : Entidade
    {
        public virtual Guid FilmeId { get; }
        public virtual Guid SalaId { get; }

        public virtual  DateTime Data { get; }

        public virtual int IngressosVendidos { get; protected set; }
        public virtual bool Disponivel { get; protected set; }

        
        protected Sessao()
        {

        }

        public Sessao(Guid salaId,Guid filmeId, DateTime dataDaSessao, bool disponivel)
        {
            Id = Guid.NewGuid();
            FilmeId = filmeId;
            SalaId = salaId;
            Data = dataDaSessao;
            Disponivel = disponivel;
            IngressosVendidos = 0;
           
        }
    }
}
