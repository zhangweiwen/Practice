using FluentNHibernate.Mapping;
using NHibernateDemo.School.Models;

namespace NHibernateDemo.School.Mappings
{
    public class CourseMap : ClassMap<Course>
    {
        public CourseMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.CreditPoint);
            Map(x => x.CreditHours);
            Map(x => x.Teacher);
            Map(x => x.Description);
        }
    }
}