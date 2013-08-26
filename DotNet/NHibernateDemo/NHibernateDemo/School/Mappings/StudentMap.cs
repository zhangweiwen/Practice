using FluentNHibernate.Mapping;
using NHibernateDemo.School.Models;

namespace NHibernateDemo.School.Mappings
{
    public class StudentMap : ClassMap<Student>
    {
        public StudentMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.No);
            Map(x => x.Gender);
            Map(x => x.Birthday);
            References(x => x.Class).Column("ClassId");
        }
    }
}