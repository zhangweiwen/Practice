using NHibernateDemo.Models;

namespace NHibernateDemo.School.Models
{
    /// <summary>
    /// 学生选课信息
    /// </summary>
    public class StudentCourse
    {
        public virtual int Id { get; set; }        

        /// <summary>
        /// 课程
        /// </summary>
        public virtual Course Course { get; set; }

        /// <summary>
        /// 学生
        /// </summary>
        public virtual Student Student { get; set; }

        /// <summary>
        /// 成绩
        /// </summary>
        public virtual float Grade { get; set; }
    }
}