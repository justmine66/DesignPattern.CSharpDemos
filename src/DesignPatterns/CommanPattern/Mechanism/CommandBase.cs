using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommanPattern.Mechanism
{
    public abstract class CommandBase
    {
        protected Receiver _receiver;

        public CommandBase(Receiver receiver)
        {
            _receiver = receiver;
        }

        public abstract void Execute();
    }
}
