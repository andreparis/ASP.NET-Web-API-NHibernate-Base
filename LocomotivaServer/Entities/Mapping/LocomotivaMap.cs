using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Entities.Mapping
{
    /// <summary>
    /// Classe para mapear no NHibernate Locomotiva classe e Locomotiva tabela.
    /// </summary>
    public class LocomotivaMap : ClassMapBase<Locomotiva>
    {
        public LocomotivaMap()
        {
            Table("LOCOMOTIVA");
            Map(x => x.Name);
            Map(x => x.DeployTimeStamp).Nullable();
            Map(x => x.DeployVersion).Nullable();
            Map(x => x.DeviceKey);
            Map(x => x.GPS.Addr).Nullable();
            Map(x => x.GPS.Monitor).Nullable();
            Map(x => x.GPS.OpcTagMonitor).Nullable();
            Map(x => x.GPS.PoolingTime).Nullable();
            Map(x => x.GPS.Port).Nullable();
            Map(x => x.HubProtocol).Nullable();
            Map(x => x.HubUri);
            Map(x => x.LogDir).Nullable();
            Map(x => x.LogLevel).Nullable();
            Map(x => x.MonX).Nullable();
        }
    }
}