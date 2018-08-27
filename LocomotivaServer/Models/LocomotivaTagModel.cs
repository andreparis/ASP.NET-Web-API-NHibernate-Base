using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models
{
    /// <summary>
    /// Classe modelo para tabela que relaciona locomotiva e tag
    /// </summary>
    public class LocomotivaTagModel : EntityBase
    {
        public virtual LocomotivaModel Locomotiva { get; set; }
        public virtual TagModel Tag { get; set; }

        /// <summary>
        /// Tempo que a tag realiza coleta.
        /// </summary>
        public virtual int PoolingTime { get; set; }
        public virtual string PimsServer { get; set; }               
        public virtual string Family { get; set; }
    }
}