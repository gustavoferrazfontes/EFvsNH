using CineClick.Dominio.NHibernate.AgregadoDeIngresso;
using FluentNHibernate.Mapping;

namespace CineClick.Infra.NHibernate.Maps
{
    public class IngressoMap : ClassMap<Ingresso>
    {
        public IngressoMap() : base()
        {
            Id(i => i.Id);

            Map(i => i.Tipo).CustomType<TipoDoIngresso>();

            Map(i => i.SessaoId);

            Component(i => i.Preco, p =>
            {
                p.Map(v => v.Valor);
            });

            Table("Ingresso");
        }
    }
}
