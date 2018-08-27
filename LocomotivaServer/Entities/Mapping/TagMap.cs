using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Entities.Mapping
{
    /// <summary>
    /// Classe de mapeamento da tabela tag com classe modelo.
    /// </summary>
    public class TagMap : ClassMapBase<Tag>
    {
        public TagMap()
        {
            Table("TAG");
            Map(x => x.Name);
            Map(x => x.NamePIMS);
            Map(x => x.TimeStamp).Nullable();
        }
    }
}