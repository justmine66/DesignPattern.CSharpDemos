using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.Mechanism
{
    /// <summary>
    /// 具体状态A，每个子类实现一个与Context的一个状态相关的行为
    /// </summary>
    public class ConcreteStateA : State
    {
        /// <summary>
        /// 设置下一个状态
        /// </summary>
        /// <param name="context"></param>
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
