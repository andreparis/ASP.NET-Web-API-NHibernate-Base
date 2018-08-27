using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using LocomotivaServer.Models;
using LocomotivaServer.Models.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;

namespace LocomotivaServer.SessionManager
{
    /// <summary>
    /// Classe responsável por criar sessão de acesso ao NHibernate.
    /// </summary>
    public class SessionFactoryHelper
    {
        public static ISessionFactory CreateSessionFactory()
        {
            string cstring = Properties.Settings.Default.OracleConnectionString;
            var c = Fluently.Configure();
            try
            {
                c.Database(OracleDataClientConfiguration.Oracle10.
                    ConnectionString(cstring));
                c.Mappings(m => m.FluentMappings.AddFromAssemblyOf<LocomotivaModel>());
                c.Mappings(m => m.FluentMappings.AddFromAssemblyOf<SystemModel>());
                c.Mappings(m => m.FluentMappings.AddFromAssemblyOf<LocomotivaTagModel>());
                c.Mappings(m => m.FluentMappings.AddFromAssemblyOf<TagModel>());
                c.Mappings(m => m.FluentMappings.AddFromAssemblyOf<UserModel>());
                c.ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true));
                return c.BuildSessionFactory();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}