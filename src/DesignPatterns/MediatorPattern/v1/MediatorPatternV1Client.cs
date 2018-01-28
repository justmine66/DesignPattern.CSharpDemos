using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MediatorPattern.v1
{
    public class MediatorPatternV1Client
    {
        public void Main()
        {
            var mediator = new UnitedNationsSecruityConcil();

            var usa = new USA(mediator);
            var iraq = new Iraq(mediator);

            mediator.SetIraq = iraq;
            mediator.SetUsa = usa;

            usa.Declare("不准研制核武器，否则要发送战争.");
            iraq.Declare("我们没有核武器，也不怕侵略.");

            Console.Read();
        }
    }
}
