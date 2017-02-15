using CineClick.Dominio.EF.AgregadoDeProgramacao;
using System.Data.Entity.ModelConfiguration;

namespace CineClick.Infra.EF.Map
{
    public class ProgramacaoMap:EntityTypeConfiguration<Programacao>
    {
        public ProgramacaoMap()
        {
            HasKey(p => p.Id);

            HasMany(Programacao.SessaoExpresson)
                .WithRequired()
                .Map(x => x.MapKey("Programacao_id"));
                //.WillCascadeOnDelete();
                
            ToTable(@"Programacao");
        }
    }
}
