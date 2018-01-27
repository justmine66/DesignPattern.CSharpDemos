using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.Mechanism
{
    public abstract class Abstraction
    {
        protected ImplementorBase _implementor;

        public void SetImplementor(ImplementorBase implementor)
        {
            _implementor = implementor;
        }

        public virtual void Operation()
        {
            _implementor.Operation();
        }
    }
}
