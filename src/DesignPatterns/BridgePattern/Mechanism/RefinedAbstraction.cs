using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.Mechanism
{
    /// <summary>
    /// 精炼的抽象
    /// </summary>
    public class RefinedAbstraction:Abstraction
    {
        public override void Operation()
        {
            _implementor.Operation();
        }
    }
}
