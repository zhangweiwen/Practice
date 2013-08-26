using FluentNHibernate.Mapping;
using NHibernateDemo.Permission.Models;

namespace NHibernateDemo.Permission.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.No);
            References(x => x.Role);
        }
    }
}