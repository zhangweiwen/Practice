namespace ChainOfResponsibility
{
    /// <summary>
    /// 职责链模式
    /// </summary>
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var liu = new CEO("刘备");
            var guan = new AssistantCEO("关羽") { Boss = liu };
            var zhang = new Manager("张飞") { Boss = guan };
            var zhao = new AssistantManager("赵云") { Boss = zhang };

            var contract1 = new Contract
            {
                Money = 5000,
                Name = "企业A主页设计"
            };
            var contract2 = new Contract
            {
                Money = 98000,
                Name = "企业B网站建设"
            };
            var contract3 = new Contract
            {
                Money = 3880000,
                Name = "电信积分系统开发"
            }; 

            zhao.Approval(contract1);
            zhao.Approval(contract2);
            zhao.Approval(contract3);
        }
    }
}