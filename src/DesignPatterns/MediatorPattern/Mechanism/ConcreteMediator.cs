using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MediatorPattern.Mechanism
{
    public class ConcreteMediator : MediatorBase
    {
        ConcreteCollage1 _collage1;
        ConcreteCollage2 _collage2;

        public ConcreteCollage1 Collage1 { set { _collage1 = value; } }
        public ConcreteCollage2 Collage2 { set { _collage2 = value; } }

        public override void Send(string message, CollageBase collage)
        {
            if (collage == _collage1)
            {
                _collage2.Notify();
            }
            else {
                _collage1.Notify();
            }
        }
    }
}
