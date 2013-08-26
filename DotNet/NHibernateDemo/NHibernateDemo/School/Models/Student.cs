using System;

namespace NHibernateDemo.School.Models
{
    public class Student
    {
        public virtual int Id { get; protected set; }
        /// <summary>
        /// 学号
        /// </summary>
        public virtual string No { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public virtual Gender Gender { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public virtual DateTime Birthday { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        public virtual Class Class { get; set; }
    }
}