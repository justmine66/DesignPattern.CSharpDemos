using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.Mechanism
{
    /// <summary>
    /// 具体状态B，每个子类实现一个与Context的一个状态相关的行为
    /// </summary>
    public class ConcreteStateB : State
    {
        /// <summary>
        /// 设置下一个状态
        /// </summary>
        /// <param name="context"></param>
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
