using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v2
{
    public class DecoratorV2Test
    {
        public void Main()
        {
            var person = new Person("小菜");

            Console.WriteLine("第一种装扮");
            Finery tshirts1 = new TShirts();
            Finery bigtrouser1 = new BigTrouser();
            Finery leathershoes1 = new LeatherShoes();

            tshirts1.Show();
            bigtrouser1.Show();
            leathershoes1.Show();
            person.Show();

            Console.WriteLine("\n第二种装扮");
            Finery suit2 = new Suit();
            Finery tie2 = new Tie();
            Finery leathershoes2 = new LeatherShoes();

            suit2.Show();
            tie2.Show();
            leathershoes2.Show();
            person.Show();
        }
    }
}
