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
        #region Atributos
        public virtual LocomotivaModel Locomotiva { get; set; }
        public virtual TagModel Tag { get; set; }
        public virtual string IP21NAME { get; set; }

        /// <summary>
        /// Tempo que a tag realiza coleta.
        /// </summary>
        public virtual int PoolingTime { get; set; }
        public virtual PimsServerModel PimsServer { get; set; }               
        public virtual string Family { get; set; }
        public virtual string TagGroup { get; set; }        
        #endregion
        public LocomotivaTagModel() { }

        public LocomotivaTagModel(LocomotivaModel locomotiva, TagModel tag, int poolingTime, PimsServerModel pimsServer, 
            string family, string tagGroup, string iP21NAME)
        {
            Locomotiva = locomotiva;
            Tag = tag;
            PoolingTime = poolingTime;
            PimsServer = pimsServer;
            Family = family;
            TagGroup = tagGroup;
            IP21NAME = iP21NAME;
        }
    }
}