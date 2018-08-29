using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using LocomotivaServer.SessionManager;
using NHibernate;
using NHibernate.Context;

namespace LocomotivaServer
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private ISessionFactory SessionFactory = SessionManager.SessionManager.SessionFactory;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var session = SessionFactory.OpenSession();
            CurrentSessionContext.Bind(session);
            session.BeginTransaction();
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            var session = SessionFactory.GetCurrentSession();
            var transaction = session.Transaction;
            if (transaction == null || !transaction.IsActive)
                return;
            try
            {
                transaction.Commit();
            }
            catch (Exception err)
            {
                if (transaction != null) transaction.Rollback();
                throw err;
            }
            finally
            {
                session = CurrentSessionContext.Unbind(SessionFactory);
                session.Close();
            }            
        }
    }
}
