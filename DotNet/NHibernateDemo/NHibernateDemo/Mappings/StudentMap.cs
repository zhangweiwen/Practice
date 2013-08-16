using FluentNHibernate.Mapping;
using NHibernateDemo.Models;

namespace NHibernateDemo.Mappings
{
    public class StudentMap : ClassMap<Student>
    {
        public StudentMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.No);
            References(x => x.Class);
        }
    }
}