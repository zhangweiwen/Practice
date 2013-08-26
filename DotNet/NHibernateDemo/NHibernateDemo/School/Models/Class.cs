using System.Collections.Generic;

namespace NHibernateDemo.School.Models
{
    /// <summary>
    /// 班级
    /// </summary>
    public class Class
    {
        public virtual int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 班主任
        /// </summary>
        public virtual string MainTeacher { get; set; }

        /// <summary>
        /// 学生
        /// </summary>
        public virtual IList<Student> Students { get; set; }
    }
}