using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models.Mapping
{
    public class PimsServerMap : ClassMapBase<PimsServerModel>
    {
        public PimsServerMap()
        {
            Table("PIMS");
            Map(x => x.Server).Length(250);
        }
    }
}