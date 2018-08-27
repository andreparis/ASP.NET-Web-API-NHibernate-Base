using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Entities.Mapping
{
    /// <summary>
    /// Classe de mapeamento da tabela LocomotivaTag com classe modelo.
    /// </summary>
    public class LocomotivaTagMap : ClassMapBase<LocomotivaTag>
    {
        public LocomotivaTagMap()
        {
            Table("LOCOMOTIVA_TAG");
            References(x => x.Locomotiva);
            References(x => x.Tag);
            Map(x => x.PimsServer).Nullable().Length(75);
            Map(x => x.PoolingTime);
            Map(x => x.Family).Nullable().Length(75); ;
        }
    }
}