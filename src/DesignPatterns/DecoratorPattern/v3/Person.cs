using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v3
{
    /// <summary>
    /// 给人搭配不同的服饰-第三版
    /// </summary>
    public class Person
    {
        public Person() { }

        public Person(string name)
        {
            this.name = name;
        }

        string name;

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}", this.name);
        }
    }
}
