using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Entities
{
    /// <summary>
    /// Classe modelo das locomotivas.
    /// </summary>
    public class Locomotiva : EntityBase
    {
        /// <summary>
        /// Nome atribuído a locomotiva
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// Data do ultimo deploy
        /// </summary>
        public virtual DateTime DeployTimeStamp { get; set; }
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
        public virtual Gps GPS { get; set; }
        /// <summary>
        /// Diretoria de logs na locomotiva.
        /// </summary>
        public virtual string LogDir { get; set;}
        /// <summary>
        /// LogLevel na locomotiva.
        /// </summary>
        public virtual int LogLevel { get; set; }
        public virtual string MonX { get; set; }
    }
}