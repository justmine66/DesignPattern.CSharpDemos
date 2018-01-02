using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v2
{
    /// <summary>
    /// 给人搭配不同的服饰-第二版
    /// </summary>
    public class Person
    {
        public Person(string name)
        {
            this.name = name;
        }

        readonly string name;

        public void Show()
        {
            Console.WriteLine("装扮的{0}", this.name);
        }
    }
}
