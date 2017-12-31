using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.FunctionalChain
{
    /// <summary>
    /// 项目经理
    /// </summary>
    public class Manager : Handler
    {
        public Manager(string name)
            : base(name)
        {

        }

        public override void handleRequest(Client request)
        {
            if (1 < request.GetLeaveDays() && request.GetLeaveDays() <= 3)
            {
                Console.WriteLine("项目经理" + this.Name + "审批员工" + request.GetLeaveName()
                        + "的请假条，请假天数为" + request.GetLeaveDays() + "天。");

                if (this.Successor != null)
                {
                    this.Successor.handleRequest(request);
                }
            }
            else
            {
                Console.WriteLine("项目经理" + this.Name + "认为第" + request.GetLeaveName() + "员工，项目进展慢，不允许请假");
            }
        }
    }
}
