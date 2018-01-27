using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommanPattern.Mechanism
{
   public class Invoker
    {
        private CommandBase _command;

        public void SetCommand(CommandBase command)
        {
            _command = command;
        }

        public void Execute()
        {
            _command.Execute();
        }
    }
}
