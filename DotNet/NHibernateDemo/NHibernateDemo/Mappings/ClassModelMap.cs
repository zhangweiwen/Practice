using FluentNHibernate.Mapping;
using NHibernateDemo.Models;

namespace NHibernateDemo.Mappings
{
    public class ClassModelMap : ClassMap<Class>
    {
        public ClassModelMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Students).Inverse().Cascade.All();
        }
    }
}