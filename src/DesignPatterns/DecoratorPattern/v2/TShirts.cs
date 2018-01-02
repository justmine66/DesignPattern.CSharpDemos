using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v2
{
    public class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("大T桖");
        }
    }
}
