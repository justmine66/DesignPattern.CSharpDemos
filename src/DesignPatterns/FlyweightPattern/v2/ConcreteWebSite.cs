using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyweightPattern.v2
{
    public class ConcreteWebSite : WebSite
    {
        private string _name = "";
        public ConcreteWebSite(string name)
        {
            _name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine("网站分类：" + _name + " 用户：" + user.Name);
        }
    }
}
