using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernateDemo.School.Models;
using NUnit.Framework;

namespace NHibernateDemo.TestCases
{
    [TestFixture]
    public class AutoMappingTest
    {
        private ISessionFactory _sessionFactory;

        protected ISessionFactory SessionFactory
        {
            get
            {
                return _sessionFactory ?? (_sessionFactory = Fluently
                    .Configure()
                    .Database(SetDatabase)
                    .Mappings(SetMappings)
                    .ExposeConfiguration(BuildSchema)
                    .BuildSessionFactory());
            }
        }

        private static void BuildSchema(Configuration cfg)
        {
            var schema = new SchemaExport(cfg);
            schema.SetOutputFile("AutoMap.sql");
            schema.Create(true, true);
        }

        private static IPersistenceConfigurer SetDatabase()
        {
            return MsSqlConfiguration.MsSql2008.ShowSql()
                .ConnectionString(b =>
                {
                    b.Database("Test2");
                    b.Server(@"WIN-71BO1P05S08\SQLEXPRESS");
                    b.TrustedConnection();
                }).AdoNetBatchSize(0);
        }

        private static void SetMappings(MappingConfiguration cfg)
        {
            cfg.AutoMappings.Add(AutoMap.AssemblyOf<Class>);
            cfg.AutoMappings.Add(AutoMap.AssemblyOf<Student>);
        }

    }
}