using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;

namespace cat.itb.M6UF2EA3.connections
{
    public class SessionFactoryCloud

    {
        private static string ConnectionString = "Server=ella.db.elephantsql.com;Port=5432;Database=vohtpoqn;User Id=vohtpoqn;Password=z-Kxpge1zI6GmtmKt1JJfGPLnoubMuzZBM;";
        private static ISessionFactory session;

        public static ISessionFactory CreateSession<T>()
        {
            if (session != null)
                return session;

            IPersistenceConfigurer configDB = PostgreSQLConfiguration.PostgreSQL82.ConnectionString(ConnectionString);
            var configMap =
                Fluently.Configure().Database(configDB).Mappings(
                    c => c.FluentMappings.AddFromAssemblyOf<T>());

            session = configMap.BuildSessionFactory();

            return session;
        }

        public static ISession Open<T>()
        {
            return CreateSession<T>().OpenSession();
        }
    }
}
