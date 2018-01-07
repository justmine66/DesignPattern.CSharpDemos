using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.Mechanism
{
    public class StatePatternClient
    {
        public void Main()
        {
            var context = new Context(new ConcreteStateA());
            //不断的请求，并更改状态
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }
}
