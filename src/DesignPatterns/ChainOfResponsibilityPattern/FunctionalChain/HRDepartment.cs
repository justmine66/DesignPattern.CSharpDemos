using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.FunctionalChain
{
    /// <summary>
    /// 人事部门
    /// </summary>
    public class HRDepartment : Handler
    {
        public HRDepartment(string name)
            : base(name)
        {

        }

        public override void handleRequest(Client request)
        {
            if (3 < request.GetLeaveDays() && request.GetLeaveDays() <= 7)
            {
                Console.WriteLine("人事部门" + this.Name + "审批员工" + request.GetLeaveName()
                        + "的请假条，请假天数为" + request.GetLeaveDays() + "天。");

                if (this.Successor != null)
                {
                    this.Successor.handleRequest(request);
                }
            }
            else
            {
                Console.WriteLine("人事部门" + this.Name + "认为第" + request.GetLeaveName() + "员工，项目进展慢，不允许请假");
            }
        }
    }
}
