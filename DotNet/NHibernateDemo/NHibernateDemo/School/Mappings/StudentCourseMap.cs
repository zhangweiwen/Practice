using FluentNHibernate.Mapping;
using NHibernateDemo.School.Models;

namespace NHibernateDemo.School.Mappings
{
    public class StudentCourseMap : ClassMap<StudentCourse>
    {
        public StudentCourseMap()
        {
            Id(x => x.Id);
            Map(x => x.Grade);
            References(x => x.Student);
            References(x => x.Course);
        }
    }
}