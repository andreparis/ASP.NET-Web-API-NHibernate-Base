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
            References(x => x.PimsServer).Column("Pims_Server_Id");
            Map(x => x.PoolingTime).Column("Pooling_Time");
            Map(x => x.Family).Nullable().Length(250);
            Map(x => x.TagGroup).Nullable().Length(250).Column("Tag_Group");
            Map(x => x.IP21NAME).Nullable().Length(250);
        }
    }
}