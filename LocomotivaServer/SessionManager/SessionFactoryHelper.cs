using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using LocomotivaServer.Entities;
using LocomotivaServer.Entities.Mapping;
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
            var sac = new StoreAutomappingConfiguration();
            var c = Fluently.Configure();
            try
            {
                c.Database(OracleDataClientConfiguration.Oracle10.
                    ConnectionString(cstring));
                c.Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<Locomotiva>()
                    .Where(x => x.GetType() == typeof(Locomotiva))
                    .IgnoreBase<EntityBase>()
                    .Conventions.Setup(s =>
                    {
                        s.Add<CustomPrimaryKeyConvention>();
                        s.Add<DefaultStringLengthConvention>();
                    }))
                    .ExportTo(@"C:\Users\VM-LOCOMOTIVAS\Desktop\Projetos\Locomotiva-Web"));
                //c.Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<Tag>(sac)
                //    .Conventions.Setup(s =>
                //    {
                //        s.Add<CustomPrimaryKeyConvention>();
                //        s.Add<DefaultStringLengthConvention>();
                //    })));
                //c.Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<LocomotivaTag>(sac)
                //    .Conventions.Setup(s =>
                //    {
                //        s.Add<CustomPrimaryKeyConvention>();
                //        s.Add<CustomForeignKeyConvention>();
                //        s.Add<DefaultStringLengthConvention>();
                //    })));
                //c.Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<Entities.System>(sac)
                //    .Conventions.Setup(s =>
                //    {
                //        s.Add<CustomPrimaryKeyConvention>();
                //        s.Add<DefaultStringLengthConvention>();
                //    })));
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