using System;

namespace ChainOfResponsibility
{
    public sealed class CEO : Employee
    {
        public CEO(string name)
            : base(name)
        {
        }

        public override void Approval(Contract contract)
        {
            if (contract == null)
                return;

            const string format = "{0}审批了'{1}'合同,金额为'{2}'";
            Console.WriteLine(format, Name, contract.Name, contract.Money);
        }
    }
}