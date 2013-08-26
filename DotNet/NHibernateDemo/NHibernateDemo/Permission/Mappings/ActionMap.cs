using FluentNHibernate.Mapping;
using NHibernateDemo.Permission.Models;

namespace NHibernateDemo.Permission.Mappings
{
    public class ActionMap : ClassMap<Action>
    {
        public ActionMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Description);
            HasManyToMany(x => x.Roles);
        }
    }
}