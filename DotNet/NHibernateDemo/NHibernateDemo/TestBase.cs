using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace NHibernateDemo
{
    public abstract class TestBase
    {
        private ISessionFactory _sessionFactory;

        protected ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var cfg = MsSqlConfiguration.MsSql2008.ShowSql()
                        .ConnectionString(b =>
                        {
                            b.Database("Test1");
                            b.Server(@"WIN-71BO1P05S08\SQLEXPRESS");
                            b.TrustedConnection();
                        }).AdoNetBatchSize(0);
                    _sessionFactory = Fluently.Configure().Database(cfg)
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<TestBase>())
                        .ExposeConfiguration(BuildSchema)
                        .BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        private static void BuildSchema(Configuration config)
        {
            var schema = new SchemaExport(config);
            schema.SetOutputFile("script.sql");
            //schema.Drop(true, true);
            //schema.Create(true, true);
            schema.Create(true, true);
            //var update = new NHibernate.Tool.hbm2ddl.SchemaUpdate(config);
            //update.Execute(false, true);
        }

        protected ISession Session { get; private set; }

        protected ITransaction Transaction { get; private set; }

        protected TestBase()
        {
            Session = SessionFactory.OpenSession();
            Transaction = Session.BeginTransaction();
        }

    }
}