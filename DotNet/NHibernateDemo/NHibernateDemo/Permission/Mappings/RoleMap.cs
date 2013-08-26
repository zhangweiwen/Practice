using FluentNHibernate.Mapping;
using NHibernateDemo.Permission.Models;

namespace NHibernateDemo.Permission.Mappings
{
    public class RoleMap : ClassMap<Role>
    {
        public RoleMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasManyToMany(x => x.Actions)
                .Table("RoleAction");
        }
    }
}