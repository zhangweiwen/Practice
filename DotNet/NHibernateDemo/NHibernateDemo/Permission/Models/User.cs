namespace NHibernateDemo.Permission.Models
{
    public class User
    {
        public virtual int Id { get; set; }

        /// <summary>
        /// 员工号
        /// </summary>
        public virtual string   No { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public virtual Role Role { get; set; }
    }
}