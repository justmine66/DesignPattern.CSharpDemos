using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MediatorPattern.Mechanism
{
    public class ConcreteCollage1 : CollageBase
    {
        public ConcreteCollage1(MediatorBase mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify()
        {
            Console.WriteLine("收到同事2的消息");
        }
    }
}
