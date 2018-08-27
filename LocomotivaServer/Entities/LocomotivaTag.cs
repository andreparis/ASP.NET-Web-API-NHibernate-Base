using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Entities
{
    /// <summary>
    /// Classe modelo para tabela que relaciona locomotiva e tag
    /// </summary>
    public class LocomotivaTag : EntityBase
    {
        public virtual Locomotiva Locomotiva { get; set; }
        public virtual Tag Tag { get; set; }

        /// <summary>
        /// Tempo que a tag realiza coleta.
        /// </summary>
        public virtual int PoolingTime { get; set; }
        public virtual string PimsServer { get; set; }               
        public virtual string Family { get; set; }
    }
}