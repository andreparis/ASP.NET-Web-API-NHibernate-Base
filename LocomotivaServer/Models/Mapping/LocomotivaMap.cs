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
    public class LocomotivaMap : ClassMap<LocomotivaModel>
    {
        public LocomotivaMap()
        {
            Table("Locomotiva");
            //LOCOMOTIVA_SEQUENCE is the oracle sequence against the person table
            Id(x => x.Id, "Id").GeneratedBy.Sequence("LOCOMOTIVA_SEQUENCE");
            Map(x => x.Name);
            Map(x => x.IdsTags);
        }
    }
}