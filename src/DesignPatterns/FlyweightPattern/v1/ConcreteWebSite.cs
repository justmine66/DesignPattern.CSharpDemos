using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyweightPattern.v1
{
    public class ConcreteWebSite : WebSite
    {
        private string _name = "";
        public ConcreteWebSite(string name)
        {
            _name = name;
        }

        public override void Use()
        {
            Console.WriteLine("网站分类：" + _name);
        }
    }
}
