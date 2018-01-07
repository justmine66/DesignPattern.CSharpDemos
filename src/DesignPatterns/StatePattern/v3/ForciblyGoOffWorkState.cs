using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.v3
{
    /// <summary>
    /// 强制下班状态
    /// </summary>
    public class ForciblyGoOffWorkState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour == 20)
            {
                Console.WriteLine("当前时间：{0}点 员工必须离开公司了", work.Hour);
            }
            else
            {
                work.SetState(new SleepingState());
                work.WriteProgram();
            }
        }
    }
}
