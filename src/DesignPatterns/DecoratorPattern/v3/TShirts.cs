using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v3
{
    public class TShirts : Finery
    {
        public override void Show()
        {
            base.Show();

            Console.WriteLine("大T桖");
        }
    }
}
