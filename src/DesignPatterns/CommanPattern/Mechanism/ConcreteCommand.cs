using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommanPattern.Mechanism
{
    public class ConcreteCommand : CommandBase
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            _receiver.Action();
        }
    }
}
