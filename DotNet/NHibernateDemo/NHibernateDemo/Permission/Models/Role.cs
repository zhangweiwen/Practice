using System.Collections.Generic;

namespace NHibernateDemo.Permission.Models
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Role
    {
        public virtual int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 角色拥有的权限
        /// </summary>
        public virtual IList<Action> Actions { get; set; }
    }
}