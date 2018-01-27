using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.Mechanism
{
    public class BridgePatternClient
    {
        public void Main()
        {
            Abstraction abstraction;
            abstraction = new RefinedAbstraction();

            abstraction.SetImplementor(new ConcreteImplementorA());
            abstraction.Operation();

            abstraction.SetImplementor(new ConcreteImplementorB());
            abstraction.Operation();

            Console.Read();
        }
    }
}
