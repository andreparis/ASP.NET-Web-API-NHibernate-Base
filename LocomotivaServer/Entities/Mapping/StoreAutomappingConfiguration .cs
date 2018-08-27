using FluentNHibernate.Automapping;
using LocomotivaServer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocomotivaServer
{
    public class StoreAutomappingConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            if (type.Namespace == "LocomotivaServer.Entities")
                Console.WriteLine(type.Namespace.ToString());            
            return type.Namespace == "LocomotivaServer.Entities";
        }
        public override bool IsComponent(Type type)
        {
            // override this method to specify which types should be treated as components
            // if you have a large list of types, you should consider maintaining a list of them
            // somewhere or using some form of conventional and/or attribute design
            return type == typeof(Gps);
        }
    }
}
