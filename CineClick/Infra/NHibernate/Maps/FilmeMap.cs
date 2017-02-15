using CineClick.Dominio.NHibernate;
using FluentNHibernate.Mapping;
using System;

namespace CineClick.Infra.NHibernate.Maps
{
    public class FilmeMap : ClassMap<Filme>
    {
        public FilmeMap() :base()
        {
            Id(f => f.Id);

            Map(f => f.Nome);
            Map(f => f.Sinopse);
            Map(f => f.CadastradoEm);

            Component(f => f.PeriodoDeExebicao, pe => {
                pe.Map(p => p.Inicio).Column("InicioDoPeriodo");
                pe.Map(p => p.Fim).Column("FimDoPeriodo");
            });

            Component(c => c.Classificacao, nc =>
             {
                 nc.Map(n => n.Nivel).Column("NivelDeClassificacao");
             });

            Table("Filme");
        }
    }
}
