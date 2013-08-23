using System;
using System.IO;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace NHibernateDemo.TestCases
{
    [TestFixture]
    public class SchemaExportTest
    {
        private const string SqlCeSqlName = "sqlce.sql";
        private const string SqlCeDatabaseName = "../../App_Data/NhTest.sdf";
        private const string SqliteDatabaseName = "NhTest.db";
        private const string MsSql2008SqlName = "mssql2008.sql";
        private const string SqliteFileSqlName = "sqliteFile.sql";
        private const string SqliteMemorySqlName = "SqliteMemory.sql";

        private IPersistenceConfigurer _sqlCeCfg;
        private IPersistenceConfigurer _msSql2008Cfg;
        private IPersistenceConfigurer _sqliteFileCfg;
        private IPersistenceConfigurer _sqliteMemoryCfg;

        private ISessionFactory _sqlCeSessionFactory;
        private ISessionFactory _msSql2008SessionFactory;
        private ISessionFactory _sqliteFileSessionFactory;
        private ISessionFactory _sqliteMemorySessionFactory;

        public IPersistenceConfigurer SqlCeCfg
        {
            get
            {
                if (_sqlCeCfg == null)
                {
                    _sqlCeCfg = MsSqlCeConfiguration.Standard
                        .ShowSql()
                        .FormatSql()
                        .ConnectionString("Data Source=" + SqlCeDatabaseName)
                        .AdoNetBatchSize(0);
                }
                return _sqlCeCfg;
            }
        }
        public IPersistenceConfigurer MsSql2008Cfg
        {
            get
            {
                if (_msSql2008Cfg == null)
                {
                    _msSql2008Cfg = MsSqlConfiguration.MsSql2008.ShowSql().FormatSql()
                        .ConnectionString(b =>
                        {
                            b.Database("Test1");
                            b.Server(@"WIN-71BO1P05S08\SQLEXPRESS");
                            b.TrustedConnection();
                        }).AdoNetBatchSize(0);
                }
                return _msSql2008Cfg;
            }
        }
        public IPersistenceConfigurer SqliteFileCfg
        {
            get
            {
                if (_sqliteFileCfg == null)
                {
                    _sqliteFileCfg = SQLiteConfiguration.Standard
                    .ShowSql()
                    .UsingFile(SqliteDatabaseName)
                    .AdoNetBatchSize(0);
                }
                return _sqliteFileCfg;
            }
        }
        public IPersistenceConfigurer SqliteMemoryCfg
        {
            get
            {
                if (_sqliteMemoryCfg == null)
                {
                    _sqliteMemoryCfg = SQLiteConfiguration.Standard.InMemory();
                }
                return _sqliteMemoryCfg;
            }
        }

        public ISessionFactory SqlCeSessionFactory
        {
            get
            {
                if (_sqlCeSessionFactory == null)
                {
                    _sqlCeSessionFactory = BuildSessionFactory(SqlCeCfg, SqlCeSqlName);
                }
                return _sqlCeSessionFactory;
            }
        }
        public ISessionFactory MsSql2008SessionFactory
        {
            get
            {
                if (_msSql2008SessionFactory == null)
                {
                    _msSql2008SessionFactory = BuildSessionFactory(MsSql2008Cfg, MsSql2008SqlName);
                }
                return _msSql2008SessionFactory;
            }
        }
        public ISessionFactory SqliteFileSessionFactory
        {
            get
            {
                if (_sqliteFileSessionFactory == null)
                {
                    _sqliteFileSessionFactory = BuildSessionFactory(SqliteFileCfg, SqliteFileSqlName);
                }
                return _sqliteFileSessionFactory;
            }
        }
        public ISessionFactory SqliteMemorySessionFactory
        {
            get
            {
                if (_sqliteMemorySessionFactory == null)
                {
                    _sqliteMemorySessionFactory = BuildSessionFactory(SqliteMemoryCfg, SqliteMemorySqlName);
                }
                return _sqliteMemorySessionFactory;
            }
        }

        [Test]
        public void SqlCe()
        {
            Assert.NotNull(SqlCeSessionFactory);
            Assert.NotNull(SqlCeSessionFactory.OpenSession());
        }

        [Test]
        public void MsSql2008()
        {
            Assert.NotNull(MsSql2008SessionFactory);
            Assert.NotNull(MsSql2008SessionFactory.OpenSession());
        }

        [Test]
        public void SqliteFile()
        {
            if (File.Exists(SqliteDatabaseName))
            {
                File.Delete(SqliteDatabaseName);
            }
            Assert.NotNull(SqliteFileSessionFactory);
            Assert.NotNull(SqliteFileSessionFactory.OpenSession());
        }

        [Test]
        public void SqliteMemory()
        {
            Assert.NotNull(SqliteMemorySessionFactory);
            Assert.NotNull(SqliteMemorySessionFactory.OpenSession());
        }

        private static ISessionFactory BuildSessionFactory(IPersistenceConfigurer cfg, string sqlFileName)
        {
            var sessionFactory = Fluently.Configure().Database(cfg)
                .Mappings(m =>
                {
                    m.FluentMappings.AddFromAssemblyOf<SchemaExportTest>();
                    m.FluentMappings.ExportTo(Console.Out);
                })
                .ExposeConfiguration(c =>
                {
                    var export = new SchemaExport(c);
                    export.SetOutputFile(sqlFileName);
                    export.Drop(false, true);
                    export.Create(true, true);
                }).BuildSessionFactory();
            Console.WriteLine(File.ReadAllText(sqlFileName));
            return sessionFactory;
        }
    }
}