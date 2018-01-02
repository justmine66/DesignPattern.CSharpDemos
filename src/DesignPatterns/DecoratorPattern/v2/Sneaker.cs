using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v2
{
    public class Sneaker : Finery
    {
        public override void Show()
        {
            Console.WriteLine("破球鞋");
        }
    }
}
