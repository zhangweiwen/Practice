using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 副经理
    /// </summary>
    public sealed class AssistantManager : Employee
    {
        public AssistantManager(string name)
            : base(name)
        {
        }

        public override void Approval(Contract contract)
        {
            if (contract == null)
                return;

            if (contract.Money < 10000)
            {
                const string format = "{0}审批了'{1}'合同,金额为'{2}'";
                Console.WriteLine(format, Name, contract.Name, contract.Money);
                return;
            }
            //无权审批,交给Boss
            Boss.Approval(contract);
        }
    }
}