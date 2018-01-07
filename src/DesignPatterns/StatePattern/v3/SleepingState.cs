using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.v3
{
    /// <summary>
    /// 睡觉状态
    /// </summary>
    public class SleepingState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("当前时间：{0}点 不行哦，睡着了", work.Hour);
        }
    }
}
