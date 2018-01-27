using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommanPattern.Mechanism
{
    public class CommanPatternClient
    {
        public void Main()
        {
            var receiver = new Receiver();
            CommandBase command = new ConcreteCommand(receiver);
            var invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.Execute();

            Console.Read();
        }
    }
}
