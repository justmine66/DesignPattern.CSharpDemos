using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.Standard
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
            }
            else
            {
                if (this.Successor != null)
                {
                    this.Successor.handleRequest(request);
                }
            }
        }
    }
}
