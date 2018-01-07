using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.v3
{
    /// <summary>
    /// 抽象状态类
    /// 定义一个抽象方法“写程序”
    /// </summary>
    public abstract class State
    {
        public abstract void WriteProgram(Work context);
    }
}
