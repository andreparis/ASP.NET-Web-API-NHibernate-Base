using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models
{
    /// <summary>
    /// Classe modelo das locomotivas.
    /// </summary>
    public class LocomotivaModel : EntityBase
    {       
        /// <summary>
        /// Nome atribuído a locomotiva.
        /// </summary>
        public virtual string Name { get; set; }

    }
}