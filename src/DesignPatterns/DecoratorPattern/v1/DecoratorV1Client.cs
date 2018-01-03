using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v1
{
    public class DecoratorV1Client
    {
        public void Main()
        {
            var person = new Person("小菜");

            Console.WriteLine("第一种装扮");
            person.WearTShirts();//T恤
            person.WearBigTrouser();//垮裤
            person.WearLeatherShoes();//皮鞋
            person.Show();

            Console.WriteLine("第二种装扮");
            person.WearSuit();//西装
            person.WearTie();//领带
            person.WearLeatherShoes();//皮鞋
            person.Show();
        }
    }
}
