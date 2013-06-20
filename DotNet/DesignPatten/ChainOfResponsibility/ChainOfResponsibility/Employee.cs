using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 这里设下一个负责人,自己不够权力就交给他
    /// </summary>
    public abstract class Employee
    {
        public string Name { get; set; }

        public Employee Boss { get; set; }

        protected Employee(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name");

            Name = name;
        }

        /// <summary>
        /// 审批合同
        /// </summary>
        /// <param name="contract"></param>
        public abstract void Approval(Contract contract);
    }
}