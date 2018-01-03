using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v3
{
    public class DecoratorV3Client
    {
        public void Main()
        {
            var person = new Person("小菜");

            Console.WriteLine("第一种装扮");
            Finery sneaker1 = new Sneaker();
            Finery bigtrouser1 = new BigTrouser();
            Finery tshirts1 = new TShirts();

            //装扮过程
            sneaker1.Decorate(person);//先穿鞋子
            bigtrouser1.Decorate(sneaker1);//再穿裤子
            tshirts1.Decorate(bigtrouser1);//最后穿T恤
            tshirts1.Show();

            Console.WriteLine("\n第二种装扮");
            Finery suit2 = new Suit();
            Finery Tie2 = new Tie();
            Finery leathershoes2 = new LeatherShoes();

            //装扮过程
            leathershoes2.Decorate(person);//先穿鞋子
            suit2.Decorate(leathershoes2);//再穿西装
            Tie2.Decorate(suit2);//最后打领带
            Tie2.Show();
        }
    }
}
