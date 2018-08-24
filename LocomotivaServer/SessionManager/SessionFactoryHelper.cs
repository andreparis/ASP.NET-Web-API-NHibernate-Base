using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using LocomotivaServer.Models;
using LocomotivaServer.Models.Mapping;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

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
                c.Mappings(m => m.FluentMappings.AddFromAssemblyOf<LocomotivaModel>())
                    .ExposeConfiguration(cfg => new SchemaExport(cfg).Execute(true, true, false));
                return c.BuildSessionFactory();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}