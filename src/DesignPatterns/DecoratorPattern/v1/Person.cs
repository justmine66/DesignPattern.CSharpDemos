using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v1
{
    /// <summary>
    /// 给人搭配不同的服饰-第一版
    /// </summary>
    public class Person
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }

        public void WearTShirts()
        {
            Console.Write("大T桖 ");
        }

        public void WearBigTrouser()
        {
            Console.Write("垮裤 ");
        }

        public void WearSneaker()
        {
            Console.Write("破球鞋 ");
        }

        public void WearSuit()
        {
            Console.Write("西装 ");
        }

        public void WearTie()
        {
            Console.Write("领带 ");
        }

        public void WearLeatherShoes()
        {
            Console.Write("皮鞋 ");
        }

        public void Show()
        {
            Console.WriteLine("装扮的{0}", this.name);
        }
    }
}
