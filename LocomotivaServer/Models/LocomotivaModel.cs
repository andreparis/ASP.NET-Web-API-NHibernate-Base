using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models
{
    /// <summary>
    /// Classe modelo das locomotivas.
    /// </summary>
    public class LocomotivaModel
    {
        /// <summary>
        /// Id da Locomotiva.
        /// </summary>
        public virtual int Id { get; set; }
        
        /// <summary>
        /// Nome atribuído a locomotiva.
        /// </summary>
        public virtual string Name { get; set; }
        
        /// <summary>
        /// Lista com o Id referente as tags que a locomotiva possui.
        /// </summary>
        public virtual List<int> IdsTags { get; set; }

    }
}