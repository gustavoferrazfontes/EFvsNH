using CineClick.Dominio.NHibernate.AgregadoDeProgramacao;
using FluentNHibernate;
using FluentNHibernate.Mapping;

namespace CineClick.Infra.NHibernate.Maps
{
    public class ProgramacaoMap : ClassMap<Programacao>
    {
        public ProgramacaoMap()
        {

            Id(p => p.Id);

            Component(p => p.Exibicao, e =>
             {
                 e.Map(pe => pe.Inicio);
                 e.Map(pe => pe.Fim);

             });

           

            HasMany<Sessao>(Reveal.Member<Programacao>("Sessoes"))
                .KeyColumns
                .Add("ProgramacaoId")
               .Access.CamelCaseField(Prefix.Underscore)
               .Cascade.AllDeleteOrphan()
               .Cascade.SaveUpdate();


            Table("Programacao");
        }
    }
}
