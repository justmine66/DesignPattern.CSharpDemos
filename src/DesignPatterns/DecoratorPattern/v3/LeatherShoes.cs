using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v3
{
    public class LeatherShoes : Finery
    {
        public override void Show()
        {
            base.Show();

            Console.WriteLine("皮鞋");
        }
    }
}
