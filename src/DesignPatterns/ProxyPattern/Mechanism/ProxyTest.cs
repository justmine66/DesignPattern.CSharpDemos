using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern.Mechanism
{
    public class ProxyTest
    {
        public void Main()
        {
            var proxy = new Proxy();
            proxy.Request();
        }
    }
}
