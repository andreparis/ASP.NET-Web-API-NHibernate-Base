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
        #region Atributos
        public virtual string Name { get; set; }
        public virtual string TimeStamp { get; set; }
        #endregion
        public TagModel() { }

        public TagModel(string name, string timeStamp)
        {
            Name = name;
            TimeStamp = timeStamp;
        }
    }
}