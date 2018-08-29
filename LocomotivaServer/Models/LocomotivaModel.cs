using System;

namespace LocomotivaServer.Models
{
    /// <summary>
    /// Classe modelo das locomotivas.
    /// </summary>
    public class LocomotivaModel : EntityBase
    {
        #region Atributos
        /// <summary>
        /// Nome atribuído a locomotiva
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// Data do ultimo deploy
        /// </summary>
        public virtual string DeployTimeStamp { get; set; }
        /// <summary>
        /// Versão do software embarcado
        /// </summary>
        public virtual string DeployVersion { get; set; }
        /// <summary>
        /// Chave cadastrada no IoT Hub
        /// </summary>
        public virtual string DeviceKey { get; set; }
        public virtual string HubUri { get; set; }
        public virtual string HubProtocol { get; set; }
        /// <summary>
        /// Dados referentes ao GPS
        /// </summary>
        #region GPS
        public virtual string Type { get; set; }
        public virtual string Addr { get; set; }
        public virtual int Port { get; set; }
        public virtual int PoolingTime { get; set; }
        public virtual bool Monitor { get; set; }
        public virtual string OpcTagMonitor { get; set; }
        #endregion
        /// <summary>
        /// Diretoria de logs na locomotiva.
        /// </summary>
        public virtual string LogDir { get; set;}
        /// <summary>
        /// LogLevel na locomotiva.
        /// </summary>
        public virtual int LogLevel { get; set; }
        public virtual string OpcServerName { get; set; }
        public virtual string OpcNodeName { get; set; }

        #endregion

        public LocomotivaModel() { }

        public LocomotivaModel(string name, string deployTimeStamp, string deployVersion, 
            string deviceKey, string hubUri, string hubProtocol, string type, string addr, 
            int port, int poolingTime, bool monitor, string opcTagMonitor, string logDir, int logLevel,
            string opcServerName, string opcNodeName)
        {
            Name = name;
            DeployTimeStamp = deployTimeStamp;
            DeployVersion = deployVersion;
            DeviceKey = deviceKey;
            HubUri = hubUri;
            HubProtocol = hubProtocol;
            Type = type;
            Addr = addr;
            Port = port;
            PoolingTime = poolingTime;
            Monitor = monitor;
            OpcTagMonitor = opcTagMonitor;
            LogDir = logDir;
            LogLevel = logLevel;
            OpcServerName = opcServerName;
            OpcNodeName = opcNodeName;
        }
    }
}