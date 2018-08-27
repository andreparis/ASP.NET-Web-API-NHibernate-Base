using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models.Mapping
{
    /// <summary>
    /// Classe de mapeamento da tabela LocomotivaTag com classe modelo.
    /// </summary>
    public class LocomotivaTagMap : ClassMapBase<LocomotivaTagModel>
    {
        public LocomotivaTagMap()
        {
            Table("LOCOMOTIVA_TAG");
            References(x => x.Locomotiva);
            References(x => x.Tag);
            Map(x => x.PimsServer).Length(250).Column("Pims_Server");
            Map(x => x.PoolingTime).Column("Pooling_Time");
            Map(x => x.Family).Nullable().Length(250); ;
        }
    }
}