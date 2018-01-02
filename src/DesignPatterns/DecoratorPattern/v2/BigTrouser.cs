using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v2
{
    public class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.WriteLine("垮裤");
        }
    }
}
