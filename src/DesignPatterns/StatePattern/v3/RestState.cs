using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.v3
{
    /// <summary>
    /// 休息状态
    /// </summary>
    public class RestState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("当前时间：{0}点 下班回家了", work.Hour);
        }
    }
}
