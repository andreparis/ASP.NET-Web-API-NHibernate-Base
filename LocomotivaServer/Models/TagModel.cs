using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models
{
    /// <summary>
    /// Classe modelo para tabela de Tags
    /// </summary>
    public class TagModel : EntityBase
    {
        public virtual string Name { get; set; }
        public virtual string NamePIMS { get; set; }      
        public virtual DateTime TimeStamp { get; set; }
    }
}