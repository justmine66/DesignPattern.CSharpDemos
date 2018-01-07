using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.v3
{
    /// <summary>
    /// 上午工作状态
    /// </summary>
    public class ForenoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 12)
            {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍", work.Hour);
            }
            else
            {
                //超过12点，转入中午工作状态
                work.SetState(new NoonState());
                work.WriteProgram();
            };
        }
    }
}
