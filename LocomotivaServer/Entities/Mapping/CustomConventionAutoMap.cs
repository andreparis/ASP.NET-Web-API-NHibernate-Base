using FluentNHibernate;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace LocomotivaServer.Entities.Mapping
{
    public class CustomPrimaryKeyConvention : IIdConvention
    {
        public void Apply(IIdentityInstance instance)
        {
            instance.Column(instance.EntityType.Name + "Id");
        }
    }

    public class CustomForeignKeyConvention : ForeignKeyConvention
    {
        protected override string GetKeyName(Member property, Type type)
        {
            if (property == null)
                return type.Name + "_FK";

            return property.Name + "_FK";
        }
    }

    public class DefaultStringLengthConvention : IPropertyConvention
    {
        public void Apply(IPropertyInstance instance)
        {
            instance.Length(250);
        }
    }
}