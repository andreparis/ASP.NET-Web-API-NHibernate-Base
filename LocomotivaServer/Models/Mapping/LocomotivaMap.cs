using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models.Mapping
{
    /// <summary>
    /// Classe para mapear no NHibernate Locomotiva classe e Locomotiva tabela.
    /// </summary>
    public class LocomotivaMap : ClassMapBase<LocomotivaModel>
    {
        public LocomotivaMap()
        {
            Table("LOCOMOTIVA");
            Map(x => x.Name);
        }
    }
}