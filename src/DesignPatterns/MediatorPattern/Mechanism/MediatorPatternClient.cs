using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MediatorPattern.Mechanism
{
    public class MediatorPatternClient
    {
        public void Main()
        {
            var mediator = new ConcreteMediator();

            var collage1 = new ConcreteCollage1(mediator);
            var collage2 = new ConcreteCollage2(mediator);

            mediator.Collage1 = collage1;
            mediator.Collage2 = collage2;

            collage1.Send("吃过饭了吗？");
            collage2.Send("没有呢，你打算请客？");

            Console.Read();
        }
    }
}
