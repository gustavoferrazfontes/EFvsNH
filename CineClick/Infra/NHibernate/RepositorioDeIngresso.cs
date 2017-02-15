using CineClick.Dominio.NHibernate.AgregadoDeIngresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineClick.Infra.NHibernate
{
    public class RepositorioDeIngresso : RepositorioBase<Ingresso>
    {
        public void Salvar(Ingresso novoIngresso)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.Save(novoIngresso);

                tran.Commit();
            }
        }

        public void Editar(Ingresso ingresso)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.Update(ingresso);

                tran.Commit();
            }

        }

        public void Excluir(Ingresso ingresso)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.Delete(ingresso);

                tran.Commit();
            }

        }
    }
}
