using System;
using CineClick.Dominio.EF.AgregadoDeProgramacao;
using System.Linq;

namespace CineClick.Infra.EF
{
    public class RepositorioDeProgramacao
    {
        private readonly ContextoCineClick _conexao;

        public RepositorioDeProgramacao()
        {
            _conexao = new ContextoCineClick();
        }

        public void Criar(Programacao programacao)
        {
            _conexao.Programacoes.Add(programacao);
            _conexao.SaveChanges();
        }

        public Programacao ObterPor(Guid programacaoId)
        {
            return _conexao
                .Programacoes
                .Include("_Sessoes")
                .FirstOrDefault(p => p.Id == programacaoId);
        }

        public void Editar(Programacao programacao)
        {   
            _conexao.Entry<Programacao>(programacao).State = System.Data.Entity.EntityState.Modified;
            _conexao.SaveChanges();
        }

       
    }
}
