using System.Collections.Generic;

namespace NHibernateDemo.Models
{
    /// <summary>
    /// 班级
    /// </summary>
    public class Class
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Student> Students { get; set; }
    }
}