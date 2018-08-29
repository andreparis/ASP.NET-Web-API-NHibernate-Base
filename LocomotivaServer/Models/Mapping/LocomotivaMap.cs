using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models.Mapping
{
    /// <summary>
    /// Classe para mapear no NHibernate Locomotiva classe e Locomotiva tabela.
    /// </summary>
    public class LocomotivaMap : ClassMapBase<LocomotivaModel>
    {
        public LocomotivaMap()
        {
            Table("LOCOMOTIVA");
            Map(x => x.Name).Length(250);
            Map(x => x.DeployTimeStamp).Nullable().Length(250).Column("Deploy_Time_Stamp");
            Map(x => x.DeployVersion).Nullable().Length(250).Column("Deploy_Version");
            Map(x => x.DeviceKey).Length(250).Column("Device_Key");
            Map(x => x.Addr).Length(250).Nullable();
            Map(x => x.Monitor).Nullable();
            Map(x => x.OpcTagMonitor).Nullable().Length(250).Column("Opc_Tag_Monitor");
            Map(x => x.PoolingTime).Nullable().Column("Pooling_Time");
            Map(x => x.Port).Nullable();
            Map(x => x.HubProtocol).Nullable().Length(250).Column("Hub_Protocol");
            Map(x => x.HubUri).Length(250).Column("Hub_Uri");
            Map(x => x.LogDir).Nullable().Length(250).Column("Log_Dir");
            Map(x => x.LogLevel).Nullable().Column("Log_Level");
            Map(x => x.OpcNodeName).Nullable().Length(250).Column("Opc_Node_Name");
            Map(x => x.OpcServerName).Nullable().Length(250).Column("Opc_Server_Name");
        }
    }
}