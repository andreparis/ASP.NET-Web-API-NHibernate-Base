using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Entities
{
    public abstract class ClassMapBase<T> : ClassMap<T> where T : EntityBase
    {
        protected ClassMapBase()
        {
            Id(x => x.Id).Not.Nullable();
            LazyLoad();
        }
    }
}