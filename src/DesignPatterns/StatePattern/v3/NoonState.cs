using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.v3
{
    /// <summary>
    /// 中午工作状态
    /// </summary>
    public class NoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 13)
            {
                Console.WriteLine("当前时间：{0}点 饿了，午饭：犯困、午休", work.Hour);
            }
            else
            {
                work.SetState(new AfternoonState());
                work.WriteProgram();
            }
        }
    }
}
