using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v3
{
    public class BigTrouser : Finery
    {
        public override void Show()
        {
            base.Show();

            Console.WriteLine("垮裤");
        }
    }
}
