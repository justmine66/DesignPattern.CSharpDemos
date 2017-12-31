using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.FunctionalChain
{
    /// <summary>
    /// 组长
    /// </summary>
    public class GroupLeader : Handler
    {
        public GroupLeader(string name)
            : base(name)
        {

        }

        public override void handleRequest(Client request)
        {
            if (request.GetLeaveDays() <= 1)
            {
                Console.WriteLine("组长" + this.Name + "审批员工" + request.GetLeaveName()
                        + "的请假条，请假天数为" + request.GetLeaveDays() + "天。");

                if (this.Successor != null)
                {
                    this.Successor.handleRequest(request);
                }
            }
            else
            {
                Console.WriteLine("组长" + this.Name + "认为第" + request.GetLeaveName() + "员工，项目进展慢，不允许请假");
            }
        }
    }
}
