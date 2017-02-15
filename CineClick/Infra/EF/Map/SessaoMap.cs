using CineClick.Dominio.EF.AgregadoDeProgramacao;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CineClick.Infra.EF.Map
{
    public class SessaoMap:EntityTypeConfiguration<Sessao>
    {
        public SessaoMap()
        {
            //HasKey(s => new { s.Id, s.ProgramacaoId });
            HasKey(s => s.Id);

            Property(s => s.IngressosVendidos)
                .HasColumnName("VendasRealizadas")
                .HasColumnType("int");

            Property(s => s.Disponivel).HasColumnType("bit");
            Property(s => s.Data);
           

            ToTable("Sessao");
        }

    }
}
