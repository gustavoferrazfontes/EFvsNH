using CineClick.Dominio.NHibernate.AgregadoDeSala;
using FluentNHibernate.Mapping;
using System;

namespace CineClick.Infra.NHibernate.Maps
{
    public class SalaMap : ClassMap<Sala>
    {

        public SalaMap() : base()
        {
            Id(s => s.Id)
                .GeneratedBy.Assigned()
                .UnsavedValue(Guid.Empty);

            Map(s => s.Capacidade);
            Map(s => s.Descricao);

            Table("Sala");


        }
    }
}
