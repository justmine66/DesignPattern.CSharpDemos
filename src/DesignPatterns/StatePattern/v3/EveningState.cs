using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.v3
{
    /// <summary>
    /// 傍晚工作状态
    /// </summary>
    public class EveningState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.WorkFinished)
            {
                work.SetState(new RestState());
                work.WriteProgram();
            }
            else
            {
                if (work.Hour < 20)
                {
                    Console.WriteLine("当前时间：{0}点 加班哦，疲惫至极", work.Hour);
                }
                else if (work.Hour >= 20)
                {
                    work.SetState(new ForciblyGoOffWorkState());
                    work.WriteProgram();
                }
            }
        }
    }
}
