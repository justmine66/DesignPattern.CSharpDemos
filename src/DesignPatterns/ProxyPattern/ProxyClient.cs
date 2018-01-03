using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    public class ProxyClient
    {
        public void Main()
        {
            var girl = new SchoolGirl("小芳");
            var proxy = new PursuitProxy(girl);

            proxy.GiveFlowers();
            proxy.GiveChocolates();
            proxy.GiveDolls();
        }
    }
}
