using CineClick.Dominio.EF.AgregadoDeProgramacao;
using CineClick.Infra.EF.Map;
using System.Data.Entity;
using System.Linq;

namespace CineClick.Infra.EF
{
    public class ContextoCineClick : DbContext
    {
        public ContextoCineClick() :
             base(@"Server=.\; Database=CineClick; Integrated Security=SSPI;")
        {
           
        }


        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ProgramacaoMap());
            modelBuilder.Configurations.Add(new SessaoMap());
            modelBuilder.Configurations.Add(new SalaMap());
            modelBuilder.Configurations.Add(new PeriodoDeExibicaoMap());
        }

        public DbSet<Programacao> Programacoes { get; set; }

        public DbSet<Sala> Salas { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
    }
}
