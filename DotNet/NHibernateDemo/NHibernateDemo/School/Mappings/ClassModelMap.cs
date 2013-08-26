using FluentNHibernate.Mapping;
using NHibernateDemo.School.Models;

namespace NHibernateDemo.School.Mappings
{
    public class ClassModelMap : ClassMap<Class>
    {
        public ClassModelMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.MainTeacher);
            HasMany(x => x.Students)
                .KeyColumn("ClassId")
                .Inverse()
                .Cascade.All();
        }
    }
}