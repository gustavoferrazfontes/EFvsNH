using System;
using CineClick.Dominio.NHibernate.AgregadoDeProgramacao;

namespace CineClick.Infra.NHibernate
{
    public class RepositorioDeProgramacao : RepositorioBase<Programacao>
    {

        public void Salvar(Programacao novaProgramacao)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.Save(novaProgramacao);
                _session.Flush();
                tran.Commit();
            }
        }   

        public void Editar(Programacao programacao)
        {
            using (var tran = _session.BeginTransaction())
            {
                
                _session.Update(programacao);
                tran.Commit();
            }

        }

        public void Excluir(Programacao programacao)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.Delete(programacao);

                tran.Commit();
            }

        }
                                             
    }
}
