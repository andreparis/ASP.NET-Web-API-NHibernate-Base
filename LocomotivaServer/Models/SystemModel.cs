using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models
{
    public class SystemModel : EntityBase
    {        
        #region Atributos
        public virtual string HubConnectionString { get; set; }
        public virtual string HubConsumerGroup { get; set; }
        public virtual bool HubHttpProxyEnabled { get; set; }
        public virtual string HubHttpProxyAddress { get; set; }
        public virtual string IoTHubProtocol { get; set; }
        public virtual List<String> Families { get; set; }
        public virtual string Monx { get; set; }
        public virtual string LogDir { get; set; }
        /// <summary>
        /// LogLevel na locomotiva.
        /// </summary>
        public virtual int LogLevel { get; set; }
        #endregion

        public SystemModel() { }

        public SystemModel(string hubConnectionString, string hubConsumerGroup, 
            bool hubHttpProxyEnabled, string hubHttpProxyAddress, string ioTHubProtocol, List<string> families,
            string logDir, int logLevel)
        {
            HubConnectionString = hubConnectionString;
            HubConsumerGroup = hubConsumerGroup;
            HubHttpProxyEnabled = hubHttpProxyEnabled;
            HubHttpProxyAddress = hubHttpProxyAddress;
            IoTHubProtocol = ioTHubProtocol;
            Families = families;
            LogDir = logDir;
            LogLevel = logLevel;
        }
    }
}