namespace NHibernateDemo.School.Models
{
    /// <summary>
    /// 课程
    /// </summary>
    public class Course
    {
        public virtual int Id { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 学分
        /// </summary>
        public virtual float CreditPoint { get; set; }

        /// <summary>
        /// 学时
        /// </summary>
        public virtual int CreditHours { get; set; }

        /// <summary>
        /// 教师
        /// </summary>
        public virtual string Teacher { get; set; }

        /// <summary>
        /// 简介,描述
        /// </summary>
        public virtual string Description { get; set; }
    }
}