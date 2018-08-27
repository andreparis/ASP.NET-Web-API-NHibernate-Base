using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Entities
{
    /// <summary>
    /// Classe modelo para GPS
    /// </summary>
    public class Gps
    {
        public string Type { get; set; }
        #region TCPListener
        public string Addr { get; set; }
        public int Port { get; set; }
        public int PoolingTime { get; set; }
        #endregion
        public string Monitor { get; set; }
        public int OpcTagMonitor { get; set; }
    }
}