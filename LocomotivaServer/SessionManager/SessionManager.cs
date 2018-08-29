using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using LocomotivaServer.Models;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.SessionManager
{
    public class SessionManager
    {
        private readonly ISessionFactory sessionFactory;
        public static ISessionFactory SessionFactory
        {
            get { return Instance.sessionFactory; }
        }

        private ISessionFactory GetSessionFactory()
        {
            return sessionFactory;
        }

        public static SessionManager Instance
        {
            get
            {
                return NestedSessionManager.sessionManager;
            }
        }

        public static ISession OpenSession()
        {
            return Instance.GetSessionFactory().OpenSession();
        }

        public static void CloseSession()
        {
            Instance.GetSessionFactory().Close();
        }

        public static ISession CurrentSession
        {
            get
            {
                return Instance.GetSessionFactory().GetCurrentSession();
            }
        }

        private SessionManager()
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
                c.ExposeConfiguration(cfg =>
                {
                    new SchemaUpdate(cfg).Execute(true, true);
                    cfg.SetProperty("current_session_context_class", "web");
                });
                sessionFactory = c.BuildSessionFactory();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        class NestedSessionManager
        {
            internal static readonly SessionManager sessionManager =
                new SessionManager();
        }
    }
}