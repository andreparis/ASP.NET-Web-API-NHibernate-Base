using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models.Mapping
{
    public class SystemMap : ClassMapBase<SystemModel>
    {
        public SystemMap()
        {
            Table("SYSTEM_VARIABLES");
            Map(x=> x.Name).Nullable().Length(250);
            Map(x => x.PimsServers).Nullable().Length(250).Column("Pims_Servers");
            Map(x => x.Families).Nullable().Length(250);
            Map(x => x.HubConnectionString).Nullable().Length(250).Column("Hub_Connection_String");
            Map(x => x.HubConsumerGroup).Nullable().Length(250).Column("Hub_Consumer_Group");
            Map(x => x.HubHttpProxyAddress).Nullable().Length(250).Column("Hub_Http_Proxy_Address");
            Map(x => x.HubHttpProxyEnabled).Nullable().Column("Hub_Http_Proxy_Enabled");
            Map(x => x.IoTHubProtocol).Nullable().Length(250).Column("IoT_Hub_Protocol");
        }
    }
}