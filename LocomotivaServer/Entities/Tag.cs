using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Entities
{
    /// <summary>
    /// Classe modelo para tabela de Tags
    /// </summary>
    public class Tag : EntityBase
    {
        public virtual string Name { get; set; }
        public virtual string NamePIMS { get; set; }      
        public virtual DateTime TimeStamp { get; set; }
    }
}