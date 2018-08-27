using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models.Mapping
{
    /// <summary>
    /// Classe de mapeamento da tabela tag com classe modelo.
    /// </summary>
    public class TagMap : ClassMapBase<TagModel>
    {
        public TagMap()
        {
            Table("TAG");
            Map(x => x.Name).Length(250);
            Map(x => x.NamePIMS).Length(250).Column("Name_PIMS"); 
            Map(x => x.TimeStamp).Nullable().Length(250).Column("Time_Stamp"); 
        }
    }
}