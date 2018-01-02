using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v2
{
    public class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.WriteLine("皮鞋");
        }
    }
}
