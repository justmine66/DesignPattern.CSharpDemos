using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.Mechanism
{
    /// <summary>
    /// 抽象状态类
    /// 定义一个接口以封装与Context的一个特定状态相关的行为
    /// </summary>
    public abstract class State
    {
        /// <summary>
        /// 对请求进行处理并设置下一个状态
        /// </summary>
        /// <param name="context"></param>
        public abstract void Handle(Context context);
    }
}
