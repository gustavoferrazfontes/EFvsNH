using CineClick.Dominio.EF.AgregadoDeProgramacao;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CineClick.Infra.EF.Map
{
    public class SalaMap:EntityTypeConfiguration<Sala>
    {
        public SalaMap()
        {
            HasKey(s => s.Id);
   
       
            Property(s => s.Capacidade)
                .HasColumnType("int");

            Property(s => s.Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            ToTable("Sala");
        }
    }
}
