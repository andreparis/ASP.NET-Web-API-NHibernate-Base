using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using LocomotivaServer.Models;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
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
            var c = Fluently.Configure();
            try
            {
                c.Database(OracleDataClientConfiguration.Oracle10.
                    ConnectionString(x =>
                    x.FromAppSetting("OracleConnectionString")));
                c.Mappings(m => m.FluentMappings.AddFromAssemblyOf<LocomotivaModel>());
            }
            catch (Exception ex)
            {
                throw;
            }
            return c.BuildSessionFactory();

        }
    }
}