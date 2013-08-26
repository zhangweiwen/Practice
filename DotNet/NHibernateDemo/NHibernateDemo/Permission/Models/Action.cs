using System.Collections.Generic;

namespace NHibernateDemo.Permission.Models
{
    /// <summary>
    /// 操作
    /// </summary>
    public class Action
    {
        public virtual int Id { get; set; }

        /// <summary>
        /// 操作名称
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// 拥有这个权限的角色
        /// </summary>
        public virtual IList<Role> Roles { get; set; }
    }
}