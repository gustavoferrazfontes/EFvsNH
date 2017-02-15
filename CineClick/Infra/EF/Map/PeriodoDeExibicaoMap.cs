using CineClick.Dominio.EF;
using System.Data.Entity.ModelConfiguration;

namespace CineClick.Infra.EF.Map
{
    public class PeriodoDeExibicaoMap:ComplexTypeConfiguration<PeriodoDeExibicao>
    {
        public PeriodoDeExibicaoMap()
        {
            Property(e => e.Inicio)
                .HasColumnName("Inicio")
                .HasColumnType("datetime"); 

            Property(e => e.Fim)
                .HasColumnName("Fim")
                .HasColumnType("datetime");
        }
    }
}
