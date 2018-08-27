using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Entities
{
    public class System : EntityBase
    {
        public virtual string Name { get; set; }
        public virtual string HubConnectionString { get; set; }
        public virtual string HubConsumerGroup { get; set; }
        public virtual bool HubHttpProxyEnabled { get; set; }
        public virtual string HubHttpProxyAddress { get; set; }
        public virtual string IoTHubProtocol { get; set; }
        public virtual List<String> PimsServers { get; set; }
        public virtual List<String> Families { get; set; }

    }
}