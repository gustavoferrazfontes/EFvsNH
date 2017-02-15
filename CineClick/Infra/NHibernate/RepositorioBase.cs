using CineClick.Infra.NHibernate.Maps;
using CineClick.SharedKernel;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;

namespace CineClick.Infra.NHibernate
{
    public class RepositorioBase<T> where T : RaizDeAgregado
    {

        protected readonly ISessionFactory _sessionFactory;
        protected readonly ISession _session;

        public RepositorioBase()
        {
            _sessionFactory = Init();

            _session = _sessionFactory.OpenSession();

        }

        public T ObterPor(Guid id)
        {
            return _session.Load<T>(id);
        }

        private ISessionFactory Init()
        {
            return Fluently.Configure()
               .Database(MsSqlConfiguration.MsSql2012.ShowSql()
                           .ConnectionString(@"Server=.\; Database=CineClick; Integrated Security=SSPI;"))
               .Mappings(m =>
               {
                   m.FluentMappings.Add<FilmeMap>();
                   m.FluentMappings.Add<SessaoMap>();
                   m.FluentMappings.Add<IngressoMap>();
                   m.FluentMappings.Add<SalaMap>();
                   m.FluentMappings.Add<ProgramacaoMap>();

               })

               .BuildConfiguration()
               .BuildSessionFactory();
        }



    }
}
