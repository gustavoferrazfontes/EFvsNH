using CineClick.Dominio.NHibernate.AgregadoDeProgramacao;
using FluentNHibernate.Mapping;
using System;

namespace CineClick.Infra.NHibernate.Maps
{
    public class SessaoMap : ClassMap<Sessao>
    {
        public SessaoMap() : base()
        {
            Id(s => s.Id).GeneratedBy.Assigned().UnsavedValue(Guid.Empty);

            Map(s => s.FilmeId);
            Map(s => s.SalaId);
            Map(s => s.Data);
            Map(s => s.Disponivel);
            Map(s => s.IngressosVendidos).Column("VendasRealizadas");

            

        }
    }
}
