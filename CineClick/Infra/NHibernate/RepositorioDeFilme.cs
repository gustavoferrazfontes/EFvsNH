using CineClick.Dominio.NHibernate;

namespace CineClick.Infra.NHibernate
{
    public class RepositorioDeFilme : RepositorioBase<Filme>
    {
       
        public void Salvar(Filme novoFilme)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.Save(novoFilme);

                tran.Commit();
            }
        }

        public void Editar(Filme filme)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.Update(filme);

                tran.Commit();
            }

        }

        public void Excluir(Filme filme)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.Delete(filme);

                tran.Commit();
            }

        }

    }
}
